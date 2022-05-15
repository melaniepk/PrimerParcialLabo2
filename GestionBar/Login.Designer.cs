namespace GestionBar
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUtn = new System.Windows.Forms.Label();
            this.tbxUsuario = new System.Windows.Forms.TextBox();
            this.tbxClave = new System.Windows.Forms.TextBox();
            this.lblGestion = new System.Windows.Forms.Label();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.btnRellenarDue = new System.Windows.Forms.Button();
            this.btnRellenarEmp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUtn
            // 
            this.lblUtn.AutoSize = true;
            this.lblUtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUtn.Font = new System.Drawing.Font("Book Antiqua", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblUtn.Location = new System.Drawing.Point(90, 9);
            this.lblUtn.Name = "lblUtn";
            this.lblUtn.Padding = new System.Windows.Forms.Padding(120, 30, 120, 30);
            this.lblUtn.Size = new System.Drawing.Size(617, 118);
            this.lblUtn.TabIndex = 0;
            this.lblUtn.Text = "~ Les UTN bar ~";
            this.lblUtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxUsuario
            // 
            this.tbxUsuario.BackColor = System.Drawing.Color.Thistle;
            this.tbxUsuario.ForeColor = System.Drawing.SystemColors.Info;
            this.tbxUsuario.Location = new System.Drawing.Point(276, 184);
            this.tbxUsuario.Name = "tbxUsuario";
            this.tbxUsuario.PlaceholderText = "Ingrese nombre de usuario";
            this.tbxUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxUsuario.Size = new System.Drawing.Size(241, 23);
            this.tbxUsuario.TabIndex = 1;
            // 
            // tbxClave
            // 
            this.tbxClave.BackColor = System.Drawing.Color.Thistle;
            this.tbxClave.Location = new System.Drawing.Point(276, 235);
            this.tbxClave.Name = "tbxClave";
            this.tbxClave.PasswordChar = '*';
            this.tbxClave.PlaceholderText = "Ingrese contraseña";
            this.tbxClave.Size = new System.Drawing.Size(241, 23);
            this.tbxClave.TabIndex = 2;
            // 
            // lblGestion
            // 
            this.lblGestion.AutoSize = true;
            this.lblGestion.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblGestion.Location = new System.Drawing.Point(324, 127);
            this.lblGestion.Name = "lblGestion";
            this.lblGestion.Size = new System.Drawing.Size(151, 20);
            this.lblGestion.TabIndex = 3;
            this.lblGestion.Text = "Gestion del negocio ";
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAcceder.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue;
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAcceder.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAcceder.ForeColor = System.Drawing.Color.Transparent;
            this.btnAcceder.Location = new System.Drawing.Point(349, 295);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(100, 50);
            this.btnAcceder.TabIndex = 4;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // btnRellenarDue
            // 
            this.btnRellenarDue.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnRellenarDue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRellenarDue.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRellenarDue.ForeColor = System.Drawing.Color.Transparent;
            this.btnRellenarDue.Location = new System.Drawing.Point(646, 338);
            this.btnRellenarDue.Name = "btnRellenarDue";
            this.btnRellenarDue.Size = new System.Drawing.Size(122, 33);
            this.btnRellenarDue.TabIndex = 5;
            this.btnRellenarDue.Text = "Rellenar Dueño";
            this.btnRellenarDue.UseVisualStyleBackColor = false;
            this.btnRellenarDue.Click += new System.EventHandler(this.btnRellenarDue_Click);
            // 
            // btnRellenarEmp
            // 
            this.btnRellenarEmp.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnRellenarEmp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRellenarEmp.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRellenarEmp.ForeColor = System.Drawing.Color.Transparent;
            this.btnRellenarEmp.Location = new System.Drawing.Point(646, 376);
            this.btnRellenarEmp.Name = "btnRellenarEmp";
            this.btnRellenarEmp.Size = new System.Drawing.Size(122, 33);
            this.btnRellenarEmp.TabIndex = 6;
            this.btnRellenarEmp.Text = "Rellenar empleado";
            this.btnRellenarEmp.UseVisualStyleBackColor = false;
            this.btnRellenarEmp.Click += new System.EventHandler(this.btnRellenarEmp_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRellenarEmp);
            this.Controls.Add(this.btnRellenarDue);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.lblGestion);
            this.Controls.Add(this.tbxClave);
            this.Controls.Add(this.tbxUsuario);
            this.Controls.Add(this.lblUtn);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUtn;
        private System.Windows.Forms.TextBox tbxUsuario;
        private System.Windows.Forms.TextBox tbxClave;
        private System.Windows.Forms.Label lblGestion;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.Button btnRellenarDue;
        private System.Windows.Forms.Button btnRellenarEmp;
    }
}
