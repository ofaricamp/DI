
namespace Ejercicio9
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
            this.customControl12 = new DibujoAhorcado.CustomControl1();
            this.customControl11 = new DibujoAhorcado.CustomControl1();
            this.SuspendLayout();
            // 
            // customControl12
            // 
            this.customControl12.Location = new System.Drawing.Point(132, 67);
            this.customControl12.Name = "customControl12";
            this.customControl12.Size = new System.Drawing.Size(75, 240);
            this.customControl12.TabIndex = 1;
            this.customControl12.Text = "customControl12";
            // 
            // customControl11
            // 
            this.customControl11.Location = new System.Drawing.Point(303, 67);
            this.customControl11.Name = "customControl11";
            this.customControl11.Size = new System.Drawing.Size(75, 183);
            this.customControl11.TabIndex = 0;
            this.customControl11.Text = "customControl11";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customControl12);
            this.Controls.Add(this.customControl11);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ejercicio 9";
            this.ResumeLayout(false);

        }

        #endregion

        private DibujoAhorcado.CustomControl1 customControl11;
        private DibujoAhorcado.CustomControl1 customControl12;
    }
}

