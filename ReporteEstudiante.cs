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
    public partial class ReporteEstudiante : Form
    {
        public List<alumno> Recibe = null; //creación de una lista que reciba
        private int editIndice = -1;
        public ReporteEstudiante()
        {
            InitializeComponent();
        }
        private void actualizarGrid() //función que llena el DGV del formulario 2
        {

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Recibe;


        }

        private void ReporteEstudiante_Load(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow seleccion = dataGridView1.SelectedRows[0];
            int pos = dataGridView1.Rows.IndexOf(seleccion);
            editIndice = pos;

            alumno listalumno = Recibe[pos];

            //Lo siguiente es para cuando se seleccione el alumno, nos muestre los datos en los textbox correspondientes
            txtnombre.Text = listalumno.Nombre;
            txtcarnet.Text = listalumno.Apellido;
            txtmateria.Text = listalumno.Materia;
            txtapellido.Text = listalumno.Apellido;
            txtnota1.Text = Convert.ToString(listalumno.Calificaciones[0]);
            txtnota2.Text = Convert.ToString(listalumno.Calificaciones[1]);
            txtnota3.Text = Convert.ToString(listalumno.Calificaciones[2]);

            double promedio,nota1,nota2,nota3;
            nota1 = Convert.ToDouble(txtnota1.Text);
            nota2 = Convert.ToDouble(txtnota2.Text);
            nota3 = Convert.ToDouble(txtnota3.Text);
            promedio = (nota1 + nota2 + nota3) / 3;
            txtprom.Text = Convert.ToString(promedio);

        }
    }
}
