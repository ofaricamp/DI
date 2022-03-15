using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RespasoExamenRecuDI
{
    public enum ePosicion
    {
        IZQUIERDA,DERECHA
    }

    public partial class LabelTextBox : UserControl
    {
        public LabelTextBox()
        {
            InitializeComponent();
            TextLbl = "Funciono";
            TextText = "";
            recolocar();
        }

        private ePosicion posicion = ePosicion.IZQUIERDA;
        
        [Category("Appearence")]
        [Description("Indica si la Label se situa a la IZQUIERDA o a la DERECHA del TextBox")]
        public ePosicion Posicion
        {
            set 
            {
                if (Enum.IsDefined(typeof(ePosicion),value))
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
            get { return posicion; }
        }

        private int separacion = 0;
        [Category("Design")]
        [Description("Pixeles de separacion entre la Label y el Textbox")]
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
                    throw new ArgumentOutOfRangeException();
                }
            }
            get { return separacion; }
        }
        
        [Category("Appearence")]
        [Description("Texto asociado a la Label del control")]
        public string TextLbl
        {
            set 
            {
                lbl.Text = value;
                recolocar();
            }
            get { return lbl.Text; }
        }

        [Category("Appearence")]
        [Description("Texto asociado al TextBox del control")]
        public string TextText
        {
            set
            {
                txt.Text = value;
            }
            get { return txt.Text; }
        }

        [Category("Appearence")]
        [Description("Propiedad PaswordChar del TextBox")]
        public char Pswchar
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
        void recolocar() 
        {
            switch (posicion)
            {
                case ePosicion.IZQUIERDA:
                    lbl.Location = new Point(0, 0);
                    txt.Location = new Point(lbl.Width + Separacion, 0);
                    txt.Width = this.Width - lbl.Width - Separacion;
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

        public void LabelTextBox_SizeChanged(object sender, EventArgs e)
        {
            recolocar();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            recolocar();
        }
        private void txt_KeyUp(object sender, KeyEventArgs e)
        {
            this.OnKeyUp(e);
        }

        private void LabelTextBox_Load(object sender, EventArgs e)
        {

        }


        private void labelTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Text = "Letra: " + e.KeyChar;
        }
        private void txt_TextChanged(object sender, EventArgs e)
        {
            if (TxtChanged != null)
            {
                TxtChanged(this, new EventArgs());
            }
        }

        [Category("La propiedad cambió")]
        [Description("Se lanza cuando la propiedad Posicion cambia")]
        public event System.EventHandler CambiaPosicion;

        [Category("La propiedad cambio")]
        [Description("Se lanza cuando la propiedad separacion cambia")]
        public event System.EventHandler CambiaSeparacion;

        [Category("La propiedad TextChanged cambio")]
        [Description("Se lanza cuando ocurre un textChanged en el textbox")]
        public event System.EventHandler TxtChanged;

     
    }
}
