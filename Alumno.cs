using System;

namespace Alumnos
{
    // Alumno hereda de Persona
    // Alumno extiende la clase Persona
    //Persona es la clase base de Alumno
    class Alumno : Persona
    {
        //(Atributos heredados desde Persona)    
        
        public int matricula;
        // Todos los alumnos son de la misma escuela (en este programa)
        static public string escuela = "CRESP";
        public Alumno(string nombre, string apellido, int matricula) : base(nombre, apellido)
        {
            this.matricula = matricula;           
        }

        // override - Modificar su funcionamiento
        public override void Presentarse() 
        {
            Console.WriteLine($"Hola, mi nombre es {this.NombreCompleto} y soy estudiante en {Alumno.escuela} con matricula {this.matricula}");
        }          
    }
}    
