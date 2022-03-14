
namespace Bol5_Ejer3
{
    partial class ReproductorSimple
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Playbtn = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Playbtn
            // 
            this.Playbtn.Location = new System.Drawing.Point(49, 184);
            this.Playbtn.Name = "Playbtn";
            this.Playbtn.Size = new System.Drawing.Size(75, 23);
            this.Playbtn.TabIndex = 0;
            this.Playbtn.Text = "Play/Pause";
            this.Playbtn.UseVisualStyleBackColor = true;
            this.Playbtn.Click += new System.EventHandler(this.Playbtn_Click);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(46, 210);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(61, 13);
            this.Time.TabIndex = 1;
            this.Time.Text = "HH:MM:SS";
            // 
            // ReproductorSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Playbtn);
            this.Name = "ReproductorSimple";
            this.Size = new System.Drawing.Size(211, 233);
            this.Load += new System.EventHandler(this.ReproductorSimple_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Playbtn;
        private System.Windows.Forms.Label Time;
    }
}
