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
    public partial class gestionUnidadesTematicas : Form
    {
        public gestionUnidadesTematicas()
        {
            InitializeComponent();
        }

        private void gestionUnidadesTematicas_Load(object sender, EventArgs e)
        {
            refreshItems();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void nuevoGrupo_TextChanged(object sender, EventArgs e)
        {

        }
        public void refreshItems()
        {

            
            cursoNuevaUnidad.Items.Clear();
            cursoEliminado.Items.Clear();
            for (int i = 0; i < BD.CURSO_GLOBAL.Count; i++)
            {
                string nuevo = BD.CURSO_GLOBAL[i].nombre;
                cursoNuevaUnidad.Items.Add(nuevo);
                cursoEliminado.Items.Add(nuevo);
            }
            
        }


        private void eliminarUnidadBT_Click(object sender, EventArgs e)
        {
            BD.CURSO_GLOBAL[cursoEliminado.SelectedIndex].unidadesTematicas.RemoveAt(unidadEliminado.SelectedIndex);
            unidadEliminado.Items.Clear();
        }

        private void cursoEliminado_SelectedIndexChanged(object sender, EventArgs e)
        {
            unidadEliminado.Items.Clear();
            for (int i = 0; i < BD.CURSO_GLOBAL[cursoEliminado.SelectedIndex].unidadesTematicas.Count; i++)
            {
                string nuevo = BD.CURSO_GLOBAL[i].nombre;
                unidadEliminado.Items.Add(nuevo);
            }

        }

        private void unidadEliminado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form back = new menuProfesor();
            back.ShowDialog();
            this.Close();
        }
    }

    public class Unidad_Tematica {
        public string nombre;
        public string descripcion;
        public void setDescripcion(string des) {
            descripcion = des;
        }
        public Unidad_Tematica getUnidad_Tematica() {
            return this;
        }
    };
}
