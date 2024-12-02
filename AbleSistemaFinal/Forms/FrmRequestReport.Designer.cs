namespace AbleSistemaFinal.Forms
{
    partial class FrmRequestReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRequestReport));
            this.label1 = new System.Windows.Forms.Label();
            this.RbEmployeeRegister = new System.Windows.Forms.RadioButton();
            this.RbPayrollRegister = new System.Windows.Forms.RadioButton();
            this.BtnRequestReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reportes";
            // 
            // RbEmployeeRegister
            // 
            this.RbEmployeeRegister.AutoSize = true;
            this.RbEmployeeRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbEmployeeRegister.Location = new System.Drawing.Point(52, 104);
            this.RbEmployeeRegister.Name = "RbEmployeeRegister";
            this.RbEmployeeRegister.Size = new System.Drawing.Size(188, 20);
            this.RbEmployeeRegister.TabIndex = 1;
            this.RbEmployeeRegister.TabStop = true;
            this.RbEmployeeRegister.Text = "Registro de empleados";
            this.RbEmployeeRegister.UseVisualStyleBackColor = true;
            // 
            // RbPayrollRegister
            // 
            this.RbPayrollRegister.AutoSize = true;
            this.RbPayrollRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbPayrollRegister.Location = new System.Drawing.Point(52, 148);
            this.RbPayrollRegister.Name = "RbPayrollRegister";
            this.RbPayrollRegister.Size = new System.Drawing.Size(267, 20);
            this.RbPayrollRegister.TabIndex = 2;
            this.RbPayrollRegister.TabStop = true;
            this.RbPayrollRegister.Text = "Registro de Nómina de empleados";
            this.RbPayrollRegister.UseVisualStyleBackColor = true;
            // 
            // BtnRequestReport
            // 
            this.BtnRequestReport.Location = new System.Drawing.Point(138, 205);
            this.BtnRequestReport.Name = "BtnRequestReport";
            this.BtnRequestReport.Size = new System.Drawing.Size(92, 29);
            this.BtnRequestReport.TabIndex = 3;
            this.BtnRequestReport.Text = "Solicitar";
            this.BtnRequestReport.UseVisualStyleBackColor = true;
            this.BtnRequestReport.Click += new System.EventHandler(this.BtnRequestReport_Click);
            // 
            // FrmRequestReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 270);
            this.Controls.Add(this.BtnRequestReport);
            this.Controls.Add(this.RbPayrollRegister);
            this.Controls.Add(this.RbEmployeeRegister);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRequestReport";
            this.Text = "FrmRequestReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RbEmployeeRegister;
        private System.Windows.Forms.RadioButton RbPayrollRegister;
        private System.Windows.Forms.Button BtnRequestReport;
    }
}