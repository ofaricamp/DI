using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepasoBase
{

    //public class RadioNegativoException : Exception
    //{
    //    public RadioNegativoException(string mensaje) : base("Problema:" + mensaje)
    //    {
    //    }
    //}
    class Astro
    {
        private string nombre;
        private int radio;
        //public Astro(string nombre, int radio)
        //{
        //    this.nombre = nombre;
        //    this.radio = radio;
        //}

        public string Nombre
        {
            set 
            {
             //   nombre = value.ToUpper().TrimStart(' ').TrimEnd(' ');
                nombre = value.ToUpper();
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

        public string getNombre(char caracter, string hola) 
        {
            string prueba = "";
            char[] contenidoHola = hola.ToCharArray();
            //char [] contenido = Nombre.ToCharArray();

            //for (int i = 0; i < contenido.Length; i++)
            //{
            //    if ((i / 2 != 0) || i == 1)
            //    {
            //        Nombre += caracter;
            //    }
            //    Nombre += contenido[i].ToString();

            //}

            for (int i = 0; i < contenidoHola.Length; i++)
            {
                if ((i / 2 != 0) || i == 1)
                {
                    prueba += caracter;
                }
                prueba += contenidoHola[i].ToString();

            }
            return prueba;
        }
        public string getNombre(char caracter)
        {
            char[] contenido = this.nombre.ToCharArray();
            this.nombre = "";
            for (int i = 0; i < contenido.Length; i++)
            {
                if ((i / 2 != 0) || i == 1)
                {
                    this.nombre += caracter;
                }
                this.nombre += contenido[i].ToString();

            }

            return Nombre;
        }
        public override bool Equals(object obj)
        {
            Astro astro = (Astro)obj;
            return this.nombre.Equals(astro.nombre);
            //return base.Equals(obj);
        }

        public override string ToString()
        {
            return $"{getNombre('_')} tiene un radio de {this.radio:F2}";
        }

    }
}
