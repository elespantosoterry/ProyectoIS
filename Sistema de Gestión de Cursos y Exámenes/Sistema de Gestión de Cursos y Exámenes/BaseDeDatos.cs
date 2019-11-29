using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sistema_de_Gestión_de_Cursos_y_Exámenes
{
    
    public static class BD
    {
        public static List<Curso> g_CURSO_GLOBAL= new List<Curso>();
        public static List<Curso> CURSO_GLOBAL
        {
            get { return g_CURSO_GLOBAL; }
            set { g_CURSO_GLOBAL = value; }
        }

        public static List<Profesor> g_PROFESOR_GLOBAL= new List<Profesor>();
        public static List<Profesor> PROFESOR_GLOBAL
        {
            get { return g_PROFESOR_GLOBAL; }
            set { g_PROFESOR_GLOBAL = value; }
        }


        public static List<Periodo_Academico> g_PERIODO_ACADEMICO_GLOBAL= new List<Periodo_Academico>();

        public static List<Periodo_Academico> PERIODO_ACADEMICO_GLOBAL
        {
            get { return g_PERIODO_ACADEMICO_GLOBAL; }
            set { g_PERIODO_ACADEMICO_GLOBAL = value; }
        }

        public static List<Grupo> g_GRUPO_GLOBAL= new List<Grupo>();
        public static List<Grupo> GRUPO_GLOBAL
        {
            get { return g_GRUPO_GLOBAL; }
            set { g_GRUPO_GLOBAL = value; }
        }

    }
    /*class MainClass
    {
        public static void Main(String[] args)
        {
            BaseDeDatos BD = new BaseDeDatos();

            //WILBER
            


        }
    }*/
    
    
}
