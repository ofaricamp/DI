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

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public delegate double calculo(double primerNumero, double segundoNumero);
        public calculo calcular;
        Hashtable hash = new Hashtable();

        int minutos = 0;
        int segundos = 0;

        public Form1()
        {
            InitializeComponent();
            plusrb.Tag = "+";
            minusrb.Tag = "-";
            multiplyrb.Tag = "X";
            divisionrb.Tag = "/";

            hash = new Hashtable();
            hash.Add(plusrb.Text, (calculo)((double primerNumero, double segundoNumero) => primerNumero + segundoNumero));
            hash.Add(minusrb.Text, (calculo)((double primerNumero, double segundoNumero) => primerNumero - segundoNumero));
            hash.Add(multiplyrb.Text, (calculo)((double primerNumero, double segundoNumero) => primerNumero * segundoNumero));
            hash.Add(divisionrb.Text, (calculo)((double primerNumero, double segundoNumero) => primerNumero / segundoNumero));


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void executebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(textBox2.Text) == 0 && signolbl.Text.Equals("/"))
                {
                    reslbl.Text = "Dividir entre 0 asi no vencerás!";
                }
                else
                {
                    double resultador = 0;
                    resultador = calcular(double.Parse(textBox1.Text),double.Parse(textBox2.Text));
                    reslbl.Text = String.Format("{0:F2}", resultador);
                }
            }
            catch (Exception ex) when (ex is FormatException || ex is ArgumentException || ex is OverflowException)
            {

                reslbl.Text = "Dato no valido";
            }
        }
        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            signolbl.Text = (string)((RadioButton)sender).Tag;
            calcular = (calculo)hash[((RadioButton)sender).Text];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           

            if (segundos == 59)
            {
                minutos += 1;
                segundos = 0;
            }
            else
            {
                segundos++;
            }

            this.Text = $"{minutos:00} Minutos: {segundos:00} Segundos";
        }
    }
}
