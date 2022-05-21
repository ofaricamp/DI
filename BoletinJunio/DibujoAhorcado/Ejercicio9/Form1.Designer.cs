
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
            this.Intentbtn = new System.Windows.Forms.Button();
            this.lettertxt = new System.Windows.Forms.TextBox();
            this.Letterlbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Trieslbl = new System.Windows.Forms.Label();
            this.FailedLetterslbl = new System.Windows.Forms.Label();
            this.Stripeslbl = new System.Windows.Forms.Label();
            this.Errorlbl = new System.Windows.Forms.Label();
            this.Resetbtn = new System.Windows.Forms.Button();
            this.Resultlb = new System.Windows.Forms.Label();
            this.ahorcado = new DibujoAhorcado.CustomControl1();
            this.letrasUSadaslbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Intentbtn
            // 
            this.Intentbtn.Location = new System.Drawing.Point(59, 111);
            this.Intentbtn.Name = "Intentbtn";
            this.Intentbtn.Size = new System.Drawing.Size(75, 23);
            this.Intentbtn.TabIndex = 2;
            this.Intentbtn.Text = "Intentar";
            this.Intentbtn.UseVisualStyleBackColor = true;
            this.Intentbtn.Click += new System.EventHandler(this.Intentbtn_Click);
            // 
            // lettertxt
            // 
            this.lettertxt.Location = new System.Drawing.Point(48, 85);
            this.lettertxt.Name = "lettertxt";
            this.lettertxt.Size = new System.Drawing.Size(100, 20);
            this.lettertxt.TabIndex = 3;
            // 
            // Letterlbl
            // 
            this.Letterlbl.AutoSize = true;
            this.Letterlbl.Location = new System.Drawing.Point(7, 88);
            this.Letterlbl.Name = "Letterlbl";
            this.Letterlbl.Size = new System.Drawing.Size(34, 13);
            this.Letterlbl.TabIndex = 4;
            this.Letterlbl.Text = "Letra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Inserte una Letra";
            // 
            // Trieslbl
            // 
            this.Trieslbl.AutoSize = true;
            this.Trieslbl.Location = new System.Drawing.Point(45, 159);
            this.Trieslbl.Name = "Trieslbl";
            this.Trieslbl.Size = new System.Drawing.Size(51, 13);
            this.Trieslbl.TabIndex = 6;
            this.Trieslbl.Text = "Intentos: ";
            // 
            // FailedLetterslbl
            // 
            this.FailedLetterslbl.AutoSize = true;
            this.FailedLetterslbl.Location = new System.Drawing.Point(45, 181);
            this.FailedLetterslbl.Name = "FailedLetterslbl";
            this.FailedLetterslbl.Size = new System.Drawing.Size(96, 13);
            this.FailedLetterslbl.TabIndex = 10;
            this.FailedLetterslbl.Text = "Letras empleadas: ";
            // 
            // Stripeslbl
            // 
            this.Stripeslbl.AutoSize = true;
            this.Stripeslbl.Location = new System.Drawing.Point(45, 22);
            this.Stripeslbl.Name = "Stripeslbl";
            this.Stripeslbl.Size = new System.Drawing.Size(0, 13);
            this.Stripeslbl.TabIndex = 11;
            // 
            // Errorlbl
            // 
            this.Errorlbl.AutoSize = true;
            this.Errorlbl.Location = new System.Drawing.Point(45, 253);
            this.Errorlbl.Name = "Errorlbl";
            this.Errorlbl.Size = new System.Drawing.Size(0, 13);
            this.Errorlbl.TabIndex = 12;
            // 
            // Resetbtn
            // 
            this.Resetbtn.Location = new System.Drawing.Point(59, 316);
            this.Resetbtn.Name = "Resetbtn";
            this.Resetbtn.Size = new System.Drawing.Size(75, 23);
            this.Resetbtn.TabIndex = 13;
            this.Resetbtn.Text = "Reintentar";
            this.Resetbtn.UseVisualStyleBackColor = true;
            this.Resetbtn.Visible = false;
            this.Resetbtn.Click += new System.EventHandler(this.Resetbtn_Click);
            // 
            // Resultlb
            // 
            this.Resultlb.AutoSize = true;
            this.Resultlb.Location = new System.Drawing.Point(59, 297);
            this.Resultlb.Name = "Resultlb";
            this.Resultlb.Size = new System.Drawing.Size(0, 13);
            this.Resultlb.TabIndex = 14;
            // 
            // ahorcado
            // 
            this.ahorcado.Errores = 1;
            this.ahorcado.Location = new System.Drawing.Point(232, 12);
            this.ahorcado.Name = "ahorcado";
            this.ahorcado.Size = new System.Drawing.Size(146, 283);
            this.ahorcado.TabIndex = 1;
            this.ahorcado.Text = "customControl12";
            this.ahorcado.CambiaError += new System.EventHandler(this.ahorcado_CambiaError);
            this.ahorcado.Ahorcado += new System.EventHandler(this.ahorcado_Ahorcado);
            // 
            // letrasUSadaslbl
            // 
            this.letrasUSadaslbl.AutoSize = true;
            this.letrasUSadaslbl.Location = new System.Drawing.Point(48, 198);
            this.letrasUSadaslbl.Name = "letrasUSadaslbl";
            this.letrasUSadaslbl.Size = new System.Drawing.Size(0, 13);
            this.letrasUSadaslbl.TabIndex = 15;
            // 
            // Form1
            // 
            this.AcceptButton = this.Intentbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 351);
            this.Controls.Add(this.letrasUSadaslbl);
            this.Controls.Add(this.Resultlb);
            this.Controls.Add(this.Resetbtn);
            this.Controls.Add(this.Errorlbl);
            this.Controls.Add(this.Stripeslbl);
            this.Controls.Add(this.FailedLetterslbl);
            this.Controls.Add(this.Trieslbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Letterlbl);
            this.Controls.Add(this.lettertxt);
            this.Controls.Add(this.Intentbtn);
            this.Controls.Add(this.ahorcado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 9";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DibujoAhorcado.CustomControl1 ahorcado;
        private System.Windows.Forms.Button Intentbtn;
        private System.Windows.Forms.TextBox lettertxt;
        private System.Windows.Forms.Label Letterlbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Trieslbl;
        private System.Windows.Forms.Label FailedLetterslbl;
        private System.Windows.Forms.Label Stripeslbl;
        private System.Windows.Forms.Label Errorlbl;
        private System.Windows.Forms.Button Resetbtn;
        private System.Windows.Forms.Label Resultlb;
        private System.Windows.Forms.Label letrasUSadaslbl;
    }
}

