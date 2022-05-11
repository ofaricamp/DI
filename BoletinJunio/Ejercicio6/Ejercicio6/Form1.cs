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
    public partial class Form1 : Form
    {
        string ruta = Directory.GetCurrentDirectory()+"\\Numeros.txt";
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

        public void GuardarNumero()
        {

        }

        public void MostrarNumeros()
        {

        }

        void btnClick(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text +=  button.Text;
            button.BackColor = Color.BlanchedAlmond;
        }

        void btnMouseEnter(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;

            if (!(button.BackColor == Color.BlanchedAlmond))
            {
                button.BackColor = Color.Red;
            }
        }

        void btnMouseLeave(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;

            if (!(button.BackColor == Color.BlanchedAlmond))
            {
                button.BackColor = Color.Transparent;
            }
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

        private void grabarNúmeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Archivos de texto|*.txt| Todos los archivos |*.*";
            int number;
            bool isnumeric = false;

            isnumeric = int.TryParse(textBox1.Text, out number);
            if (!string.IsNullOrEmpty(textBox1.Text) && isnumeric)
            {
                fileDialog.OverwritePrompt = false;
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    ruta = fileDialog.FileName;
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(ruta,true))
                        {
                            sw.Write(textBox1.Text + Environment.NewLine);
                        }
                    }
                    catch (Exception ex) when (ex is FileNotFoundException || ex is DirectoryNotFoundException || ex is IOException)
                    {
                        Errorlbl.Text = ex.Message;
                    }
                }
            }
        }

        private string LectorDeArchivo(string ruta)
        {
            string contenido = "";
            try
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    contenido = sr.ReadToEnd();
                }
            }
            catch (Exception e) when (e is FileNotFoundException || e is DirectoryNotFoundException || e is IOException)
            {

                Errorlbl.Text = e.Message;
            }
            
            return contenido;
        }

        private void verNúmerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 formulario3 = new Form3(LectorDeArchivo(ruta),ruta);
            formulario3.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 formulario3 = new Form3(LectorDeArchivo(Directory.GetCurrentDirectory() + "\\Acerca_De.txt"), Directory.GetCurrentDirectory() + "\\Acerca_De.txt");
            formulario3.ShowDialog();
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    c.BackColor = Color.Transparent;
                }
            }
            textBox1.Text = "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Salir de la Aplicacion?","Cerrar app",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
