using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtiquetaAviso
{
    public enum eMarca
    {
        Nada,
        Cruz,
        Circulo,
        Imagen
    }

    public partial class etiquetaAviso : Control
    {
        private Image imagenMarca;
        private Color primerColor;
        private Color segundoColor;
        private bool gradiante;
        private Size espacioMarca;
        private eMarca marca = eMarca.Nada;

        [Category("Appearance")]
        [Description("Indica el tipo de marca que aparece junto al texto")]
        public eMarca Marca
        {
            set
            {
                marca = value;
                this.Refresh();
            }

            get
            {
                return marca;
            }
        }

        [Category("Appearance")]
        [Description("Indica si se pone imagen o no")]
        public Image ImagenMarca
        {
            set
            {
                imagenMarca = value;
                if (imagenMarca == null)
                {
                    marca = eMarca.Nada;
                }
                this.Refresh();
            }
            get
            {
                return imagenMarca;
            }
        }

        [Category("Appearance")]
        [Description("Pones el primer color para el degradado o no")]
        public Color PrimerColor
        {
            set
            {
                primerColor = value;
                this.Refresh();
            }
            get
            {
                return primerColor;
            }
        }

        [Category("Appearance")]
        [Description("Pones el segundo color para el degradado o no")]
        public Color SegundoColor
        {
            set
            {
                segundoColor = value;
                this.Refresh();
            }
            get
            {
                return segundoColor;
            }
        }

        [Category("Appearance")]
        [Description("Determina si el fondo se pondra gradiante o no")]
        public bool Gradiante
        {
            set
            {
                gradiante = value;
                this.Refresh();
            }
            get
            {
                return gradiante;
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            int grosor = 0;
            int offsetX = 0;
            int offsetY = 0;
            int h = this.Font.Height;

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            SolidBrush b = new SolidBrush(this.ForeColor);
            LinearGradientBrush linearBruh;
            if (gradiante)
            {
                linearBruh = new LinearGradientBrush(
                new Point(0, 0),
                new Point(this.Width, this.Height),
                primerColor,
                segundoColor);
            }
            else
            {
                linearBruh = new LinearGradientBrush(
                new Point(0, 0),
                new Point(this.Width, this.Height),
                Color.FromArgb(0, 0, 0, 0),
                Color.FromArgb(0, 0, 0, 0));

            }
            e.Graphics.FillRectangle(linearBruh, 0, 0, this.Width, this.Height);

            switch (Marca)
            {
                case eMarca.Circulo:
                    e.Graphics.FillRectangle(linearBruh, 0, 0, this.Width, this.Height);
                    grosor = 20;
                    g.DrawEllipse(new Pen(Color.Green, grosor), grosor, grosor,
                    h, h);
                    offsetX = h + grosor;
                    offsetY = grosor;
                    break;
                case eMarca.Cruz:
                    e.Graphics.FillRectangle(linearBruh, 0, 0, this.Width, this.Height);
                    grosor = 3;
                    Pen lapiz = new Pen(Color.Red, grosor);
                    g.DrawLine(lapiz, grosor, grosor, h, h);
                    g.DrawLine(lapiz, h, grosor, grosor, h);
                    offsetX = h + grosor;
                    offsetY = grosor / 2;
                    lapiz.Dispose();
                    break;
                case eMarca.Imagen:
                    if (ImagenMarca != null)
                    {
                        e.Graphics.FillRectangle(linearBruh, 0, 0, this.Width, this.Height);
                        grosor = 20;
                        g.DrawImage(imagenMarca, grosor, grosor, h, h);
                        offsetX = h + grosor;
                        offsetY = grosor;
                    }
                    break;
            }

            g.DrawString(this.Text, this.Font, b, offsetX + grosor, offsetY);
            Size tam = g.MeasureString(this.Text, this.Font).ToSize();
            this.Size = new Size(tam.Width + offsetX + grosor, tam.Height + offsetY * 2);
            espacioMarca =new Size((this.Size.Width - tam.Width), this.Size.Height);
            b.Dispose();
            linearBruh.Dispose();

        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (e.X < espacioMarca.Width && e.Y < espacioMarca.Height)
            {
                ClickEnMarca(this, new EventArgs());
            }
        }

        [Category("La propiedad Onclick del componente")]
        [Description("Se lanza cuando se hace clin en el componente")]
        public event System.EventHandler ClickEnMarca;
    }
}
