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

namespace Ejercicio9
{
    public partial class Form1 : Form
    {
        private string palabra;
        private char[] letras;
        private string letra;
        private string rayas;
        private DibujoAhorcado.DelegadoAhorcado dibujo;
        
        public void LeeArchivo()
        {
            string ruta = Directory.GetCurrentDirectory() + "\\palabraSecreta.txt";
            //Trieslbl.Text = ruta;

            try
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    //Trieslbl.Text = ruta;
                    palabra = sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Errorlbl.Text = $"Error: {e.Message}";
            }

        }

        public Form1()
        {
            InitializeComponent();
            Trieslbl.Text += ahorcado.Errores;
            LeeArchivo();
            //Stripeslbl.Text = palabra;
            letras = palabra.ToCharArray();

            for (int i = 0; i < letras.Length; i++)
            {
                Stripeslbl.Text += " _";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void Intentbtn_Click(object sender, EventArgs e)
        {
            if (palabra.Contains(lettertxt.Text.ToUpper()))
            {
                Errorlbl.Text = "SI";
                rayas = Stripeslbl.Text.Trim(' ');
            }
            else
            {
                Trieslbl.Text = $"Intentos: {ahorcado.Errores++}";
            }
            Errorlbl.Text = "NO";
        }
    }
}
