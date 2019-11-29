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
    public partial class gestionPreguntas : Form
    {
        public gestionPreguntas()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
    public class Pregunta_Opciones{
        public string tipo;
        public string pregunta;
        public List<string> respuestasCorrectas;
        public List<string> respuestasIncorrectas;
        public Curso m_curso;
        public Pregunta_Opciones getPregunta() { return this; }
    };
    public class Pregunta_Completar {
        public string tipo;
        public string pregunta;
        public string respuesta;
        public Curso m_curso;
        public Pregunta_Completar getPregunta() { return this; }
    };

}
