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
    public partial class examenesDisponibles : Form
    {
        public examenesDisponibles()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuAlumno mA = new menuAlumno();
            mA.Show();
        }

        private void tablaProfesores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaProfesores.Columns[e.ColumnIndex].Name == "Acceder")
            {

                int index = e.RowIndex;
                this.Hide();
                examenVirtuak eV = new examenVirtuak();
                eV.Show();
            }
        }

        private void examenesDisponibles_Load(object sender, EventArgs e)
        {
            Alumno al =  BD.ALUMNO_GLOBAL[BD.g_sesionID];
            Examen exa = new Examen();
            exa.Tipo = "Final";
            Curso c = new Curso("Mate");
            exa.curso = c;
            exa.Npreguntas = 1;
            List<int> preguntas = new List<int>();
            Pregunta p1 = new Pregunta();
            p1.pregunta = "Hola?";
            preguntas.Add(0);
            BD.PREGUNTAS_GLOBAL.Add(p1);
            exa.Preguntas = preguntas;
            List<Examen> exam = new List<Examen>();
            
            al.examenes = exam;
            Grupo g = new Grupo("grupo1", 1);
            List<Grupo> grupos = new List<Grupo>();
            grupos.Add(g);
            exa.Grupos = grupos;
            exam.Add(exa);
            //al.examenes.Add(exa);
            //al.examenes.Add(exa);


            for (int i = 0; i < exam.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)tablaProfesores.Rows[0].Clone();
                row.Cells[0].Value = "Examen " + exam[i].Tipo;
                row.Cells[1].Value = exam[i].curso.nombre;
                tablaProfesores.Rows.Add(row);

            }
        }
    }
}
