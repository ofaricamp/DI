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
    public partial class Form2 : Form
    {
        private Button btn;
        private int xPosition = 0;
        private int yPosition = 30;
        bool presionado = false;
        int tries = 3;
        bool numerico = false;
        int pin;

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
                this.btn.MouseEnter += new System.EventHandler(this.btnMouseEnter);
                this.btn.MouseLeave += new System.EventHandler(this.btnMouseLeave);

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
        void btnClick(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
            button.BackColor = Color.BlanchedAlmond;
            presionado = true;
        }

        void btnMouseEnter(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.Red;
        }

        void btnMouseLeave(object sender, System.EventArgs e)
        {
            if (!presionado)
            {
                Button button = (Button)sender;
                button.BackColor = Color.Transparent;
            }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ButtonCreator();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numerico = int.TryParse(textBox1.Text, out pin);

            if (!string.IsNullOrEmpty(textBox1.Text) && numerico && textBox1.Text.Length == 4)
            {
                if (textBox1.Text.Equals("1905"))
                {
                    Close();
                }
                else
                {

                    tries--;

                    if (tries == 0)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        label1.Text = "Quedan " + tries + " intentos";
                    }
                }
            }

            presionado = false;

            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    c.BackColor = Color.Transparent;
                }
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            if (!string.IsNullOrEmpty(texto))
            {
                textBox1.Text = texto.Substring(0, texto.Length - 1);
            }
        }
    }
}
