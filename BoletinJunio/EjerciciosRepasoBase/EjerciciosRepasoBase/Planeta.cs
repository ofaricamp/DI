using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepasoBase
{
    class Planeta : Astro
    {
        public List<Astro> satelites;
        private bool gaseoso;
        public Planeta() //lamar al otro
            :this("",0,false)
        {
             //new Planeta("", 0, false);
        }

        public Planeta(string nombre, int radio, bool gaseoso) //llamar a base check
            :base(nombre,radio)
        {
            //base.Nombre = nombre;
            //base.Radio = radio;
            Gaseoso = gaseoso;
            satelites = new List<Astro>();
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
