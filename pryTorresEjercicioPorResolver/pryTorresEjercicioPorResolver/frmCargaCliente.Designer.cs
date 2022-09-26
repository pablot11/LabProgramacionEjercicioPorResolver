namespace pryTorresEjercicioPorResolver
{
    partial class frmCargaCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mskIdCliente = new System.Windows.Forms.MaskedTextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mskIdCliente
            // 
            this.mskIdCliente.Location = new System.Drawing.Point(58, 46);
            this.mskIdCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskIdCliente.Mask = "9999";
            this.mskIdCliente.Name = "mskIdCliente";
            this.mskIdCliente.Size = new System.Drawing.Size(76, 20);
            this.mskIdCliente.TabIndex = 11;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(58, 47);
            this.txtIdCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(76, 20);
            this.txtIdCliente.TabIndex = 10;
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Location = new System.Drawing.Point(9, 47);
            this.lblIdCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(47, 13);
            this.lblIdCliente.TabIndex = 9;
            this.lblIdCliente.Text = "Numero:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(58, 7);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(76, 20);
            this.txtNombreCliente.TabIndex = 8;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(9, 7);
            this.lblNombreCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(47, 13);
            this.lblNombreCliente.TabIndex = 7;
            this.lblNombreCliente.Text = "Nombre:";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(76, 79);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(56, 19);
            this.btnCargar.TabIndex = 12;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // frmCargaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 186);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.mskIdCliente);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.lblIdCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.lblNombreCliente);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCargaCliente";
            this.Text = "Carga Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskIdCliente;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Button btnCargar;
    }
}