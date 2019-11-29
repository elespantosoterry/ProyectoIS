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

        private void gestionPreguntas_Load(object sender, EventArgs e)
        {

        }
    }
    public class Pregunta_Opcion_Multiple{
        public string tipo;
        public string pregunta;
        public string respuesta;
        public List<string> incorrectas;
        public int tiempo;
        public Curso m_curso;
        public Pregunta_Opcion_Multiple getPregunta() { return this; }
        public bool setPregunta(string pr) {
            pregunta = pr;
            return true;
        }
        public bool setRespuesta(string qr) {
            respuesta = qr;
            return true;
        }
    };
    public class Pregunta_Completar {
        public string tipo;
        public string pregunta;
        public string respuesta;
        public Curso m_curso;
        public int tiempo;
        public Pregunta_Completar getPregunta() { return this; }
        public bool setPregunta(string pr) {
            pregunta = pr;
            return true;
        }
        public bool setRespuesta(string qr) {
            respuesta = qr;
            return true;
        }
    };

}
