using System;
using System.Collections;
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
            this.alumno = alumnos;
            this.asignatura = new string[asignaturas.Length];
            this.asignatura = asignaturas;

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
            }
            Console.WriteLine(notasAux+"\\"+notas.Length);
            return notasAux / notas.Length;
        }

        public double MediaAlumnos(int AlumnoCod)
        {
            double notasAux = 0;


            for (int j = 0; j < notas.GetLength(1); j++)
            {
                notasAux += notas[AlumnoCod, j];
            }
            Console.WriteLine(notasAux + "\\" + notas.GetLength(1));
            return notasAux / notas.GetLength(1);
        }

        public double MediaAsignatura(int asinaturaCod)
        {
            double notasAux = 0;


            for (int i = 0; i < notas.GetLength(1); i++)
            {

                notasAux += notas[i, asinaturaCod];
            }
            Console.WriteLine(notasAux + "\\" + notas.GetLength(0));
            return notasAux / notas.GetLength(0);
        }

        public void NotaMaxMinAlumnos(int alumnoCod, ref int maximo, ref int minimo)
        {
            for (int i = 0; i < notas.GetLength(1); i++)
            {
                if (maximo <= notas[alumnoCod, i])
                {
                    maximo = notas[alumnoCod, i];
                }
                if (minimo >= notas[alumnoCod, i])
                {
                    minimo = notas[alumnoCod, i];
                }
            }
        }

        public Hashtable NotasAlumno(string nombreAlumno)
        {
            Hashtable alumnosAprobados = new Hashtable();
            int[] notasDeAlumno = new int[asignatura.Length];
            for (int i = 0; i < notas.GetLength(0); i++)
            {
                if (alumno[i] == nombreAlumno)
                {
                    for (int j = 0; j < notas.GetLength(1); j++)
                    {
                        notasDeAlumno[j] = notas[i, j];
                    }
                    alumnosAprobados.Add(alumno[i], notasDeAlumno);
                }
            }
            return alumnosAprobados;
        }

        public Hashtable Aprobados()
        {
            Hashtable aprobados = new Hashtable();
            int cont = 0;
            int[] notasAprobadas = new int[asignatura.Length];

            for (int i = 0; i < notas.GetLength(0); i++)
            {
                cont = 0;

                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    if (notas[i, j] >= 5)
                    {
                        notasAprobadas[j] = notas[i, j];
                        cont++;
                        if (cont == asignatura.Length)
                        {
                            aprobados.Add(alumno[i], notasAprobadas);
                        }
                    }
                }

                notasAprobadas = new int[asignatura.Length];
            }

            return aprobados;
        }

    }
}
