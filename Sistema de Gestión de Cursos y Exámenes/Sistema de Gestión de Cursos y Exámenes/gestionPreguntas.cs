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
        Pregunta m_pregunta;

        public gestionPreguntas()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        public void gestionPreguntas_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < BD.g_PROFESOR_GLOBAL[BD.g_sesionID].cursos.Count(); i++)
            {
                CursosComboBox.Items.Add(BD.g_PROFESOR_GLOBAL[BD.g_sesionID].cursos[i]);
                for (int j = 0; j < BD.PROFESOR_GLOBAL[BD.g_sesionID].cursos[i].unidadesTematicas.Count(); j++)
                {
                    unidadesComboBox.Items.Add(BD.PROFESOR_GLOBAL[BD.g_sesionID].cursos[i].unidadesTematicas[j]);
                }
            }
        }

        public int to_int(string a) {
            int i = 0;
            if (!Int32.TryParse(a, out i))
            {
                i = -1;
            }
            return i;
        }
        private void GUARDARbancoPregunta_Click(object sender, EventArgs e)
        {
            if (DesarrolloCheck.Checked == true) {
                m_pregunta.tipo = "llenar";
                m_pregunta.setPregunta(preguntaPlanteamiento.Text);
                m_pregunta.m_curso = (Curso)CursosComboBox.SelectedItem;
                m_pregunta.m_unidad = (Unidad_Tematica)unidadesComboBox.SelectedItem;
                m_pregunta.tiempo = to_int(Time.Text);
                m_pregunta.setReglones((int)Reglones.Value);
                BD.g_PREGUNTAS_GLOBAL.Add(m_pregunta);
            }
            if (ConcretaCheck.Checked == true) {
                m_pregunta.tipo = "llenar";
                m_pregunta.setPregunta(preguntaPlanteamiento.Text);
                m_pregunta.m_curso = (Curso)CursosComboBox.SelectedItem;
                m_pregunta.m_unidad = (Unidad_Tematica)unidadesComboBox.SelectedItem;
                m_pregunta.tiempo = to_int(Time.Text);
                m_pregunta.setRespuestaCMP(ConcretaRespuesta.Text);
                BD.g_PREGUNTAS_GLOBAL.Add(m_pregunta);
            }
            if (AlternativaCheck.Checked == true) {
                m_pregunta.tipo = "opcion multiple";
                m_pregunta.setPregunta(preguntaPlanteamiento.Text);
                m_pregunta.m_curso = (Curso)CursosComboBox.SelectedItem;
                m_pregunta.m_unidad = (Unidad_Tematica)unidadesComboBox.SelectedItem;
                m_pregunta.tiempo = to_int(Time.Text);
                BD.g_PREGUNTAS_GLOBAL.Add(m_pregunta);
            }
            if (ChoiceCheck.Checked == true) {
                m_pregunta.tipo = "opcion multiple";
                m_pregunta.setPregunta(preguntaPlanteamiento.Text);
                m_pregunta.m_curso = (Curso)CursosComboBox.SelectedItem;
                m_pregunta.m_unidad = (Unidad_Tematica)unidadesComboBox.SelectedItem;
                m_pregunta.tiempo = to_int(Time.Text);
                BD.g_PREGUNTAS_GLOBAL.Add(m_pregunta);
            }
        }

        private void UploadCorrecta_Click(object sender, EventArgs e)
        {
            m_pregunta.setRespuestaOP(AlternativaCorrecta.Text);
        }

        private void UploadIncorrecta_Click(object sender, EventArgs e)
        {
            m_pregunta.setIncorrectaOP(AlternativaIncorrecta.Text);
        }

        private void UploadChoiceCorrecta_Click(object sender, EventArgs e)
        {
            m_pregunta.setRespuestaOP(ChoiceCorrecta.Text);
            //m_q.setRespuesta(ChoiceCorrecta.Text);
        }

        private void UploadChoiceIncorrecta_Click(object sender, EventArgs e)
        {
            m_pregunta.setIncorrectaOP(ChoiceIncorrecta.Text);
            //m_q.setRespuestaIncorrecta(ChoiceIncorrecta.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuAlumno a = new menuAlumno();
            a.Show();
        }

        private void ViewBanco_Click(object sender, EventArgs e)
        {
            this.Hide();
            bancoPreguntas a = new bancoPreguntas();
            a.Show();
        }
    }

    public class Pregunta {
        public string tipo;
        //tipo = "llenar"
        //tipo = "opcion multiple"
        public string pregunta;
        public string respuestaCMP;
        public List<string> respuestasOP;
        public List<string> incorrectasOP;
        public int tiempo;
        public int reglones;
        public Unidad_Tematica m_unidad;
        public Curso m_curso;
        public Pregunta getPregunta() { return this; }
        public void setReglones(int a) { reglones = a; }
        public int getReglones() {
            return this.reglones;
        }
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
        public bool setIncorrectaOP(string qr) {
            incorrectasOP.Add(qr);
            return true;
        }
        public Pregunta(int p = 0) {
            reglones = 0;
            if (p == 1) {
                tipo = "llenar";
                pregunta = "Esta bien esto? DESARROLLO LARGO";
                Curso m_c = new Curso("matematica");
                m_c.nombre = "matematica";
                Unidad_Tematica m_u = new Unidad_Tematica();
                m_u.nombre = "unidad 1";
                m_u.descripcion = "aqui aprenderas lo basico en mates";
                m_c.unidadesTematicas.Add(m_u);
                m_curso = m_c;
                m_unidad = m_u;
                tiempo = 5;
                reglones = 3;
            }
            if (p == 2) {
                tipo = "llenar";
                pregunta = "Esta bien esto? DESARROLLO CONCRETO";
                Curso m_c = new Curso("matematica");
                m_c.nombre = "matematica";
                Unidad_Tematica m_u = new Unidad_Tematica();
                m_u.nombre = "unidad 1";
                m_u.descripcion = "aqui aprenderas lo basico en mates";
                m_c.unidadesTematicas.Add(m_u);
                m_curso = m_c;
                m_unidad = m_u;
                tiempo = 3;
                respuestaCMP = "No esta bien";
            }
            if (p == 3)
            {
                tipo = "opcion multiple";
                pregunta = "Esta bien esto? Opcion multiple";
                Curso m_c = new Curso("matematica");
                m_c.nombre = "matematica";
                Unidad_Tematica m_u = new Unidad_Tematica();
                m_u.nombre = "unidad 1";
                m_u.descripcion = "aqui aprenderas lo basico en mates";
                m_c.unidadesTematicas.Add(m_u);
                m_curso = m_c;
                m_unidad = m_u;
                tiempo = 6;
                setRespuestaOP("Esta esta bien");
                setIncorrectaOP("la primera mala");
                setIncorrectaOP("la segunda mala");
            }
            if (p == 4)
            {
                tipo = "opcion multiple";
                pregunta = "Esta bien esto? Verdadero/Falso";
                Curso m_c = new Curso("matematica");
                m_c.nombre = "matematica";
                Unidad_Tematica m_u = new Unidad_Tematica();
                m_u.nombre = "unidad 1";
                m_u.descripcion = "aqui aprenderas lo basico en mates";
                m_c.unidadesTematicas.Add(m_u);
                m_curso = m_c;
                m_unidad = m_u;
                tiempo = 4;
                setRespuestaOP("Esta es la verdadera");
                setIncorrectaOP("esta es la falsa");
            }
        }
    };
    /*public class Pregunta_Opcion_Multiple{
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
    };*/

}
