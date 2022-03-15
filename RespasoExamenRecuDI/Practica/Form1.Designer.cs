
namespace Practica
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
            this.separbtn = new System.Windows.Forms.Button();
            this.posbtn = new System.Windows.Forms.Button();
            this.labelTextBox2 = new RespasoExamenRecuDI.LabelTextBox();
            this.SuspendLayout();
            // 
            // separbtn
            // 
            this.separbtn.Location = new System.Drawing.Point(141, 233);
            this.separbtn.Name = "separbtn";
            this.separbtn.Size = new System.Drawing.Size(75, 23);
            this.separbtn.TabIndex = 3;
            this.separbtn.Text = "Separacion";
            this.separbtn.UseVisualStyleBackColor = true;
            this.separbtn.Click += new System.EventHandler(this.separbtn_Click_1);
            // 
            // posbtn
            // 
            this.posbtn.Location = new System.Drawing.Point(223, 232);
            this.posbtn.Name = "posbtn";
            this.posbtn.Size = new System.Drawing.Size(75, 23);
            this.posbtn.TabIndex = 4;
            this.posbtn.Text = "Posicion";
            this.posbtn.UseVisualStyleBackColor = true;
            this.posbtn.Click += new System.EventHandler(this.posbtn_Click);
            // 
            // labelTextBox2
            // 
            this.labelTextBox2.Location = new System.Drawing.Point(141, 207);
            this.labelTextBox2.Name = "labelTextBox2";
            this.labelTextBox2.Posicion = RespasoExamenRecuDI.ePosicion.IZQUIERDA;
            this.labelTextBox2.Pswchar = '*';
            this.labelTextBox2.Separacion = 0;
            this.labelTextBox2.Size = new System.Drawing.Size(150, 20);
            this.labelTextBox2.TabIndex = 1;
            this.labelTextBox2.TextLbl = "Funciono";
            this.labelTextBox2.TextText = "";
            this.labelTextBox2.CambiaPosicion += new System.EventHandler(this.labelTextBox2_CambiaPosicion);
            this.labelTextBox2.CambiaSeparacion += new System.EventHandler(this.labelTextBox2_CambiaSeparacion);
            this.labelTextBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.labelTextBox2_KeyUp);
            // 
            // Form1
            // 
            this.AcceptButton = this.separbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.posbtn);
            this.Controls.Add(this.separbtn);
            this.Controls.Add(this.labelTextBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private RespasoExamenRecuDI.LabelTextBox labelTextBox2;
        private System.Windows.Forms.Button separbtn;
        private System.Windows.Forms.Button posbtn;
    }
}

