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
