
namespace Ejercicio7
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
            this.separacionbtn = new System.Windows.Forms.Button();
            this.cambiobtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.keyUplbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textChangedlbl = new System.Windows.Forms.Label();
            this.labelTextBoxcs4 = new LabelTextBox.LabelTextBoxcs();
            this.labelTextBoxcs3 = new LabelTextBox.LabelTextBoxcs();
            this.labelTextBoxcs2 = new LabelTextBox.LabelTextBoxcs();
            this.labelTextBoxcs1 = new LabelTextBox.LabelTextBoxcs();
            this.SuspendLayout();
            // 
            // separacionbtn
            // 
            this.separacionbtn.Location = new System.Drawing.Point(12, 56);
            this.separacionbtn.Name = "separacionbtn";
            this.separacionbtn.Size = new System.Drawing.Size(75, 23);
            this.separacionbtn.TabIndex = 1;
            this.separacionbtn.Text = "Separacion";
            this.separacionbtn.UseVisualStyleBackColor = true;
            this.separacionbtn.Click += new System.EventHandler(this.separacionbtn_Click);
            // 
            // cambiobtn
            // 
            this.cambiobtn.Location = new System.Drawing.Point(94, 56);
            this.cambiobtn.Name = "cambiobtn";
            this.cambiobtn.Size = new System.Drawing.Size(75, 23);
            this.cambiobtn.TabIndex = 2;
            this.cambiobtn.Text = "Cambio";
            this.cambiobtn.UseVisualStyleBackColor = true;
            this.cambiobtn.Click += new System.EventHandler(this.cambiobtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pasword Char Test";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Key Up test";
            // 
            // keyUplbl
            // 
            this.keyUplbl.AutoSize = true;
            this.keyUplbl.Location = new System.Drawing.Point(305, 221);
            this.keyUplbl.Name = "keyUplbl";
            this.keyUplbl.Size = new System.Drawing.Size(0, 13);
            this.keyUplbl.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "TxtChanged test";
            // 
            // textChangedlbl
            // 
            this.textChangedlbl.AutoSize = true;
            this.textChangedlbl.Location = new System.Drawing.Point(566, 221);
            this.textChangedlbl.Name = "textChangedlbl";
            this.textChangedlbl.Size = new System.Drawing.Size(0, 13);
            this.textChangedlbl.TabIndex = 10;
            // 
            // labelTextBoxcs4
            // 
            this.labelTextBoxcs4.Location = new System.Drawing.Point(461, 261);
            this.labelTextBoxcs4.Name = "labelTextBoxcs4";
            this.labelTextBoxcs4.Posicion = LabelTextBox.LabelTextBoxcs.ePosicion.IZQUIERDA;
            this.labelTextBoxcs4.PswChr = '\0';
            this.labelTextBoxcs4.Separacion = 0;
            this.labelTextBoxcs4.Size = new System.Drawing.Size(183, 20);
            this.labelTextBoxcs4.TabIndex = 8;
            this.labelTextBoxcs4.TextLbl = "LabelTextBoxcs";
            this.labelTextBoxcs4.TextTxt = "Pruebame";
            this.labelTextBoxcs4.TxtXhanged += new System.EventHandler(this.labelTextBoxcs4_TxtXhanged);
            // 
            // labelTextBoxcs3
            // 
            this.labelTextBoxcs3.Location = new System.Drawing.Point(240, 247);
            this.labelTextBoxcs3.Name = "labelTextBoxcs3";
            this.labelTextBoxcs3.Posicion = LabelTextBox.LabelTextBoxcs.ePosicion.IZQUIERDA;
            this.labelTextBoxcs3.PswChr = '\0';
            this.labelTextBoxcs3.Separacion = 0;
            this.labelTextBoxcs3.Size = new System.Drawing.Size(183, 20);
            this.labelTextBoxcs3.TabIndex = 5;
            this.labelTextBoxcs3.TextLbl = "LabelTextBoxcs";
            this.labelTextBoxcs3.TextTxt = "";
            this.labelTextBoxcs3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.labelTextBoxcs3_KeyUp);
            // 
            // labelTextBoxcs2
            // 
            this.labelTextBoxcs2.Location = new System.Drawing.Point(12, 247);
            this.labelTextBoxcs2.Name = "labelTextBoxcs2";
            this.labelTextBoxcs2.Posicion = LabelTextBox.LabelTextBoxcs.ePosicion.IZQUIERDA;
            this.labelTextBoxcs2.PswChr = '*';
            this.labelTextBoxcs2.Separacion = 0;
            this.labelTextBoxcs2.Size = new System.Drawing.Size(183, 20);
            this.labelTextBoxcs2.TabIndex = 3;
            this.labelTextBoxcs2.TextLbl = "LabelTextBoxcs";
            this.labelTextBoxcs2.TextTxt = "";
            // 
            // labelTextBoxcs1
            // 
            this.labelTextBoxcs1.Location = new System.Drawing.Point(12, 21);
            this.labelTextBoxcs1.Name = "labelTextBoxcs1";
            this.labelTextBoxcs1.Posicion = LabelTextBox.LabelTextBoxcs.ePosicion.IZQUIERDA;
            this.labelTextBoxcs1.PswChr = '\0';
            this.labelTextBoxcs1.Separacion = 0;
            this.labelTextBoxcs1.Size = new System.Drawing.Size(183, 20);
            this.labelTextBoxcs1.TabIndex = 0;
            this.labelTextBoxcs1.TextLbl = "LabelTextBoxcs";
            this.labelTextBoxcs1.TextTxt = "";
            this.labelTextBoxcs1.CambiaPosicion += new System.EventHandler(this.labelTextBoxcs1_CambiaPosicion);
            this.labelTextBoxcs1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.labelTextBoxcs1_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textChangedlbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTextBoxcs4);
            this.Controls.Add(this.keyUplbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTextBoxcs3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTextBoxcs2);
            this.Controls.Add(this.cambiobtn);
            this.Controls.Add(this.separacionbtn);
            this.Controls.Add(this.labelTextBoxcs1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LabelTextBox.LabelTextBoxcs labelTextBoxcs1;
        private System.Windows.Forms.Button separacionbtn;
        private System.Windows.Forms.Button cambiobtn;
        private LabelTextBox.LabelTextBoxcs labelTextBoxcs2;
        private System.Windows.Forms.Label label1;
        private LabelTextBox.LabelTextBoxcs labelTextBoxcs3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label keyUplbl;
        private LabelTextBox.LabelTextBoxcs labelTextBoxcs4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label textChangedlbl;
    }
}

