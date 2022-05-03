using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        private Button btn;
        private int xPosition = 0;
        private int yPosition = 30;
        Form2 f = new Form2();
        DialogResult res;
        public void ButtonCreator()
        {
            for (int i = 1; i <= 12; i++)
            {
                btn = new Button();
                btn.Text = i.ToString();
                btn.Location = new Point(xPosition, yPosition);
                btn.Size = new Size(50, 30);
                btn.Enabled = true;

                this.btn.Click += new System.EventHandler(this.btnClick);

                this.Controls.Add(btn);
                xPosition += 50;

                if (xPosition == 150)
                {
                    xPosition = 0;
                    yPosition += 40;
                }

                if (i == 10)
                {
                    btn.Text = ".";
                }
                if (i == 11)
                {
                    btn.Text = "0";
                }
                if (i == 12)
                {
                    btn.Text = "#";
                }
            }
            btn = new Button();
        }

        public void GuardarNumero()
        {

        }

        public void MostrarNumeros()
        {

        }

        void btnClick(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            this.Text =  button.Text;
        }

        public Form1()
        {
            InitializeComponent();
            res = f.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ButtonCreator();
        }
    }
}
