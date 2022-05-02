
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
            this.list1Contentlbl = new System.Windows.Forms.Label();
            this.list1Selectedlbl = new System.Windows.Forms.Label();
            this.exitbtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lista1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.traspasarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lista2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traspasarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // list1
            // 
            this.list1.FormattingEnabled = true;
            this.list1.Location = new System.Drawing.Point(72, 145);
            this.list1.Name = "list1";
            this.list1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.list1.Size = new System.Drawing.Size(120, 251);
            this.list1.TabIndex = 2;
            this.list1.SelectedIndexChanged += new System.EventHandler(this.list1_SelectedIndexChanged);
            // 
            // list2
            // 
            this.list2.FormattingEnabled = true;
            this.list2.Location = new System.Drawing.Point(288, 145);
            this.list2.Name = "list2";
            this.list2.Size = new System.Drawing.Size(120, 251);
            this.list2.TabIndex = 5;
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(207, 41);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 1;
            this.addbtn.Text = "añadir";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // quitarbtn
            // 
            this.quitarbtn.Location = new System.Drawing.Point(198, 185);
            this.quitarbtn.Name = "quitarbtn";
            this.quitarbtn.Size = new System.Drawing.Size(84, 23);
            this.quitarbtn.TabIndex = 10;
            this.quitarbtn.TabStop = false;
            this.quitarbtn.Text = "quitar";
            this.quitarbtn.UseVisualStyleBackColor = true;
            this.quitarbtn.Click += new System.EventHandler(this.quitarbtn_Click);
            // 
            // traspas1To2btn
            // 
            this.traspas1To2btn.Location = new System.Drawing.Point(198, 214);
            this.traspas1To2btn.Name = "traspas1To2btn";
            this.traspas1To2btn.Size = new System.Drawing.Size(84, 34);
            this.traspas1To2btn.TabIndex = 3;
            this.traspas1To2btn.Text = "Traspasar 1-2";
            this.traspas1To2btn.UseVisualStyleBackColor = true;
            this.traspas1To2btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // traspas2To1btn
            // 
            this.traspas2To1btn.Location = new System.Drawing.Point(198, 254);
            this.traspas2To1btn.Name = "traspas2To1btn";
            this.traspas2To1btn.Size = new System.Drawing.Size(84, 34);
            this.traspas2To1btn.TabIndex = 4;
            this.traspas2To1btn.Text = "Traspasar 2-1";
            this.traspas2To1btn.UseVisualStyleBackColor = true;
            this.traspas2To1btn.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lista 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lista 2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contenidotxt
            // 
            this.contenidotxt.Location = new System.Drawing.Point(8, 41);
            this.contenidotxt.Name = "contenidotxt";
            this.contenidotxt.Size = new System.Drawing.Size(193, 20);
            this.contenidotxt.TabIndex = 0;
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
            // list1Contentlbl
            // 
            this.list1Contentlbl.AutoSize = true;
            this.list1Contentlbl.Location = new System.Drawing.Point(58, 90);
            this.list1Contentlbl.Name = "list1Contentlbl";
            this.list1Contentlbl.Size = new System.Drawing.Size(0, 13);
            this.list1Contentlbl.TabIndex = 10;
            // 
            // list1Selectedlbl
            // 
            this.list1Selectedlbl.AutoSize = true;
            this.list1Selectedlbl.Location = new System.Drawing.Point(58, 112);
            this.list1Selectedlbl.Name = "list1Selectedlbl";
            this.list1Selectedlbl.Size = new System.Drawing.Size(0, 13);
            this.list1Selectedlbl.TabIndex = 11;
            // 
            // exitbtn
            // 
            this.exitbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitbtn.Location = new System.Drawing.Point(481, 415);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(75, 23);
            this.exitbtn.TabIndex = 12;
            this.exitbtn.Text = "Salir";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lista1ToolStripMenuItem,
            this.lista2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(565, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lista1ToolStripMenuItem
            // 
            this.lista1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddMenuItem,
            this.quitarToolStripMenuItem1,
            this.traspasarToolStripMenuItem});
            this.lista1ToolStripMenuItem.Name = "lista1ToolStripMenuItem";
            this.lista1ToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.lista1ToolStripMenuItem.Text = "&Lista 1";
            // 
            // AddMenuItem
            // 
            this.AddMenuItem.Name = "AddMenuItem";
            this.AddMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.A)));
            this.AddMenuItem.Size = new System.Drawing.Size(174, 22);
            this.AddMenuItem.Text = "&Añadir";
            this.AddMenuItem.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // quitarToolStripMenuItem1
            // 
            this.quitarToolStripMenuItem1.Name = "quitarToolStripMenuItem1";
            this.quitarToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D)));
            this.quitarToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.quitarToolStripMenuItem1.Text = "&Quitar";
            this.quitarToolStripMenuItem1.Click += new System.EventHandler(this.quitarbtn_Click);
            // 
            // traspasarToolStripMenuItem
            // 
            this.traspasarToolStripMenuItem.Name = "traspasarToolStripMenuItem";
            this.traspasarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.traspasarToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.traspasarToolStripMenuItem.Text = "&Traspasar";
            this.traspasarToolStripMenuItem.Click += new System.EventHandler(this.button3_Click);
            // 
            // lista2ToolStripMenuItem
            // 
            this.lista2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.traspasarToolStripMenuItem1});
            this.lista2ToolStripMenuItem.Name = "lista2ToolStripMenuItem";
            this.lista2ToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.lista2ToolStripMenuItem.Text = "L&ista 2";
            // 
            // traspasarToolStripMenuItem1
            // 
            this.traspasarToolStripMenuItem1.Name = "traspasarToolStripMenuItem1";
            this.traspasarToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.T)));
            this.traspasarToolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
            this.traspasarToolStripMenuItem1.Text = "T&raspasar";
            this.traspasarToolStripMenuItem1.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.addbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitbtn;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.list1Selectedlbl);
            this.Controls.Add(this.list1Contentlbl);
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
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Ejercicio 5";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Label list1Contentlbl;
        private System.Windows.Forms.Label list1Selectedlbl;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lista1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem traspasarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lista2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traspasarToolStripMenuItem1;
    }
}

