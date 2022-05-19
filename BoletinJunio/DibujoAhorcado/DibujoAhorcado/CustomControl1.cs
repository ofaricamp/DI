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
        private int errores;
        public DelegadoAhorcado[] delegados = new DelegadoAhorcado[] { };

        public CustomControl1()
        {
            InitializeComponent();
            errores = 0;
        }

        [Category("Ahorcado")]
        [Description("Es la cantidad de errores que puede cometer el usuario")]
        public int Errores
        {
            set 
            {
                if (errores >= 0)
                {
                    errores = value;
                    Refresh();
                    if (CambiaError != null)
                    {
                        CambiaError(this, new EventArgs());
                    }
                }
            }
            get { return errores; }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            Graphics g = pe.Graphics;
            Pen pen = new Pen(Color.Black, 2);

            // Horca
            //g.DrawLine(pen, 0, Height, Width, Height);
            //g.DrawLine(pen, 0, 0, 0, Height);
            //g.DrawLine(pen, 0, 0, Width / 2, 0);
            //g.DrawLine(pen, Width / 2, 0, (Width / 2), Height / 6);
            // Cabeza
            //g.DrawEllipse(pen, Width / 3, Height / 6, Width / 3, Height / 6);
            //Torso
            //g.DrawLine(pen, Width / 2, Height - Height / 6, Width / 2, Height / 3);
            // Brazos
            //g.DrawLine(pen, Width / 10, Height - Height / 3, Width / 2, Height / 2);
            //g.DrawLine(pen, Width / 2, Height / 2, Width - Width / 10, Height - Height / 3);
            //Piernas
            //g.DrawLine(pen, Width / 2, Height - Height / 6, Width / 10, Height - Height / 10);
            //g.DrawLine(pen, Width / 2, Height - Height / 6, Width - Width / 10, Height - Height / 10);

            delegados = new DelegadoAhorcado[]
            {
                ()=> { g.DrawLine(pen, 0, Height, Width, Height); },
                ()=> { g.DrawLine(pen, 0, 0, 0, Height);},
                ()=> { g.DrawLine(pen, 0, 0, Width / 2, 0);},
                ()=> { g.DrawLine(pen, Width / 2, 0, (Width / 2), Height / 6);},
                ()=> { g.DrawEllipse(pen, Width / 3, Height / 6, Width / 3, Height / 6);},
                ()=> { g.DrawLine(pen, Width / 2, Height - Height / 6, Width / 2, Height / 3);},
                ()=> { g.DrawLine(pen, Width / 10, Height - Height / 3, Width / 2, Height / 2);},
                ()=> { g.DrawLine(pen, Width / 2, Height / 2, Width - Width / 10, Height - Height / 3);},
                ()=> { g.DrawLine(pen, Width / 2, Height - Height / 6, Width / 10, Height - Height / 10);},
                ()=> { g.DrawLine(pen, Width / 2, Height - Height / 6, Width - Width / 10, Height - Height / 10);}
            };
            if (errores < delegados.Length)
            {
                for (int i = 0; i <= errores; i++)
                {
                    DelegadoAhorcado dop = delegados[i];
                    dop();
                    if (Ahorcado != null && delegados.Length - 1 == errores)
                    {
                        Ahorcado(this, new EventArgs());
                    }
                }
            }
           
        }

        [Category("Ahorcado")]
        [Description("Se lanza cuando el número de errores que se puede cometer es canbiado")]
        public event EventHandler CambiaError;

        [Category("Ahorcado")]
        [Description("Se lanza cuando el dibujo del ahorcado es completado")]
        public event EventHandler Ahorcado;
    }
}
