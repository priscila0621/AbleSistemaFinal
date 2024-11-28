using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AbleSistemaFinal.Dao;

namespace AbleSistemaFinal.Forms
{
    public partial class FrmRequestReport : Form
    {
        public FrmRequestReport()
        {
            InitializeComponent();

        }

        private void BtnRequestReport_Click(object sender, EventArgs e)
        {
            // Validar cuál RadioButton está seleccionado
            if (RbEmployeeRegister.Checked)
            {
                // Abrir el FrmReport con el reporte de empleados
                var reportForm = new FrmReport("RptEmployeeRegister.rdlc", EmployeeDao.GetAllEmployees());
                reportForm.ShowDialog();
            }
            else if (RbPayrollRegister.Checked)
            {
                // Abrir el FrmReport con el reporte de nómina
                var payrollDao = new PayrollDao();
                var reportForm = new FrmReport("RptPayroll.rdlc", payrollDao.GetAllEmployees());
                reportForm.ShowDialog();
            }
            else
            {
                // Mostrar un mensaje si no se seleccionó ningún RadioButton
                MessageBox.Show("Please select a report type.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
