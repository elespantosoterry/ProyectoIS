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
    public partial class gestionPeriodos : Form
    {
        public gestionPeriodos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void refreshPeriodos()
        {
            periodoEliminado.Items.Clear();
            for (int i = 0; i < BD.PERIODO_ACADEMICO_GLOBAL.Count; i++)
            {
                string nuevo = BD.PERIODO_ACADEMICO_GLOBAL[i].m_periodo;
                periodoEliminado.Items.Add(nuevo);
            }
            //periodoEliminado.SelectedIndex = 0;
        }
        private void abrirPeriodoBT_Click(object sender, EventArgs e)
        {
            string nombre = this.nuevoPeriodo.Text;



            Periodo_Academico foo = new Periodo_Academico(nombre, calendarPeriodo.SelectionStart, calendarPeriodo.SelectionEnd);
            //string nuevo = foo.m_periodo;
            BD.PERIODO_ACADEMICO_GLOBAL.Add(foo);
            this.nuevoPeriodo.Text = string.Empty; //borra lo escrito
            MessageBox.Show("Abierto exitosamente");
            refreshPeriodos();

        }

        private void periodoEliminado_Loaded(object sender, EventArgs e)
        {
            for (int i = 0; i < BD.PERIODO_ACADEMICO_GLOBAL.Count; i++)
            {
                string nuevo = BD.PERIODO_ACADEMICO_GLOBAL[i].m_periodo;
                periodoEliminado.Items.Add(nuevo);
            }
            //periodoEliminado.SelectedIndex = 0;

        }

        private void periodoEliminado_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private void cerrarPeriodoBT_Click(object sender, EventArgs e)
        {
            BD.PERIODO_ACADEMICO_GLOBAL.RemoveAt(periodoEliminado.SelectedIndex);
            refreshPeriodos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form back = new menuDirector();
            back.ShowDialog();
            this.Close();
        }
        private void calendarPeriodo_DateChanged(object sender, DateRangeEventArgs e)
        {

            
        }
        private void gestionPeriodos_Load(object sender, EventArgs e)
        {
            refreshPeriodos();
        }
        
    }
    public class Periodo_Academico
    {
        public string m_periodo;
        public DateTime inicio;
        public DateTime fin;
        public Periodo_Academico(string nombre, DateTime ini, DateTime fn)
        {
            m_periodo = nombre;
            inicio = ini;
            fin = fn;
        }
    }
}
