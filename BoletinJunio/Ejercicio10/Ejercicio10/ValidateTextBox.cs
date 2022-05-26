using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio10
{
    public enum eTipo
    {
        Numerico,
        Textual
    }

    public partial class ValidateTextBox : UserControl
    {
        private Pen pen;

        public ValidateTextBox()
        {
            InitializeComponent();
            pen = new Pen(Color.Red);
            txt.Location = new Point(10, 10);
            this.Height = txt.Height + 20;
            txt.Width = this.Width - 20;
            
        }

        private eTipo tipo = eTipo.Numerico;

        [Category("Ejercicio 10")]
        [Description("Determina el tipo de escritura en el TextBox")]
        public eTipo Tipo
        {
            set { tipo = value; }
            get { return tipo; }
        }

        public bool Comprobar()
        {
            if (!string.IsNullOrWhiteSpace(txt.Text))
            {
                if (tipo == eTipo.Textual)
                {
                    for (int i = 0; i < txt.Text.Length; i++)
                    {
                        if (!(char.IsLetter(txt.Text[i])))
                        {
                            return false;
                        }
                    }
                    return true;
                }
                else
                {
                    for (int i = 0; i < txt.Text.Length; i++)
                    {
                        if (!(char.IsDigit(txt.Text[i])))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }


        [Category("Ejercicio 10")]
        [Description("Acceso a la propiedad Text del TextBox")]
        public string TexTxt
        {
            set { txt.Text = value; }
            get { return txt.Text; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (Comprobar())
            {
                pen = new Pen(Color.Green);
            }
            else
            {
                pen = new Pen(Color.Red);
            }

            e.Graphics.DrawRectangle(pen, 5, 5, txt.Width + 10, txt.Height + 10);
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            if (CambiaTexto != null)
            {
                CambiaTexto(this, new EventArgs());
            }
            Comprobar();
            Refresh();
        }


        [Category("Ejercicio 10")]
        [Description("Accede al evento TextChange del TextBox")]
        public event EventHandler CambiaTexto;

        private void ValidateTextBox_SizeChanged(object sender, EventArgs e)
        {
            this.Height = txt.Height + 20;
        }
    }
}
