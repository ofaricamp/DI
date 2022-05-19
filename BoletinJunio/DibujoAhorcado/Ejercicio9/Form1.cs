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
        private string letrasUsadas;
        private char[] rayas;
      //  private DibujoAhorcado.DelegadoAhorcado dibujo;
        
        public void LeeArchivo()
        {
            string ruta = Directory.GetCurrentDirectory() + "\\palabraSecreta.txt";

            try
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
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
            Trieslbl.Text += 9-ahorcado.Errores;
            LeeArchivo();
            letras = palabra.ToCharArray();

            rayas = new char[palabra.Length];

            for (int i = 0; i < letras.Length; i++)
            {
                rayas[i] = '_';
                Stripeslbl.Text += " "+rayas[i];

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Intentbtn_Click(object sender, EventArgs e)
        {
            if (lettertxt.Text.Length == 1)
            {
                if (palabra.Contains(lettertxt.Text.ToUpper()))
                {
                    Errorlbl.Text = "SI";
                    for (int i = 0; i < letras.Length; i++)
                    {
                        Errorlbl.Text += $"Letra actual: {letras[i]}  letra comparar: {lettertxt.Text.ToUpper()}\n";
                        if (letras[i].ToString() == lettertxt.Text.ToUpper())
                        {
                            rayas[i] = letras[i];
                        }
                        Stripeslbl.Text += " " + rayas[i].ToString();
                    }
                }
                else
                {
                    Trieslbl.Text = $"Intentos: {8-ahorcado.Errores++}";
                    Errorlbl.Text = "NO";
                }
            }
            else
            {
                Errorlbl.Text = "Por favor escriba solo un caracter";
            }

            if (Stripeslbl.Text == palabra)
            {
                Resetbtn.Visible = true;
                Resultlb.Text = "GANASTE!!!!!!!";
            }
            
        }

        private void ahorcado_Ahorcado(object sender, EventArgs e)
        {
            Intentbtn.Enabled = false;
            lettertxt.Enabled = false;
            Resetbtn.Visible = true;
            Resultlb.Text = "PERDISTE!!!!!";

        }

        private void ahorcado_CambiaError(object sender, EventArgs e)
        {

        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
