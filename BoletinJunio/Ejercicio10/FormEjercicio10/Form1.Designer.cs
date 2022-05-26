
namespace FormEjercicio10
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
            this.textuallbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.validateTextBox2 = new Ejercicio10.ValidateTextBox();
            this.validateTextBox1 = new Ejercicio10.ValidateTextBox();
            this.SuspendLayout();
            // 
            // textuallbl
            // 
            this.textuallbl.AutoSize = true;
            this.textuallbl.Location = new System.Drawing.Point(25, 66);
            this.textuallbl.Name = "textuallbl";
            this.textuallbl.Size = new System.Drawing.Size(84, 13);
            this.textuallbl.TabIndex = 1;
            this.textuallbl.Text = "TIPO TEXTUAL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "TIPO NUMERICO";
            // 
            // validateTextBox2
            // 
            this.validateTextBox2.AutoScroll = true;
            this.validateTextBox2.Location = new System.Drawing.Point(16, 254);
            this.validateTextBox2.Name = "validateTextBox2";
            this.validateTextBox2.Size = new System.Drawing.Size(172, 40);
            this.validateTextBox2.TabIndex = 2;
            this.validateTextBox2.TexTxt = "";
            this.validateTextBox2.Tipo = Ejercicio10.eTipo.Numerico;
            // 
            // validateTextBox1
            // 
            this.validateTextBox1.AutoScroll = true;
            this.validateTextBox1.Location = new System.Drawing.Point(28, 82);
            this.validateTextBox1.Name = "validateTextBox1";
            this.validateTextBox1.Size = new System.Drawing.Size(196, 40);
            this.validateTextBox1.TabIndex = 0;
            this.validateTextBox1.TexTxt = "";
            this.validateTextBox1.Tipo = Ejercicio10.eTipo.Textual;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.validateTextBox2);
            this.Controls.Add(this.textuallbl);
            this.Controls.Add(this.validateTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Ejercicio10.ValidateTextBox validateTextBox1;
        private System.Windows.Forms.Label textuallbl;
        private Ejercicio10.ValidateTextBox validateTextBox2;
        private System.Windows.Forms.Label label1;
    }
}

