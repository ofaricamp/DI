using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepasoBase
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //}
        static void Main(string[] args)
        {
            Astro hola = new Astro();
            string opcion = "";
            Console.WriteLine(hola.getNombre('_',"hola"));
            hola.Nombre = "Luna";
            hola.Radio = -10;
            Console.WriteLine(hola.getNombre('_'));
            Console.WriteLine(hola.Nombre+" "+hola.Radio);
            Console.ReadKey();

            Console.WriteLine("Que quieres hacer");
            opcion = Console.ReadLine();
            switch (opcion)
            {
                case "añadir planeta":
                    break;
                case "añadir astro":
                    break;
                case "muestra datos":
                    break;
                case "elemina repetidos":
                    break;
                case "Salir":
                    break;
                default:
                    break;
            }

        }
    }
}
