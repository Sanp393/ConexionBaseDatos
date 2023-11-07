namespace ConexionBaseDatos
{
    partial class FormCrearJob
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
            this.LABTitle = new System.Windows.Forms.Label();
            this.TXTBOXTitle = new System.Windows.Forms.TextBox();
            this.LABMinSalary = new System.Windows.Forms.Label();
            this.LABMaxSalary = new System.Windows.Forms.Label();
            this.NUMMinSalary = new System.Windows.Forms.NumericUpDown();
            this.NUMMaxSalary = new System.Windows.Forms.NumericUpDown();
            this.BUTCreateJob = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUMMinSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUMMaxSalary)).BeginInit();
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
            // LABTitle
            // 
            this.LABTitle.AutoSize = true;
            this.LABTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABTitle.Location = new System.Drawing.Point(13, 100);
            this.LABTitle.Name = "LABTitle";
            this.LABTitle.Size = new System.Drawing.Size(74, 29);
            this.LABTitle.TabIndex = 3;
            this.LABTitle.Text = "Title:";
            // 
            // TXTBOXTitle
            // 
            this.TXTBOXTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBOXTitle.Location = new System.Drawing.Point(93, 97);
            this.TXTBOXTitle.Name = "TXTBOXTitle";
            this.TXTBOXTitle.Size = new System.Drawing.Size(363, 36);
            this.TXTBOXTitle.TabIndex = 4;
            this.TXTBOXTitle.TextChanged += new System.EventHandler(this.TXTBOXTitle_TextChanged);
            // 
            // LABMinSalary
            // 
            this.LABMinSalary.AutoSize = true;
            this.LABMinSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABMinSalary.Location = new System.Drawing.Point(13, 197);
            this.LABMinSalary.Name = "LABMinSalary";
            this.LABMinSalary.Size = new System.Drawing.Size(151, 29);
            this.LABMinSalary.TabIndex = 5;
            this.LABMinSalary.Text = "Min Salary:";
            // 
            // LABMaxSalary
            // 
            this.LABMaxSalary.AutoSize = true;
            this.LABMaxSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABMaxSalary.Location = new System.Drawing.Point(410, 197);
            this.LABMaxSalary.Name = "LABMaxSalary";
            this.LABMaxSalary.Size = new System.Drawing.Size(157, 29);
            this.LABMaxSalary.TabIndex = 6;
            this.LABMaxSalary.Text = "Max Salary:";
            // 
            // NUMMinSalary
            // 
            this.NUMMinSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUMMinSalary.Location = new System.Drawing.Point(170, 197);
            this.NUMMinSalary.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.NUMMinSalary.Name = "NUMMinSalary";
            this.NUMMinSalary.Size = new System.Drawing.Size(179, 36);
            this.NUMMinSalary.TabIndex = 7;
            this.NUMMinSalary.ValueChanged += new System.EventHandler(this.NUMMinSalary_ValueChanged);
            // 
            // NUMMaxSalary
            // 
            this.NUMMaxSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUMMaxSalary.Location = new System.Drawing.Point(567, 197);
            this.NUMMaxSalary.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.NUMMaxSalary.Name = "NUMMaxSalary";
            this.NUMMaxSalary.Size = new System.Drawing.Size(179, 36);
            this.NUMMaxSalary.TabIndex = 8;
            this.NUMMaxSalary.ValueChanged += new System.EventHandler(this.NUMMaxSalary_ValueChanged);
            // 
            // BUTCreateJob
            // 
            this.BUTCreateJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTCreateJob.Location = new System.Drawing.Point(277, 318);
            this.BUTCreateJob.Name = "BUTCreateJob";
            this.BUTCreateJob.Size = new System.Drawing.Size(239, 77);
            this.BUTCreateJob.TabIndex = 9;
            this.BUTCreateJob.Text = "Create Job";
            this.BUTCreateJob.UseVisualStyleBackColor = true;
            this.BUTCreateJob.Click += new System.EventHandler(this.BUTCreateJob_Click);
            // 
            // FormCrearJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BUTCreateJob);
            this.Controls.Add(this.NUMMaxSalary);
            this.Controls.Add(this.NUMMinSalary);
            this.Controls.Add(this.LABMaxSalary);
            this.Controls.Add(this.LABMinSalary);
            this.Controls.Add(this.TXTBOXTitle);
            this.Controls.Add(this.LABTitle);
            this.Controls.Add(this.LABDataBase);
            this.Name = "FormCrearJob";
            this.Text = "Employees";
            ((System.ComponentModel.ISupportInitialize)(this.NUMMinSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUMMaxSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LABDataBase;
        private System.Windows.Forms.Label LABTitle;
        private System.Windows.Forms.TextBox TXTBOXTitle;
        private System.Windows.Forms.Label LABMinSalary;
        private System.Windows.Forms.Label LABMaxSalary;
        private System.Windows.Forms.NumericUpDown NUMMinSalary;
        private System.Windows.Forms.NumericUpDown NUMMaxSalary;
        private System.Windows.Forms.Button BUTCreateJob;
    }
}