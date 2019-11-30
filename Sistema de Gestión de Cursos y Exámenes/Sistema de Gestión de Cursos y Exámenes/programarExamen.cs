using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gestión_de_Cursos_y_Exámenes
{
    public partial class programarExamen : Form
    {
        public programarExamen()
        {
            InitializeComponent();
        }

        private void programarExamen_Load(object sender, EventArgs e)
        {
            //SeleccionarCurso.Items.Add();
        }
        private void SeleccionarCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guardarConfExamen_Click(object sender, EventArgs e)
        {

        }

        private void SeleccionarTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void titulo_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuProfesor mP = new menuProfesor();
            mP.Show();
        }
    }
}
