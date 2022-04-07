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
            Astro astroAux = new Astro();
            int gaseoso;
            int numeroDeLunas = 0;
            try
            {
                Console.WriteLine("Con que quieres añadir un planeta eh, pues cuentame");
                Console.WriteLine("Es o no es Gaseoso?\n1-Si\t2-No(aunque en caso de poner cualquier otro número se dirá que no es gaseoso)");
                gaseoso = int.Parse(Console.ReadLine());

                //if (gaseoso == 1)
                //{
                //    planeta.Gaseoso = true;
                //}
                //else
                //{
                //    planeta.Gaseoso = false;
                //}

                planeta.Gaseoso = gaseoso == 1 ;

                astroAux = AddAstro("del Planeta");
                if (astroAux != null)
                {
                    Console.WriteLine("De cuantas Lunas dispone tu planeta?");
                    numeroDeLunas = int.Parse(Console.ReadLine());
                    planeta.satelites = new List<Astro>();
                    for (int i = 1; i <= numeroDeLunas; i++)
                    {
                        astroAux = AddAstro("de la Luna");
                        if (astroAux != null)  //revisar
                        {
                            planeta.satelites.Add(astroAux);
                        }
                        else
                        {
                            return null;
                        }
                    }

                    return planeta;
                }
                else
                {
                    return null;
                }
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static Astro AddAstro(string contenido)
        {
            Astro astro = new Astro();

            try
            {
                Console.WriteLine($"Por favor escribe el Nombre {contenido}");
                astro.Nombre = Console.ReadLine();
                Console.WriteLine($"Por favor escribe el Radio {contenido}");
                astro.Radio = int.Parse(Console.ReadLine());
            }
            catch (RadioNegativoException re)
            {
                Console.WriteLine(re.Message);
                return null;
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            return astro;
        }

        public static void MuestraDatos(List<Astro> astros)
        {
            int cont = 0;
            foreach (Astro astrocitos in astros)
            {
                if (astrocitos is Planeta)
                {
                    Console.WriteLine("Nombre: " + astrocitos.getNombre(".") +
                        "\nRadio: " + astrocitos.Radio +
                        "\nGaseoso: " + ((Planeta)astrocitos).Gaseoso
                        + "\nCantidad De Lunas: " + ((Planeta)astrocitos).satelites.Count);
                    if (((Planeta)astrocitos).satelites.Count > 0)
                    {
                        Console.WriteLine("Y la informacio de la/s luna/s es:");
                        foreach (Astro luna in ((Planeta)astrocitos).satelites)
                        {
                            Console.WriteLine($"Luna {cont} Nombre: {luna.getNombre("_")} Radio: {luna.Radio}");
                            cont++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("No existen Lunas");
                    }
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
            List<Astro> astros = new List<Astro>();
            Astro astroAux = new Astro();
            astros.Add(new Astro("Aquatos", 10));
            astros.Add(new Astro("Taitum", 1000));
            astros.Add(new Astro("Taitum", 20));
            astros.Add(new Astro("Torrente", 5));
            astros.Add(new Astro("Tiraniland", 58));
            astros.Add(new Planeta("Planeta", 25, true));
            do
            {
                try
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
                            astroAux = AddPlaneta();
                            if (astroAux != null)  //revisar check
                            {
                                astros.Add(astroAux);
                            }
                            Console.WriteLine("Size: " + astros.Count);
                            break;
                        case 2:
                            astroAux = AddAstro("del Astro");
                            if (astroAux != null)  //revisar check
                            {
                                astros.Add(astroAux);
                            }
                            Console.WriteLine("Size: " + astros.Count);
                            break;
                        case 3:
                            MuestraDatos(astros);
                            break;
                        case 4:
                            Console.WriteLine("Cantidad Original: " + astros.Count);
                            List<Astro> copia = new List<Astro>();
                            foreach (Astro item in astros)
                            {
                                if (!copia.Contains(item))
                                {
                                    copia.Add(item);
                                }
                            }
                            astros.Clear();
                            astros = copia;
                            Console.WriteLine("Cantidad Nueva: " + copia.Count);
                            break;
                        case 5:
                            Console.WriteLine("Lograste salir aparentemente");
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("Opción no encontrada");
                            break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    opcion = 6;
                }
            } while (opcion != 5);
        }
    }
}