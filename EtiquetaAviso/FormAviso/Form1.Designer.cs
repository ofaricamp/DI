
namespace FormAviso
{
    partial class Bol5_Ejer2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bol5_Ejer2));
            this.etiquetaAviso5 = new EtiquetaAviso.etiquetaAviso();
            this.etiquetaAviso4 = new EtiquetaAviso.etiquetaAviso();
            this.etiquetaAviso3 = new EtiquetaAviso.etiquetaAviso();
            this.etiquetaAviso2 = new EtiquetaAviso.etiquetaAviso();
            this.SuspendLayout();
            // 
            // etiquetaAviso5
            // 
            this.etiquetaAviso5.Gradiante = false;
            this.etiquetaAviso5.ImagenMarca = global::FormAviso.Properties.Resources.Calamardo;
            this.etiquetaAviso5.Location = new System.Drawing.Point(412, 311);
            this.etiquetaAviso5.Marca = EtiquetaAviso.eMarca.Imagen;
            this.etiquetaAviso5.Name = "etiquetaAviso5";
            this.etiquetaAviso5.PrimerColor = System.Drawing.Color.Empty;
            this.etiquetaAviso5.SegundoColor = System.Drawing.Color.Empty;
            this.etiquetaAviso5.Size = new System.Drawing.Size(131, 53);
            this.etiquetaAviso5.TabIndex = 3;
            this.etiquetaAviso5.Text = "etiquetaAviso5";
            this.etiquetaAviso5.ClickEnMarca += new System.EventHandler(this.etiquetaAviso1_ClickEnMarca);
            this.etiquetaAviso5.Click += new System.EventHandler(this.etiquetaAviso5_Click);
            // 
            // etiquetaAviso4
            // 
            this.etiquetaAviso4.Gradiante = false;
            this.etiquetaAviso4.ImagenMarca = null;
            this.etiquetaAviso4.Location = new System.Drawing.Point(221, 311);
            this.etiquetaAviso4.Marca = EtiquetaAviso.eMarca.Cruz;
            this.etiquetaAviso4.Name = "etiquetaAviso4";
            this.etiquetaAviso4.PrimerColor = System.Drawing.Color.Empty;
            this.etiquetaAviso4.SegundoColor = System.Drawing.Color.Empty;
            this.etiquetaAviso4.Size = new System.Drawing.Size(97, 15);
            this.etiquetaAviso4.TabIndex = 2;
            this.etiquetaAviso4.Text = "etiquetaAviso4";
            this.etiquetaAviso4.ClickEnMarca += new System.EventHandler(this.etiquetaAviso1_ClickEnMarca);
            // 
            // etiquetaAviso3
            // 
            this.etiquetaAviso3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaAviso3.Gradiante = true;
            this.etiquetaAviso3.ImagenMarca = null;
            this.etiquetaAviso3.Location = new System.Drawing.Point(208, 77);
            this.etiquetaAviso3.Marca = EtiquetaAviso.eMarca.Circulo;
            this.etiquetaAviso3.Name = "etiquetaAviso3";
            this.etiquetaAviso3.PrimerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.etiquetaAviso3.SegundoColor = System.Drawing.Color.Fuchsia;
            this.etiquetaAviso3.Size = new System.Drawing.Size(449, 100);
            this.etiquetaAviso3.TabIndex = 1;
            this.etiquetaAviso3.Text = "etiquetaAviso3";
            this.etiquetaAviso3.ClickEnMarca += new System.EventHandler(this.etiquetaAviso1_ClickEnMarca);
            // 
            // etiquetaAviso2
            // 
            this.etiquetaAviso2.Gradiante = true;
            this.etiquetaAviso2.ImagenMarca = null;
            this.etiquetaAviso2.Location = new System.Drawing.Point(208, 202);
            this.etiquetaAviso2.Marca = EtiquetaAviso.eMarca.Circulo;
            this.etiquetaAviso2.Name = "etiquetaAviso2";
            this.etiquetaAviso2.PrimerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.etiquetaAviso2.SegundoColor = System.Drawing.Color.Fuchsia;
            this.etiquetaAviso2.Size = new System.Drawing.Size(131, 53);
            this.etiquetaAviso2.TabIndex = 0;
            this.etiquetaAviso2.Text = "etiquetaAviso2";
            this.etiquetaAviso2.ClickEnMarca += new System.EventHandler(this.etiquetaAviso1_ClickEnMarca);
            // 
            // Bol5_Ejer2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.etiquetaAviso5);
            this.Controls.Add(this.etiquetaAviso4);
            this.Controls.Add(this.etiquetaAviso3);
            this.Controls.Add(this.etiquetaAviso2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bol5_Ejer2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Bol5_Ejer2_Load);
            this.Click += new System.EventHandler(this.Bol5_Ejer2_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private EtiquetaAviso.etiquetaAviso etiquetaAviso1;
        private EtiquetaAviso.etiquetaAviso etiquetaAviso2;
        private EtiquetaAviso.etiquetaAviso etiquetaAviso3;
        private EtiquetaAviso.etiquetaAviso etiquetaAviso4;
        private EtiquetaAviso.etiquetaAviso etiquetaAviso5;
    }
}

