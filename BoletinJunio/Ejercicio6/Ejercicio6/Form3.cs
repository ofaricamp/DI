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
        private string ruta;
        private Form1 form1 = new Form1();

        public Form3(string contenido, string ruta)
        {
            InitializeComponent();
            textBox1.Text = contenido;
            Text = ruta;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBox1.Modified)
            {
                if (MessageBox.Show("Cambiaste el contenido desea Guardarlo?", "Cambio en el text", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    File.WriteAllText(Text, textBox1.Text);
                }
                else
                {
                    Close();
                }
            }
        }
    }
}
