using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bol5_Ejer3
{
    public enum ePlayPause
    {
        Play,
        Pause
    }
    public partial class ReproductorSimple : UserControl
    {
        private ePlayPause playPause;
        [Category("Appearance")]
        [Description("Indica el diseño que aparece")]
        public ePlayPause PlayPause
        {
            set
            {
                playPause = value;
                this.Refresh();
            }
            get
            {
                return PlayPause;
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            int grosor = 0;
            int offsetX = 0;
            int offsetY = 0;
            int altura = this.Height;

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            SolidBrush b = new SolidBrush(this.ForeColor);



            switch (PlayPause)
            {
                case ePlayPause.Play:
                    e.Graphics.FillRectangle(b, 0, 0, this.Width, this.Height);
                    grosor = 35;
                    g.DrawEllipse(new Pen(Color.Black, grosor), grosor, grosor, altura, altura);
                    grosor = 4;
                    Pen lapiz = new Pen(Color.White, grosor);
                    g.DrawLine(lapiz,grosor,grosor,altura,altura);
                    g.DrawLine(lapiz, altura, grosor, grosor, altura);
                    g.DrawLine(lapiz, altura, altura, grosor, grosor);
                    offsetX = altura + grosor;
                    offsetY = grosor;
                    lapiz.Dispose();
                    break;
                case ePlayPause.Pause:
                    e.Graphics.FillRectangle(b, 0, 0, this.Width, this.Height);
                    grosor = 35;
                    g.DrawEllipse(new Pen(Color.Black, grosor), grosor,grosor,altura,altura);
                    grosor = 4;
                    g.DrawLine(new Pen(Color.White, grosor), 0, altura, 0, altura);
                    g.DrawLine(new Pen(Color.White, grosor), grosor, altura, grosor, altura);
                    offsetX = altura + grosor;
                    offsetY = grosor;
                    break;
                default:
                    break;
            }
            b.Dispose();
        }



        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (e.X <= this.Width && e.Y <= this.Height)
            {
                Reproduce(this, new EventArgs());
            }
        }




        [Category("La propiedad Onclick del componente")]
        [Description("Se lanza cuando se hace click en el componente")]
        public event System.EventHandler Reproduce;
       
        
        
        
        
        
        public ReproductorSimple()
        {
            InitializeComponent();
        }

        private void ReproductorSimple_Load(object sender, EventArgs e)
        {

        }

        private void Playbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
