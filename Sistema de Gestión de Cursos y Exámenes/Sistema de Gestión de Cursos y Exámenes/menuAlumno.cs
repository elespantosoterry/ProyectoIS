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
    public partial class menuAlumno : Form
    {
        public menuAlumno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            verNotas vN = new verNotas();
            vN.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            examenesDisponibles rE = new examenesDisponibles();
            rE.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            login l = new login();
            l.Show();

        }

        private void menuAlumno_Load(object sender, EventArgs e)
        {
        }
    }
}
