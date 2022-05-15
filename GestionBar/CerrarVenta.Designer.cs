namespace GestionBar
{
    partial class CerrarVenta
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
            this.lblPago = new System.Windows.Forms.Label();
            this.cmbPago = new System.Windows.Forms.ComboBox();
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblVuelto = new System.Windows.Forms.Label();
            this.tbxImporte = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalNro = new System.Windows.Forms.Label();
            this.lblVueltoNro = new System.Windows.Forms.Label();
            this.ckbEstacionamiento = new System.Windows.Forms.CheckBox();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblMesaNro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPago.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPago.Location = new System.Drawing.Point(29, 37);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(133, 20);
            this.lblPago.TabIndex = 0;
            this.lblPago.Text = "Metodo de Pago";
            // 
            // cmbPago
            // 
            this.cmbPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPago.FormattingEnabled = true;
            this.cmbPago.Location = new System.Drawing.Point(29, 70);
            this.cmbPago.Name = "cmbPago";
            this.cmbPago.Size = new System.Drawing.Size(243, 23);
            this.cmbPago.TabIndex = 1;
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblImporte.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblImporte.Location = new System.Drawing.Point(172, 109);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(80, 20);
            this.lblImporte.TabIndex = 2;
            this.lblImporte.Text = "Importe: ";
            // 
            // lblVuelto
            // 
            this.lblVuelto.AutoSize = true;
            this.lblVuelto.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVuelto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblVuelto.Location = new System.Drawing.Point(29, 174);
            this.lblVuelto.Name = "lblVuelto";
            this.lblVuelto.Size = new System.Drawing.Size(80, 20);
            this.lblVuelto.TabIndex = 3;
            this.lblVuelto.Text = "Vuelto $:";
            // 
            // tbxImporte
            // 
            this.tbxImporte.Location = new System.Drawing.Point(172, 132);
            this.tbxImporte.Name = "tbxImporte";
            this.tbxImporte.Size = new System.Drawing.Size(100, 23);
            this.tbxImporte.TabIndex = 4;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotal.Location = new System.Drawing.Point(32, 109);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(67, 20);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total $:";
            // 
            // lblTotalNro
            // 
            this.lblTotalNro.AutoSize = true;
            this.lblTotalNro.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalNro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotalNro.Location = new System.Drawing.Point(32, 132);
            this.lblTotalNro.Name = "lblTotalNro";
            this.lblTotalNro.Size = new System.Drawing.Size(19, 20);
            this.lblTotalNro.TabIndex = 6;
            this.lblTotalNro.Text = "$";
            // 
            // lblVueltoNro
            // 
            this.lblVueltoNro.AutoSize = true;
            this.lblVueltoNro.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVueltoNro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblVueltoNro.Location = new System.Drawing.Point(32, 194);
            this.lblVueltoNro.Name = "lblVueltoNro";
            this.lblVueltoNro.Size = new System.Drawing.Size(19, 20);
            this.lblVueltoNro.TabIndex = 7;
            this.lblVueltoNro.Text = "$";
            // 
            // ckbEstacionamiento
            // 
            this.ckbEstacionamiento.AutoSize = true;
            this.ckbEstacionamiento.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbEstacionamiento.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ckbEstacionamiento.Location = new System.Drawing.Point(281, 70);
            this.ckbEstacionamiento.Name = "ckbEstacionamiento";
            this.ckbEstacionamiento.Size = new System.Drawing.Size(159, 24);
            this.ckbEstacionamiento.TabIndex = 8;
            this.ckbEstacionamiento.Text = "Estacionamiento";
            this.ckbEstacionamiento.UseVisualStyleBackColor = true;
            this.ckbEstacionamiento.CheckedChanged += new System.EventHandler(this.ckbEstacionamiento_CheckedChanged);
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCobrar.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCobrar.ForeColor = System.Drawing.Color.Black;
            this.btnCobrar.Location = new System.Drawing.Point(32, 262);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(111, 90);
            this.btnCobrar.TabIndex = 9;
            this.btnCobrar.Text = "Cobrar ";
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(161, 262);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(111, 90);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblMesaNro
            // 
            this.lblMesaNro.AutoSize = true;
            this.lblMesaNro.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMesaNro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMesaNro.Location = new System.Drawing.Point(29, 17);
            this.lblMesaNro.Name = "lblMesaNro";
            this.lblMesaNro.Size = new System.Drawing.Size(50, 20);
            this.lblMesaNro.TabIndex = 11;
            this.lblMesaNro.Text = "Mesa";
            // 
            // CerrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(452, 381);
            this.Controls.Add(this.lblMesaNro);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.ckbEstacionamiento);
            this.Controls.Add(this.lblVueltoNro);
            this.Controls.Add(this.lblTotalNro);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.tbxImporte);
            this.Controls.Add(this.lblVuelto);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.cmbPago);
            this.Controls.Add(this.lblPago);
            this.Name = "CerrarVenta";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CerrarVenta";
            this.Load += new System.EventHandler(this.CerrarVenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.ComboBox cmbPago;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label lblVuelto;
        private System.Windows.Forms.TextBox tbxImporte;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalNro;
        private System.Windows.Forms.Label lblVueltoNro;
        private System.Windows.Forms.CheckBox ckbEstacionamiento;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblMesaNro;
    }
}