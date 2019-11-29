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
        Pregunta_Opcion_Multiple m_q;
        Pregunta_Completar m_p;

        public gestionPreguntas()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void GUARDARbancoPregunta_Click(object sender, EventArgs e)
        {
            if (DesarrolloCheck.Checked == true) {
                   
            }
            if (ConcretaCheck.Checked == true) {

            }
            if (AlternativaCheck.Checked == true) { 
            
            }
            if (ChoiceCheck.Checked == true) { 
            
            }
            if (PairCheck.Checked == true) { 
            
            }
        }

        private void gestionPreguntas_Load(object sender, EventArgs e)
        {
            unidadesComboBox.Items.Add(BD.g_PROFESOR_GLOBAL);
        }

        private void UploadCorrecta_Click(object sender, EventArgs e)
        {
            m_q.setRespuesta(AlternativaCorrecta.Text);
        }

        private void UploadIncorrecta_Click(object sender, EventArgs e)
        {
            m_q.setRespuestaIncorrecta(AlternativaIncorrecta.Text);
        }

        private void UploadChoiceCorrecta_Click(object sender, EventArgs e)
        {
            m_q.setRespuesta(ChoiceCorrecta.Text);
        }

        private void UploadChoiceIncorrecta_Click(object sender, EventArgs e)
        {
            m_q.setRespuestaIncorrecta(ChoiceIncorrecta.Text);
        }

        private void PairUpload_Click(object sender, EventArgs e)
        {
            m_q.setRespuesta(PairOne.Text);
            m_q.setRespuestaIncorrecta(PairTwo.Text);
        }
    }

    public class Pregunta {
        public string tipo;
        public string pregunta;
        public string respuestaCMP;
        public List<string> respuestasOP;
        public List<string> incorrectasOP;
        public int tiempo;
        public Unidad_Tematica m_unidad;
        public Curso m_curso;
        public Pregunta getPregunta() { return this; }
        public bool setPregunta(string pr) {
            pregunta = pr;
            return true;
        }
        public bool setRespuestaOP(string pr) {
            respuestasOP.Add(pr);
            return true;
        }
        public bool setRespuestaCMP(string qr) {
            respuestaCMP = qr;
            return true;
        }
    };
    public class Pregunta_Opcion_Multiple{
        public string tipo;
        public string pregunta;
        public List<string> respuesta;
        public List<string> incorrectas;
        public int tiempo;
        public Unidad_Tematica m_unidad;
        public Curso m_curso;
        public Pregunta_Opcion_Multiple getPregunta() { return this; }
        public bool setPregunta(string pr) {
            pregunta = pr;
            return true;
        }
        public bool setRespuesta(string qr) {
            respuesta.Add(qr);
            return true;
        }
        public bool setRespuestaIncorrecta(string qr) {
            incorrectas.Add(qr);
            return true;
        }
    };
    public class Pregunta_Completar {
        public string tipo;
        public string pregunta;
        public string respuesta;
        public Unidad_Tematica m_unidad;
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
