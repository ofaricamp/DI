using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6
{
    public partial class Form3 : Form
    {
        public void LectorDeArchivo(string ruta)
        {
            using (StreamReader sr = new StreamReader(ruta))
            {
                textBox1.Text = sr.ReadToEnd();
            }
        }

        public void Autor(string ruta)
        {
            using (StreamReader sr = new StreamReader(ruta))
            {
                textBox1.Text = sr.ReadToEnd();
            }
        }

        public Form3(string ruta,bool numerosOAutor)
        {
            InitializeComponent();
            LectorDeArchivo(ruta);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
