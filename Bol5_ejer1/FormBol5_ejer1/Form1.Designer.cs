
namespace FormBol5_ejer1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelTextBox1 = new Bol5_ejer1.LabelTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Posicion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Separacion";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelTextBox1
            // 
            this.labelTextBox1.Location = new System.Drawing.Point(90, 65);
            this.labelTextBox1.Name = "labelTextBox1";
            this.labelTextBox1.Posicion = Bol5_ejer1.ePosicion.IZQUIERDA;
            this.labelTextBox1.PswChr = '*';
            this.labelTextBox1.Separacion = 0;
            this.labelTextBox1.Size = new System.Drawing.Size(172, 20);
            this.labelTextBox1.TabIndex = 0;
            this.labelTextBox1.TextLbl = "LabelTextBox";
            this.labelTextBox1.TextTxt = "";
            this.labelTextBox1.CambiaPosicion += new System.EventHandler(this.labelTextBox1_CambiaPosicion);
            this.labelTextBox1.CambiaSeparacion += new System.EventHandler(this.labelTextBox1_CambiaSeparacion);
            this.labelTextBox1.TxtChanged += new System.EventHandler(this.labelTextBox1_TxtChanged);
            this.labelTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.labelTextBox1_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Bol5_ejer1.LabelTextBox labelTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

