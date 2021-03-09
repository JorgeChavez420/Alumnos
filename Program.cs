using System;

namespace Alumnos
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona nombre1 = new Persona("Jorge Angel" ," Chavez Guzman ");           
            nombre1.Presentarse();
            
            nombre1.ColorFavorito = " Azul ";

            Console.WriteLine(nombre1.ColorFavorito);

            // Alumnos

            Alumno alumno1 = new Alumno("Jose", "Talamantes", 2759);
            Console.WriteLine("Primer alumno: " + alumno1.NombreCompleto);
            alumno1.Presentarse();
            
            

            

            
            
            

            

           
        }
    }
}
