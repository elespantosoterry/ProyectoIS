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
    public partial class gestionGrupos : Form
    {

        public gestionGrupos()
        {
            InitializeComponent();
        }
        private void Form_Load(object sender, EventArgs e)
        {
            refreshGrupos();
        }
        public void refreshGrupos()
        {
            grupoCerrado.Items.Clear();
            for (int i = 0; i < BD.GRUPO_GLOBAL.Count; i++)
            {
                string nuevo = BD.GRUPO_GLOBAL[i].identificador;
                grupoCerrado.Items.Add(nuevo);
            }
        }

        private void guardarNuevoCursoBT_Click(object sender, EventArgs e)
        {
            string nombre = this.nuevoGrupo.Text;



            Grupo foo = new Grupo(nombre, Int32.Parse(cuposGrupo.Text));
            //string nuevo = foo.m_periodo;
            BD.GRUPO_GLOBAL.Add(foo);
            this.nuevoGrupo.Text = string.Empty;
            this.cuposGrupo.Text = string.Empty;//borra lo escrito
            MessageBox.Show("Abierto exitosamente");
            refreshGrupos();
        }

        private void eliminarGrupoBT_Click(object sender, EventArgs e)
        {
            BD.GRUPO_GLOBAL.RemoveAt(grupoCerrado.SelectedIndex);
            refreshGrupos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form back = new menuDirector();
            back.ShowDialog();
            this.Close();
        }

        private void gestionGrupos_Load(object sender, EventArgs e)
        {
            refreshGrupos();
        }
    }

    public class Grupo:ICloneable
    {
        public Profesor encargado;
        public Curso curso;
        public Periodo_Academico periodo;
        public string identificador;
        public int cupos;
        public  List<Alumno> alumnos;
        public List<int> notas;

        public Grupo(string id, int c)
        {
            identificador = id;
            cupos = c;
        }
        public Grupo()
        {
            
        }
        public object Clone()
        {
            Grupo nuevo = (Grupo)this.MemberwiseClone();
            return nuevo;
        }
        void ejecutarExamen(Examen exa)
        {

        }

    }
}
