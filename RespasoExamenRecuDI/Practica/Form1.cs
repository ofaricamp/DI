using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelTextBox2.TextText = Convert.ToString(labelTextBox2.TextLbl);
        }
        private void separbtn_Click_1(object sender, EventArgs e)
        {
            labelTextBox2.Separacion++;
        }

        private void labelTextBox2_CambiaPosicion(object sender, EventArgs e)
        {
            this.Text = labelTextBox2.Posicion.ToString();
        }

        private void posbtn_Click(object sender, EventArgs e)
        {
            if (labelTextBox2.Posicion == RespasoExamenRecuDI.ePosicion.DERECHA)
            {
                labelTextBox2.Posicion = RespasoExamenRecuDI.ePosicion.IZQUIERDA;
            }
            else
            {
                labelTextBox2.Posicion = RespasoExamenRecuDI.ePosicion.DERECHA;
            }
        }

        private void labelTextBox2_CambiaSeparacion(object sender, EventArgs e)
        {
            this.Text = labelTextBox2.Separacion.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseas Salir?","Seguro?",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) ==DialogResult.Cancel )
            {
                e.Cancel = true;
            }
        }

        private void labelTextBox2_KeyUp(object sender, KeyEventArgs e)
        {
            this.Text = e.KeyCode.ToString();
        }
    }
}
