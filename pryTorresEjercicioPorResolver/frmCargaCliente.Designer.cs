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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargaCliente));
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
            this.mskIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskIdCliente.Location = new System.Drawing.Point(84, 44);
            this.mskIdCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskIdCliente.Mask = "9999";
            this.mskIdCliente.Name = "mskIdCliente";
            this.mskIdCliente.Size = new System.Drawing.Size(68, 24);
            this.mskIdCliente.TabIndex = 11;
            this.mskIdCliente.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskIdCliente_MaskInputRejected);
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCliente.Location = new System.Drawing.Point(84, 45);
            this.txtIdCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(68, 24);
            this.txtIdCliente.TabIndex = 10;
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCliente.Location = new System.Drawing.Point(12, 44);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(26, 18);
            this.lblIdCliente.TabIndex = 9;
            this.lblIdCliente.Text = "ID:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(84, 11);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreCliente.MaxLength = 30;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(172, 24);
            this.txtNombreCliente.TabIndex = 8;
            this.txtNombreCliente.TextChanged += new System.EventHandler(this.txtNombreCliente_TextChanged);
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(12, 11);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(66, 18);
            this.lblNombreCliente.TabIndex = 7;
            this.lblNombreCliente.Text = "Nombre:";
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(182, 82);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(74, 28);
            this.btnCargar.TabIndex = 12;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // frmCargaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 122);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.mskIdCliente);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.lblIdCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.lblNombreCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCargaCliente";
            this.Text = "Carga Cliente";
            this.Load += new System.EventHandler(this.frmCargaCliente_Load);
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