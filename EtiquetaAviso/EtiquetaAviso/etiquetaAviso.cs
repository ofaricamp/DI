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

    public partial class etiquetaAviso : UserControl
    {
        public etiquetaAviso()
        {
            this.Text = "Eres un grande Alvaroooooooooooooooooo";
          

        }
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
                //if (ClickEnMarca != null)
                //{
                //    ClickEnMarca(this, new EventArgs());
                //}
            }

            get
            {
                return marca;
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
            Image image = Image.FromFile("C:\\alvaroApreciame.jpg");
            LinearGradientBrush linearBruh = new LinearGradientBrush(
            new Point(0, 0),
            new Point(this.Width, this.Height),
            Color.FromArgb(255, 0, 60, 154),
            Color.FromArgb(0, 100, 60, 60));

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
                    e.Graphics.FillRectangle(linearBruh, 0, 0, this.Width, this.Height);
                    grosor = 20;
                    g.DrawImage(image, grosor, grosor, h, h);
                    offsetX = h + grosor;
                    offsetY = grosor;
                    break;
            }

            g.DrawString(this.Text, this.Font, b, offsetX + grosor, offsetY);
            Size tam = g.MeasureString(this.Text, this.Font).ToSize();
            this.Size = new Size(tam.Width + offsetX + grosor, tam.Height + offsetY * 2);
            espacioMarca = this.Size - tam;
            b.Dispose();
            linearBruh.Dispose();
            
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (e.X <= espacioMarca.Width && e.Y <= espacioMarca.Height)
            {
                ClickEnMarca(this, new EventArgs());
            }
        }

        [Category("La propiedad Onclick del componente")]
        [Description("Se lanza cuando se hace clin en el componente")]
        public event System.EventHandler ClickEnMarca;

    }
}
