using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRepaso2
{
    class Usuario
    {
        Aula aula;
        public void menu()
        {
            int opcion;
            Console.WriteLine("Elija una opción");
            Console.WriteLine("1-Visualizar tabla completa"
                +"\n2-Calcular la media de notas de toda la tabla"
                +"\n3-Media de un alumno"
                +"\n4-Media de una asignatura");
            Console.WriteLine("5-Visualizar notas de un alumno"
                +"\n6-Visualizar notas de una asignatura" 
                +"\n7-Nota máxima y mínima de un alumno"
                +"\n8-Tabla solo de aprobados");
            Console.WriteLine("9-Salir");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                default:
                    break;
            }
        }

        public void muestraTabla()
        {
            Console.WriteLine("\t");

            for (int i = 0; i < aula.asignaturas.Length; i++)
            {
                Console.WriteLine(aula.asignaturas[i] + "\t");
            }
            Console.WriteLine();

            for (int i = 0; i < aula.notas.GetLength(0); i++)
            {
                Console.WriteLine(aula.nombres[i] + "\t");
                for (int j = 0; j < aula.notas.GetLength(1); j++)
                {
                    Console.WriteLine(aula.notas[i, j] + "\t\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //Console.WriteLine("Intento de media: " + mediaGlobal(notas));
        }
    }
}
