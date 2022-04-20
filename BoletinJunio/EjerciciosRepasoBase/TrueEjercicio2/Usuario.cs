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
        string[] alumnos = new string[4];
        string[] asignaturas = new string[4];
        Aula aula;

        public Usuario()
        {
            for (int i = 0; i < this.alumnos.Length; i++)
            {
                this.alumnos[i] = "Alumno " + (i + 1);
            }

            for (int i = 0; i < this.asignaturas.Length; i++)
            {
                this.asignaturas[i] = "Asignatura " + (i + 1);
            }
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
                            Console.WriteLine("Media de alumno: " + aula.MediaAlumnos(InsertaAlumno()));
                            break;
                        case 4:
                            Console.WriteLine("Media de asignatura: " + aula.MediaAsignatura(InsertaAsignatura()));
                            break;
                        case 5:
                            VisualizarNotasDeAlumno();
                            break;
                        case 6:
                            VisualizarNotasDeUnaAsignatura();
                            break;
                        case 7:
                            int minimo = 10;
                            int maximo = 0;
                            aula.NotaMaxMinAlumnos(InsertaAlumno(), ref maximo, ref minimo);
                            Console.WriteLine($"Nota maxima: {maximo}\nNota minima: {minimo}" );
                            break;
                        case 8:
                            VisualizarAprobados(aula.Aprobados());
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
            //Console.Write("\t");
            string space = String.Format("{0,9}", "");
            Console.Write(space);
            for (int i = 0; i < asignaturas.Length; i++)
            {
               //Console.Write(aula.asignatura[i] + "\t");
               Console.Write(asignaturas[i] + space);

            }

            Console.WriteLine();

            for (int i = 0; i < aula.notas.GetLength(0); i++)
            {
                //Console.Write(aula.alumno[i] + "\t");
                Console.Write(alumnos[i] + space);
                for (int j = 0; j < aula.notas.GetLength(1); j++)
                {
                    //Console.Write(aula.notas[i, j] + "\t\t");
                    Console.Write(aula.notas[i,j] + space + space);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
        private int InsertaAlumno()
        {
            int alumnoCod = 0;
            do
            {
                Console.WriteLine("Introduzaca el codigo del alumno a visualizar (disponemos de un total de) " + alumnos.Length);
                alumnoCod = int.Parse(Console.ReadLine()) - 1;
            } while (alumnoCod + 1 > alumnos.Length || alumnoCod < 0);

            return alumnoCod;
        }

        private int InsertaAsignatura()
        {
            int asignaturaCod = 0;
            do
            {
                Console.WriteLine("Introduzaca el codigo del alumno a visualizar (disponemos de un total de) " + alumnos.Length);
                asignaturaCod = int.Parse(Console.ReadLine()) - 1;
            } while (asignaturaCod + 1 > alumnos.Length || asignaturaCod < 0);

            return asignaturaCod;
        }
        private void VisualizarNotasDeAlumno()
        {
            int alumnoCod = InsertaAlumno();
            string space = String.Format("{0,9}", "");
            //do
            //{
            //    Console.WriteLine("Introduzaca el codigo del alumno a visualizar (disponemos de un total de) " + alumnos.Length);
            //    alumnoCod = int.Parse(Console.ReadLine()) - 1;
            //} while (alumnoCod + 1 > alumnos.Length || alumnoCod < 0);

           // Console.Write("\t");
            Console.Write(space);

            for (int i = 0; i < asignaturas.Length; i++)
            {
                // Console.Write(asignaturas[i] + "\t");
                Console.Write(asignaturas[i] + space);
            }
            Console.WriteLine();

            //Console.Write(alumnos[alumnoCod] + "\t");
            Console.Write(alumnos[alumnoCod] + space);

            for (int i = 0; i < aula.notas.GetLength(1); i++)
            {
               // Console.Write(aula.notas[alumnoCod, i] + "\t\t");
                Console.Write(aula.notas[alumnoCod, i] + space+space);
            }

            Console.WriteLine();
        }
        private void VisualizarNotasDeUnaAsignatura()
        {
            int asignaturaCod = InsertaAsignatura();
            string space = String.Format("{0,9}", "");

            do
            {
                Console.WriteLine("Introduzaca el codigo de la asignatura a visualizar (disponemos de un total de )" + asignaturas.Length);
                asignaturaCod = int.Parse(Console.ReadLine()) - 1;
            } while (asignaturaCod + 1 > asignaturas.Length || asignaturaCod < 0);

            //  Console.Write("\t");
            Console.Write(space);
           // Console.WriteLine(asignaturas[asignaturaCod] + "\t");
            Console.WriteLine(asignaturas[asignaturaCod] + space);

            for (int i = 0; i < aula.notas.GetLength(0); i++)
            {
                //Console.Write(alumnos[i] + "\t");
                Console.Write(alumnos[i] + space);
                Console.Write(aula.notas[i, asignaturaCod] + space + space);
                // Console.Write(aula.notas[i, asignaturaCod] + "\t\t");
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        private void VisualizarAprobados(Hashtable hashtable)
        {
            foreach (DictionaryEntry item in hashtable)
            {
                Console.Write("Nombre: " + item.Key + "\nNotas: ");
                for (int i = 0; i < ((int[])item.Value).Length; i++)
                {
                    Console.Write(((int[])item.Value)[i]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
