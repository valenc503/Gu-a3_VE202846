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
    public partial class Estudiantes : Form
    {

        private List<alumno> Alumnos = new List<alumno>();
        private int editIndice = -1;

        public float promedio(float nota1, float nota2, float nota3)
        {
            float notapromedio = (nota1 + nota2 + nota3) / 3;
            return notapromedio;
        }

        
        private void limpiar()
        {
            txtapellido.Clear();
            txtcarnet.Clear();
            txtmateria.Clear();
            txtnombre.Clear();
            txtnota1.Clear();
            txtnota2.Clear();
            txtnota3.Clear();
        }
        public Estudiantes()
        {
            InitializeComponent();
        }

        private void txtprom_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            alumno alumno = new alumno();
            alumno.Nombre = txtnombre.Text;
            alumno.Apellido = txtapellido.Text;
            alumno.Carnet = txtcarnet.Text;
            alumno.Materia = txtmateria.Text;
            alumno.Calificaciones[0] = float.Parse(txtnota1.Text);
            alumno.Calificaciones[1] = float.Parse(txtnota2.Text);
            alumno.Calificaciones[2] = float.Parse(txtnota3.Text);

            float notaPromedio = promedio(alumno.Calificaciones[0], alumno.Calificaciones[1], alumno.Calificaciones[2]);

            if (editIndice > -1)
            {
                Alumnos[editIndice] = alumno;
                editIndice = -1;
            }
            else
            {
                Alumnos.Add(alumno);
            }
         
            limpiar();
        }

        private void dgvalumnos_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReporteEstudiante formulario = new ReporteEstudiante(); //instancia de otro formulario
            formulario.Recibe = Alumnos; /*lista original Personas es enviada
a la lista PersonaRecibe que está en el formulario 2 y que puede ser invocada por medio de
la instancia del segundo formulario */
            formulario.Show(); //mostar el segundo formulario
        }
    }
}
