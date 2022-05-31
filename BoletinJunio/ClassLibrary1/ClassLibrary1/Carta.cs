using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    [DefaultEvent("AlcanzaMax")]
    public partial class Carta : UserControl
    {
        public Carta()
        {
            InitializeComponent();
           
            lbl.BackColor = Color.LightYellow;
        }

        public Carta(Image image, int nivel, int valor,int positionx,int positiony,int width,int height)
        {
            InitializeComponent();
            Imagen = image;
            Nivel = nivel;
            Valor = valor;
            this.Location = new Point(positionx, positiony);
            this.Size = new Size(width, height);
        }
        private void Carta_Load(object sender, EventArgs e)
        {

        }


        [Category("Examen")]
        [Description("La imagen de la carta")]
        public Image Imagen
        {
            set { pb.Image = value; }
            get { return pb.Image; }
        }

        private int nivel;
        [Category("Examen")]
        [Description("El nivel de la carta")]
        public int Nivel
        {
            set
            {
                nivel = value;
                lbl.Text = nivel.ToString();
            }
            get { return nivel; }
        }

        private int valor;
        [Category("Examen")]
        [Description("es el porcenja de la barra")]
        public int Valor
        {
            set
            {

                if (value > 100)
                {
                    if (AlcanzaMax != null)
                    {
                        AlcanzaMax.Invoke(this, new EventArgs());
                    }

                }else if (value < 0)
                {
                    valor = 0;
                }
                else
                {
                    valor = value;
                }

                Refresh();
            }
            get { return valor; }
        }

        [Category("Examen")]
        [Description("se lanza cuando se alcanza el valor maximo")]
        public event EventHandler AlcanzaMax;

        private void lbl_DoubleClick(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            pb.Location = new Point(0, 0);
            pb.Width = this.Width;
            pb.Height = this.Height - lbl.Height;
            pb.BackColor = Color.White;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            lbl.Location = new Point(0, pb.Height);

            base.OnPaint(e);
            Graphics g = e.Graphics;
            Color color = Color.Blue;

            if (Valor == 100)
            {
                color = Color.Green;
            }

            if (!Enabled)
            {
                color = Color.LightGray;
            }

            g.FillRectangle(new SolidBrush(color), lbl.Width, lbl.Top, ((Width - lbl.Width) * Valor / 100), lbl.Bottom);
        }
    }
}
