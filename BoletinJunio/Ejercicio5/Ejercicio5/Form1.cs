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

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        ToolTip toolTip = new ToolTip();
        string titulo;
        int cont = 0;
        double ms = 0;
        Icon icon;
        
        char[] charslengt;
        
        public Form1()
        {
            InitializeComponent();

            titulo = Text;
            charslengt = Text.ToCharArray();
            Text = "";

            toolTip.SetToolTip(list1, "ListBox de multiselección simple");
            toolTip.SetToolTip(addbtn, "Boton que añade el contenido de la TextBox a la lista 1");
            toolTip.SetToolTip(contenidotxt,"TextBox donde se escribe lo que se desea añadir a la lista 1");
            toolTip.SetToolTip(quitarbtn, "Boton que elimina el/los elemento/s seleccionado/s de la lista 1");
            toolTip.SetToolTip(traspas1To2btn, "Boton que pasa el/los elemento/s selecionado/s de la lista 1 a la lista 2");
            toolTip.SetToolTip(traspas2To1btn,"Boton que pasa el elemnto seleccionado de la lista 2 a la lista 1");
            toolTip.SetToolTip(list2, "La lista 2 dispone de un total de "+list2.Items.Count+" elementos");
           // label1.Text = Directory.GetCurrentDirectory();
          //  Icon = new Icon(Directory.GetCurrentDirectory() + "\\GreyKu.ico");
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(contenidotxt.Text))
            {
                list1.Items.Add(contenidotxt.Text);
                contenidotxt.Clear();
            }
            list1Contentlbl.Text = "Cantidad de la lista 1: " + (list1.Items.Count);
        }

        private void quitarbtn_Click(object sender, EventArgs e)
        {
            if (list1.Items.Count > 0)
            {
                for (int i = list1.SelectedItems.Count - 1; i >= 0; i--)
                {
                    list1.Items.Remove(list1.SelectedItems[i]);
                }
            }
            list1Contentlbl.Text = "Cantidad de la lista 1: " + (list1.Items.Count);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (list1.SelectedItems != null)
            {
                for (int i = 0; i < list1.SelectedItems.Count; i++)
                {
                    list2.Items.Insert(i, list1.SelectedItems[i]);
                }

                for (int j = list1.SelectedItems.Count - 1; j >= 0; j--)
                {
                    list1.Items.Remove(list1.SelectedItems[j]);
                }
            }
            list1Contentlbl.Text = "Cantidad de la lista 1: " + (list1.Items.Count);
            toolTip.SetToolTip(list2, "La lista 2 dispone de un total de " + list2.Items.Count + " elementos");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (list2.SelectedItem != null)
            {
                list1.Items.Add(list2.SelectedItem);
                list2.Items.Remove(list2.SelectedItem);
            }
            list1Contentlbl.Text = "Cantidad de la lista 1: " + (list1.Items.Count);
            toolTip.SetToolTip(list2, "La lista 2 dispone de un total de " + list2.Items.Count + " elementos");
        }

        private void list1_SelectedIndexChanged(object sender, EventArgs e)
        {
            list1Selectedlbl.Text = "Indices Seleccionados : ";
            if (list1.SelectedIndices.Count > 0)
            {
                foreach (int index in list1.SelectedIndices)
                {
                    list1Selectedlbl.Text += $"{index}, ";
                }
            }
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Cerrar la aplicacion? Una vez cerrada no tendras otra oportunidad","Ejercicio 5"
                ,MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cont >= titulo.Length)
            {
                cont = 0;
                Text = "";
            }
            Text += charslengt[(charslengt.Length-1) - cont];
            cont++;
            if (cont%2 == 0)
            {
                icon = new Icon(Directory.GetCurrentDirectory() + "\\iconito.ico");
            }
            else
            {
                icon = new Icon(Directory.GetCurrentDirectory() + "\\GreyKu.ico");
            }
        }
    }
}
