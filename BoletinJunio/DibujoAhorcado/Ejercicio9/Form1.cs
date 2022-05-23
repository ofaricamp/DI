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
        private string[] palabras = new string[]{};
        private Random random = new Random();
        private char[] letras;
        private char[] rayas;

        public string[] LeeArchivo()
        {
            string[] palabritas = new string[] { };
            string ruta = Directory.GetCurrentDirectory() + "\\palabraSecreta.txt";

            try
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    palabritas = sr.ReadToEnd().Split(' ');
                }
                return palabritas;
            }
            catch (Exception e)
            {
                return null;
                Errorlbl.Text = $"Error: {e.Message}";
            }

        }

        public Form1()
        {
            InitializeComponent();
            Trieslbl.Text += 9 - ahorcado.Errores;
            palabras = LeeArchivo();

            if (!(palabra == null))
            {
                palabra = palabras[random.Next(palabras.Length - 1)];
                letras = palabra.ToCharArray();

                rayas = new char[palabra.Length];

                for (int i = 0; i < letras.Length; i++)
                {
                    rayas[i] = '_';
                    Stripeslbl.Text += " " + rayas[i];

                }
            }
            else
            {
                Errorlbl.Text = "No disponemos de palabras para jugar";
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
                    Stripeslbl.Text = "";
                    for (int i = 0; i < letras.Length; i++)
                    {
                        //  Errorlbl.Text += $"Letra actual: {letras[i]}  letra comparar: {lettertxt.Text.ToUpper()}\n";
                        if (letras[i].ToString() == lettertxt.Text.ToUpper())
                        {
                            rayas[i] = letras[i];
                        }
                        Stripeslbl.Text += " " + rayas[i].ToString();
                    }
                }
                else
                {
                    Trieslbl.Text = $"Intentos: {8 - ahorcado.Errores++}";
                    letrasUSadaslbl.Text += $"{lettertxt.Text.ToUpper()}, ";
                }
            }
            else
            {
                Errorlbl.Text = "Por favor escriba solo un caracter";
            }

            string letrasAdivinadas = new string(rayas);
            if (letrasAdivinadas.Equals(palabra))
            {
                Intentbtn.Enabled = false;
                lettertxt.Enabled = false;
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
            ahorcado.Errores = 1;
            letrasUSadaslbl.Text = "";
            Resultlb.Text = "";
            Trieslbl.Text = "Intentos: " + (9 - ahorcado.Errores);
            lettertxt.Enabled = true;
            Intentbtn.Enabled = true;
            Resetbtn.Visible = false;
            palabras = LeeArchivo();
            Stripeslbl.Text = "";
            if (!(palabra == null))
            {
                palabra = palabras[random.Next(palabras.Length - 1)];
                letras = palabra.ToCharArray();

                rayas = new char[palabra.Length];

                for (int i = 0; i < letras.Length; i++)
                {
                    rayas[i] = '_';
                    Stripeslbl.Text += " " + rayas[i];

                }
            }
            else
            {
                Errorlbl.Text = "No disponemos de palabras para jugar";
            }
           

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("El programa se cerrará", "Seguro que quieres salir?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }

        }
    }
}
