
namespace FormEjercicio10
{
    partial class Entrada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entrada));
            this.validateTextBox1 = new Ejercicio10.ValidateTextBox();
            this.validateTextBox2 = new Ejercicio10.ValidateTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aficionCB = new System.Windows.Forms.ComboBox();
            this.sexGB = new System.Windows.Forms.GroupBox();
            this.opositesexGB = new System.Windows.Forms.GroupBox();
            this.menRB = new System.Windows.Forms.RadioButton();
            this.womenRB = new System.Windows.Forms.RadioButton();
            this.opositeMenRB = new System.Windows.Forms.RadioButton();
            this.opositeWomenRB = new System.Windows.Forms.RadioButton();
            this.sexGB.SuspendLayout();
            this.opositesexGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // validateTextBox1
            // 
            this.validateTextBox1.Location = new System.Drawing.Point(22, 51);
            this.validateTextBox1.Name = "validateTextBox1";
            this.validateTextBox1.Size = new System.Drawing.Size(150, 40);
            this.validateTextBox1.TabIndex = 0;
            this.validateTextBox1.TexTxt = "";
            this.validateTextBox1.Tipo = Ejercicio10.eTipo.Textual;
            // 
            // validateTextBox2
            // 
            this.validateTextBox2.Location = new System.Drawing.Point(22, 130);
            this.validateTextBox2.Name = "validateTextBox2";
            this.validateTextBox2.Size = new System.Drawing.Size(150, 40);
            this.validateTextBox2.TabIndex = 1;
            this.validateTextBox2.TexTxt = "";
            this.validateTextBox2.Tipo = Ejercicio10.eTipo.Numerico;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Edad";
            // 
            // aficionCB
            // 
            this.aficionCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aficionCB.FormattingEnabled = true;
            this.aficionCB.Location = new System.Drawing.Point(35, 193);
            this.aficionCB.Name = "aficionCB";
            this.aficionCB.Size = new System.Drawing.Size(121, 21);
            this.aficionCB.TabIndex = 4;
            // 
            // sexGB
            // 
            this.sexGB.Controls.Add(this.womenRB);
            this.sexGB.Controls.Add(this.menRB);
            this.sexGB.Location = new System.Drawing.Point(35, 230);
            this.sexGB.Name = "sexGB";
            this.sexGB.Size = new System.Drawing.Size(68, 65);
            this.sexGB.TabIndex = 5;
            this.sexGB.TabStop = false;
            this.sexGB.Text = "Sexo";
            // 
            // opositesexGB
            // 
            this.opositesexGB.Controls.Add(this.opositeWomenRB);
            this.opositesexGB.Controls.Add(this.opositeMenRB);
            this.opositesexGB.Location = new System.Drawing.Point(35, 301);
            this.opositesexGB.Name = "opositesexGB";
            this.opositesexGB.Size = new System.Drawing.Size(91, 65);
            this.opositesexGB.TabIndex = 6;
            this.opositesexGB.TabStop = false;
            this.opositesexGB.Text = "Sexo Opuesto";
            // 
            // menRB
            // 
            this.menRB.AutoSize = true;
            this.menRB.Location = new System.Drawing.Point(6, 19);
            this.menRB.Name = "menRB";
            this.menRB.Size = new System.Drawing.Size(62, 17);
            this.menRB.TabIndex = 0;
            this.menRB.TabStop = true;
            this.menRB.Text = "Hombre";
            this.menRB.UseVisualStyleBackColor = true;
            // 
            // womenRB
            // 
            this.womenRB.AutoSize = true;
            this.womenRB.Location = new System.Drawing.Point(6, 42);
            this.womenRB.Name = "womenRB";
            this.womenRB.Size = new System.Drawing.Size(51, 17);
            this.womenRB.TabIndex = 1;
            this.womenRB.TabStop = true;
            this.womenRB.Text = "Mujer";
            this.womenRB.UseVisualStyleBackColor = true;
            // 
            // opositeMenRB
            // 
            this.opositeMenRB.AutoSize = true;
            this.opositeMenRB.Location = new System.Drawing.Point(6, 19);
            this.opositeMenRB.Name = "opositeMenRB";
            this.opositeMenRB.Size = new System.Drawing.Size(62, 17);
            this.opositeMenRB.TabIndex = 0;
            this.opositeMenRB.TabStop = true;
            this.opositeMenRB.Text = "Hombre";
            this.opositeMenRB.UseVisualStyleBackColor = true;
            // 
            // opositeWomenRB
            // 
            this.opositeWomenRB.AutoSize = true;
            this.opositeWomenRB.Location = new System.Drawing.Point(6, 42);
            this.opositeWomenRB.Name = "opositeWomenRB";
            this.opositeWomenRB.Size = new System.Drawing.Size(51, 17);
            this.opositeWomenRB.TabIndex = 1;
            this.opositeWomenRB.TabStop = true;
            this.opositeWomenRB.Text = "Mujer";
            this.opositeWomenRB.UseVisualStyleBackColor = true;
            // 
            // Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.opositesexGB);
            this.Controls.Add(this.sexGB);
            this.Controls.Add(this.aficionCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.validateTextBox2);
            this.Controls.Add(this.validateTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Entrada";
            this.Text = "Entrada";
            this.Load += new System.EventHandler(this.Entrada_Load);
            this.sexGB.ResumeLayout(false);
            this.sexGB.PerformLayout();
            this.opositesexGB.ResumeLayout(false);
            this.opositesexGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Ejercicio10.ValidateTextBox validateTextBox1;
        private Ejercicio10.ValidateTextBox validateTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox aficionCB;
        private System.Windows.Forms.GroupBox sexGB;
        private System.Windows.Forms.RadioButton womenRB;
        private System.Windows.Forms.RadioButton menRB;
        private System.Windows.Forms.GroupBox opositesexGB;
        private System.Windows.Forms.RadioButton opositeWomenRB;
        private System.Windows.Forms.RadioButton opositeMenRB;
    }
}