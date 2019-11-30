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
    public partial class bancoPreguntas : Form
    {
        public bancoPreguntas()
        {
            InitializeComponent();
        }

        private void bancoPreguntas_Load(object sender, EventArgs e)
        {
            verBANCO.Text += "ID_____TIPO____________PREGUNTA_______________RESPUESTA_______________TIEMPO_________ \n";
            for (int i = 0; i < BD.g_PREGUNTAS_GLOBAL.Count(); i++) {
                verBANCO.Text += i.ToString();
                if(BD.g_PREGUNTAS_GLOBAL[i].tipo == "opcion multiple")
                {
                    if (BD.g_PREGUNTAS_GLOBAL[i].respuestasOP.Count() == 1 && BD.g_PREGUNTAS_GLOBAL[i].incorrectasOP.Count() == 1)
                    {
                        verBANCO.Text += "   Verdadero Falso   ";
                        verBANCO.Text += BD.g_PREGUNTAS_GLOBAL[i].pregunta;
                        verBANCO.Text += "   ";
                        verBANCO.Text += BD.g_PREGUNTAS_GLOBAL[i].respuestasOP[0];
                        verBANCO.Text += "   ";
                        verBANCO.Text += BD.g_PREGUNTAS_GLOBAL[i].tiempo.ToString();
                        verBANCO.Text += "   ";
                    }
                    else {
                        verBANCO.Text += "   Opcion Multiple   ";
                        verBANCO.Text += BD.g_PREGUNTAS_GLOBAL[i].pregunta;
                        verBANCO.Text += "   ";
                        verBANCO.Text += BD.g_PREGUNTAS_GLOBAL[i].respuestasOP[0];
                        verBANCO.Text += "   ";
                        verBANCO.Text += BD.g_PREGUNTAS_GLOBAL[i].tiempo.ToString();
                        verBANCO.Text += "   ";
                    }
                }
                if (BD.g_PREGUNTAS_GLOBAL[i].tipo == "llenar") {
                    if (BD.g_PREGUNTAS_GLOBAL[i].reglones == 0)
                    {
                        verBANCO.Text += "   Respuesta Concreta   ";
                        verBANCO.Text += BD.g_PREGUNTAS_GLOBAL[i].pregunta;
                        verBANCO.Text += "   ";
                        verBANCO.Text += BD.g_PREGUNTAS_GLOBAL[i].respuestaCMP[0];
                        verBANCO.Text += "   ";
                        verBANCO.Text += BD.g_PREGUNTAS_GLOBAL[i].tiempo.ToString();
                        verBANCO.Text += "   ";
                    }
                    else {
                        verBANCO.Text += "   Respuesta Desarrollo   ";
                        verBANCO.Text += BD.g_PREGUNTAS_GLOBAL[i].pregunta;
                        verBANCO.Text += "   ";
                        verBANCO.Text += "------------";
                        verBANCO.Text += "   ";
                        verBANCO.Text += BD.g_PREGUNTAS_GLOBAL[i].tiempo.ToString();
                        verBANCO.Text += "   ";
                    }
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestionPreguntas A = new gestionPreguntas();
            A.Show();
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            Pregunta pregunta_vacia = new Pregunta();
            BD.g_PREGUNTAS_GLOBAL[to_int(textBox1.Text)] = pregunta_vacia;
        }

        public int to_int(string a)
        {
            int i = 0;
            if (!Int32.TryParse(a, out i))
            {
                i = -1;
            }
            return i;
        }

        private void verBANCO_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
