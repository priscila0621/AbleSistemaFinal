namespace AbleSistemaFinal
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnPrincipal = new System.Windows.Forms.Button();
            this.BtnAdministration = new System.Windows.Forms.Button();
            this.BtnCoordination = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(306, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 331);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(190, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(610, 52);
            this.panel3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de gestión de empleados";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.BtnPrincipal);
            this.panel1.Controls.Add(this.BtnAdministration);
            this.panel1.Controls.Add(this.BtnCoordination);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 450);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(190, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 39);
            this.panel2.TabIndex = 2;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.DarkGray;
            this.SidePanel.Location = new System.Drawing.Point(3, 91);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 54);
            this.SidePanel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 24);
            this.button1.TabIndex = 0;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnPrincipal
            // 
            this.BtnPrincipal.FlatAppearance.BorderSize = 0;
            this.BtnPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrincipal.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrincipal.ForeColor = System.Drawing.Color.White;
            this.BtnPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrincipal.Image")));
            this.BtnPrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrincipal.Location = new System.Drawing.Point(12, 211);
            this.BtnPrincipal.Name = "BtnPrincipal";
            this.BtnPrincipal.Size = new System.Drawing.Size(179, 54);
            this.BtnPrincipal.TabIndex = 3;
            this.BtnPrincipal.Text = "  Dirección";
            this.BtnPrincipal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPrincipal.UseVisualStyleBackColor = true;
            this.BtnPrincipal.Click += new System.EventHandler(this.BtnPrincipal_Click_1);
            // 
            // BtnAdministration
            // 
            this.BtnAdministration.FlatAppearance.BorderSize = 0;
            this.BtnAdministration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdministration.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdministration.ForeColor = System.Drawing.Color.White;
            this.BtnAdministration.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdministration.Image")));
            this.BtnAdministration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdministration.Location = new System.Drawing.Point(12, 151);
            this.BtnAdministration.Name = "BtnAdministration";
            this.BtnAdministration.Size = new System.Drawing.Size(179, 54);
            this.BtnAdministration.TabIndex = 2;
            this.BtnAdministration.Text = "  Administración";
            this.BtnAdministration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAdministration.UseVisualStyleBackColor = true;
            this.BtnAdministration.Click += new System.EventHandler(this.BtnAdministration_Click_1);
            // 
            // BtnCoordination
            // 
            this.BtnCoordination.FlatAppearance.BorderSize = 0;
            this.BtnCoordination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCoordination.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCoordination.ForeColor = System.Drawing.Color.White;
            this.BtnCoordination.Image = ((System.Drawing.Image)(resources.GetObject("BtnCoordination.Image")));
            this.BtnCoordination.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCoordination.Location = new System.Drawing.Point(12, 91);
            this.BtnCoordination.Name = "BtnCoordination";
            this.BtnCoordination.Size = new System.Drawing.Size(179, 54);
            this.BtnCoordination.TabIndex = 1;
            this.BtnCoordination.Text = "  Coordinación";
            this.BtnCoordination.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCoordination.UseVisualStyleBackColor = true;
            this.BtnCoordination.Click += new System.EventHandler(this.BtnCoordination_Click_1);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Able";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnPrincipal;
        private System.Windows.Forms.Button BtnAdministration;
        private System.Windows.Forms.Button BtnCoordination;
    }
}

