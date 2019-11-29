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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Profesor");
            comboBox1.Items.Add("Director");
            comboBox1.Items.Add("Alumno");

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Profesor> Profesores = new List<Profesor>();
            Profesores = BD.g_PROFESOR_GLOBAL;

            List<string> Directores = new List<string>();
            Directores.Add("YvanTupac");
            Directores.Add("Erick");
            Directores.Add("AlexC");

            string tipo = comboBox1.Text;
            bool check = false;

            if (tipo == "Director")
            {
                for(int i=0; i<Directores.Count; i++)
                {
                    if(textBox1.Text==Directores[i] && textBox2.Text == Directores[i])
                    {
                        check = true;
                        this.Hide();
                        menuDirector mD = new menuDirector();
                        mD.Show();

                    }
                }

                if (check == false)
                {
                    MessageBox.Show("Error de autenticacion, verifique usuario y/O contraseña ó es posible que su cuenta este inhabilitada", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }

            else if (tipo == "Profesor")
            {
                for (int i = 0; i < Profesores.Count; i++)
                {
                    if (textBox1.Text == Profesores[i].usuario && textBox2.Text == Profesores[i].contraseña)
                    {
                        check = true;
                        this.Hide();
                        menuProfesor mP = new menuProfesor();
                        mP.Show();

                    }

                }
                if (check == false)
                {
                    MessageBox.Show("Error de autenticacion, verifique usuario y/O contraseña ó es posible que su cuenta este inhabilitada", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
