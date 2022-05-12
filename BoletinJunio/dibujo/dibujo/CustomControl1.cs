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

namespace dibujo
{
    public partial class CustomControl1 : Control
    {
        public enum eMarca
        {
            CRUZ,
            CIRCULO,
            IMAGEN,
            NADA
        }

        Rectangle rectangle;
        
        public CustomControl1()
        {

            InitializeComponent();
            primerColor = Color.Orange;
            segundoColor = Color.Blue;
            gradiente = false;
        }

        private eMarca marca = eMarca.NADA;

        [Category("Appearance")]
        [Description("Indica qué marca aparecerá junto al texto")]
        public eMarca Marca
        {
            set 
            {
                marca = value;
                Refresh();
            }
            get { return marca; }
        }

        private Image imagen;

        [Category("Appearance")]
        [Description("Imagen que se pondra como marca en la etiqueta")]
        public Image Imagen
        {
            set {
                imagen = value;

                if (imagen == null)
                {
                    marca = eMarca.NADA;
                }

                Refresh();
            }
            get
            {
                return imagen;
            }
        }

        private Color primerColor;

        [Category("Appearance")]
        [Description("Es el primer color a elegir para el fondo gradiente")]
        public Color PrimerColor
        {
            set 
            {
                primerColor = value;
                Refresh();
            }
            get { return primerColor; }
        }

        private Color segundoColor;

        [Category("Appearance")]
        [Description("Es el segundo color a elegir para el fondo gradiente")]
        public Color SegundoColor
        {
            set 
            {
                segundoColor = value;
                Refresh();
            }
            get { return segundoColor; }
        }

        private bool gradiente;
        
        [Category("Appearance")]
        [Description("Determina si se desea que la etiqueta disponga de un fondo gradiente o no")]
        public bool Gradiente
        {
            set
            { 
                gradiente = value;
                Refresh();
            }
            get { return gradiente; }
        }

        
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            Graphics g = pe.Graphics;
            int grosor = 0;
            int offsetX = 0;
            int offsetY = 0;
            int height = Font.Height;

            g.SmoothingMode = SmoothingMode.AntiAlias;

            if (gradiente)
            {
                LinearGradientBrush linearGradient = new LinearGradientBrush(new Point(0, 0), new Point(150, 150),
                    PrimerColor, SegundoColor);
                g.FillRectangle(linearGradient, 0, 0, Width, Height);
                linearGradient.Dispose();
            }

            switch (Marca)
            {
                case eMarca.CRUZ:
                    grosor = 3;
                    g.DrawLine(new Pen(Color.Red, grosor), grosor, grosor, height, height);
                    g.DrawLine(new Pen(Color.Red, grosor), height, grosor, grosor, height);
                    offsetX = height + grosor;
                    offsetY = grosor / 2;
                    rectangle = new Rectangle(grosor, grosor, height, height);
                    g.DrawRectangle(new Pen(Color.Transparent), rectangle);
                    break;
                case eMarca.CIRCULO:
                    grosor = 25;
                    g.DrawEllipse(new Pen(Color.MediumVioletRed, grosor), grosor, grosor, height, height);
                    offsetX = height + grosor;
                    offsetY = grosor;

                    rectangle = new Rectangle(grosor, grosor, height, height);
                    g.DrawRectangle(new Pen(Color.Transparent), rectangle);
                    break;
                case eMarca.IMAGEN:
                    if (Imagen != null)
                    {
                       
                        grosor = 20;
                        g.DrawImage(Imagen, grosor, grosor, height, height);
                        offsetX = height + grosor;
                        offsetY = grosor;
                    }

                    rectangle = new Rectangle(grosor, grosor, height, height);
                    g.DrawRectangle(new Pen(Color.Transparent), rectangle);
                    break;
                case eMarca.NADA:
                    break;
            }

            SolidBrush bruh = new SolidBrush(ForeColor);
            g.DrawString(this.Text, Font, bruh, offsetX + grosor, offsetY);
            Size size = g.MeasureString(this.Text, this.Font).ToSize();
            this.Size = new Size(size.Width + offsetX + grosor, size.Height + offsetY * 2);
            bruh.Dispose();
        }

        [Category("Ejercicio")]
        [Description("Se ejecuta si se pulsa la marca de la etuiqueta")]
        public event EventHandler ClickEnMarca;

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (e.X <= rectangle.Right)
            {
                if (ClickEnMarca != null)
                {
                    ClickEnMarca(this, new EventArgs());
                }
            }
        }

    }

}
