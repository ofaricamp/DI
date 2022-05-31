namespace WindowsFormsApp1
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
            this.resultlbl = new System.Windows.Forms.Label();
            this.playbtn = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.carta4 = new ClassLibrary1.Carta();
            this.carta3 = new ClassLibrary1.Carta();
            this.carta2 = new ClassLibrary1.Carta();
            this.carta1 = new ClassLibrary1.Carta();
            this.SuspendLayout();
            // 
            // resultlbl
            // 
            this.resultlbl.AutoSize = true;
            this.resultlbl.Location = new System.Drawing.Point(541, 102);
            this.resultlbl.Name = "resultlbl";
            this.resultlbl.Size = new System.Drawing.Size(35, 13);
            this.resultlbl.TabIndex = 4;
            this.resultlbl.Text = "label1";
            // 
            // playbtn
            // 
            this.playbtn.Location = new System.Drawing.Point(521, 61);
            this.playbtn.Name = "playbtn";
            this.playbtn.Size = new System.Drawing.Size(75, 23);
            this.playbtn.TabIndex = 5;
            this.playbtn.Text = "Jugar";
            this.playbtn.UseVisualStyleBackColor = true;
            this.playbtn.Click += new System.EventHandler(this.playbtn_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(70, 178);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(223, 180);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(387, 178);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(14, 13);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point(0, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 200);
            this.panel1.TabIndex = 9;
            // 
            // carta4
            // 
            this.carta4.Imagen = null;
            this.carta4.Location = new System.Drawing.Point(638, 12);
            this.carta4.Name = "carta4";
            this.carta4.Nivel = 0;
            this.carta4.Size = new System.Drawing.Size(150, 150);
            this.carta4.TabIndex = 3;
            this.carta4.Valor = 0;
            // 
            // carta3
            // 
            this.carta3.Imagen = global::WindowsFormsApp1.Properties.Resources.tijera;
            this.carta3.Location = new System.Drawing.Point(324, 12);
            this.carta3.Name = "carta3";
            this.carta3.Nivel = 1;
            this.carta3.Size = new System.Drawing.Size(150, 150);
            this.carta3.TabIndex = 2;
            this.carta3.Valor = 0;
            this.carta3.AlcanzaMax += new System.EventHandler(this.carta1_AlcanzaMax);
            // 
            // carta2
            // 
            this.carta2.Enabled = false;
            this.carta2.Imagen = global::WindowsFormsApp1.Properties.Resources.papel;
            this.carta2.Location = new System.Drawing.Point(168, 12);
            this.carta2.Name = "carta2";
            this.carta2.Nivel = 1;
            this.carta2.Size = new System.Drawing.Size(150, 150);
            this.carta2.TabIndex = 1;
            this.carta2.Valor = 0;
            this.carta2.AlcanzaMax += new System.EventHandler(this.carta1_AlcanzaMax);
            // 
            // carta1
            // 
            this.carta1.Imagen = global::WindowsFormsApp1.Properties.Resources.piedra;
            this.carta1.Location = new System.Drawing.Point(12, 12);
            this.carta1.Name = "carta1";
            this.carta1.Nivel = 1;
            this.carta1.Size = new System.Drawing.Size(150, 150);
            this.carta1.TabIndex = 0;
            this.carta1.Valor = 0;
            this.carta1.AlcanzaMax += new System.EventHandler(this.carta1_AlcanzaMax);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 405);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.playbtn);
            this.Controls.Add(this.resultlbl);
            this.Controls.Add(this.carta4);
            this.Controls.Add(this.carta3);
            this.Controls.Add(this.carta2);
            this.Controls.Add(this.carta1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClassLibrary1.Carta carta1;
        private ClassLibrary1.Carta carta2;
        private ClassLibrary1.Carta carta3;
        private ClassLibrary1.Carta carta4;
        private System.Windows.Forms.Label resultlbl;
        private System.Windows.Forms.Button playbtn;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Panel panel1;
    }
}

