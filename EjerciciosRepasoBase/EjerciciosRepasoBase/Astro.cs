using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepasoBase
{
    class Astro
    {
        private string nombre;
        private int radio;
        public Astro() { }
        public Astro(string nombre, int radio)
        {
            Nombre = nombre;  //mayúscula
            Radio = radio;
        }

        public string Nombre
        {
            set
            {
                //nombre = value.ToUpper().TrimStart(' ').TrimEnd(' ');
                nombre = value.ToUpper().Trim();
            }
            get { return nombre; }
        }
        public int Radio
        {
            set
            {
                if (value >= 0)
                {
                    radio = value;
                }
                else
                {
                    throw new RadioNegativoException("El radio debe ser positivo");
                }
            }
            get
            {
                return radio;
            }
        }

        //public string getNombre(char caracter, string hola)
        //{
        //    string prueba = "";
        //    char[] contenidoHola = hola.ToCharArray();
        //    for (int i = 0; i < contenidoHola.Length; i++)
        //    {
        //        if ((i / 2 != 0) || i == 1)
        //        {
        //            prueba += caracter;
        //        }
        //        prueba += contenidoHola[i].ToString();

        //    }
        //    return prueba;
        //}

        public string getNombre(string caracter)
        {
            char[] nombreArray = Nombre.ToCharArray();
            string nombreSeparado = nombreArray[0].ToString();

            for (int i = 1; i <= nombreArray.Length - 1; i++)
            {
                nombreSeparado += caracter + nombreArray[i];
            }

            return nombreSeparado;
        }
        public override bool Equals(object obj)  //misma clase (y que no sea null)
        {
            Astro astro = (Astro)obj;
            return Nombre.Equals(astro.nombre);
            //return base.Equals(obj);
        }

        public override string ToString()
        {
            return $"{getNombre("_")} tiene un radio de {Radio:F2}";
        }

    }
}
