using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ejemplo5_VE202846
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }
        //prepara objeto para generar cuadro de dialogo de seleccion de archivo
        OpenFileDialog cuadroseleccion = new OpenFileDialog();

        /*listado que permite tener varios elementos de la clase Persona*/
        private List<Producto> Productos = new List<Producto>();
        private int edit_indice = -1; //el índice para editar comienza en -1, esto significa que no hay ninguno seleccionado, esto servirá para el DataGridView.
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void actualizarGrid()
        {
            dgvlistado.DataSource = null;
            dgvlistado.DataSource = Productos; /*los nombres de columna que veremos son los de las propiedades*/
            
        }
        private void reseteo()
        {
            txtnombre.Clear();
            txtdescripcion.Clear();
            txtmarca.Clear();
            txtprecio.Clear();
            txtstock.Clear();
            pictureBox1.Image.Dispose();
            pictureBox1.Image = null;
        }

        private void dgvlistado_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow selected = dgvlistado.SelectedRows[0];
            int posicion = dgvlistado.Rows.IndexOf(selected); //almacena en cual fila estoy
            edit_indice = posicion; //copio esa variable en índice editado

            Producto product = Productos[posicion]; /*esta variable de tipo persona, se carga con los valores que le pasa el listado*/
            //lo que tiene el atributo se lo doy al textbox
            
            txtnombre.Text = product.Nombre;
            txtdescripcion.Text = product.Descripcion;
            txtmarca.Text = product.Marca;
            txtprecio.Text = Convert.ToString(product.Precio);
            txtstock.Text = Convert.ToString(product.Stock);
            pictureBox2.Image = Image.FromFile(product.Imagen);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {


            //creo un objeto de la clase persona y guardo a través de las propiedades
            Producto product = new Producto();
            product.Nombre = txtnombre.Text;
            product.Descripcion = txtdescripcion.Text;
            product.Marca = txtmarca.Text;
            product.Precio = float.Parse(txtprecio.Text);
            product.Stock = int.Parse(txtstock.Text);
            product.Imagen = pictureBox1.ImageLocation;
            

            if (edit_indice > -1) //verifica si hay un índice seleccionado
            {
                Productos[edit_indice] = product;
                edit_indice = -1;
            }
            else
            {

                Productos.Add(product); /*al arreglo de Productos le agrego el objeto creado con todos los datos que recolecté*/

            }
            
            actualizarGrid();//llamamos al procedimiento que guarda en datagrid
            reseteo(); //llamamos al método que resetea
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (edit_indice > -1) //verifica si hay un índice seleccionado

            {
                Productos.RemoveAt(edit_indice);
                edit_indice = -1; //resetea variable a -1
                reseteo();
                actualizarGrid();
            }
            else
            {
                MessageBox.Show("Dar doble click sobre elemento para seleccionar y borrar ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cuadroseleccion.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = cuadroseleccion.FileName;
            }

        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            //Define filtros para el cuadro de seleccion, que mostrara solo imagenes JPG
            cuadroseleccion.Filter = "Imagenes de tipo JPG |*.jpg";
        }


        private void btnmostrar_Click(object sender, EventArgs e)
        {
            
        }
    
    }
}
