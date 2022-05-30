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
    public partial class Form1 : Form
    {
        List<Friki> frikis = new List<Friki>();
        private int cont;
        private string tituloaux;
        private Friki friki = new Friki();
        private string rutaFotos = Directory.GetCurrentDirectory();

        public Form1()
        {
            InitializeComponent();
            friki = new Friki("DonCangrejo", 54, rutaFotos + "\\as.png", eAficion.SciFi, eSexo.Hombre, eSexoOpuesto.Mujer);
            frikis.Add(friki);
            listBox1.Items.Add(friki);
            friki = new Friki("Wingman", 57, rutaFotos + "\\Toon.png", eAficion.SciFi, eSexo.Mujer, eSexoOpuesto.Hombre);
            frikis.Add(friki);
            listBox1.Items.Add(friki);
            friki = new Friki("DOYON", 2, rutaFotos + "\\doyon.jpg", eAficion.Tecnologia, eSexo.Hombre, eSexoOpuesto.Hombre);
            frikis.Add(friki);
            listBox1.Items.Add(friki);
            friki = new Friki("PIKARI", 99, rutaFotos + "\\pikari.jpg", eAficion.Tecnologia, eSexo.Hombre, eSexoOpuesto.Hombre);
            frikis.Add(friki);
            listBox1.Items.Add(friki);
            friki = new Friki("JillSandwitch", 42, rutaFotos + "\\jill.jpg", eAficion.SciFi, eSexo.Hombre, eSexoOpuesto.Mujer);
            frikis.Add(friki);
            listBox1.Items.Add(friki);
            friki = new Friki("Españadite", 27, rutaFotos + "\\dragonite.jpg", eAficion.Manga, eSexo.Mujer, eSexoOpuesto.Mujer);
            frikis.Add(friki);
            listBox1.Items.Add(friki);
            friki = new Friki("AI", 30, rutaFotos + "\\doyon.jpg", eAficion.Manga, eSexo.Mujer, eSexoOpuesto.Mujer);
            frikis.Add(friki);
            listBox1.Items.Add(friki);
            frikis.Add(new Friki("Ligthning", 99, rutaFotos + "\\pikari.jpg", eAficion.Tecnologia, eSexo.Hombre, eSexoOpuesto.Hombre));
            listBox1.Items.Add(friki);
            
            tituloaux = this.Text;
            cont = this.Text.Length -1;
        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            Entrada entrada = new Entrada();

            if (entrada.ShowDialog() == DialogResult.OK)
            {
                if (entrada.radioButton1.Checked)
                {
                    friki.sexo = eSexo.Hombre;
                }
                else
                {
                    friki.sexo = eSexo.Mujer;
                }

                if (entrada.radioButton3.Checked)
                {
                    friki.sexoOpuesto = eSexoOpuesto.Hombre;
                }
                else
                {
                    friki.sexoOpuesto = eSexoOpuesto.Mujer;
                }

                friki = new Friki(entrada.validatetextbox1.TexTxt, int.Parse(entrada.validatetextbox2.TexTxt), entrada.path, (eAficion)entrada.aficionCombox.SelectedItem, friki.sexo, friki.sexoOpuesto);
                frikis.Add(friki);
                listBox1.Items.Add(friki);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Friki frikiaux = new Friki();
            int x = 0;
            int y = 0;

            if (listBox1.SelectedIndices != null && listBox1.SelectedIndices.Count > 0)
            {
                listBox2.Items.Clear();
                pictureBox1.Image = Image.FromFile(frikis[listBox1.SelectedIndex].Foto);

                frikiaux = frikis[listBox1.SelectedIndex];
                label1.Text = frikiaux.ToString();
                PictureBox imagen;
                panel1.Controls.Clear();
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (frikiaux.aficion == frikis[i].aficion)
                    {
                        if (frikiaux.sexo.ToString() == frikis[i].sexoOpuesto.ToString() && frikiaux.sexoOpuesto.ToString() == frikis[i].sexo.ToString())
                        {
                            if (frikiaux != frikis[i])
                            {
                                listBox2.Items.Add(frikis[i]);

                                imagen = new PictureBox();
                                imagen.Name = "fotografia";
                                imagen.Size = new Size(80, 80);
                                imagen.Location = new Point(x,y);
                                imagen.SizeMode = PictureBoxSizeMode.StretchImage;
                                imagen.Image = Image.FromFile(frikis[i].Foto);
                                panel1.Controls.Add(imagen);

                                if (x >= 160)
                                {
                                    x = 0;
                                    y = 90;
                                }
                                else
                                {
                                    x += 80;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            while (listBox1.SelectedIndex != -1)
            {
                frikis.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (cont >= tituloaux.Length)
            {
                cont = 0;
                Text = "";
            }

            this.Text += tituloaux[cont];
            cont++;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Salimos?", "Frikilove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nombre de la app: Frikilove\n Creador: Óscar Fariña Campelo\nAgradecimientos especiales:\nAlvaro Rodriguez Vila\nCurro Bellas","Aceca De",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
