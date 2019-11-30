﻿using System;
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
<<<<<<< HEAD
    public class Examen
    {
        public List<int> Preguntas; //Indices de pregunta
        public string Nombre;
        public string Tipo; //Control parcial final
        public int Tiempo;
        public int Npreguntas; //cantidad
        public List<Grupo> Grupos;
        public List<int> Puntajes;
=======
    public struct Examen
    {
        List<int> Preguntas; //Indices de pregunta
        string Nombre; //Nombres y apellidos del alumno
        string Tipo; //Control parcial final
        int Tiempo;  //Tiempo del examen debe coincidir con la sumatoria de tiempo de las preguntas
        int Npreguntas; //cantidad
        List<Grupo> Grupos;
        List<int> Puntajes; //el vector de las preguntas deben conincidir en cuanto a indices a el de puntajes

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
>>>>>>> 414b96e1607212093f3606ef42e4e57dfc6a2a66
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
        void PedirDatosExamen()
        {

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
    }
}
