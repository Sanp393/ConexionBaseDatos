namespace ConexionBaseDatos
{
    partial class FiltradoEmpleadosForm
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
            this.LABDataBase = new System.Windows.Forms.Label();
            this.LSTBOXEmployees = new System.Windows.Forms.ListBox();
            this.LABFiltro = new System.Windows.Forms.Label();
            this.LABCiudad = new System.Windows.Forms.Label();
            this.LABNombre = new System.Windows.Forms.Label();
            this.TXTBOXNombre = new System.Windows.Forms.TextBox();
            this.LABApellidos = new System.Windows.Forms.Label();
            this.TXTBOXApellidos = new System.Windows.Forms.TextBox();
            this.COMBOXCiudad = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LABDataBase
            // 
            this.LABDataBase.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LABDataBase.Dock = System.Windows.Forms.DockStyle.Top;
            this.LABDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABDataBase.Location = new System.Drawing.Point(0, 0);
            this.LABDataBase.Name = "LABDataBase";
            this.LABDataBase.Size = new System.Drawing.Size(800, 48);
            this.LABDataBase.TabIndex = 2;
            this.LABDataBase.Text = "Guillermo Employees";
            this.LABDataBase.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LSTBOXEmployees
            // 
            this.LSTBOXEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSTBOXEmployees.FormattingEnabled = true;
            this.LSTBOXEmployees.ItemHeight = 29;
            this.LSTBOXEmployees.Location = new System.Drawing.Point(7, 65);
            this.LSTBOXEmployees.Name = "LSTBOXEmployees";
            this.LSTBOXEmployees.Size = new System.Drawing.Size(387, 410);
            this.LSTBOXEmployees.TabIndex = 3;
            // 
            // LABFiltro
            // 
            this.LABFiltro.AutoSize = true;
            this.LABFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABFiltro.Location = new System.Drawing.Point(423, 65);
            this.LABFiltro.Name = "LABFiltro";
            this.LABFiltro.Size = new System.Drawing.Size(105, 36);
            this.LABFiltro.TabIndex = 4;
            this.LABFiltro.Text = "Filtros:";
            // 
            // LABCiudad
            // 
            this.LABCiudad.AutoSize = true;
            this.LABCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABCiudad.Location = new System.Drawing.Point(453, 147);
            this.LABCiudad.Name = "LABCiudad";
            this.LABCiudad.Size = new System.Drawing.Size(81, 25);
            this.LABCiudad.TabIndex = 5;
            this.LABCiudad.Text = "Ciudad:";
            // 
            // LABNombre
            // 
            this.LABNombre.AutoSize = true;
            this.LABNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABNombre.Location = new System.Drawing.Point(447, 231);
            this.LABNombre.Name = "LABNombre";
            this.LABNombre.Size = new System.Drawing.Size(87, 25);
            this.LABNombre.TabIndex = 7;
            this.LABNombre.Text = "Nombre:";
            // 
            // TXTBOXNombre
            // 
            this.TXTBOXNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBOXNombre.Location = new System.Drawing.Point(540, 234);
            this.TXTBOXNombre.Multiline = true;
            this.TXTBOXNombre.Name = "TXTBOXNombre";
            this.TXTBOXNombre.Size = new System.Drawing.Size(237, 22);
            this.TXTBOXNombre.TabIndex = 8;
            this.TXTBOXNombre.TextChanged += new System.EventHandler(this.TXTBOXNombre_TextChanged);
            // 
            // LABApellidos
            // 
            this.LABApellidos.AutoSize = true;
            this.LABApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABApellidos.Location = new System.Drawing.Point(436, 318);
            this.LABApellidos.Name = "LABApellidos";
            this.LABApellidos.Size = new System.Drawing.Size(98, 25);
            this.LABApellidos.TabIndex = 9;
            this.LABApellidos.Text = "Apellidos:";
            // 
            // TXTBOXApellidos
            // 
            this.TXTBOXApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBOXApellidos.Location = new System.Drawing.Point(540, 315);
            this.TXTBOXApellidos.Multiline = true;
            this.TXTBOXApellidos.Name = "TXTBOXApellidos";
            this.TXTBOXApellidos.Size = new System.Drawing.Size(237, 22);
            this.TXTBOXApellidos.TabIndex = 10;
            // 
            // COMBOXCiudad
            // 
            this.COMBOXCiudad.FormattingEnabled = true;
            this.COMBOXCiudad.Location = new System.Drawing.Point(541, 147);
            this.COMBOXCiudad.Name = "COMBOXCiudad";
            this.COMBOXCiudad.Size = new System.Drawing.Size(236, 24);
            this.COMBOXCiudad.TabIndex = 11;
            // 
            // FiltradoEmpleadosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 631);
            this.Controls.Add(this.COMBOXCiudad);
            this.Controls.Add(this.TXTBOXApellidos);
            this.Controls.Add(this.LABApellidos);
            this.Controls.Add(this.TXTBOXNombre);
            this.Controls.Add(this.LABNombre);
            this.Controls.Add(this.LABCiudad);
            this.Controls.Add(this.LABFiltro);
            this.Controls.Add(this.LSTBOXEmployees);
            this.Controls.Add(this.LABDataBase);
            this.Name = "FiltradoEmpleadosForm";
            this.Text = "FiltradoEmpleadosForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LABDataBase;
        private System.Windows.Forms.ListBox LSTBOXEmployees;
        private System.Windows.Forms.Label LABFiltro;
        private System.Windows.Forms.Label LABCiudad;
        private System.Windows.Forms.Label LABNombre;
        private System.Windows.Forms.TextBox TXTBOXNombre;
        private System.Windows.Forms.Label LABApellidos;
        private System.Windows.Forms.TextBox TXTBOXApellidos;
        private System.Windows.Forms.ComboBox COMBOXCiudad;
    }
}