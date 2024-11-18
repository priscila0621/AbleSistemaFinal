namespace AbleSistemaFinal.Forms
{
    partial class FrmPayroll
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
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TbName = new System.Windows.Forms.TextBox();
            this.LblNetSalary = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TbOvertimePay = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.LblSalary = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TbBonus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblIR = new System.Windows.Forms.Label();
            this.LblINSS = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LblOvertimePayment = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TbOvertime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TbBaseSalary = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuPayroll = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuPayrollRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(116, 406);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(106, 30);
            this.BtnCalculate.TabIndex = 20;
            this.BtnCalculate.Text = "Calcular";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(568, 406);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(106, 30);
            this.BtnSave.TabIndex = 21;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TbName);
            this.groupBox1.Controls.Add(this.LblNetSalary);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TbOvertimePay);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.LblSalary);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TbBonus);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.LblOvertimePayment);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.TbOvertime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TbBaseSalary);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TbId);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 259);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Nómina";
            // 
            // TbName
            // 
            this.TbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbName.Location = new System.Drawing.Point(269, 31);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(86, 22);
            this.TbName.TabIndex = 21;
            // 
            // LblNetSalary
            // 
            this.LblNetSalary.AutoSize = true;
            this.LblNetSalary.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNetSalary.Location = new System.Drawing.Point(591, 209);
            this.LblNetSalary.Name = "LblNetSalary";
            this.LblNetSalary.Size = new System.Drawing.Size(60, 21);
            this.LblNetSalary.TabIndex = 20;
            this.LblNetSalary.Text = "(Pago)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(472, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "SalarioNeto:";
            // 
            // TbOvertimePay
            // 
            this.TbOvertimePay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbOvertimePay.Location = new System.Drawing.Point(417, 77);
            this.TbOvertimePay.Name = "TbOvertimePay";
            this.TbOvertimePay.Size = new System.Drawing.Size(65, 22);
            this.TbOvertimePay.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(511, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 21);
            this.label13.TabIndex = 17;
            this.label13.Text = "Horas extras:";
            // 
            // LblSalary
            // 
            this.LblSalary.AutoSize = true;
            this.LblSalary.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSalary.Location = new System.Drawing.Point(366, 209);
            this.LblSalary.Name = "LblSalary";
            this.LblSalary.Size = new System.Drawing.Size(60, 21);
            this.LblSalary.TabIndex = 16;
            this.LblSalary.Text = "(Pago)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(249, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 21);
            this.label10.TabIndex = 15;
            this.label10.Text = "Salario Total:";
            // 
            // TbBonus
            // 
            this.TbBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbBonus.Location = new System.Drawing.Point(364, 142);
            this.TbBonus.Name = "TbBonus";
            this.TbBonus.Size = new System.Drawing.Size(65, 22);
            this.TbBonus.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(246, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 21);
            this.label9.TabIndex = 13;
            this.label9.Text = "Bonificación:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblIR);
            this.groupBox2.Controls.Add(this.LblINSS);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(14, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 100);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deducciones";
            // 
            // LblIR
            // 
            this.LblIR.AutoSize = true;
            this.LblIR.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIR.Location = new System.Drawing.Point(86, 60);
            this.LblIR.Name = "LblIR";
            this.LblIR.Size = new System.Drawing.Size(100, 21);
            this.LblIR.TabIndex = 8;
            this.LblIR.Text = "(Deducción)";
            // 
            // LblINSS
            // 
            this.LblINSS.AutoSize = true;
            this.LblINSS.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblINSS.Location = new System.Drawing.Point(86, 28);
            this.LblINSS.Name = "LblINSS";
            this.LblINSS.Size = new System.Drawing.Size(100, 21);
            this.LblINSS.TabIndex = 7;
            this.LblINSS.Text = "(Deducción)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "INSS:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 21);
            this.label11.TabIndex = 6;
            this.label11.Text = "IR:";
            // 
            // LblOvertimePayment
            // 
            this.LblOvertimePayment.AutoSize = true;
            this.LblOvertimePayment.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOvertimePayment.Location = new System.Drawing.Point(668, 144);
            this.LblOvertimePayment.Name = "LblOvertimePayment";
            this.LblOvertimePayment.Size = new System.Drawing.Size(60, 21);
            this.LblOvertimePayment.TabIndex = 11;
            this.LblOvertimePayment.Text = "(Pago)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(483, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(179, 21);
            this.label12.TabIndex = 10;
            this.label12.Text = "Pago por horas extras:";
            // 
            // TbOvertime
            // 
            this.TbOvertime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbOvertime.Location = new System.Drawing.Point(629, 77);
            this.TbOvertime.Name = "TbOvertime";
            this.TbOvertime.Size = new System.Drawing.Size(65, 22);
            this.TbOvertime.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(246, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tarifa por Hora extra:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "ID:";
            // 
            // TbBaseSalary
            // 
            this.TbBaseSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbBaseSalary.Location = new System.Drawing.Point(137, 81);
            this.TbBaseSalary.Name = "TbBaseSalary";
            this.TbBaseSalary.Size = new System.Drawing.Size(83, 22);
            this.TbBaseSalary.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // TbId
            // 
            this.TbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbId.Location = new System.Drawing.Point(49, 31);
            this.TbId.Name = "TbId";
            this.TbId.Size = new System.Drawing.Size(86, 22);
            this.TbId.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "Salario Básico:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuPayroll,
            this.MnuPayrollRegister});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuPayroll
            // 
            this.MnuPayroll.Name = "MnuPayroll";
            this.MnuPayroll.Size = new System.Drawing.Size(121, 20);
            this.MnuPayroll.Text = "Gestión de Nómina";
            // 
            // MnuPayrollRegister
            // 
            this.MnuPayrollRegister.Name = "MnuPayrollRegister";
            this.MnuPayrollRegister.Size = new System.Drawing.Size(129, 20);
            this.MnuPayrollRegister.Text = "Registros de Nómina";
            // 
            // FrmPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmPayroll";
            this.Text = "FrmPayroll";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button BtnCalculate;
        public System.Windows.Forms.Button BtnSave;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox TbName;
        public System.Windows.Forms.Label LblNetSalary;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TbOvertimePay;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label LblSalary;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox TbBonus;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label LblIR;
        public System.Windows.Forms.Label LblINSS;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label LblOvertimePayment;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox TbOvertime;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox TbBaseSalary;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TbId;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem MnuPayroll;
        public System.Windows.Forms.ToolStripMenuItem MnuPayrollRegister;
    }
}