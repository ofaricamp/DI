using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Carta[] cartas;
        Image[] imagenes;
        int cartaJugador = 0;
        int cartaRival = 0;
        int x = 0;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            cartas = new Carta[] { carta1, carta2, carta3 };
            imagenes = new Image[] { carta1.Imagen, carta2.Imagen, carta3.Imagen };
            radioButton1.Tag = 0;
            radioButton2.Tag = 1;
            radioButton3.Tag = 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cartaJugador = (int)((RadioButton)sender).Tag;
        }

        private void playbtn_Click(object sender, EventArgs e)
        {
            Carta elegida = cartas[cartaJugador];
            cartaRival = random.Next(3);
            carta4.Imagen = imagenes[cartaRival];
            carta4.Nivel = elegida.Nivel - 1 + random.Next(3);
            carta4.Valor = 0;

            resultlbl.Text = "IT´S A DRAW!!!!!!";

            if (Ganar(cartaJugador, cartaRival))
            {
                if (elegida.Nivel >= carta4.Nivel)
                {
                    resultlbl.Text = "YOU WIN!!!!!!";
                }
            }
            else
            {
                if (Ganar(cartaRival, cartaJugador))
                {
                    if (elegida.Nivel <= carta4.Nivel)
                    {
                        resultlbl.Text = "YOU LOSE!!!!!!";
                    }
                }
            }

            elegida.Valor += random.Next(10, 21);
            panel1.Controls.Add(new Carta(elegida.Imagen,elegida.Nivel, elegida.Valor,x,0,40,70));
            panel1.Controls.Add(new Carta(carta4.Imagen, carta4.Nivel, carta4.Valor, x, 90, 40, 70));

            if (x >= panel1.Width - 50)
            {
                panel1.Controls.Clear();
                x = 0;
            }
            else
            {
                x += 50;
            }
        
        }

        public bool Ganar(int cartaDelJugador, int cartaEnemiga)
        {
            return cartaDelJugador == 0 && cartaEnemiga == 2 ||
                cartaDelJugador == 1 && cartaEnemiga == 0 ||
                cartaDelJugador == 2 && cartaRival == 1;
        }

        private void carta1_AlcanzaMax(object sender, EventArgs e)
        {
            Carta carta = (Carta)sender;
            carta.Valor = 0;
            carta.Nivel++;
        }
    }
}
