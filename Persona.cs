using System;

namespace Alumnos
{
    class Persona
    {
        public string nombre;
        public string apellido;
        
    
  
        public string NombreCompleto
        {
            get => this.nombre + " " + this.apellido;
        }

        private string colorFavorito; 

        public string ColorFavorito
        {
            get => "Color" + this.colorFavorito;
            set => this.colorFavorito = value;
        }

        

         public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

                public void Presentarse()
        {
            Console.WriteLine("Hola! Mi nombre es " + this.nombre + this.apellido);
            
        }
    }
}
             
