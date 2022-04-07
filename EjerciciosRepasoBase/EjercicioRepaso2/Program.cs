using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRepaso2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] asignaturas = {"Cosa","Rascar","Nariz","Fuerte" };
            string[] nombre = {"Rodrigo","Fernando","Garcilaso","Omil" };
            Aula aula = new Aula(asignaturas,nombre);
            Usuario us = new Usuario();

           // Console.WriteLine(us.muestraTabla());
            Console.WriteLine("Intento de media: "+aula.mediaGlobal(aula.notas));
            Console.ReadKey();

        }
    }
}
