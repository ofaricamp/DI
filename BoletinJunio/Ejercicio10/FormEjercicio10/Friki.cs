using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormEjercicio10
{
    public enum eAficion
    {
        Manga,
        SciFi,
        RPG,
        Fantasia,
        Terror,
        Tecnologia
    }

    public enum eSexo
    {
        Hombre,
        Mujer,
        Otro
    }

    public enum eSexoOpuesto
    {
        Hombre,
        Mujer
    }

    class Friki
    {
        public string nombre;
        public int edad;
        public string foto;
        public eAficion aficion;
        public eSexo sexo;
        public eSexoOpuesto sexoOpuesto;
       

        public Friki()
        {

        }

        public Friki(string nombre,int edad, string foto, eAficion aficion, eSexo sexo, eSexoOpuesto sexoOpuesto)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.foto = foto;
            this.aficion = aficion;
            this.sexo = sexo;
            this.sexoOpuesto = sexoOpuesto;
        }

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public int Edad
        {
            set { edad = value; }
            get { return edad; }
        }

        public string Foto
        {
            set { foto = value; }
            get{ return foto; }
        }

    }
}
