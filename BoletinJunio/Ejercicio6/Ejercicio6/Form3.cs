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
        private string originalContent;
        private Form1 form1 = new Form1();

        public Form3(string contenido)
        {
            InitializeComponent();
            textBox1.Text = contenido;
            originalContent = contenido;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!originalContent.Equals(textBox1.Text))
            {
                if (MessageBox.Show("Cambiaste el contenido desea Guardarlo?", "Cambio en el text", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                {

                }
                else
                {
                    Close();
                }
            }
        }
    }
}
