using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo5_VE202846
{
    public partial class Banco : Form
    {
        public Banco()
        {
            InitializeComponent();
        }
        /*listado que permite tener varios elementos de la clase cliente bancos*/
        private List<Clientebanco> clientesbanco = new List<Clientebanco>();
        private int edit_indice = -1; //el índice para editar comienza en -1, esto significa que no hay ninguno seleccionado, esto servirá para el DataGridView.

        private void actualizarGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = clientesbanco; /*los nombres de columna que veremos son los de las propiedades*/
        }
        private void Banco_Load(object sender, EventArgs e)
        {
            cmbtipocuenta.Items.Add("Corriente");
            cmbtipocuenta.Items.Add("Ahorros");
            cmbtipocuenta.Items.Add("Plazos");
            cmbsucursal.Items.Add("Santa elena");
            cmbsucursal.Items.Add("Panamericana");
            cmbsucursal.Items.Add("Metrocentro");
            cmbsucursal.Items.Add("Unicentro soyapango");
            cmbsucursal.Items.Add("Santa tecla");
        }
        private void limpiar()
        {
            txtnombre.Clear();
            txtapellidos.Clear();
            txtdui.Clear();
            txtmonto.Clear();
            txtnit.Clear();
            txtncuenta.Clear();
            
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cmbtipocuenta_DropDown(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow seleccion = dataGridView1.SelectedRows[0];
            int pos = dataGridView1.Rows.IndexOf(seleccion); //almacena en cual fila estoy
            edit_indice = pos; //copio esa variable en índice editado

            Clientebanco per = clientesbanco[pos]; /*esta variable de tipo persona, se carga con los valores que le pasa el listado*/

            txtdui.Text = per.Dui;
            txtnombre.Text = per.Nombre; //lo que tiene el atributo se lo doy al textbox
            txtapellidos.Text = per.Apellido;
            cmbtipocuenta.Text = per.TipoCuenta;
            txtnit.Text = per.Nit;
            txtncuenta.Text = per.NumeroCuenta;
            txtmonto.Text = per.Monto;
            cmbsucursal.Text = per.Sucursal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //creo un objeto de la clase persona y guardo a través de las propiedades
            Clientebanco per = new Clientebanco();
            per.Nombre = txtnombre.Text;
            per.Apellido = txtapellidos.Text;
            per.Dui = txtdui.Text;
            per.TipoCuenta = cmbtipocuenta.Text;
            per.Nit = txtnit.Text;
            per.NumeroCuenta = txtncuenta.Text;
            per.Monto = txtmonto.Text;
            per.Sucursal = cmbsucursal.Text;
            if (edit_indice > -1) //verifica si hay un índice seleccionado
            {
                clientesbanco[edit_indice] = per;
                edit_indice = -1;
            }
            else
            {

                clientesbanco.Add(per); /*al arreglo de Personas le agrego el objeto creado
con todos los datos que recolecté*/

            }
            actualizarGrid();//llamamos al procedimiento que guarda en datagrid
            limpiar();//mandamos a llamar la función que limpia

        }

        private void cmbtipocuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbtipocuenta.Text == "Corriente")
            {
                txtncuenta.Text = "CC-";
            }
            else if (cmbtipocuenta.Text == "Ahorros")
            {
                txtncuenta.Text = "CA-";
            }
            else if (cmbtipocuenta.Text == "Plazos")
            {
                txtncuenta.Text = "CP-";
            }
        }

        private void txtncuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtdui_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtmonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
