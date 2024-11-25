using AbleSistemaFinal.Dao;
using AbleSistemaFinal.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbleSistemaFinal.Forms
{
    public partial class FrmPayrollRegister : Form
    {
        private PayrollDao payrollDao;
        public FrmPayrollRegister(PayrollDao dao)
        {
            InitializeComponent();
            payrollDao = dao;
            LoadData();
        }
        private void LoadData()
        {
            // Configurar el DataSource con los datos
            DgvPayrollRegister.DataSource = null;
            DgvPayrollRegister.DataSource = payrollDao.GetAllEmployees();

            // Configurar los encabezados en español
            if (DgvPayrollRegister.Columns.Count > 0)
            {
                DgvPayrollRegister.Columns["Id"].HeaderText = "Identificación";
                DgvPayrollRegister.Columns["Name"].HeaderText = "Nombre";
                DgvPayrollRegister.Columns["BaseSalary"].HeaderText = "Salario Básico";
                DgvPayrollRegister.Columns["OvertimeHours"].HeaderText = "Horas Extra";
                DgvPayrollRegister.Columns["OvertimePayRate"].HeaderText = "Tarifa por Hora Extra";
                DgvPayrollRegister.Columns["Bonus"].HeaderText = "Bonificación";
                DgvPayrollRegister.Columns["INSSDeduction"].HeaderText = "Deducción INSS";
                DgvPayrollRegister.Columns["IRDeduction"].HeaderText = "Deducción IR";
                DgvPayrollRegister.Columns["TotalSalary"].HeaderText = "Salario Total";
            }

            // Ajustar el ancho de las columnas automáticamente
            DgvPayrollRegister.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (DgvPayrollRegister.SelectedRows.Count > 0)
            {
                var selectedEmployee = (EmployeePayroll)DgvPayrollRegister.SelectedRows[0].DataBoundItem;
                payrollDao.DeleteEmployee(selectedEmployee.Id);
                LoadData();
                MessageBox.Show("Employee deleted successfully.");
            }
            else
            {
                MessageBox.Show("Select an employee to delete.");
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (DgvPayrollRegister.SelectedRows.Count > 0)
            {
                // Obtener el empleado seleccionado del DataGridView
                var selectedEmployee = (EmployeePayroll)DgvPayrollRegister.SelectedRows[0].DataBoundItem;

                // Crear instancia del formulario principal
                var mainForm = new FrmPayroll();

                // Pasar los datos del empleado al formulario principal
                mainForm.LoadEmployeeData(selectedEmployee);

                // Mostrar el formulario principal para editar
                mainForm.ShowDialog();

                // Recargar los datos en el DataGridView después de la edición
                LoadData();
            }
            else
            {
                MessageBox.Show("Select an employee to edit.");
            }
        }

        private void MnuPayroll_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnReportPayroll_Click(object sender, EventArgs e)
        {
            ReportDataSource dataSource = new ReportDataSource("DsPayroll", DgvPayrollRegister);

            FrmReport frmReport = new FrmReport();
            frmReport.reportViewer1.LocalReport.DataSources.Clear();
            frmReport.reportViewer1.LocalReport.DataSources.Add(dataSource);
            //Configurar archivo reporte
            frmReport.reportViewer1.LocalReport.ReportEmbeddedResource = "AbleSistemaFinal.Reports.RptPayroll.rdlc";
            //Refrescar reporte
            frmReport.reportViewer1.RefreshReport();

            //Visualizar formulario
            frmReport.ShowDialog();
        }
    }
}
