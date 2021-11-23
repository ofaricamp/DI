namespace ejercicio4DI
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
            this.signo = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.suma = new System.Windows.Forms.RadioButton();
            this.resta = new System.Windows.Forms.RadioButton();
            this.multiplicacion = new System.Windows.Forms.RadioButton();
            this.division = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // signo
            // 
            this.signo.AutoSize = true;
            this.signo.Location = new System.Drawing.Point(180, 86);
            this.signo.Name = "signo";
            this.signo.Size = new System.Drawing.Size(13, 13);
            this.signo.TabIndex = 0;
            this.signo.Text = "+";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(302, 86);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(13, 13);
            this.labelResult.TabIndex = 1;
            this.labelResult.Text = "=";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(196, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // suma
            // 
            this.suma.AutoSize = true;
            this.suma.Location = new System.Drawing.Point(105, 121);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(50, 17);
            this.suma.TabIndex = 4;
            this.suma.TabStop = true;
            this.suma.Text = "suma";
            this.suma.UseVisualStyleBackColor = true;
            this.suma.CheckedChanged += new System.EventHandler(this.RadioButtonsClick);
            // 
            // resta
            // 
            this.resta.AutoSize = true;
            this.resta.Location = new System.Drawing.Point(196, 121);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(48, 17);
            this.resta.TabIndex = 5;
            this.resta.TabStop = true;
            this.resta.Text = "resta";
            this.resta.UseVisualStyleBackColor = true;
            this.resta.CheckedChanged += new System.EventHandler(this.RadioButtonsClick);
            // 
            // multiplicacion
            // 
            this.multiplicacion.AutoSize = true;
            this.multiplicacion.Location = new System.Drawing.Point(105, 144);
            this.multiplicacion.Name = "multiplicacion";
            this.multiplicacion.Size = new System.Drawing.Size(88, 17);
            this.multiplicacion.TabIndex = 6;
            this.multiplicacion.TabStop = true;
            this.multiplicacion.Text = "multiplicacion";
            this.multiplicacion.UseVisualStyleBackColor = true;
            this.multiplicacion.CheckedChanged += new System.EventHandler(this.RadioButtonsClick);
            // 
            // division
            // 
            this.division.AutoSize = true;
            this.division.Location = new System.Drawing.Point(196, 144);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(60, 17);
            this.division.TabIndex = 7;
            this.division.TabStop = true;
            this.division.Text = "division";
            this.division.UseVisualStyleBackColor = true;
            this.division.CheckedChanged += new System.EventHandler(this.RadioButtonsClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplicacion);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.signo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton suma;
        private System.Windows.Forms.RadioButton resta;
        private System.Windows.Forms.RadioButton multiplicacion;
        private System.Windows.Forms.RadioButton division;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.Label signo;
    }
}

