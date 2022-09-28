namespace pryTorresEjercicioPorResolver
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnsPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsCargar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCargarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.picLogoEmresa = new System.Windows.Forms.PictureBox();
            this.lblVenkaktus = new System.Windows.Forms.Label();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoEmresa)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsPrincipal
            // 
            this.mnsPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi,
            this.vendedoresToolStripMenuItem,
            this.ventasToolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.mnsPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnsPrincipal.Name = "mnsPrincipal";
            this.mnsPrincipal.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnsPrincipal.Size = new System.Drawing.Size(594, 24);
            this.mnsPrincipal.TabIndex = 0;
            this.mnsPrincipal.Text = "menuStrip1";
            // 
            // tsmi
            // 
            this.tsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsCargar});
            this.tsmi.Name = "tsmi";
            this.tsmi.Size = new System.Drawing.Size(61, 20);
            this.tsmi.Text = "Clientes";
            this.tsmi.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // mnsCargar
            // 
            this.mnsCargar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCargarCliente});
            this.mnsCargar.Name = "mnsCargar";
            this.mnsCargar.Size = new System.Drawing.Size(109, 22);
            this.mnsCargar.Text = "Cargar";
            this.mnsCargar.Click += new System.EventHandler(this.cargarToolStripMenuItem_Click);
            // 
            // tsmiCargarCliente
            // 
            this.tsmiCargarCliente.Name = "tsmiCargarCliente";
            this.tsmiCargarCliente.Size = new System.Drawing.Size(111, 22);
            this.tsmiCargarCliente.Text = "Cliente";
            this.tsmiCargarCliente.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // vendedoresToolStripMenuItem
            // 
            this.vendedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarToolStripMenuItem});
            this.vendedoresToolStripMenuItem.Name = "vendedoresToolStripMenuItem";
            this.vendedoresToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.vendedoresToolStripMenuItem.Text = "Vendedores";
            // 
            // cargarToolStripMenuItem
            // 
            this.cargarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendedorToolStripMenuItem});
            this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            this.cargarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.cargarToolStripMenuItem.Text = "Cargar";
            // 
            // vendedorToolStripMenuItem
            // 
            this.vendedorToolStripMenuItem.Name = "vendedorToolStripMenuItem";
            this.vendedorToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.vendedorToolStripMenuItem.Text = "Vendedor";
            this.vendedorToolStripMenuItem.Click += new System.EventHandler(this.vendedorToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem1
            // 
            this.ventasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarToolStripMenuItem1,
            this.consultarToolStripMenuItem});
            this.ventasToolStripMenuItem1.Name = "ventasToolStripMenuItem1";
            this.ventasToolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.ventasToolStripMenuItem1.Text = "Ventas";
            // 
            // cargarToolStripMenuItem1
            // 
            this.cargarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem});
            this.cargarToolStripMenuItem1.Name = "cargarToolStripMenuItem1";
            this.cargarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.cargarToolStripMenuItem1.Text = "Cargar";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click_1);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem2});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // ventasToolStripMenuItem2
            // 
            this.ventasToolStripMenuItem2.Name = "ventasToolStripMenuItem2";
            this.ventasToolStripMenuItem2.Size = new System.Drawing.Size(108, 22);
            this.ventasToolStripMenuItem2.Text = "Ventas";
            this.ventasToolStripMenuItem2.Click += new System.EventHandler(this.ventasToolStripMenuItem2_Click);
            // 
            // picLogoEmresa
            // 
            this.picLogoEmresa.Image = ((System.Drawing.Image)(resources.GetObject("picLogoEmresa.Image")));
            this.picLogoEmresa.Location = new System.Drawing.Point(68, 92);
            this.picLogoEmresa.Margin = new System.Windows.Forms.Padding(2);
            this.picLogoEmresa.Name = "picLogoEmresa";
            this.picLogoEmresa.Size = new System.Drawing.Size(451, 359);
            this.picLogoEmresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoEmresa.TabIndex = 1;
            this.picLogoEmresa.TabStop = false;
            // 
            // lblVenkaktus
            // 
            this.lblVenkaktus.AutoSize = true;
            this.lblVenkaktus.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenkaktus.Location = new System.Drawing.Point(192, 42);
            this.lblVenkaktus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVenkaktus.Name = "lblVenkaktus";
            this.lblVenkaktus.Size = new System.Drawing.Size(212, 46);
            this.lblVenkaktus.TabIndex = 2;
            this.lblVenkaktus.Text = "VenKaktus";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 461);
            this.Controls.Add(this.lblVenkaktus);
            this.Controls.Add(this.picLogoEmresa);
            this.Controls.Add(this.mnsPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsPrincipal;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "VenKaktus";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnsPrincipal.ResumeLayout(false);
            this.mnsPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoEmresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmi;
        private System.Windows.Forms.ToolStripMenuItem mnsCargar;
        private System.Windows.Forms.ToolStripMenuItem tsmiCargarCliente;
        private System.Windows.Forms.PictureBox picLogoEmresa;
        private System.Windows.Forms.Label lblVenkaktus;
        private System.Windows.Forms.ToolStripMenuItem vendedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

