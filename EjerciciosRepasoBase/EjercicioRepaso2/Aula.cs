using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRepaso2
{
    class Aula
    {
       // private int[][] notas;
        public int[,] notas;
        public string[] asignaturas;
        public string[] nombres;

        public void colocarMaxYMin(bool maxOrMin, ref int valor)
        {
            if (maxOrMin)
            {
                valor = 10;
            }
            else
            {
                valor = 0;
            }
        }

        public Aula(string[] asignaturas, string[] nombres)
        {
            this.notas = new int[nombres.Length, asignaturas.Length];
            Random valores = new Random();
            //Console.WriteLine("Rezar\n\n\n");
            //for (int i = 0; i < nombre.GetLength(0); i++)
            //{
            //    nombre[i, 0] = nombres[i];
            //    Console.WriteLine(nombre[i, 0]);
            //    for (int j = 0; j < nombre.GetLength(1); j++)
            //    {
            //        nombre[0, j] = asignaturas[j];
            //        nombre[i, j] = valores.Next(1, 11).ToString();
            //    }
            //    Console.WriteLine(nombre[i, 0]);
            //}
            //for (int i = 0; i <= nombre.GetUpperBound(0); i++)
            //{
            //    Console.Write(nombres[i]);
            //    Console.Write("{0,4}", nombre[i, 0]);
            //    for (int j = 0; j <= nombre.GetUpperBound(1); j++)
            //    {
            //        Console.Write("{0,10}", nombre[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            notas = new int[nombres.Length, asignaturas.Length];
            this.nombres = new string[nombres.Length];
            this.asignaturas = new string[asignaturas.Length];

            for (int i = 0; i < this.nombres.Length; i++) // Rellena array de nombres alumnos
            {
                this.nombres[i] = "Alumno " + (i + 1);
            }

            for (int i = 0; i < this.asignaturas.Length; i++) // Rellena array de nombres asignaturas
            {
                this.asignaturas[i] = "Asignatura " + (i + 1);
            }

            for (int i = 0; i < notas.GetLength(0); i++) // Rellena array de notas
            {
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    notas[i, j] = valores.Next(0, 11); // Notas entre 0 y 10
                }
            }

           
        }

        public double mediaGlobal(int[,] notazas)
        {
            double notasAux = 0;
            for (int i = 0; i < notazas.GetLength(0); i++)
            {
                for (int j = 0; j < notazas.GetLength(1); j++)
                {
                    notasAux += notazas[i, j];
                }
                Console.WriteLine("NotasAux value: " + notasAux);
            }
            Console.WriteLine("Supuesto resultado de " + notasAux + "/ " + notazas.GetLength(0) + " " + notazas.GetLength(1) +
                                " Result: " + notasAux / (notazas.GetLength(0) * notazas.GetLength(1)));
            return notasAux / (notazas.GetLength(0) * notazas.GetLength(1));
        }

        public double mediaAsignatura(string[,] asignaturazas, string nombreAsignatura)
        {
            double media = 0;

            for (int i = 0; i < asignaturazas.GetLength(0); i++)
            {
                if (asignaturazas[i, 0] == nombreAsignatura)
                {
                    for (int j = 0; j < asignaturazas.GetLength(1); j++)
                    {

                    }
                }
            }
            return 0;
        }

        public double mediaAlumnos(string[,] alumnazos, string nombreAlumno)
        {
            double media = 0;

            for (int i = 0; i < alumnazos.GetLength(0); i++)
            {
                for (int j = 0; j < alumnazos.GetLength(1); j++)
                {
                    if (alumnazos[i, j] == nombreAlumno)
                    {

                    }
                }
            }
            return 0;
        }

        public void devuelveFilas()
        {

        }
    }
}
