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

namespace RespasoExamenRecuDI
{
    public partial class EtiquetaAviso : Control
    {
        public enum eMarca
        {
            Nada,
            Cruz,
            Circulo,
            Imagen
        }
        public EtiquetaAviso()
        {
            InitializeComponent();
        }

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

        private bool gradiante = false;
        [Category("Appearance")]
        [Description("Determina si el fondo sera gradiante o no")]
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

        private Image imagenMarca;
        [Category("Appearance")]
        [Description("Indica que imagen dispondra la etiqueta en caso de que se quiera disponer de ella")]
        public Image ImagenMarca
        {
            set
            {
                imagenMarca = value;
                if (imagenMarca != null)
                {
                    marca = eMarca.Nada;
                }
            }
            get
            {
                return imagenMarca;
            }
        }

        private Color primerColor;
        [Category("Appearance")]
        [Description("Primer color del gradiante")]
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


        private Color segundoColor;
        [Category("Appearance")]
        [Description("Segundo color del gradiante")]
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

        public Size espacioMarca;
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            int grosor = 0;
            int offsetX = 0;
            int offsetY = 0;
            int altura = this.Font.Height;
          
            LinearGradientBrush linearG;

            if (gradiante)
            {
                linearG = new LinearGradientBrush(new Point(0, 0), new Point(this.Width, this.Height),
                    primerColor,segundoColor);
            }
            else
            {
                linearG = new LinearGradientBrush(new Point(0, 0), new Point(this.Width, this.Height),
                    Color.FromArgb(0,0,0),Color.FromArgb(0,0,0));
            }
            
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            switch (Marca)
            {
                case eMarca.Circulo:
                    e.Graphics.FillRectangle(linearG, 0, 0, this.Width, this.Height);
                    grosor = 20;
                    g.DrawEllipse(new Pen(Color.Green, grosor), grosor, grosor, altura, altura);
                    offsetX = altura + grosor;
                    offsetY = grosor;
                    break;
                case eMarca.Cruz:
                    e.Graphics.FillRectangle(linearG, 0, 0, this.Width, this.Height);
                    grosor = 3;
                    Pen lapiz = new Pen(Color.Red, grosor);
                    g.DrawLine(lapiz, grosor, grosor, altura, altura);
                    g.DrawLine(lapiz, altura, grosor, grosor, altura);
                    offsetX = altura + grosor;
                    offsetY = grosor / 2;
                    lapiz.Dispose();
                    break;
                case eMarca.Imagen:
                    if (ImagenMarca != null)
                    {
                        e.Graphics.FillRectangle(linearG, 0, 0, this.Width, this.Height);
                        grosor = 20;
                        g.DrawImage(imagenMarca,grosor,grosor,altura,altura);
                        offsetX = altura + grosor;
                        offsetY = grosor;
                    }
                    break;
            }
            SolidBrush brush = new SolidBrush(this.ForeColor);
            g.DrawString(this.Text, this.Font, brush, offsetX + grosor, offsetY);
            Size tamanho = g.MeasureString(this.Text, this.Font).ToSize();
            this.Size = new Size(tamanho.Width + offsetX + grosor, tamanho.Height + offsetY * 2);
            espacioMarca = new Size((this.Width - tamanho.Width), this.Height);
            base.Dispose();
            linearG.Dispose();
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (ClickEnMarca != null && (e.X <= espacioMarca.Width && e.Y <= espacioMarca.Height))
            {
                ClickEnMarca(this, new EventArgs());
            }
        }

        [Category("La propiedad OnClick del componente")]
        [Description("Se lanza cuando se hace click en el componente (en el espacio que dispone de texto)")]
        public event System.EventHandler ClickEnMarca;

        private void EtiquetaAviso_Load(object sender, EventArgs e)
        {

        }
    }
}
