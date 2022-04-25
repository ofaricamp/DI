using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (contenidotxt.Text != "")
            {
                list1.Items.Add(contenidotxt.Text);
                contenidotxt.Clear();
            }
           // label1.Text = list1.SelectedItems.Count.ToString();
        }

        private void quitarbtn_Click(object sender, EventArgs e)
        {
            for (int i = list1.SelectedItems.Count-1; i >= 0 ; i--)
            {
              //  label1.Text = "hola";
                list1.Items.Remove(list1.SelectedItems[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = list1.SelectedItems.Count-1; i >= 0; i--)
            {
                list2.Items.Add(list1.SelectedItems[i]);
                list1.Items.Remove(list1.SelectedItems[i]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            list1.Items.Add(list2.SelectedItem);
            list2.Items.Remove(list2.SelectedItem);
        }
    }
}
