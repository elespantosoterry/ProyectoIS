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
    public partial class menuProfesor : Form
    {
        public menuProfesor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestionUnidadesTematicas gU = new gestionUnidadesTematicas();
            gU.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            login l = new login();
            l.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestionExamenes gE = new gestionExamenes();
            gE.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            generacionExamenes gEx = new generacionExamenes();
            gEx.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            programarExamen pE = new programarExamen();
            pE.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestionPreguntas gP = new gestionPreguntas();
            gP.Show();
        }

        private void menuProfesor_Load(object sender, EventArgs e)
        {
        }
    }
}
