using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colores_e_Imagenes
{
    // informar del error de los colores con una label
    // Cuando el raton salga del formulario se restablece el titulo
    //KEYPREVIEW DATO DE SUBLIME IMPORTANCIA    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Close the aplication? You´ll lost all the progress not saved","Colores e Imagenes"
                ,MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void Colorbtn_Click(object sender, EventArgs e)
        {
            FormBAckgroundColor();
        }

        private void Imagebtn_Click(object sender, EventArgs e)
        {
            FormBackgroundImage();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            if (e.KeyCode == Keys.T)
            {
                this.Text = "Colores e Imagenes";
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Point actualPoint;

            if (sender == this)
            {
                Text = "X: " + e.X + " Y:" + e.Y;
            }
            else
            {
                actualPoint = ((Control)sender).Location;
                Text = "X: " +(e.X + actualPoint.X) + " Y: " + (e.Y + actualPoint.Y);
            }
        }

        private void buttonMouseEnter(object sender,EventArgs e)
        {
            ((Button)sender).BackColor = Color.BlueViolet;
        }

        private void buttonMouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Transparent;
        }
        private void FormBAckgroundColor()
        {
            label1.Text = "";
            try
            {
                BackgroundImage = null;
                BackColor = Color.FromArgb(255,int.Parse(Redtxt.Text),int.Parse(Greentxt.Text),int.Parse(Bluetxt.Text));
            }
            catch(Exception ex) when (ex is FormatException || ex is ArgumentException || ex is OverflowException)
            {
                label1.Text = ex.Message;
            }
            
        }
        private void FormBackgroundImage()
        {
            label1.Text = "";
            try
            {
               // BackColor = Color.Transparent;
                BackgroundImage =  Image.FromFile(Imagetxt.Text);
            }
            catch (Exception ex) when (ex is FormatException || ex is ArgumentException || ex is System.IO.FileNotFoundException)
            {
                label1.Text = "Un error ocurrio con el fichero insertado";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.Text = "Colores e Imagenes";
        }
    }
}
