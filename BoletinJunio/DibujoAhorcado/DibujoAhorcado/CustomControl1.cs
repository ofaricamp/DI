using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DibujoAhorcado
{
    public delegate void DelegadoAhorcado();// raphics g,Pen pen, int x1, int y1, int x2, int y2,bool ellipse);

    public partial class CustomControl1 : Control
    {
        static void Pintado(Graphics g,Pen pen, int x1,int y1, int x2,int y2, bool ellipse)
        {
            if (!ellipse)
            {
                g.DrawLine(pen, x1, y1, x2, y2);
            }
            else
            {
                g.DrawEllipse(pen, x1, y1, x2, y2);
            }
        }
       // public DelegadoAhorcado pintarDelegado = new DelegadoAhorcado(Pintado);
        public DelegadoAhorcado[] delegados = new DelegadoAhorcado[] {
                ()=>{ } ,
        
        
        
        };

        public CustomControl1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            Graphics g = pe.Graphics;
            Pen pen = new Pen(Color.Black, 2);

            // Horca
            Pintado(g,pen, 0, Height, Width, Height,false);
            Pintado(g, pen, 0, 0, 0, Height,false);
            Pintado(g, pen, 0, 0, Width / 2, 0,false);
            Pintado(g, pen, Width / 2, 0, (Width / 2), Height / 6,false);
            
            g.DrawLine(pen, 0, Height, Width, Height);
            g.DrawLine(pen, 0, 0, 0, Height);
            g.DrawLine(pen, 0, 0, Width / 2, 0);
            g.DrawLine(pen, Width / 2, 0, (Width / 2), Height / 6);
            // Cabeza
            Pintado(g, pen, Width / 3, Height / 6, Width / 3, Height / 6,true);

            g.DrawEllipse(pen, Width / 3, Height / 6, Width / 3, Height / 6);
            //Torso
            Pintado(g, pen, Width / 2, Height - Height / 6, Width / 2, Height / 3,false);

            g.DrawLine(pen, Width / 2, Height - Height / 6, Width / 2, Height / 3);
            // Brazos
            Pintado(g, pen, Width / 10, Height - Height / 3, Width / 2, Height / 2,false);
            Pintado(g, pen, Width / 2, Height / 2, Width - Width / 10, Height - Height / 3,false);

            g.DrawLine(pen, Width / 10, Height - Height / 3, Width / 2, Height / 2);
            g.DrawLine(pen, Width / 2, Height / 2, Width - Width / 10, Height -Height / 3);
            //Piernas
            Pintado(g, pen, Width / 2, Height - Height / 6, Width / 10, Height - Height / 10,false);
            Pintado(g, pen, Width / 2, Height - Height / 6, Width - Width / 10, Height - Height / 10,false);

            g.DrawLine(pen, Width / 2, Height - Height / 6, Width / 10, Height - Height / 10);
            g.DrawLine(pen, Width / 2, Height - Height / 6, Width - Width / 10, Height - Height / 10);
        }
    }
}
