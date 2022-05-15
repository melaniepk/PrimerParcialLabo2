namespace GestionBar
{
    partial class MenuNuevaVenta
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
            this.cmbComidas = new System.Windows.Forms.ComboBox();
            this.lblComidas = new System.Windows.Forms.Label();
            this.rtbPedido = new System.Windows.Forms.RichTextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAgregarPedido = new System.Windows.Forms.Button();
            this.btnCerrarVenta = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tamaño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTamanioComida = new System.Windows.Forms.Label();
            this.cmbTamanioComi = new System.Windows.Forms.ComboBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblNroMesa = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTamanioBebi = new System.Windows.Forms.ComboBox();
            this.cmbBebidas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotaltxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbComidas
            // 
            this.cmbComidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(79)))));
            this.cmbComidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComidas.FormattingEnabled = true;
            this.cmbComidas.Location = new System.Drawing.Point(4, 41);
            this.cmbComidas.Name = "cmbComidas";
            this.cmbComidas.Size = new System.Drawing.Size(187, 23);
            this.cmbComidas.TabIndex = 2;
            // 
            // lblComidas
            // 
            this.lblComidas.AutoSize = true;
            this.lblComidas.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblComidas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblComidas.Location = new System.Drawing.Point(4, 17);
            this.lblComidas.Name = "lblComidas";
            this.lblComidas.Size = new System.Drawing.Size(151, 21);
            this.lblComidas.TabIndex = 4;
            this.lblComidas.Text = "Menu Comidas";
            // 
            // rtbPedido
            // 
            this.rtbPedido.Location = new System.Drawing.Point(360, 12);
            this.rtbPedido.Name = "rtbPedido";
            this.rtbPedido.Size = new System.Drawing.Size(412, 167);
            this.rtbPedido.TabIndex = 5;
            this.rtbPedido.Text = "";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotal.Location = new System.Drawing.Point(488, 392);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 36);
            this.lblTotal.TabIndex = 6;
            // 
            // btnAgregarPedido
            // 
            this.btnAgregarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(79)))));
            this.btnAgregarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPedido.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarPedido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregarPedido.Location = new System.Drawing.Point(13, 181);
            this.btnAgregarPedido.Name = "btnAgregarPedido";
            this.btnAgregarPedido.Size = new System.Drawing.Size(138, 61);
            this.btnAgregarPedido.TabIndex = 7;
            this.btnAgregarPedido.Text = "Agregar al Pedido";
            this.btnAgregarPedido.UseVisualStyleBackColor = false;
            this.btnAgregarPedido.Click += new System.EventHandler(this.btnAgregarPedido_Click);
            // 
            // btnCerrarVenta
            // 
            this.btnCerrarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(79)))));
            this.btnCerrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarVenta.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerrarVenta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCerrarVenta.Location = new System.Drawing.Point(185, 181);
            this.btnCerrarVenta.Name = "btnCerrarVenta";
            this.btnCerrarVenta.Size = new System.Drawing.Size(138, 61);
            this.btnCerrarVenta.TabIndex = 8;
            this.btnCerrarVenta.Text = "Cerrar Venta";
            this.btnCerrarVenta.UseVisualStyleBackColor = false;
            this.btnCerrarVenta.Click += new System.EventHandler(this.btnCerrarVenta_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(79)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.Location = new System.Drawing.Point(103, 248);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(138, 61);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvPedido
            // 
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Cantidad,
            this.Tamaño,
            this.Precio});
            this.dgvPedido.Location = new System.Drawing.Point(360, 201);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.ReadOnly = true;
            this.dgvPedido.RowTemplate.Height = 25;
            this.dgvPedido.Size = new System.Drawing.Size(412, 167);
            this.dgvPedido.TabIndex = 10;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Tamaño
            // 
            this.Tamaño.HeaderText = "Tamaño";
            this.Tamaño.Name = "Tamaño";
            this.Tamaño.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // lblTamanioComida
            // 
            this.lblTamanioComida.AutoSize = true;
            this.lblTamanioComida.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTamanioComida.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTamanioComida.Location = new System.Drawing.Point(196, 17);
            this.lblTamanioComida.Name = "lblTamanioComida";
            this.lblTamanioComida.Size = new System.Drawing.Size(92, 21);
            this.lblTamanioComida.TabIndex = 12;
            this.lblTamanioComida.Text = "Tamaño ";
            // 
            // cmbTamanioComi
            // 
            this.cmbTamanioComi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(79)))));
            this.cmbTamanioComi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTamanioComi.FormattingEnabled = true;
            this.cmbTamanioComi.Location = new System.Drawing.Point(196, 41);
            this.cmbTamanioComi.Name = "cmbTamanioComi";
            this.cmbTamanioComi.Size = new System.Drawing.Size(127, 23);
            this.cmbTamanioComi.TabIndex = 14;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVendedor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblVendedor.Location = new System.Drawing.Point(3, 65);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(99, 21);
            this.lblVendedor.TabIndex = 15;
            this.lblVendedor.Text = "Vendedor";
            // 
            // lblNroMesa
            // 
            this.lblNroMesa.AutoSize = true;
            this.lblNroMesa.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNroMesa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNroMesa.Location = new System.Drawing.Point(3, 16);
            this.lblNroMesa.Name = "lblNroMesa";
            this.lblNroMesa.Size = new System.Drawing.Size(97, 21);
            this.lblNroMesa.TabIndex = 16;
            this.lblNroMesa.Text = "Nro Mesa";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.lblNroMesa);
            this.panel1.Controls.Add(this.lblVendedor);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 97);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RosyBrown;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbTamanioBebi);
            this.panel2.Controls.Add(this.btnCerrarVenta);
            this.panel2.Controls.Add(this.cmbBebidas);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.lblTamanioComida);
            this.panel2.Controls.Add(this.cmbTamanioComi);
            this.panel2.Controls.Add(this.btnAgregarPedido);
            this.panel2.Controls.Add(this.cmbComidas);
            this.panel2.Controls.Add(this.lblComidas);
            this.panel2.Location = new System.Drawing.Point(12, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 328);
            this.panel2.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(196, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tamaño";
            // 
            // cmbTamanioBebi
            // 
            this.cmbTamanioBebi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(79)))));
            this.cmbTamanioBebi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTamanioBebi.FormattingEnabled = true;
            this.cmbTamanioBebi.Location = new System.Drawing.Point(196, 99);
            this.cmbTamanioBebi.Name = "cmbTamanioBebi";
            this.cmbTamanioBebi.Size = new System.Drawing.Size(127, 23);
            this.cmbTamanioBebi.TabIndex = 18;
            // 
            // cmbBebidas
            // 
            this.cmbBebidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(79)))));
            this.cmbBebidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBebidas.FormattingEnabled = true;
            this.cmbBebidas.Location = new System.Drawing.Point(4, 99);
            this.cmbBebidas.Name = "cmbBebidas";
            this.cmbBebidas.Size = new System.Drawing.Size(187, 23);
            this.cmbBebidas.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(4, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Menu Bebidas";
            // 
            // lblTotaltxt
            // 
            this.lblTotaltxt.AutoSize = true;
            this.lblTotaltxt.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotaltxt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotaltxt.Location = new System.Drawing.Point(360, 392);
            this.lblTotaltxt.Name = "lblTotaltxt";
            this.lblTotaltxt.Size = new System.Drawing.Size(122, 36);
            this.lblTotaltxt.TabIndex = 19;
            this.lblTotaltxt.Text = "Total $:";
            // 
            // MenuNuevaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(802, 459);
            this.Controls.Add(this.lblTotaltxt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.rtbPedido);
            this.Controls.Add(this.panel2);
            this.Name = "MenuNuevaVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "5";
            this.Text = "MenuNuevaVenta";
            this.Load += new System.EventHandler(this.MenuNuevaVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbComidas;
        private System.Windows.Forms.Label lblComidas;
        private System.Windows.Forms.RichTextBox rtbPedido;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAgregarPedido;
        private System.Windows.Forms.Button btnCerrarVenta;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tamaño;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Label lblTamanioComida;
        private System.Windows.Forms.ComboBox cmbTamanioComi;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblNroMesa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTamanioBebi;
        private System.Windows.Forms.ComboBox cmbBebidas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotaltxt;
    }
}