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

namespace Ejercicio10
{
    public partial class Entrada : Form
    {
        public string path = "";
        private string rutaFotos = Directory.GetCurrentDirectory();
        public Entrada()
        {
            InitializeComponent();
            aficionCombox.DataSource = Enum.GetValues(typeof(eAficion));
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void imagenbtn_Click(object sender, EventArgs e)
        {
            errorlbl.Text = "";
            try
            {
                using (OpenFileDialog op = new OpenFileDialog())
                {
                    op.Filter = "Imagenes|*.jpeg; *.png; *.jpg";
                    op.ShowDialog();
                    path = op.FileName;

                    pictureBox1.Image = Image.FromFile(rutaFotos + "\\default.jpg");

                    pictureBox1.Image = Image.FromFile(op.FileName);
                }
            }
            catch (Exception ex) when ((ex is OutOfMemoryException) || (ex is ArgumentException))
            {
                path = rutaFotos + "\\default.jpg";
                errorlbl.Text = ex.Message;
            }

        }

        private void aceptarbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(path))
            {
                path = rutaFotos + "\\default.jpg";
            }
        }

        private void Entrada_Load(object sender, EventArgs e)
        {

        }
    }
}
