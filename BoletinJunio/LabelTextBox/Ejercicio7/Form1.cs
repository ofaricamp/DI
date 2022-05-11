using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio7
{
    public partial class Form1 : Form
    {
        private int cont;
        public Form1()
        {
            InitializeComponent();
            cont = 0;
        }

        private void separacionbtn_Click(object sender, EventArgs e)
        {
            labelTextBoxcs1.Separacion++;
        }

        private void cambiobtn_Click(object sender, EventArgs e)
        {
            if (labelTextBoxcs1.Posicion == LabelTextBox.LabelTextBoxcs.ePosicion.DERECHA)
            {
                labelTextBoxcs1.Posicion = LabelTextBox.LabelTextBoxcs.ePosicion.IZQUIERDA;
            }
            else
            {
                labelTextBoxcs1.Posicion = LabelTextBox.LabelTextBoxcs.ePosicion.DERECHA;
            }
        }

        private void labelTextBoxcs1_CambiaPosicion(object sender, EventArgs e)
        {
            Text = labelTextBoxcs1.Posicion.ToString();
        }

        private void labelTextBoxcs1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Text = "letra: " + e.KeyChar;
        }

        private void labelTextBoxcs3_KeyUp(object sender, KeyEventArgs e)
        {
            keyUplbl.Text = "Key up lanzado "+ e.KeyCode;
        }

        private void labelTextBoxcs4_TxtXhanged(object sender, EventArgs e)
        {
            cont++;
            textChangedlbl.Text = "Cambie "+cont+" veces";
        }
    }
}
