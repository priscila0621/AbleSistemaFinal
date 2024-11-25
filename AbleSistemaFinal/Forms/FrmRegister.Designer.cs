namespace AbleSistemaFinal.Forms
{
    partial class FrmRegister
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
            this.DgvRegister = new System.Windows.Forms.DataGridView();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSeeRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnReportRegister = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegister)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvRegister
            // 
            this.DgvRegister.AllowUserToOrderColumns = true;
            this.DgvRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRegister.Location = new System.Drawing.Point(12, 104);
            this.DgvRegister.Name = "DgvRegister";
            this.DgvRegister.Size = new System.Drawing.Size(711, 310);
            this.DgvRegister.TabIndex = 17;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(648, 37);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 15;
            this.BtnDelete.Text = "Eliminar";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(552, 36);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 16;
            this.BtnEdit.Text = "Editar";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuRegister,
            this.MnuSeeRegister});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuRegister
            // 
            this.MnuRegister.Name = "MnuRegister";
            this.MnuRegister.Size = new System.Drawing.Size(126, 20);
            this.MnuRegister.Text = "Registrar empleados";
            this.MnuRegister.Click += new System.EventHandler(this.MnuRegister_Click);
            // 
            // MnuSeeRegister
            // 
            this.MnuSeeRegister.Name = "MnuSeeRegister";
            this.MnuSeeRegister.Size = new System.Drawing.Size(78, 20);
            this.MnuSeeRegister.Text = "Ver registro";
            // 
            // BtnReportRegister
            // 
            this.BtnReportRegister.Location = new System.Drawing.Point(445, 36);
            this.BtnReportRegister.Name = "BtnReportRegister";
            this.BtnReportRegister.Size = new System.Drawing.Size(75, 23);
            this.BtnReportRegister.TabIndex = 18;
            this.BtnReportRegister.Text = "Ver reporte";
            this.BtnReportRegister.UseVisualStyleBackColor = true;
            this.BtnReportRegister.Click += new System.EventHandler(this.BtnReportRegister_Click);
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnReportRegister);
            this.Controls.Add(this.DgvRegister);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegister";
            this.Text = "FrmRegister";
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegister)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvRegister;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuRegister;
        private System.Windows.Forms.ToolStripMenuItem MnuSeeRegister;
        private System.Windows.Forms.Button BtnReportRegister;
    }
}