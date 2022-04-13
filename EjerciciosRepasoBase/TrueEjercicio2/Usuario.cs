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
                            Console.WriteLine("Media de alumno: " + aula.MediaAlumnos(1));
                            break;
                        case 4:
                            Console.WriteLine("Media de asignatura: " + aula.MediaAsignatura(2));
                            break;
                        case 5:
                            VisualizarNotasDeAlumno();
                            break;
                        case 6:
                            VisualizarNotasDeUnaAsignatura();
                            break;
                        case 7:
                            int minimo = 0;
                            int maximo = 10;
                            aula.NotaMaxMinAlumnos(0, ref maximo, ref minimo);
                            Console.WriteLine("Nota maxima: " + maximo + "\n Nota minima: " + minimo);
                            break;
                        case 8:
                            Console.WriteLine(aula.Aprobados()); ;
                            break;
                        case 9:
                            Console.WriteLine("Bye");
                            Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("No disponible");
                            break;
                    }
                } while (opcion != 9);
            }
            catch (Exception ex) when (ex is FormatException)
            {
                Console.WriteLine("Se introdujo algo no valido");
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

        private void VisualizarNotasDeAlumno()
        {
            int alumnoCod = 0;
            do
            {
                Console.WriteLine("Introduzaca el codigo del alumno a visualizar (disponemos de un total de )" + alumnos.Length);
                alumnoCod = int.Parse(Console.ReadLine()) - 1;
            } while (alumnoCod + 1 > alumnos.Length || alumnoCod < 0);

            Console.Write("\t");

            for (int i = 0; i < asignaturas.Length; i++)
            {
                Console.Write(asignaturas[i] + "\t");
            }
            Console.WriteLine();

            Console.Write(alumnos[alumnoCod] + "\t");

            for (int i = 0; i < aula.notas.GetLength(1); i++)
            {
                Console.Write(aula.notas[alumnoCod, i] + "\t\t");
            }

            Console.WriteLine();
        }
        private void VisualizarNotasDeUnaAsignatura()
        {
            int asignaturaCod = 0;

            do
            {
                Console.WriteLine("Introduzaca el codigo de la asignatura a visualizar (disponemos de un total de )" + asignaturas.Length);
                asignaturaCod = int.Parse(Console.ReadLine()) - 1;
            } while (asignaturaCod + 1 > asignaturas.Length || asignaturaCod < 0);

            Console.Write("\t");

            Console.WriteLine(asignaturas[asignaturaCod] + "\t");

            for (int i = 0; i < aula.notas.GetLength(0); i++)
            {
                Console.Write(alumnos[i] + "\t");
                Console.Write(aula.notas[i, asignaturaCod] + "\t\t");
            }

            Console.WriteLine();
        }
    }
}
