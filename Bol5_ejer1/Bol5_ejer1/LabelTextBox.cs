#define RECOLORCAR
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bol5_ejer1
{
    public enum ePosicion
    {
        IZQUIERDA, DERECHA
    }

    public partial class LabelTextBox : UserControl
    {
        public LabelTextBox()
        {
            InitializeComponent();
            TextLbl = Name;
            TextTxt = "";
            recolocar();
        }
        private ePosicion posicion = ePosicion.IZQUIERDA;

        [Category("Appearance")]
        [Description("Indica si el Label se situa a la IZQUIERDA o a la DERECHA")]

        public ePosicion Posicion
        {
            set
            {
                if (Enum.IsDefined(typeof(ePosicion), value))
                {
                    posicion = value;
                    recolocar();
                    if (CambiaPosicion != null)
                    {
                        CambiaPosicion(this, new EventArgs());
                    }
                }
                else
                {
                    throw new InvalidEnumArgumentException();
                }
            }
            get
            {
                return posicion;
            }
        }

        void recolocar()
        {
            switch (posicion)
            {
                case ePosicion.IZQUIERDA:
                    lbl.Location = new Point(0, 0);
                    txt.Location = new Point(lbl.Width + Separacion, 0);
                    //txt.Width = this.Width - lbl.Width - Separacion;
                    this.Width = txt.Width + lbl.Width + Separacion;
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    break;
                case ePosicion.DERECHA:
                    txt.Location = new Point(0, 0);
                    //txt.Width = this.Width - lbl.Width - Separacion;
                    this.Width = txt.Width + lbl.Width + Separacion;
                    lbl.Location = new Point(txt.Width + Separacion, 0);
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    break;
                default:
                    break;
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            recolocar();
        }

        private int separacion = 0;

        [Category("Design")]
        [Description("Pixels de separacion entre Label y Textbox")]
        public int Separacion
        {
            set
            {
                if (value >= 0)
                {
                    separacion = value;
                    recolocar();
                    if (CambiaSeparacion != null)
                    {
                        CambiaSeparacion(this, new EventArgs());
                    }
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            get
            {
                return separacion;
            }
        }

        [Category("Appearance")]
        [Description("Texto asociado a la Labal del control")]
        public string TextLbl
        {
            set
            {
                lbl.Text = value;
                recolocar();
            }
            get
            {
                return lbl.Text;
            }
        }
        [Category("Appearance")]
        [Description("Texto asociado al TextBox del control")]
        public string TextTxt
        {
            set
            {
                txt.Text = value;
            }
            get
            {
                return txt.Text;
            }
        }

        [Category("Appearance")]
        [Description("Propiedad PasswordChar del textBox")]
        public char PswChr
        {
            set
            {
                txt.PasswordChar = value;
            }
            get
            {
                return txt.PasswordChar;
            }
        }

        private void txt_KeyUp(object sender, KeyEventArgs e)
        {
            this.OnKeyUp(e);
        }
        private void txt_TextChanged(object sender, EventArgs e)
        {
            if (TxtChanged != null)
            {
                TxtChanged(this, new EventArgs());
            }
        }

        [Category("La propiedad posicion cambió")]
        [Description("Se lanza cuando la propiedad Posicion cambia")]
        public event System.EventHandler CambiaPosicion;

        [Category("La propiedad separacion cambió")]
        [Description("Se lanza cuando la propiedad Separacion cambia")]
        public event System.EventHandler CambiaSeparacion;

        [Category("La propiedad TextChanged del textbox")]
        [Description("Se lanza cuando ocurre un TextChanged en el textbox")]
        public event System.EventHandler TxtChanged;

    }
}
