using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio4DI
{
    public partial class Form1 : Form
    {
        public delegate double Operation(double a, double b);
        Hashtable operation = new Hashtable();
        public Operation alvaroElGrande;
        public Form1()
        {
            InitializeComponent();
            
            
            suma.Tag = "+";
            resta.Tag = "-";
            multiplicacion.Tag = "X";
            division.Tag = "/";
            
            operation.Add(suma.Text, (Operation)((a, b) => a + b));
            operation.Add(resta.Text, (Operation)((a, b) => a - b));
            operation.Add(multiplicacion.Text, (Operation)((a, b) => a * b));
            operation.Add(division.Text, (Operation)((a, b) => a / b));
            alvaroElGrande = (Operation)operation[suma.Text];
        }

        public void RadioButtonsClick(object sender, EventArgs e) 
        {
            signo.Text = (string)((RadioButton)sender).Tag;
            alvaroElGrande = (Operation)operation[((RadioButton)sender).Text];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            double numero1 = Convert.ToInt32(textBox1.Text);
            double numero2 = Convert.ToInt32(textBox2.Text);

            double resultado = alvaroElGrande(numero1, numero2);

            labelResult.Text = Convert.ToString(resultado);
        }
    }
}
