namespace Ejercicio4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.signolbl = new System.Windows.Forms.Label();
            this.reslbl = new System.Windows.Forms.Label();
            this.plusrb = new System.Windows.Forms.RadioButton();
            this.minusrb = new System.Windows.Forms.RadioButton();
            this.multiplyrb = new System.Windows.Forms.RadioButton();
            this.divisionrb = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.executebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(251, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // signolbl
            // 
            this.signolbl.AutoSize = true;
            this.signolbl.Location = new System.Drawing.Point(211, 120);
            this.signolbl.Name = "signolbl";
            this.signolbl.Size = new System.Drawing.Size(34, 13);
            this.signolbl.TabIndex = 2;
            this.signolbl.Text = "Signo";
            // 
            // reslbl
            // 
            this.reslbl.AutoSize = true;
            this.reslbl.Location = new System.Drawing.Point(358, 120);
            this.reslbl.Name = "reslbl";
            this.reslbl.Size = new System.Drawing.Size(50, 13);
            this.reslbl.TabIndex = 3;
            this.reslbl.Text = "resultado";
            // 
            // plusrb
            // 
            this.plusrb.AutoSize = true;
            this.plusrb.Location = new System.Drawing.Point(105, 192);
            this.plusrb.Name = "plusrb";
            this.plusrb.Size = new System.Drawing.Size(31, 17);
            this.plusrb.TabIndex = 4;
            this.plusrb.TabStop = true;
            this.plusrb.Text = "+";
            this.plusrb.UseVisualStyleBackColor = true;
            this.plusrb.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // minusrb
            // 
            this.minusrb.AutoSize = true;
            this.minusrb.Location = new System.Drawing.Point(196, 192);
            this.minusrb.Name = "minusrb";
            this.minusrb.Size = new System.Drawing.Size(28, 17);
            this.minusrb.TabIndex = 5;
            this.minusrb.TabStop = true;
            this.minusrb.Text = "-";
            this.minusrb.UseVisualStyleBackColor = true;
            this.minusrb.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // multiplyrb
            // 
            this.multiplyrb.AutoSize = true;
            this.multiplyrb.Location = new System.Drawing.Point(287, 192);
            this.multiplyrb.Name = "multiplyrb";
            this.multiplyrb.Size = new System.Drawing.Size(32, 17);
            this.multiplyrb.TabIndex = 6;
            this.multiplyrb.TabStop = true;
            this.multiplyrb.Text = "X";
            this.multiplyrb.UseVisualStyleBackColor = true;
            this.multiplyrb.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // divisionrb
            // 
            this.divisionrb.AutoSize = true;
            this.divisionrb.Location = new System.Drawing.Point(378, 192);
            this.divisionrb.Name = "divisionrb";
            this.divisionrb.Size = new System.Drawing.Size(30, 17);
            this.divisionrb.TabIndex = 7;
            this.divisionrb.TabStop = true;
            this.divisionrb.Text = "/";
            this.divisionrb.UseVisualStyleBackColor = true;
            this.divisionrb.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // executebtn
            // 
            this.executebtn.Location = new System.Drawing.Point(214, 238);
            this.executebtn.Name = "executebtn";
            this.executebtn.Size = new System.Drawing.Size(75, 23);
            this.executebtn.TabIndex = 8;
            this.executebtn.Text = "Let´s try it";
            this.executebtn.UseVisualStyleBackColor = true;
            this.executebtn.Click += new System.EventHandler(this.executebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.executebtn);
            this.Controls.Add(this.divisionrb);
            this.Controls.Add(this.multiplyrb);
            this.Controls.Add(this.minusrb);
            this.Controls.Add(this.plusrb);
            this.Controls.Add(this.reslbl);
            this.Controls.Add(this.signolbl);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label signolbl;
        private System.Windows.Forms.Label reslbl;
        private System.Windows.Forms.RadioButton plusrb;
        private System.Windows.Forms.RadioButton minusrb;
        private System.Windows.Forms.RadioButton multiplyrb;
        private System.Windows.Forms.RadioButton divisionrb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button executebtn;
    }
}

