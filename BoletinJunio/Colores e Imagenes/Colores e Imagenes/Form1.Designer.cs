namespace Colores_e_Imagenes
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
            this.Exitbtn = new System.Windows.Forms.Button();
            this.Redtxt = new System.Windows.Forms.TextBox();
            this.Greentxt = new System.Windows.Forms.TextBox();
            this.Bluetxt = new System.Windows.Forms.TextBox();
            this.Imagetxt = new System.Windows.Forms.TextBox();
            this.Colorbtn = new System.Windows.Forms.Button();
            this.Imagebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Exitbtn
            // 
            this.Exitbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exitbtn.Location = new System.Drawing.Point(208, 204);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(75, 23);
            this.Exitbtn.TabIndex = 6;
            this.Exitbtn.Text = "Salir";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            this.Exitbtn.MouseEnter += new System.EventHandler(this.buttonMouseEnter);
            this.Exitbtn.MouseLeave += new System.EventHandler(this.buttonMouseLeave);
            this.Exitbtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // Redtxt
            // 
            this.Redtxt.Location = new System.Drawing.Point(12, 72);
            this.Redtxt.Name = "Redtxt";
            this.Redtxt.Size = new System.Drawing.Size(100, 20);
            this.Redtxt.TabIndex = 0;
            this.Redtxt.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // Greentxt
            // 
            this.Greentxt.Location = new System.Drawing.Point(119, 72);
            this.Greentxt.Name = "Greentxt";
            this.Greentxt.Size = new System.Drawing.Size(100, 20);
            this.Greentxt.TabIndex = 1;
            this.Greentxt.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // Bluetxt
            // 
            this.Bluetxt.Location = new System.Drawing.Point(225, 72);
            this.Bluetxt.Name = "Bluetxt";
            this.Bluetxt.Size = new System.Drawing.Size(100, 20);
            this.Bluetxt.TabIndex = 2;
            this.Bluetxt.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // Imagetxt
            // 
            this.Imagetxt.Location = new System.Drawing.Point(12, 178);
            this.Imagetxt.Name = "Imagetxt";
            this.Imagetxt.Size = new System.Drawing.Size(100, 20);
            this.Imagetxt.TabIndex = 4;
            this.Imagetxt.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // Colorbtn
            // 
            this.Colorbtn.Location = new System.Drawing.Point(132, 108);
            this.Colorbtn.Name = "Colorbtn";
            this.Colorbtn.Size = new System.Drawing.Size(75, 23);
            this.Colorbtn.TabIndex = 3;
            this.Colorbtn.Text = "Color";
            this.Colorbtn.UseVisualStyleBackColor = true;
            this.Colorbtn.Click += new System.EventHandler(this.Colorbtn_Click);
            this.Colorbtn.MouseEnter += new System.EventHandler(this.buttonMouseEnter);
            this.Colorbtn.MouseLeave += new System.EventHandler(this.buttonMouseLeave);
            this.Colorbtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // Imagebtn
            // 
            this.Imagebtn.Location = new System.Drawing.Point(22, 204);
            this.Imagebtn.Name = "Imagebtn";
            this.Imagebtn.Size = new System.Drawing.Size(75, 23);
            this.Imagebtn.TabIndex = 5;
            this.Imagebtn.Text = "Imagen";
            this.Imagebtn.UseVisualStyleBackColor = true;
            this.Imagebtn.Click += new System.EventHandler(this.Imagebtn_Click);
            this.Imagebtn.MouseEnter += new System.EventHandler(this.buttonMouseEnter);
            this.Imagebtn.MouseLeave += new System.EventHandler(this.buttonMouseLeave);
            this.Imagebtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // Form1
            // 
            this.AcceptButton = this.Colorbtn;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Exitbtn;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Imagebtn);
            this.Controls.Add(this.Colorbtn);
            this.Controls.Add(this.Imagetxt);
            this.Controls.Add(this.Bluetxt);
            this.Controls.Add(this.Greentxt);
            this.Controls.Add(this.Redtxt);
            this.Controls.Add(this.Exitbtn);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colores e Imagenes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.TextBox Redtxt;
        private System.Windows.Forms.TextBox Greentxt;
        private System.Windows.Forms.TextBox Bluetxt;
        private System.Windows.Forms.TextBox Imagetxt;
        private System.Windows.Forms.Button Colorbtn;
        private System.Windows.Forms.Button Imagebtn;
        private System.Windows.Forms.Label label1;
    }
}

