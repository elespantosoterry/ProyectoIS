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


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            List<Alumno> Alumnos = new List<Alumno>();
            Alumnos = BD.ALUMNO_GLOBAL;
            //Alumno al = new Alumno();
            //al.usuario = "alumno";
            //al.contraseña = "alumno";
            //Alumnos.Add(al);

            List<Profesor> Profesores = new List<Profesor>();
            Profesores = BD.g_PROFESOR_GLOBAL;
            //Profesor prof = new Profesor();
            //prof.usuario = "profesor";
            //prof.contraseña = "profesor";
            //Profesores.Add(prof);
            //Profesor prof = new Profesor();
            //prof.usuario = "profesor";
            //prof.contraseña = "profesor";
            //Profesores.Add(prof);
            List<string> Directores = new List<string>();
            Directores.Add("director");
            Directores.Add("Erick");
            Directores.Add("AlexC");

            bool check = false;

            if (check == false)
            {
                for (int i = 0; i < Directores.Count; i++)
                {
                    if (textBox1.Text == Directores[i] && textBox2.Text == Directores[i])
                    {
                        check = true;
                        this.Hide();
                        menuDirector mD = new menuDirector();
                        mD.Show();
                        BD.g_sesionID = i;
                        BD.g_sesionTipo = 1;

                    }
                }
            }

           if (check == false)
            {
                if (textBox1.Text == "profesor" && textBox2.Text == "profesor")
                {
                    check = true;
                    this.Hide();
                    menuProfesor mP = new menuProfesor();
                    mP.Show();
                    BD.g_sesionID = 0;
                    BD.g_sesionTipo = 2;
                }

                for (int i = 0; i < Profesores.Count && check==false; i++)
                {
                    if (textBox1.Text == Profesores[i].usuario && textBox2.Text == Profesores[i].contraseña)
                    {
                        check = true;
                        this.Hide();
                        menuProfesor mP = new menuProfesor();
                        mP.Show();
                        BD.g_sesionID = i;
                        BD.g_sesionTipo = 2;
                    }
                }
            }

            if(check==false)
            {
                if (textBox1.Text == "alumno" && textBox2.Text == "alumno")
                {
                    check = true;
                    this.Hide();
                    menuAlumno mA = new menuAlumno();
                    mA.Show();
                    BD.g_sesionID = 0;
                    BD.g_sesionTipo = 3;
                }

                for (int i = 0; i < Alumnos.Count && check == false; i++)
                {
                    if (textBox1.Text == Alumnos[i].usuario && textBox2.Text == Alumnos[i].contraseña)
                    {
                        check = true;
                        this.Hide();
                        menuAlumno mA = new menuAlumno();
                        mA.Show();
                        BD.g_sesionID = i;
                        BD.g_sesionTipo = 3;

                    }

                }
            }

            if (check == false)
            {
                MessageBox.Show("Error de autenticacion, verifique usuario y/O contraseña ó es posible que su cuenta este inhabilitada", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
