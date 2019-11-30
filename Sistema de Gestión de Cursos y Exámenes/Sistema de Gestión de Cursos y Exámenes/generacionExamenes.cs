using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Sistema_de_Gestión_de_Cursos_y_Exámenes
{
    public struct Examen
    {
        
        public List<int> Preguntas; //Indices de pregunta
        public string Nombre; //Nombres y apellidos del alumno
        public string Tipo; //Control parcial final
        public int Tiempo;  //Tiempo del examen debe coincidir con la sumatoria de tiempo de las preguntas
        public int Npreguntas; //cantidad
        public List<Grupo> Grupos;
        public List<int> Puntajes; //el vector de las preguntas deben conincidir en cuanto a indices a el de puntajes
        public Curso curso;

        int SumatoriasPuntaje()
        {
            int suma = 0;
            for (int i = 0; i < Puntajes.Count; i++)
            {
                suma += Puntajes[i]; //calculamos la sumatoria del puntaje de las preugntas almacenadas
            }
            return suma;
        }
        int SumatoriasTiempo()
        {
            int suma = 0;
            for(int i = 0 ; i < Preguntas.Count ; i++)
            {
                suma += BD.g_PREGUNTAS_GLOBAL[Preguntas[i]].tiempo; //calculamos la sumatoria del tiempo de las preugntas almacenadas
            }
            return suma;
        }
        bool CambiarPregunta(int a, int b)//cambio de indices indice del examen con indice del banco
        {
            if(b <= BD.g_PREGUNTAS_GLOBAL.Count)
            {
                Preguntas[a] = b;
                return true;
            }
            else
            {
                return false;
            }
        }
        bool CambiarPuntaje(int a, int b)//Indice de la pregunta y el puntaje que se desea asignar
        {
            Puntajes[a] = b;
            return true;
        }
        void mostrarExamen()
        {

        }
        bool GenerarExamenAleatorio()
        {
            var seed = Environment.TickCount;
            var random = new Random(seed);
            int value = random.Next(0, BD.g_PREGUNTAS_GLOBAL.Count);

            return true;
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

        private void GuardarExamen2_Click(object sender, EventArgs e)
        {

        }

        private void GuardarExamen_Click(object sender, EventArgs e)
        {

        }

        private void calendarExamen_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void SeleccionarGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SeleccionarCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SeleccionarDuracion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NumeroPreguntas_TextChanged(object sender, EventArgs e)
        {

        }

        private void guardarConfExamen_Click(object sender, EventArgs e)
        {

        }

        private void IndiceExamen_TextChanged(object sender, EventArgs e)
        {

        }

        private void IndiceBanco_TextChanged(object sender, EventArgs e)
        {

        }

        private void IndiceExamenPuntaje_TextChanged(object sender, EventArgs e)
        {

        }

        private void PuntajeCambiar_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenerarPDF_Click(object sender, EventArgs e)
        {
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream("hola.pdf", FileMode.Create));
            doc.Open();

            Paragraph title = new Paragraph();
            title.Font = FontFactory.GetFont(FontFactory.TIMES, 18f, BaseColor.BLUE);
            title.Add("Hola Mundo!!");
            doc.Add(title);

            doc.Add(new Paragraph("Hola Mundo!!"));
            doc.Add(new Paragraph("Parrafo 1"));
            doc.Add(new Paragraph("Parrafo 2"));
            doc.Close();
        }
    }
}
