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
    public partial class rendirExamen : Form
    {
        public rendirExamen()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //comboBox1.Items.Add(BD.g_PREGUNTAS_GLOBAL[exam.Preguntas[i]].pregunta);
        private void rendirExamen_Load(object sender, EventArgs e)
        {
            Examen exam = new Examen();
            exam = BD.ALUMNO_GLOBAL[BD.g_sesionID].examenes[BD.g_sesionID];
            for (int i = 0; i < exam.Npreguntas; i++)
            {
                comboBox1.Items.Add((i).ToString());
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BD.ALUMNO_GLOBAL[BD.g_sesionID].examenes.Remove(BD.ALUMNO_GLOBAL[BD.g_sesionID].examenes[BD.g_exam]);
            MessageBox.Show("TU NOTA ---> " + BD.puntaje_ex.ToString());
            this.Hide();
            examenesDisponibles eD = new examenesDisponibles();
            eD.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Examen exam = new Examen();
            exam = BD.ALUMNO_GLOBAL[BD.g_sesionID].examenes[BD.g_exam];
            
            if (comboBox1.Text == "0")
            {
                Pregunta p = new Pregunta();
                p = BD.PREGUNTAS_GLOBAL[exam.Preguntas[0]];
                label2.Text = p.pregunta;

                if(p.tipo == "opcion multiple")
                {
                    label3.Text = p.incorrectasOP[0];
                    label4.Text = p.incorrectasOP[1];
                    label5.Text = p.respuestasOP[0];
                    label6.Text = p.incorrectasOP[2];
                }
                else
                {
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    label6.Hide();
                }

            }
            else if (comboBox1.Text == "1")
            {
                Pregunta p = new Pregunta();
                p = BD.PREGUNTAS_GLOBAL[exam.Preguntas[1]];
                label2.Text = p.pregunta;
                if (p.tipo == "opcion multiple")
                {
                    label3.Text = p.incorrectasOP[0];
                    label4.Text = p.incorrectasOP[1];
                    label5.Text = p.respuestasOP[0];
                    label6.Text = p.incorrectasOP[2];
                }
                else
                {
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    label6.Hide();
                }
            }
            else if (comboBox1.Text == "2")
            {
                Pregunta p = new Pregunta();
                p = BD.PREGUNTAS_GLOBAL[exam.Preguntas[2]];
                label2.Text = p.pregunta;
                if (p.tipo == "opcion multiple")
                {
                    label3.Text = p.incorrectasOP[0];
                    label4.Text = p.incorrectasOP[1];
                    label5.Text = p.respuestasOP[0];
                    label6.Text = p.incorrectasOP[2];
                }
                else
                {
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    label6.Hide();
                }
            }
            else if (comboBox1.Text == "3")
            {
                Pregunta p = new Pregunta();
                p = BD.PREGUNTAS_GLOBAL[exam.Preguntas[3]];
                label2.Text = p.pregunta;
                if (p.tipo == "opcion multiple")
                {
                    label3.Text = p.incorrectasOP[0];
                    label4.Text = p.incorrectasOP[1];
                    label5.Text = p.respuestasOP[0];
                    label6.Text = p.incorrectasOP[2];
                }
                else
                {
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    label6.Hide();
                }
            }
            else if (comboBox1.Text == "4")
            {
                Pregunta p = new Pregunta();
                p = BD.PREGUNTAS_GLOBAL[exam.Preguntas[4]];
                label2.Text = p.pregunta;
                if (p.tipo == "opcion multiple")
                {
                    label3.Text = p.incorrectasOP[0];
                    label4.Text = p.incorrectasOP[1];
                    label5.Text = p.respuestasOP[0];
                    label6.Text = p.incorrectasOP[2];
                }
                else
                {
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    label6.Hide();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int puntaje = 0;
            if (comboBox1.Text == "0")
            {
                Examen exam = new Examen();
                exam = BD.ALUMNO_GLOBAL[BD.g_sesionID].examenes[BD.g_exam];

                Pregunta p = new Pregunta();
                p = BD.PREGUNTAS_GLOBAL[exam.Preguntas[0]];

                if(textBox1.Text == p.respuestasOP[0] || textBox1.Text == p.respuestaCMP)
                {
                    puntaje += exam.Puntajes[0];
                }


            }
            else if (comboBox1.Text == "1")
            {
                Examen exam = new Examen();
                exam = BD.ALUMNO_GLOBAL[BD.g_sesionID].examenes[BD.g_exam];

                Pregunta p = new Pregunta();
                p = BD.PREGUNTAS_GLOBAL[exam.Preguntas[1]];

                if (textBox1.Text == p.respuestasOP[0] || textBox1.Text == p.respuestaCMP)
                {
                    puntaje += exam.Puntajes[1];
                }
            }
            else if (comboBox1.Text == "2")
            {
                Examen exam = new Examen();
                exam = BD.ALUMNO_GLOBAL[BD.g_sesionID].examenes[BD.g_exam];

                Pregunta p = new Pregunta();
                p = BD.PREGUNTAS_GLOBAL[exam.Preguntas[2]];
                label2.Text = p.pregunta;
                if (textBox1.Text == p.respuestasOP[0] || textBox1.Text == p.respuestaCMP)
                {
                    puntaje += exam.Puntajes[2];
                }
            }
            else if (comboBox1.Text == "3")
            {
                Examen exam = new Examen();
                exam = BD.ALUMNO_GLOBAL[BD.g_sesionID].examenes[BD.g_exam];

                Pregunta p = new Pregunta();
                p = BD.PREGUNTAS_GLOBAL[exam.Preguntas[3]];
                label2.Text = p.pregunta;
                if (textBox1.Text == p.respuestasOP[0] || textBox1.Text == p.respuestaCMP)
                {
                    puntaje += exam.Puntajes[3];
                }
            }
            else if (comboBox1.Text == "4")
            {
                Examen exam = new Examen();
                exam = BD.ALUMNO_GLOBAL[BD.g_sesionID].examenes[BD.g_exam];

                Pregunta p = new Pregunta();
                p = BD.PREGUNTAS_GLOBAL[exam.Preguntas[4]];
                label2.Text = p.pregunta;
                if (textBox1.Text == p.respuestasOP[0] || textBox1.Text == p.respuestaCMP)
                {
                    puntaje += exam.Puntajes[4];
                }
            }

            BD.puntaje_ex = puntaje;
            MessageBox.Show("RESPUESTA ENVIADA");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
