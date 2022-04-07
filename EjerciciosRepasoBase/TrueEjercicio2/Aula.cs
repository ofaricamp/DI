using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueEjercicio2
{
    class Aula
    {
        public int[,] notas;
        public string[] alumno;
        public string[] asignatura;
        Random valorNotas = new Random();

        public Aula(string[] alumnos, string[] asignaturas)
        {
            notas = new int[alumnos.Length, asignaturas.Length];
            this.alumno = new string[alumnos.Length];
            this.asignatura = new string[asignaturas.Length];

            for (int i = 0; i < this.alumno.Length; i++)
            {
                this.alumno[i] = "Alumno " + (i + 1);
            }

            for (int i = 0; i < this.asignatura.Length; i++)
            {
                this.asignatura[i] = "Asignatura " + (i + 1);
            }

            for (int i = 0; i < notas.GetLength(0); i++)
            {
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    notas[i, j] = valorNotas.Next(1, 10);
                }
            }
        }

        public double MediaGeneralTabla()
        {
            double notasAux = 0;
            for (int i = 0; i < notas.GetLength(0); i++)
            {
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    notasAux += notas[i, j];
                }
                Console.WriteLine("NotasAux value: " + notasAux);
            }
            Console.WriteLine("Supuesto resultado de " + notasAux + "/ " + notas.GetLength(0) + " " + notas.GetLength(1) +
                                " Result: " + notasAux / (notas.GetLength(0) * notas.GetLength(1)));
            return notasAux / (notas.GetLength(0) * notas.GetLength(1));
        }

        public double MediaAlumnos(string nombreAlumno)
        {
            double notasAux = 0;
            for (int i = 0; i < notas.GetLength(0); i++)
            {
                if (alumno[i] == nombreAlumno)
                {
                    for (int j = 0; j < notas.GetLength(1); j++)
                    {
                        notasAux += notas[i, j];
                    }
                }
            }
            return notasAux / notas.GetLength(1);
        }

        public double MediaAsignatura(string nombreAsignatura)
        {
            double notasAux = 0;
            for (int i = 0; i < notas.GetLength(0); i++)
            {

                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    if (asignatura[j] == nombreAsignatura)
                    {
                        notasAux += notas[i, j];
                    }
                }
            }
            Console.WriteLine(notasAux + "/" + notas.GetLength(0));
            return notasAux / notas.GetLength(0);
        }

        public int[,] NotasAlumno(string nombreAlumno)
        {
            int[,] notasDeAlumno = new int[1,1];
            for (int i = 0; i < notas.GetLength(0); i++)
            {
                if (alumno[i] == nombreAlumno)
                {
                    for (int j = 0; j < notas.GetLength(1); j++)
                    {
                        notasDeAlumno[i, 0] = notas[i, j];
                        //Console.Write(notasDeAlumno[i,0]+"\t");
                    }
                }
            }
            return notasDeAlumno;
        }

        public void VisualizarNotasAsignatura()
        {

        }
    }
}
