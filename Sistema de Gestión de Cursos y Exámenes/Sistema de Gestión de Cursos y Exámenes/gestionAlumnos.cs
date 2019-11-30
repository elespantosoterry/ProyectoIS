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
    public partial class gestionAlumnos : Form
    {
        public gestionAlumnos()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        public void refreshItems()
        {

            matriculaGrupos.Items.Clear();
            retiroGrupos.Items.Clear();
            for (int i = 0; i < BD.GRUPO_GLOBAL.Count; i++)
            {
                string nuevo = BD.GRUPO_GLOBAL[i].identificador;
                matriculaGrupos.Items.Add(nuevo);
                retiroGrupos.Items.Add(nuevo);
            }
        }
            private void guardarNuevoCursoBT_Click(object sender, EventArgs e)
        {
            string nombre = this.nuevoNombre.Text;



            Alumno foo = new Alumno();
            foo.nombres = nombre;
            foo.apellidos = this.nuevoApellido.Text;
            foo.usuario = this.nuevoUsuario.Text;
            foo.contraseña = this.nuevaContraseña.Text;

            BD.ALUMNO_GLOBAL.Add(foo);




            this.nuevoNombre.Text = string.Empty; //borra lo escrito
            this.nuevoApellido.Text= string.Empty;
            this.nuevoUsuario.Text= string.Empty;
            this.nuevaContraseña.Text= string.Empty;


            MessageBox.Show("Creado exitosamente");


            //PONIENDO EN ELIMINADO
            refreshItems();
        }

        private void nuevoNombre_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void asignarCursoBT_Click(object sender, EventArgs e)
        {
            bool encontro = false;
            for (int i = 0; i < BD.ALUMNO_GLOBAL.Count; i++)
            {
                if (BD.ALUMNO_GLOBAL[i].codigo == codigoMatricula.Text)
                {
                    encontro = true;
                    BD.ALUMNO_GLOBAL[i].grupos.Add(BD.GRUPO_GLOBAL[matriculaGrupos.SelectedIndex]);
                    break;
                }
                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form back = new menuDirector();
            back.ShowDialog();
            this.Close();
        }

        private void matriculaGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cuposMatricula.Text =(BD.GRUPO_GLOBAL[matriculaGrupos.SelectedIndex].cupos).ToString();
        }
    }
    public class Alumno
    {
        public string usuario,contraseña,nombres,apellidos,codigo;
        public List<Grupo> grupos;
        public List<Examen> examenes;





    }
}
