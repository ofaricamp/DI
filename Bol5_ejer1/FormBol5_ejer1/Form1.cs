using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBol5_ejer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelTextBox1.TextTxt = Convert.ToString(labelTextBox1.PswChr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (labelTextBox1.Posicion == Bol5_ejer1.ePosicion.DERECHA)
            {
                labelTextBox1.Posicion = Bol5_ejer1.ePosicion.IZQUIERDA;
            }
            else
            {
                labelTextBox1.Posicion = Bol5_ejer1.ePosicion.DERECHA;
            }
        }

        private void labelTextBox1_CambiaPosicion(object sender, EventArgs e)
        {
            this.Text = labelTextBox1.Posicion.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelTextBox1.Separacion++;
        }

        private void labelTextBox1_CambiaSeparacion(object sender, EventArgs e)
        {
            this.Text = Convert.ToString(labelTextBox1.Separacion);
        }

        private void labelTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            this.Text = Convert.ToString(e.KeyCode);
        }

        private void labelTextBox1_TxtChanged(object sender, EventArgs e)
        {
            this.Text = "hola";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("¿Quieres salir?", "Debo irme",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
