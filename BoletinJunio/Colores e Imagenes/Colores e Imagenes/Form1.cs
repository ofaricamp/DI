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
            try
            {
                BackgroundImage = null;
                BackColor = Color.FromArgb(255,int.Parse(Redtxt.Text),int.Parse(Greentxt.Text),int.Parse(Bluetxt.Text));
            }
            catch (FormatException fe)
            {

            }
            catch (ArgumentException ae)
            {

            }
            catch(OverflowException oe)
            {

            }
        }
        private void FormBackgroundImage()
        {
            try
            {
                BackColor = Color.Transparent;
                BackgroundImage = Image.FromFile(Imagetxt.Text);
            }
            catch (FormatException ex)
            {
                label1.Text = "Error";
            }
            catch (ArgumentException e)
            {
                label1.Text = "Error";
            }
            catch(System.IO.FileNotFoundException fe)
            {
                label1.Text = "Error";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
