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
    struct Examen
    {
        List<int> Preguntas; //Indices de pregunta
        string Nombre;
        string Tipo; //Control parcial final
        int Tiempo;
        int Npreguntas; //cantidad
        List<Grupo> Grupos;
        List<int> Puntajes;
        bool CambiarPregunta(int a, int b)//cambio de indices indice del examen con indice del banco
        {
            //Preguntas[a] = [b];
            return true;
        }
        bool CambiarPuntaje(int a, int b)
        {
            return true;
        }
        void mostrarExamen()
        {

        }

    }
    public partial class generacionExamenes : Form
    {
        public generacionExamenes()
        {
            InitializeComponent();
        }

        private void generacionExamenes_Load(object sender, EventArgs e)
        {

        }
    }
}
