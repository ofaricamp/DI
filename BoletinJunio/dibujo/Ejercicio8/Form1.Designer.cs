
namespace Ejercicio8
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
            this.customControl14 = new dibujo.CustomControl1();
            this.customControl13 = new dibujo.CustomControl1();
            this.customControl12 = new dibujo.CustomControl1();
            this.customControl11 = new dibujo.CustomControl1();
            this.SuspendLayout();
            // 
            // customControl14
            // 
            this.customControl14.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customControl14.Gradiente = false;
            this.customControl14.Imagen = global::Ejercicio8.Properties.Resources.índice;
            this.customControl14.Location = new System.Drawing.Point(12, 318);
            this.customControl14.Marca = dibujo.CustomControl1.eMarca.IMAGEN;
            this.customControl14.Name = "customControl14";
            this.customControl14.PrimerColor = System.Drawing.Color.Orange;
            this.customControl14.SegundoColor = System.Drawing.Color.Blue;
            this.customControl14.Size = new System.Drawing.Size(632, 120);
            this.customControl14.TabIndex = 3;
            this.customControl14.Text = "customControl14";
            this.customControl14.ClickEnMarca += new System.EventHandler(this.customControl11_ClickEnMarca);
            // 
            // customControl13
            // 
            this.customControl13.Gradiente = true;
            this.customControl13.Imagen = null;
            this.customControl13.Location = new System.Drawing.Point(12, 218);
            this.customControl13.Marca = dibujo.CustomControl1.eMarca.CIRCULO;
            this.customControl13.Name = "customControl13";
            this.customControl13.PrimerColor = System.Drawing.Color.Maroon;
            this.customControl13.SegundoColor = System.Drawing.Color.Chartreuse;
            this.customControl13.Size = new System.Drawing.Size(152, 63);
            this.customControl13.TabIndex = 2;
            this.customControl13.Text = "customControl13";
            this.customControl13.ClickEnMarca += new System.EventHandler(this.customControl11_ClickEnMarca);
            // 
            // customControl12
            // 
            this.customControl12.Gradiente = false;
            this.customControl12.Imagen = null;
            this.customControl12.Location = new System.Drawing.Point(12, 175);
            this.customControl12.Marca = dibujo.CustomControl1.eMarca.CRUZ;
            this.customControl12.Name = "customControl12";
            this.customControl12.PrimerColor = System.Drawing.Color.Orange;
            this.customControl12.SegundoColor = System.Drawing.Color.Blue;
            this.customControl12.Size = new System.Drawing.Size(108, 15);
            this.customControl12.TabIndex = 1;
            this.customControl12.Text = "customControl12";
            this.customControl12.ClickEnMarca += new System.EventHandler(this.customControl11_ClickEnMarca);
            // 
            // customControl11
            // 
            this.customControl11.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customControl11.Gradiente = true;
            this.customControl11.Imagen = null;
            this.customControl11.Location = new System.Drawing.Point(12, 12);
            this.customControl11.Marca = dibujo.CustomControl1.eMarca.CIRCULO;
            this.customControl11.Name = "customControl11";
            this.customControl11.PrimerColor = System.Drawing.Color.Orange;
            this.customControl11.SegundoColor = System.Drawing.Color.Blue;
            this.customControl11.Size = new System.Drawing.Size(733, 130);
            this.customControl11.TabIndex = 0;
            this.customControl11.Text = "Bibibi Babibi BUUU";
            this.customControl11.ClickEnMarca += new System.EventHandler(this.customControl11_ClickEnMarca);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customControl14);
            this.Controls.Add(this.customControl13);
            this.Controls.Add(this.customControl12);
            this.Controls.Add(this.customControl11);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ejercicio 7";
            this.ResumeLayout(false);

        }

        #endregion

        private dibujo.CustomControl1 customControl11;
        private dibujo.CustomControl1 customControl12;
        private dibujo.CustomControl1 customControl13;
        private dibujo.CustomControl1 customControl14;
    }
}

