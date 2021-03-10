using System;

namespace Alumnos
{
    class Materia
    {
            public string nombre;
            public int semestre;
    
            public string NombreSemestre
        {
            // get => semestre + "o. semestre"; // ej. "2o. semestre"
            get => TransformarSemestreATexto() + " semestre"; // ej. "3er. semestre"
        }

        public Materia(string nombre, int semestre)
        {
            this.nombre = nombre;
            this.semestre = semestre;
        }
            
        private string TransformarSemestreATexto()
        {
            if(this.semestre == 1)
            {
                return "1er";
            }                    
            else if (this.semestre == 2)
            {
                return "2do";
            }
            else if (this.semestre == 3)
            {
                return "3er";
            }
            else if (this.semestre == 7)
            {
                return "7mo.";
            }
            else if (this.semestre == 8)
            {
                return "8vo.";
            }
            else
            {
                return this.semestre + "to.";
            }                
        }            
    }
}                
    
