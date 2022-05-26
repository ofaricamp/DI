using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEjercicio10
{
    public partial class Entrada : Form
    {

        public Entrada()
        {
            InitializeComponent();
            aficionCB.DataSource = Enum.GetValues(typeof(eAficion));
            
        }

        private void Entrada_Load(object sender, EventArgs e)
        {

        }
    }
}
