using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueEjercicio2
{
    class Usuario
    {
        string[] alumnos = new string[6];
        string[] asignaturas = new string[4];
        Aula aula;

        public Usuario()
        {
            aula = new Aula(alumnos, asignaturas);
        }

        public void Menu()
        {
            int opcion = 0;

            try
            {
                do
                {
                    Console.WriteLine("1- Visualizar tabla completa\n" +
                        "2- Media de notas de la tabla\n" +
                        "3- Media de alumno\n" +
                        "4- Media de una asignatura\n" +
                        "5- Visualizar notas de alumno\n" +
                        "6- Visualizar notas de asignatura\n" +
                        "7- Nota máxima y mínima de alumno\n" +
                        "8- Tabla de aprobados\n" +
                        "9- Salir");
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            TablaCompleta();
                            break;
                        case 2:
                           Console.WriteLine("Media de notas: " + aula.MediaGeneralTabla());
                            break;
                        case 3:
                            Console.WriteLine("Media de alumno: " + aula.MediaAlumnos("Alumno 1"));
                            break;
                        case 4:
                            Console.WriteLine("Media de asignatura: " + aula.MediaAsignatura("Asignatura 1"));
                            break;
                        case 5:
                            VisualizarNotasDeAlumno("Alumno 1");
                            break;
                        case 6:
                           // MuestraNotasAsignatura();
                            break;
                        case 7:

                            break;
                        case 8:
                            //Console.WriteLine(aula.DevuelveAprobados()); ;
                            break;
                        case 9:
                            Console.WriteLine("Bye");
                            Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                } while (opcion != 9);
            }
            catch (Exception ex) when (ex is FormatException)
            {
                Console.WriteLine("Error de entrada.");
            }
        }

        private void TablaCompleta()
        {
            Console.Write("\t");

            for (int i = 0; i < aula.asignatura.Length; i++)
            {
                Console.Write(aula.asignatura[i] + "\t");
            }

            Console.WriteLine();

            for (int i = 0; i < aula.notas.GetLength(0); i++)
            {
                Console.Write(aula.alumno[i] + "\t");
                for (int j = 0; j < aula.notas.GetLength(1); j++)
                {
                   Console.Write(aula.notas[i, j] + "\t\t");
                }
                 Console.WriteLine();
            }

            Console.WriteLine();
        }

        private void VisualizarNotasDeAlumno(string nombreAlumno)
        {
            Hashtable aprobados = aula.NotasAlumno(nombreAlumno);
            foreach (DictionaryEntry de in aprobados)
            {
                Console.Write("{0}\t",de.Key);
                for (int i  = 0; i  < ((int [])(de.Value)).Length; i ++)
                {
                    Console.Write(((int[])(de.Value))[i]+"\t");
                }
            }
            Console.WriteLine();
        }


    }
}
