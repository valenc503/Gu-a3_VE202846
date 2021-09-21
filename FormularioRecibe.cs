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
    public partial class FormularioRecibe : Form
    {

        public List<Persona>  PersonaRecibe = null; //creación de una lista que reciba
        
        DataTable directorio = new DataTable(); //DataTable
        
        public FormularioRecibe()
        {
            InitializeComponent();
            
        }

       
        private void actualizarGrid() //función que llena el DGV del formulario 2
        {
            dataGridView1.DataSource = directorio;
            dataGridView1.DataSource = PersonaRecibe;    
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            
            actualizarGrid();
            

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
