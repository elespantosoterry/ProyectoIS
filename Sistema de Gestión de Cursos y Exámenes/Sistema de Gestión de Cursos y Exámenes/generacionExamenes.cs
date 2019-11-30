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

        public string Curso;
        public List<int> Puntajes; //el vector de las preguntas deben conincidir en cuanto a indices a el de puntajes
        public DateTime inicio;
        public Curso curso;
        public int puntaje_final;


        public int SumatoriasPuntaje()
        {
            int suma = 0;
            for (int i = 0; i < Puntajes.Count; i++)
            {
                suma += Puntajes[i]; //calculamos la sumatoria del puntaje de las preugntas almacenadas
            }
            return suma;
        }
        public int SumatoriasTiempo()
        {
            int suma = 0;
            for(int i = 0 ; i < Preguntas.Count ; i++)
            {
                suma += BD.g_PREGUNTAS_GLOBAL[Preguntas[i]].tiempo; //calculamos la sumatoria del tiempo de las preugntas almacenadas
            }
            return suma;
        }
        public bool CambiarPregunta(int a, int b)//cambio de indices indice del examen con indice del banco
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
        public bool CambiarPuntaje(int a, int b)//Indice de la pregunta y el puntaje que se desea asignar
        {
            Puntajes[a] = b;
            return true;
        }
        void mostrarExamen()
        {

        }
        public bool GenerarExamenAleatorio()
        {
            var seed = Environment.TickCount;
            var random = new Random(seed);
            int value = random.Next(0, BD.g_PREGUNTAS_GLOBAL.Count);
            int puntajeGeneral = 20 / Npreguntas;
            for (int i = 0; i < Npreguntas; i++)
            {
                Puntajes.Add(puntajeGeneral);
                int a = value;
                if(BD.g_PREGUNTAS_GLOBAL[a].m_curso == curso)
                {
                    Preguntas.Add(a);
                }
                else
                {
                    i--;
                }
            }
            return true;
        }
        public void generarPDF()
        {
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream("Examen.pdf", FileMode.Create));
            doc.Open();

            Paragraph title = new Paragraph();
            title.Font = FontFactory.GetFont(FontFactory.TIMES, 18f, BaseColor.BLACK);
            title.Add(Tipo);
            doc.Add(title);
            doc.AddCreator(BD.g_PROFESOR_GLOBAL[BD.g_sesionID].nombre);
            doc.Add(new Paragraph("Nombres y Apellido:___________________________________________________________________"));
            doc.Add(new Paragraph("Tiempo para el examen:"));
            doc.Add(new Paragraph(Tiempo));
            doc.Add(new Paragraph("Curso:"));
            doc.Add(new Paragraph(Curso));
            doc.Add(new Paragraph("Nota:______"));
            /*for(int i = 0; i < Grupos.Count; i++)
            {
                doc.Add(Grupos[i].ToString);
            }*/
            for (int i = 0; i < Preguntas.Count; i++)
            {
                if(BD.PREGUNTAS_GLOBAL[Preguntas[i]].tipo == "llenar")
                {
                    doc.Add(new Paragraph("Pregunta Numero "));
                    doc.Add(new Paragraph(i));
                    doc.Add(new Paragraph("TIEMPO"));
                    doc.Add(new Paragraph(BD.PREGUNTAS_GLOBAL[Preguntas[i]].tiempo));
                    doc.Add(new Paragraph(BD.PREGUNTAS_GLOBAL[Preguntas[i]].pregunta));
                    for (int j = 0; j < BD.PREGUNTAS_GLOBAL[Preguntas[i]].reglones-1; j++)
                    {
                        doc.Add(new Paragraph("_________________________________________________________________________________________________"));
                    }
                        doc.Add(new Paragraph("_________________________________________________________________________________________________"));
                    
                }
                else if(BD.PREGUNTAS_GLOBAL[Preguntas[i]].tipo == "opcion multiple")
                {
                    doc.Add(new Paragraph("Pregunta Numero "));
                    doc.Add(new Paragraph(i));
                    doc.Add(new Paragraph("TIEMPO"));
                    doc.Add(new Paragraph(BD.PREGUNTAS_GLOBAL[Preguntas[i]].tiempo));
                    doc.Add(new Paragraph("Puntaje de la pregunta:"));
                    doc.Add(new Paragraph(Puntajes[i]));
                    doc.Add(new Paragraph("Subraye la alternativa correcta:"));
                    doc.Add(new Paragraph(BD.PREGUNTAS_GLOBAL[Preguntas[i]].pregunta));
                    for (int j = 0; j < BD.PREGUNTAS_GLOBAL[Preguntas[i]].incorrectasOP.Count; j++)
                    {
                        doc.Add(new Paragraph(BD.PREGUNTAS_GLOBAL[Preguntas[j]].incorrectasOP[j]));
                    }
                    doc.Add(new Paragraph(BD.PREGUNTAS_GLOBAL[Preguntas[i]].respuestasOP[0]));
                }
                doc.Add(new Paragraph());
            }
                doc.Add(new Paragraph("Fin del Examen..."));
            doc.Close();
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
            SeleccionarTipo.Items.Add("Control");
            SeleccionarTipo.Items.Add("Examen Parcial");
            SeleccionarTipo.Items.Add("Examen Final");
            SeleccionarDuracion.Items.Add(30);
            SeleccionarDuracion.Items.Add(60);
            SeleccionarDuracion.Items.Add(90);
            SeleccionarDuracion.Items.Add(120);
            for (int i = 0; i < BD.g_PROFESOR_GLOBAL[BD.g_sesionID].cursos.Count; i++)
            {
                SeleccionarCurso.Items.Add(BD.g_PROFESOR_GLOBAL[BD.g_sesionID].cursos[i]);
            }
        }

        private void GuardarExamen2_Click(object sender, EventArgs e)
        {
            string intString = IndiceExamen.Text;
            int i = 0;
            if (!Int32.TryParse(intString, out i))
            {
                i = -1;
            }
            intString = IndiceBanco.Text;
            int j = 0;
            if (!Int32.TryParse(intString, out j))
            {
                j = -1;
            }
            BD.g_PROFESOR_GLOBAL[BD.g_sesionID].examenes[0].CambiarPregunta(i,j);
        }

        private void GuardarExamen_Click(object sender, EventArgs e)
        {
            string intString = IndiceExamenPuntaje.Text;
            int i = 0;
            if (!Int32.TryParse(intString, out i))
            {
                i = -1;
            }
            intString = PuntajeCambiar.Text;
            int j = 0;
            if (!Int32.TryParse(intString, out j))
            {
                j = -1;
            }
            BD.g_PROFESOR_GLOBAL[BD.g_sesionID].examenes[0].CambiarPuntaje(i, j);
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
            Examen nuevo = new Examen();
            
            nuevo.inicio = calendarExamen.SelectionStart;
            string intString = NumeroPreguntas.Text;
            int i = 0;
            if (!Int32.TryParse(intString, out i))
            {
                i = -1;
            }
            nuevo.Npreguntas = i;
            nuevo.Tipo = SeleccionarTipo.Text;
            intString = SeleccionarDuracion.Text;
            if (!Int32.TryParse(intString, out i))
            {
                i = -1;
            }
            nuevo.Tiempo = i;
            nuevo.Curso = SeleccionarCurso.Text;
            nuevo.GenerarExamenAleatorio();
            BD.g_PROFESOR_GLOBAL[BD.g_sesionID].examenes.Add(nuevo);

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
            BD.g_PROFESOR_GLOBAL[BD.g_sesionID].examenes[0].generarPDF();
        }

        private void Retroceder_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuProfesor mP = new menuProfesor();
            mP.Show();
        }
    }
}
