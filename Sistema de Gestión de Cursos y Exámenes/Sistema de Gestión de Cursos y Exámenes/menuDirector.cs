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
    public partial class menuDirector : Form
    {
        public menuDirector()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestionProfesores gP = new gestionProfesores();
            gP.Show();
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
            gestionCursos gC = new gestionCursos();
            gC.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestionPeriodos gPer = new gestionPeriodos();
            gPer.Show();
        }

        private void menuDirector_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestionGrupos gG = new gestionGrupos();
            gG.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestionAlumnos gAl = new gestionAlumnos();
            gAl.Show();
        }
    }
}
