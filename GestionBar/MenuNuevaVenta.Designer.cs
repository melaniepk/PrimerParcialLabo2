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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblNroMesa = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbBebidas = new System.Windows.Forms.ComboBox();
            this.cmbComidas = new System.Windows.Forms.ComboBox();
            this.lblBebidas = new System.Windows.Forms.Label();
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
            this.lblTamanioBebida = new System.Windows.Forms.Label();
            this.lblTamanioComida = new System.Windows.Forms.Label();
            this.cmbTamanioBebi = new System.Windows.Forms.ComboBox();
            this.cmbTamanioComi = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblVendedor);
            this.panel1.Controls.Add(this.lblNroMesa);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 123);
            this.panel1.TabIndex = 0;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVendedor.Location = new System.Drawing.Point(14, 81);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(0, 20);
            this.lblVendedor.TabIndex = 2;
            // 
            // lblNroMesa
            // 
            this.lblNroMesa.AutoSize = true;
            this.lblNroMesa.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNroMesa.Location = new System.Drawing.Point(14, 52);
            this.lblNroMesa.Name = "lblNroMesa";
            this.lblNroMesa.Size = new System.Drawing.Size(0, 20);
            this.lblNroMesa.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Nombre del cliente";
            this.textBox1.Size = new System.Drawing.Size(187, 23);
            this.textBox1.TabIndex = 0;
            // 
            // cmbBebidas
            // 
            this.cmbBebidas.FormattingEnabled = true;
            this.cmbBebidas.Location = new System.Drawing.Point(12, 184);
            this.cmbBebidas.Name = "cmbBebidas";
            this.cmbBebidas.Size = new System.Drawing.Size(187, 23);
            this.cmbBebidas.TabIndex = 1;
            // 
            // cmbComidas
            // 
            this.cmbComidas.FormattingEnabled = true;
            this.cmbComidas.Location = new System.Drawing.Point(12, 261);
            this.cmbComidas.Name = "cmbComidas";
            this.cmbComidas.Size = new System.Drawing.Size(187, 23);
            this.cmbComidas.TabIndex = 2;
            // 
            // lblBebidas
            // 
            this.lblBebidas.AutoSize = true;
            this.lblBebidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBebidas.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBebidas.Location = new System.Drawing.Point(12, 152);
            this.lblBebidas.Name = "lblBebidas";
            this.lblBebidas.Size = new System.Drawing.Size(72, 20);
            this.lblBebidas.TabIndex = 3;
            this.lblBebidas.Text = "Bebidas";
            // 
            // lblComidas
            // 
            this.lblComidas.AutoSize = true;
            this.lblComidas.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblComidas.Location = new System.Drawing.Point(12, 228);
            this.lblComidas.Name = "lblComidas";
            this.lblComidas.Size = new System.Drawing.Size(77, 20);
            this.lblComidas.TabIndex = 4;
            this.lblComidas.Text = "Comidas";
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
            this.lblTotal.Location = new System.Drawing.Point(360, 388);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(122, 36);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total $:";
            // 
            // btnAgregarPedido
            // 
            this.btnAgregarPedido.Location = new System.Drawing.Point(12, 307);
            this.btnAgregarPedido.Name = "btnAgregarPedido";
            this.btnAgregarPedido.Size = new System.Drawing.Size(138, 61);
            this.btnAgregarPedido.TabIndex = 7;
            this.btnAgregarPedido.Text = "Agregar al Pedido";
            this.btnAgregarPedido.UseVisualStyleBackColor = true;
            this.btnAgregarPedido.Click += new System.EventHandler(this.btnAgregarPedido_Click);
            // 
            // btnCerrarVenta
            // 
            this.btnCerrarVenta.Location = new System.Drawing.Point(172, 307);
            this.btnCerrarVenta.Name = "btnCerrarVenta";
            this.btnCerrarVenta.Size = new System.Drawing.Size(138, 61);
            this.btnCerrarVenta.TabIndex = 8;
            this.btnCerrarVenta.Text = "Cerrar Venta";
            this.btnCerrarVenta.UseVisualStyleBackColor = true;
            this.btnCerrarVenta.Click += new System.EventHandler(this.btnCerrarVenta_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(89, 382);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(138, 61);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
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
            this.dgvPedido.RowTemplate.Height = 25;
            this.dgvPedido.Size = new System.Drawing.Size(412, 167);
            this.dgvPedido.TabIndex = 10;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Tamaño
            // 
            this.Tamaño.HeaderText = "Tamaño";
            this.Tamaño.Name = "Tamaño";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // lblTamanioBebida
            // 
            this.lblTamanioBebida.AutoSize = true;
            this.lblTamanioBebida.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTamanioBebida.Location = new System.Drawing.Point(214, 152);
            this.lblTamanioBebida.Name = "lblTamanioBebida";
            this.lblTamanioBebida.Size = new System.Drawing.Size(71, 20);
            this.lblTamanioBebida.TabIndex = 11;
            this.lblTamanioBebida.Text = "Tamaño";
            // 
            // lblTamanioComida
            // 
            this.lblTamanioComida.AutoSize = true;
            this.lblTamanioComida.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTamanioComida.Location = new System.Drawing.Point(214, 228);
            this.lblTamanioComida.Name = "lblTamanioComida";
            this.lblTamanioComida.Size = new System.Drawing.Size(71, 20);
            this.lblTamanioComida.TabIndex = 12;
            this.lblTamanioComida.Text = "Tamaño";
            // 
            // cmbTamanioBebi
            // 
            this.cmbTamanioBebi.FormattingEnabled = true;
            this.cmbTamanioBebi.Location = new System.Drawing.Point(214, 184);
            this.cmbTamanioBebi.Name = "cmbTamanioBebi";
            this.cmbTamanioBebi.Size = new System.Drawing.Size(95, 23);
            this.cmbTamanioBebi.TabIndex = 13;
            this.cmbTamanioBebi.SelectedIndexChanged += new System.EventHandler(this.cmbTamanioBebi_SelectedIndexChanged);
            // 
            // cmbTamanioComi
            // 
            this.cmbTamanioComi.FormattingEnabled = true;
            this.cmbTamanioComi.Location = new System.Drawing.Point(214, 261);
            this.cmbTamanioComi.Name = "cmbTamanioComi";
            this.cmbTamanioComi.Size = new System.Drawing.Size(96, 23);
            this.cmbTamanioComi.TabIndex = 14;
            // 
            // MenuNuevaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 459);
            this.Controls.Add(this.cmbTamanioComi);
            this.Controls.Add(this.cmbTamanioBebi);
            this.Controls.Add(this.lblTamanioComida);
            this.Controls.Add(this.lblTamanioBebida);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCerrarVenta);
            this.Controls.Add(this.btnAgregarPedido);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.rtbPedido);
            this.Controls.Add(this.lblComidas);
            this.Controls.Add(this.lblBebidas);
            this.Controls.Add(this.cmbComidas);
            this.Controls.Add(this.cmbBebidas);
            this.Controls.Add(this.panel1);
            this.Name = "MenuNuevaVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "5";
            this.Text = "MenuNuevaVenta";
            this.Load += new System.EventHandler(this.MenuNuevaVenta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblNroMesa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbBebidas;
        private System.Windows.Forms.ComboBox cmbComidas;
        private System.Windows.Forms.Label lblBebidas;
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
        private System.Windows.Forms.Label lblTamanioBebida;
        private System.Windows.Forms.Label lblTamanioComida;
        private System.Windows.Forms.ComboBox cmbTamanioBebi;
        private System.Windows.Forms.ComboBox cmbTamanioComi;
    }
}