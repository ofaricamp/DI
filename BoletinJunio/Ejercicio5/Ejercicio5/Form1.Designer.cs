
namespace Ejercicio5
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
            this.list1 = new System.Windows.Forms.ListBox();
            this.list2 = new System.Windows.Forms.ListBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.quitarbtn = new System.Windows.Forms.Button();
            this.traspas1To2btn = new System.Windows.Forms.Button();
            this.traspas2To1btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contenidotxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // list1
            // 
            this.list1.FormattingEnabled = true;
            this.list1.Location = new System.Drawing.Point(72, 115);
            this.list1.Name = "list1";
            this.list1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.list1.Size = new System.Drawing.Size(120, 251);
            this.list1.TabIndex = 0;
            // 
            // list2
            // 
            this.list2.FormattingEnabled = true;
            this.list2.Location = new System.Drawing.Point(293, 115);
            this.list2.Name = "list2";
            this.list2.Size = new System.Drawing.Size(120, 251);
            this.list2.TabIndex = 1;
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(207, 41);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 2;
            this.addbtn.Text = "añadir";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // quitarbtn
            // 
            this.quitarbtn.Location = new System.Drawing.Point(198, 185);
            this.quitarbtn.Name = "quitarbtn";
            this.quitarbtn.Size = new System.Drawing.Size(84, 23);
            this.quitarbtn.TabIndex = 3;
            this.quitarbtn.Text = "quitar";
            this.quitarbtn.UseVisualStyleBackColor = true;
            this.quitarbtn.Click += new System.EventHandler(this.quitarbtn_Click);
            // 
            // traspas1To2btn
            // 
            this.traspas1To2btn.Location = new System.Drawing.Point(198, 214);
            this.traspas1To2btn.Name = "traspas1To2btn";
            this.traspas1To2btn.Size = new System.Drawing.Size(84, 34);
            this.traspas1To2btn.TabIndex = 4;
            this.traspas1To2btn.Text = "Traspasar 1-2";
            this.traspas1To2btn.UseVisualStyleBackColor = true;
            this.traspas1To2btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // traspas2To1btn
            // 
            this.traspas2To1btn.Location = new System.Drawing.Point(198, 254);
            this.traspas2To1btn.Name = "traspas2To1btn";
            this.traspas2To1btn.Size = new System.Drawing.Size(84, 34);
            this.traspas2To1btn.TabIndex = 5;
            this.traspas2To1btn.Text = "Traspasar 2-1";
            this.traspas2To1btn.UseVisualStyleBackColor = true;
            this.traspas2To1btn.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lista 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lista 2";
            // 
            // contenidotxt
            // 
            this.contenidotxt.Location = new System.Drawing.Point(8, 41);
            this.contenidotxt.Name = "contenidotxt";
            this.contenidotxt.Size = new System.Drawing.Size(193, 20);
            this.contenidotxt.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Escriba aqui lo que quiere añadir";
            // 
            // Form1
            // 
            this.AcceptButton = this.addbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.contenidotxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.traspas2To1btn);
            this.Controls.Add(this.traspas1To2btn);
            this.Controls.Add(this.quitarbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.list2);
            this.Controls.Add(this.list1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ejercicio 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list1;
        private System.Windows.Forms.ListBox list2;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button quitarbtn;
        private System.Windows.Forms.Button traspas1To2btn;
        private System.Windows.Forms.Button traspas2To1btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox contenidotxt;
        private System.Windows.Forms.Label label3;
    }
}

