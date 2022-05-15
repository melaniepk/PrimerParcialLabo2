namespace GestionBar
{
    partial class Personal
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
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.nombreEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDuenios = new System.Windows.Forms.DataGridView();
            this.nombreDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEmp = new System.Windows.Forms.Label();
            this.lblDue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuenios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreEmp,
            this.idEmp});
            this.dgvEmpleados.Location = new System.Drawing.Point(41, 68);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowTemplate.Height = 25;
            this.dgvEmpleados.Size = new System.Drawing.Size(240, 150);
            this.dgvEmpleados.TabIndex = 0;
            // 
            // nombreEmp
            // 
            this.nombreEmp.HeaderText = "Nombre";
            this.nombreEmp.Name = "nombreEmp";
            this.nombreEmp.ReadOnly = true;
            // 
            // idEmp
            // 
            this.idEmp.HeaderText = "ID Empleado";
            this.idEmp.Name = "idEmp";
            this.idEmp.ReadOnly = true;
            // 
            // dgvDuenios
            // 
            this.dgvDuenios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDuenios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDue,
            this.idDue});
            this.dgvDuenios.Location = new System.Drawing.Point(326, 68);
            this.dgvDuenios.Name = "dgvDuenios";
            this.dgvDuenios.Size = new System.Drawing.Size(240, 150);
            this.dgvDuenios.TabIndex = 1;
            // 
            // nombreDue
            // 
            this.nombreDue.HeaderText = "Nombre";
            this.nombreDue.Name = "nombreDue";
            this.nombreDue.ReadOnly = true;
            // 
            // idDue
            // 
            this.idDue.HeaderText = "ID Dueño";
            this.idDue.Name = "idDue";
            this.idDue.ReadOnly = true;
            // 
            // lblEmp
            // 
            this.lblEmp.AutoSize = true;
            this.lblEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(79)))));
            this.lblEmp.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEmp.Location = new System.Drawing.Point(41, 32);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.Size = new System.Drawing.Size(162, 20);
            this.lblEmp.TabIndex = 2;
            this.lblEmp.Text = "Lista de Empleados";
            // 
            // lblDue
            // 
            this.lblDue.AutoSize = true;
            this.lblDue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(79)))));
            this.lblDue.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDue.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDue.Location = new System.Drawing.Point(326, 32);
            this.lblDue.Name = "lblDue";
            this.lblDue.Size = new System.Drawing.Size(137, 20);
            this.lblDue.TabIndex = 3;
            this.lblDue.Text = "Lista de Dueños";
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(613, 289);
            this.Controls.Add(this.lblDue);
            this.Controls.Add(this.lblEmp);
            this.Controls.Add(this.dgvDuenios);
            this.Controls.Add(this.dgvEmpleados);
            this.Name = "Personal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuenios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmp;
        private System.Windows.Forms.DataGridView dgvDuenios;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDue;
        private System.Windows.Forms.Label lblEmp;
        private System.Windows.Forms.Label lblDue;
    }
}