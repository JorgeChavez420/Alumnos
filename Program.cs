﻿using System;
using System.Collections.Generic;

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

            // Materias

            Materia programacionI = new Materia("Programacion I", 2);
            Console.WriteLine("La materia de " + programacionI.nombre + " se ve en " + programacionI.NombreSemestre);

            Materia inteligenciaArtificial = new Materia("Inteligencia Artificial", 7);
            Console.WriteLine("La materia de " + inteligenciaArtificial.nombre + " se ve en " + inteligenciaArtificial.NombreSemestre);

            // Materia[] materiaDeInteres = new Materia[2] {programacionI, inteligenciaArtificial, null};

            // Lista
            // - <> diamante operador
            // - <Materia> contiene materias
            // - Requiere inicializacion!
            List<Materia> materiasDeInteres = new List<Materia>();
            materiasDeInteres.Add(programacionI);
            materiasDeInteres.Add(inteligenciaArtificial);
            materiasDeInteres.Add(new Materia("Sistemas Interactivos I", 7));

            // materiasDeInteres[2]

            Console.WriteLine("La materia de " + materiasDeInteres[2].nombre + " se ve en " + materiasDeInteres[2].NombreSemestre);
            Console.WriteLine("Me interesan " + materiasDeInteres.Count + " materias");

            for (int i = 0; i < materiasDeInteres.Count; i++)
            {                
                Console.WriteLine(materiasDeInteres[i].nombre);
            }
            Console.WriteLine("...");
            materiasDeInteres.Remove(programacionI);
            Console.WriteLine("Ahora me interesan " + materiasDeInteres.Count + " materias");
            Console.WriteLine("Primer materia ahora es: " + materiasDeInteres[0].nombre);

            // Primer acercamiento; indicar indice a remover
            // materiasDeInteres.RemoveAt(1);

            // Segundo acercamiento; arrepentirnos y "crear" la variable
            // Materia sistemasInteractivosI = materiasDeInteres[1];
            //materiasDeInteres.Remove(sistemasInteractivosI);

            // Tercer acercamiento; buscar la variable a borrar
            Materia materiaABorrar = null;
            for (int i = 0; i < materiasDeInteres.Count; i++) 
            {
                if(materiasDeInteres[i].nombre == " Sistemas Interactivos I")
                {
                    // Encontramos la materia que buscamos 
                    // materiasDeInteres.RemoveAt(i);
                    // materiasDeInteres.Remove(materiasDeInteres[i]);
                    materiaABorrar = materiasDeInteres[i];

                    // como ya lo encontre puedo interrumpir el ciclo
                    break;
                }
            }
            // verificar si se encontro o no
            if (materiaABorrar != null)
            {

            }    

        }
    }
}
