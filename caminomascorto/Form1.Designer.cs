namespace caminomascorto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmoDeWarshallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciclosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caminosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excentricidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pantalla = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(732, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algoritmoDeWarshallToolStripMenuItem,
            this.ciclosToolStripMenuItem,
            this.caminosToolStripMenuItem,
            this.excentricidadToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // algoritmoDeWarshallToolStripMenuItem
            // 
            this.algoritmoDeWarshallToolStripMenuItem.Name = "algoritmoDeWarshallToolStripMenuItem";
            this.algoritmoDeWarshallToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.algoritmoDeWarshallToolStripMenuItem.Text = "Algoritmo de Warshall";
            this.algoritmoDeWarshallToolStripMenuItem.Click += new System.EventHandler(this.algoritmoDeWarshallToolStripMenuItem_Click);
            // 
            // ciclosToolStripMenuItem
            // 
            this.ciclosToolStripMenuItem.Name = "ciclosToolStripMenuItem";
            this.ciclosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.ciclosToolStripMenuItem.Text = "Ciclos";
            // 
            // caminosToolStripMenuItem
            // 
            this.caminosToolStripMenuItem.Name = "caminosToolStripMenuItem";
            this.caminosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.caminosToolStripMenuItem.Text = "Caminos";
            // 
            // excentricidadToolStripMenuItem
            // 
            this.excentricidadToolStripMenuItem.Name = "excentricidadToolStripMenuItem";
            this.excentricidadToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.excentricidadToolStripMenuItem.Text = "Excentricidad";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 223);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pantalla
            // 
            this.pantalla.Location = new System.Drawing.Point(400, 42);
            this.pantalla.Multiline = true;
            this.pantalla.Name = "pantalla";
            this.pantalla.Size = new System.Drawing.Size(85, 223);
            this.pantalla.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 329);
            this.Controls.Add(this.pantalla);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmoDeWarshallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciclosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caminosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excentricidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox pantalla;
    }
}

