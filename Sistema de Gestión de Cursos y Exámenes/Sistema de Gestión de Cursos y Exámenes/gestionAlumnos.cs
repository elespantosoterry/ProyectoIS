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
            //retiroGrupos.Items.Clear();
            for (int i = 0; i < BD.GRUPO_GLOBAL.Count; i++)
            {
                string nuevo = BD.GRUPO_GLOBAL[i].identificador;
                matriculaGrupos.Items.Add(nuevo);
                //retiroGrupos.Items.Add(nuevo);
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
            foo.codigo = this.nuevoCodigo.Text;
            BD.ALUMNO_GLOBAL.Add(foo);




            this.nuevoNombre.Text = string.Empty; //borra lo escrito
            this.nuevoApellido.Text= string.Empty;
            this.nuevoUsuario.Text= string.Empty;
            this.nuevaContraseña.Text= string.Empty;
            this.nuevoCodigo.Text = string.Empty;


            MessageBox.Show("Creado exitosamente");


            //PONIENDO EN ELIMINADO
            refreshItems();
        }

        private void nuevoNombre_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void asignarCursoBT_Click(object sender, EventArgs e)
        {
            if (BD.GRUPO_GLOBAL[matriculaGrupos.SelectedIndex].cupos < 1)
            {
                MessageBox.Show("No hay cupos para matricular a alguien mas");
                return;
            }

            bool encontro = false,enGrupo=false;
            for (int i = 0; i < BD.ALUMNO_GLOBAL.Count; i++)
            {
                if (BD.ALUMNO_GLOBAL[i].codigo == codigoMatricula.Text)
                {
                    encontro = true;


                    //Grupo foo = (Grupo)(BD.GRUPO_GLOBAL[matriculaGrupos.SelectedIndex]).Clone();
                    Grupo foo = new Grupo();
                    foo = BD.GRUPO_GLOBAL[matriculaGrupos.SelectedIndex];
                    
                    for(int j=0;j< BD.ALUMNO_GLOBAL[i].grupos.Count; j++)
                    {
                        if(foo==BD.ALUMNO_GLOBAL[i].grupos[j])
                        {
                            enGrupo = true;
                        }
                    }
                    if (enGrupo ==true )
                    {
                        MessageBox.Show("Ya estaba registrado en ese grupo");
                        break;
                    }
                    BD.ALUMNO_GLOBAL[i].grupos.Add(foo);
                    BD.GRUPO_GLOBAL[matriculaGrupos.SelectedIndex].cupos -= 1;
                    break;
                } 
            }
            if (encontro == true && enGrupo==false)
            {
                MessageBox.Show("Creado exitosamente");
            }
            else
            {
                if (encontro == false)
                    MessageBox.Show("No se encontró ese Código de Alumno");
            }

            matriculaGrupos.Text = string.Empty;
            cuposMatricula.Text = string.Empty;
            codigoMatricula.Text = string.Empty;
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

        private void eliminarCursoBT_Click(object sender, EventArgs e)
        {
            bool encontro = false;
            //retiroGrupos.Items.Clear();
            int indAlumno;
            for (int i = 0; i < BD.ALUMNO_GLOBAL.Count; i++)
            {
                if (BD.ALUMNO_GLOBAL[i].codigo == codigoRetiro.Text)
                {
                    encontro = true;
                    
                    BD.ALUMNO_GLOBAL[i].grupos.RemoveAt(retiroGrupos.SelectedIndex);
                    //BD.GRUPO_GLOBAL[retiroGrupos.SelectedIndex].cupos += 1;
                    break;
                }
            }
            codigoRetiro.Text = string.Empty;
            

        }

        private void codigoRetiro_TextChanged(object sender, EventArgs e)
        {
            bool encontro = false;
            retiroGrupos.Items.Clear();
            //int indAlumno;
            for (int i = 0; i < BD.ALUMNO_GLOBAL.Count; i++)
            {
                if (BD.ALUMNO_GLOBAL[i].codigo == codigoRetiro.Text)
                {
                    encontro = true;
                    for(int j = 0; j < BD.ALUMNO_GLOBAL[i].grupos.Count;j++)
                    {
                        string nuevo = BD.ALUMNO_GLOBAL[i].grupos[j].identificador;
                        matriculaGrupos.Items.Add(nuevo);
                    }
                    //indAlumno=i;
                    //BD.GRUPO_GLOBAL[retiroGrupos.SelectedIndex].cupos += 1;
                    break;
                }
            }

            
            

        }

        private void gestionAlumnos_Load(object sender, EventArgs e)
        {
            refreshItems();
        }
    }
    public class Alumno
    {
        public string usuario,contraseña,nombres,apellidos,codigo;
        public List<Grupo> grupos=new List<Grupo>();
        public List<Examen> examenes= new List<Examen>();





    }
}
