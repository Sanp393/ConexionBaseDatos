﻿namespace ConexionBaseDatos
{
    partial class FormPrincipal
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
            this.BUTOpenConexionBD = new System.Windows.Forms.Button();
            this.LABDataBase = new System.Windows.Forms.Label();
            this.LABMessage = new System.Windows.Forms.Label();
            this.BUTCloseConnectionBD = new System.Windows.Forms.Button();
            this.BUTCreateJob = new System.Windows.Forms.Button();
            this.LSTBOXEmployees = new System.Windows.Forms.ListBox();
            this.BUTListaEmpleados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BUTOpenConexionBD
            // 
            this.BUTOpenConexionBD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BUTOpenConexionBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTOpenConexionBD.Location = new System.Drawing.Point(37, 294);
            this.BUTOpenConexionBD.Name = "BUTOpenConexionBD";
            this.BUTOpenConexionBD.Size = new System.Drawing.Size(223, 87);
            this.BUTOpenConexionBD.TabIndex = 0;
            this.BUTOpenConexionBD.Text = "Connect BD";
            this.BUTOpenConexionBD.UseVisualStyleBackColor = true;
            this.BUTOpenConexionBD.Click += new System.EventHandler(this.BUTConexionBD_Click);
            // 
            // LABDataBase
            // 
            this.LABDataBase.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LABDataBase.Dock = System.Windows.Forms.DockStyle.Top;
            this.LABDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABDataBase.Location = new System.Drawing.Point(0, 0);
            this.LABDataBase.Name = "LABDataBase";
            this.LABDataBase.Size = new System.Drawing.Size(800, 48);
            this.LABDataBase.TabIndex = 1;
            this.LABDataBase.Text = "Guillermo Employees";
            this.LABDataBase.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LABMessage
            // 
            this.LABMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LABMessage.Location = new System.Drawing.Point(0, 525);
            this.LABMessage.Name = "LABMessage";
            this.LABMessage.Size = new System.Drawing.Size(800, 42);
            this.LABMessage.TabIndex = 2;
            // 
            // BUTCloseConnectionBD
            // 
            this.BUTCloseConnectionBD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BUTCloseConnectionBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTCloseConnectionBD.Location = new System.Drawing.Point(307, 294);
            this.BUTCloseConnectionBD.Name = "BUTCloseConnectionBD";
            this.BUTCloseConnectionBD.Size = new System.Drawing.Size(204, 87);
            this.BUTCloseConnectionBD.TabIndex = 3;
            this.BUTCloseConnectionBD.Text = "Disconnect BD";
            this.BUTCloseConnectionBD.UseVisualStyleBackColor = true;
            this.BUTCloseConnectionBD.Click += new System.EventHandler(this.BUTCloseConnectionBD_Click);
            // 
            // BUTCreateJob
            // 
            this.BUTCreateJob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BUTCreateJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTCreateJob.Location = new System.Drawing.Point(557, 294);
            this.BUTCreateJob.Name = "BUTCreateJob";
            this.BUTCreateJob.Size = new System.Drawing.Size(204, 87);
            this.BUTCreateJob.TabIndex = 4;
            this.BUTCreateJob.Text = "Create New Job";
            this.BUTCreateJob.UseVisualStyleBackColor = true;
            this.BUTCreateJob.Click += new System.EventHandler(this.BUTChangeJob_Click);
            // 
            // LSTBOXEmployees
            // 
            this.LSTBOXEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LSTBOXEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSTBOXEmployees.FormattingEnabled = true;
            this.LSTBOXEmployees.ItemHeight = 29;
            this.LSTBOXEmployees.Location = new System.Drawing.Point(12, 61);
            this.LSTBOXEmployees.Name = "LSTBOXEmployees";
            this.LSTBOXEmployees.Size = new System.Drawing.Size(776, 207);
            this.LSTBOXEmployees.TabIndex = 5;
            // 
            // BUTListaEmpleados
            // 
            this.BUTListaEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTListaEmpleados.Location = new System.Drawing.Point(37, 424);
            this.BUTListaEmpleados.Name = "BUTListaEmpleados";
            this.BUTListaEmpleados.Size = new System.Drawing.Size(223, 78);
            this.BUTListaEmpleados.TabIndex = 6;
            this.BUTListaEmpleados.Text = "Filtar Empleados";
            this.BUTListaEmpleados.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 567);
            this.Controls.Add(this.BUTListaEmpleados);
            this.Controls.Add(this.LSTBOXEmployees);
            this.Controls.Add(this.BUTCreateJob);
            this.Controls.Add(this.BUTCloseConnectionBD);
            this.Controls.Add(this.LABDataBase);
            this.Controls.Add(this.BUTOpenConexionBD);
            this.Controls.Add(this.LABMessage);
            this.Name = "FormPrincipal";
            this.Text = "Employees";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BUTOpenConexionBD;
        private System.Windows.Forms.Label LABDataBase;
        private System.Windows.Forms.Label LABMessage;
        private System.Windows.Forms.Button BUTCloseConnectionBD;
        private System.Windows.Forms.Button BUTCreateJob;
        private System.Windows.Forms.ListBox LSTBOXEmployees;
        private System.Windows.Forms.Button BUTListaEmpleados;
    }
}

