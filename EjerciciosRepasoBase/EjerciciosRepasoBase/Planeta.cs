using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepasoBase
{
    class Planeta : Astro
    {
        public Astro[] satelites = { };
        private bool gaseoso;
        public Planeta()
        {
            new Planeta("",0,false);
        }

        public Planeta(string nombre, int radio, bool gaseoso)
        {
            this.Nombre = nombre;
            this.Radio = radio;
            this.gaseoso = gaseoso;
            this.satelites = new Astro[] { };
        }
        public bool Gaseoso
        {
            set 
            {
                gaseoso = value;
            }
            get 
            {
                return gaseoso;
            }
        }
    }
}
