using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepasoBase
{
    class Program
    {
        public static Planeta AddPlaneta()
        {
            Planeta planeta = new Planeta();
            Astro luna = new Astro();
            int gaseoso;
            int numeroDeLunas = 0;

            do
            {
                Console.WriteLine("Con que quieres añadir un planeta eh, pues cuentame");
                Console.WriteLine("Es o no es Gaseoso?\n1-Si\t2-No");
                gaseoso = int.Parse(Console.ReadLine());

                if (gaseoso == 1)
                {
                    planeta.Gaseoso = true;
                }
                else if (gaseoso == 2)
                {
                    planeta.Gaseoso = false;
                }
                else
                {
                    Console.WriteLine("1 o 2 no hay más");
                }

            } while (gaseoso != 1);

            Console.WriteLine("Como se llama el planeta?");
            planeta.Nombre = Console.ReadLine();
            Console.WriteLine("Cuanto es el radio del planeta?");
            planeta.Radio = int.Parse(Console.ReadLine());
            Console.WriteLine("De cuantas Lunas dispone tu planeta?");
            numeroDeLunas = int.Parse(Console.ReadLine());
            for (int i = 0; i <= numeroDeLunas; i++)
            {
                Console.WriteLine("Como se llama la luna?");
                luna.Nombre = Console.ReadLine();
                Console.WriteLine("Cuanto es el radio la luna?");
                luna.Radio = int.Parse(Console.ReadLine());
                planeta.satelites.Add(luna);
            }

            return planeta;
        }

        public static Astro AddAstro()
        {
            Astro astro = new Astro();
            bool correcto = true;

            do
            {
                try
                {
                    Console.WriteLine("Por favor escribe el Nombre del nuevo astro");
                    astro.Nombre = Console.ReadLine();
                    Console.WriteLine("Por favor escribe el Radio del nuevo astro");
                    astro.Radio = int.Parse(Console.ReadLine());
                }
                catch (RadioNegativoException re)
                {
                    Console.WriteLine(re.Message);
                    correcto = false;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Debe no ser nulo");
                    correcto = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("El formato indicado no es el correcto");
                    correcto = false;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("un poco grande de mas el Radio");
                    correcto = false;
                }
            } while (!correcto);

            return astro;
        }

        public static void MuestraDatos(List<Astro> astros)
        {
            foreach (Astro astrocitos in astros)
            {
                if (astrocitos is Planeta)
                {
                    Console.WriteLine("Nombre: " + astrocitos.getNombre('.') +
                        "\nRadio: " + astrocitos.Radio +
                        "\nGaseoso: " + ((Planeta)astrocitos).Gaseoso
                        + "\nCantidad De Lunas: " + ((Planeta)astrocitos).satelites.Count);
                }
                else
                {
                    Console.WriteLine(astrocitos.ToString());
                }
            }
        }

        static void Main(string[] args)
        {
            int opcion;
            Astro pruebAstro = new Astro();
            Planeta pruebaPlaneta = new Planeta();
            List<Astro> astros = new List<Astro>();
            astros.Add(new Astro("Aquatos", 10));
            astros.Add(new Astro("Taitum", 1000));
            astros.Add(new Astro("Taitum", 20));
            astros.Add(new Astro("Torrente", 5));
            astros.Add(new Astro("Tiraniland", 58));
            astros.Add(new Planeta("Planeta", 25, true));

            //Console.WriteLine(astro.getNombre('.', "hola"));
            //astro.Nombre = "Luna";
            //astro.Radio = 10;
            //Console.WriteLine(astro.getNombre('.'));
            //Console.WriteLine(astro.Nombre + " " + astro.Radio);
            // Console.ReadKey();
            try
            {
                do
                {
                    Console.WriteLine("\nElige una opción");
                    Console.WriteLine("1-Añadir Planeta");
                    Console.WriteLine("2-Añadir Astro");
                    Console.WriteLine("3-Muestra Datos");
                    Console.WriteLine("4-Elemina Repetidos");
                    Console.WriteLine("5-Salir");
                    opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            pruebaPlaneta = AddPlaneta();
                            astros.Add(AddPlaneta());
                            Console.WriteLine("Nombre: " + pruebaPlaneta.Nombre + "\nRadio: " + pruebaPlaneta.Radio +
                                "\n Nº Satelites: " + pruebaPlaneta.satelites.Count());
                            Console.WriteLine("Size: " + astros.Count);
                            break;
                        case 2:
                            pruebAstro = AddAstro();
                            astros.Add(AddAstro());
                            Console.WriteLine("Nombre: " + pruebAstro.Nombre + "\nRadio: " + pruebAstro.Radio);
                            Console.WriteLine("Size: " + astros.Count);
                            break;
                        case 3:
                            MuestraDatos(astros);
                            break;
                        case 4:
                            Console.WriteLine("Cantidad Original: " + astros.Count);
                            List<Astro> copia = astros;
                            foreach (Astro astr in astros)
                            {
                                // Console.WriteLine("Cantidad Sin repetir: " + copia.Count);
                                foreach (Astro ast in copia)
                                {
                                    if (!astr.Nombre.Equals(ast.Nombre))
                                    {
                                        if (!copia.Contains(astr))
                                        {
                                            copia.Add(astr);
                                        }
                                        Console.WriteLine("Nombre: " + astr.Nombre + "\n");
                                    }
                                }
                            }
                            Console.WriteLine("Copia: " + copia.Count + "\n");
                            Console.WriteLine("Astros: " + astros.Count + "\n");
                            break;
                        case 5:
                            Console.WriteLine("Lograste salir aparentemente");
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("Opción no encontrada");
                            break;
                    }
                } while (opcion != 5);
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Formato no válido");
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato no válido");
            }
        }
    }
}