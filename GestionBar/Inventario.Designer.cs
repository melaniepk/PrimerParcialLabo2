namespace GestionBar
{
    partial class Inventario
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
            this.lblEstadoStComi = new System.Windows.Forms.Label();
            this.dgvEstadoStComi = new System.Windows.Forms.DataGridView();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblReponer = new System.Windows.Forms.Label();
            this.cmbComidas = new System.Windows.Forms.ComboBox();
            this.txbCantidadComi = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvEstadoStBebi = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarBebi = new System.Windows.Forms.Button();
            this.txbCantidadBebi = new System.Windows.Forms.TextBox();
            this.cmbBebidas = new System.Windows.Forms.ComboBox();
            this.lblReponerBebi = new System.Windows.Forms.Label();
            this.lblEstadoStBebi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoStComi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoStBebi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEstadoStComi
            // 
            this.lblEstadoStComi.AutoSize = true;
            this.lblEstadoStComi.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEstadoStComi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEstadoStComi.Location = new System.Drawing.Point(53, 27);
            this.lblEstadoStComi.Name = "lblEstadoStComi";
            this.lblEstadoStComi.Size = new System.Drawing.Size(213, 20);
            this.lblEstadoStComi.TabIndex = 0;
            this.lblEstadoStComi.Text = "Estado del Stock Comidas";
            // 
            // dgvEstadoStComi
            // 
            this.dgvEstadoStComi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadoStComi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.producto,
            this.stock});
            this.dgvEstadoStComi.Location = new System.Drawing.Point(53, 61);
            this.dgvEstadoStComi.Name = "dgvEstadoStComi";
            this.dgvEstadoStComi.RowTemplate.Height = 25;
            this.dgvEstadoStComi.Size = new System.Drawing.Size(240, 150);
            this.dgvEstadoStComi.TabIndex = 1;
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            // 
            // stock
            // 
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            // 
            // lblReponer
            // 
            this.lblReponer.AutoSize = true;
            this.lblReponer.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReponer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblReponer.Location = new System.Drawing.Point(374, 27);
            this.lblReponer.Name = "lblReponer";
            this.lblReponer.Size = new System.Drawing.Size(149, 20);
            this.lblReponer.TabIndex = 2;
            this.lblReponer.Text = "Reponer Comidas";
            // 
            // cmbComidas
            // 
            this.cmbComidas.BackColor = System.Drawing.Color.RoyalBlue;
            this.cmbComidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComidas.FormattingEnabled = true;
            this.cmbComidas.Location = new System.Drawing.Point(374, 61);
            this.cmbComidas.Name = "cmbComidas";
            this.cmbComidas.Size = new System.Drawing.Size(151, 23);
            this.cmbComidas.TabIndex = 3;
            // 
            // txbCantidadComi
            // 
            this.txbCantidadComi.Location = new System.Drawing.Point(374, 90);
            this.txbCantidadComi.Name = "txbCantidadComi";
            this.txbCantidadComi.PlaceholderText = "Cantidad a Reponer";
            this.txbCantidadComi.Size = new System.Drawing.Size(151, 23);
            this.txbCantidadComi.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.Location = new System.Drawing.Point(374, 177);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(151, 34);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar al Stock";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvEstadoStBebi
            // 
            this.dgvEstadoStBebi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadoStBebi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvEstadoStBebi.Location = new System.Drawing.Point(53, 266);
            this.dgvEstadoStBebi.Name = "dgvEstadoStBebi";
            this.dgvEstadoStBebi.RowTemplate.Height = 25;
            this.dgvEstadoStBebi.Size = new System.Drawing.Size(240, 150);
            this.dgvEstadoStBebi.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Stock";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // btnAgregarBebi
            // 
            this.btnAgregarBebi.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAgregarBebi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarBebi.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarBebi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregarBebi.Location = new System.Drawing.Point(374, 382);
            this.btnAgregarBebi.Name = "btnAgregarBebi";
            this.btnAgregarBebi.Size = new System.Drawing.Size(151, 34);
            this.btnAgregarBebi.TabIndex = 10;
            this.btnAgregarBebi.Text = "Agregar al Stock";
            this.btnAgregarBebi.UseVisualStyleBackColor = false;
            this.btnAgregarBebi.Click += new System.EventHandler(this.btnAgregarBebi_Click);
            // 
            // txbCantidadBebi
            // 
            this.txbCantidadBebi.Location = new System.Drawing.Point(374, 295);
            this.txbCantidadBebi.Name = "txbCantidadBebi";
            this.txbCantidadBebi.PlaceholderText = "Cantidad a Reponer";
            this.txbCantidadBebi.Size = new System.Drawing.Size(151, 23);
            this.txbCantidadBebi.TabIndex = 9;
            // 
            // cmbBebidas
            // 
            this.cmbBebidas.BackColor = System.Drawing.Color.RoyalBlue;
            this.cmbBebidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBebidas.FormattingEnabled = true;
            this.cmbBebidas.Location = new System.Drawing.Point(374, 266);
            this.cmbBebidas.Name = "cmbBebidas";
            this.cmbBebidas.Size = new System.Drawing.Size(151, 23);
            this.cmbBebidas.TabIndex = 8;
            // 
            // lblReponerBebi
            // 
            this.lblReponerBebi.AutoSize = true;
            this.lblReponerBebi.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReponerBebi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblReponerBebi.Location = new System.Drawing.Point(374, 237);
            this.lblReponerBebi.Name = "lblReponerBebi";
            this.lblReponerBebi.Size = new System.Drawing.Size(144, 20);
            this.lblReponerBebi.TabIndex = 7;
            this.lblReponerBebi.Text = "Reponer Bebidas";
            // 
            // lblEstadoStBebi
            // 
            this.lblEstadoStBebi.AutoSize = true;
            this.lblEstadoStBebi.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEstadoStBebi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEstadoStBebi.Location = new System.Drawing.Point(53, 237);
            this.lblEstadoStBebi.Name = "lblEstadoStBebi";
            this.lblEstadoStBebi.Size = new System.Drawing.Size(208, 20);
            this.lblEstadoStBebi.TabIndex = 11;
            this.lblEstadoStBebi.Text = "Estado del Stock Bebidas";
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(599, 470);
            this.Controls.Add(this.lblEstadoStBebi);
            this.Controls.Add(this.btnAgregarBebi);
            this.Controls.Add(this.txbCantidadBebi);
            this.Controls.Add(this.cmbBebidas);
            this.Controls.Add(this.lblReponerBebi);
            this.Controls.Add(this.dgvEstadoStBebi);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txbCantidadComi);
            this.Controls.Add(this.cmbComidas);
            this.Controls.Add(this.lblReponer);
            this.Controls.Add(this.dgvEstadoStComi);
            this.Controls.Add(this.lblEstadoStComi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Inventario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoStComi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoStBebi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstadoStComi;
        private System.Windows.Forms.DataGridView dgvEstadoStComi;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.Label lblReponer;
        private System.Windows.Forms.ComboBox cmbComidas;
        private System.Windows.Forms.TextBox txbCantidadComi;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvEstadoStBebi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnAgregarBebi;
        private System.Windows.Forms.TextBox txbCantidadBebi;
        private System.Windows.Forms.ComboBox cmbBebidas;
        private System.Windows.Forms.Label lblReponerBebi;
        private System.Windows.Forms.Label lblEstadoStBebi;
    }
}