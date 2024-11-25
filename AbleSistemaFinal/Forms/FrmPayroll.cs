using AbleSistemaFinal.Dao;
using AbleSistemaFinal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbleSistemaFinal.Forms
{
    public partial class FrmPayroll : Form
    {
        private PayrollDao payrollDao = new PayrollDao();
        private EmployeePayrollDao payrollService = new EmployeePayrollDao();

        public FrmPayroll()
        {
            InitializeComponent();
        }


        private void BtnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Crear el modelo desde los datos del formulario
                var employee = new EmployeePayroll
                {
                    Id = TbId.Text,
                    Name = TbName.Text,
                    BaseSalary = decimal.Parse(TbBaseSalary.Text),
                    OvertimeHours = decimal.Parse(TbOvertime.Text),
                    OvertimePayRate = decimal.Parse(TbOvertimePay.Text),
                    Bonus = decimal.Parse(TbBonus.Text)
                };

                // Calcular el pago por horas extras
                decimal overtimePayment = employee.OvertimeHours * employee.OvertimePayRate;

                // Calcular el salario bruto (sin deducciones)
                decimal grossSalary = employee.BaseSalary + overtimePayment + employee.Bonus;

                // Calcular deducciones
                payrollService.CalculateDeductions(employee);

                // Calcular el salario neto (bruto - deducciones)
                decimal netSalary = grossSalary - (employee.INSSDeduction + employee.IRDeduction);

                // Asignar valores calculados al modelo
                employee.TotalSalary = netSalary;

                // Guardar en la lista
                payrollDao.AddEmployee(employee);

                // Mostrar deducciones y cálculos en etiquetas
                LblOvertimePayment.Text = overtimePayment.ToString("C");
                LblSalary.Text = grossSalary.ToString("C");
                LblNetSalary.Text = netSalary.ToString("C");
                LblINSS.Text = employee.INSSDeduction.ToString("C");
                LblIR.Text = employee.IRDeduction.ToString("C");

                MessageBox.Show("Guardado con éxito");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos en los campos de salario, horas extra, tarifa y bonificación.", "Error de entrada");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error");
            }

        }

        private void MnuPayrollRegister_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de registro
            var registerForm = new FrmPayrollRegister(payrollDao);
            registerForm.ShowDialog();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        private void ClearForm()
        {
            TbId.Text = "";
            TbName.Text = "";
            TbBaseSalary.Text = "";
            TbOvertime.Text = "";
            TbOvertimePay.Text = "";
            TbBonus.Text = "";
            LblINSS.Text = "";
            LblIR.Text = "";
        }
        public void LoadEmployeeData(EmployeePayroll employee)
        {
            // Llenar los campos del formulario con los datos del empleado
            TbId.Text = employee.Id;
            TbName.Text = employee.Name;
            TbBaseSalary.Text = employee.BaseSalary.ToString();
            TbOvertime.Text = employee.OvertimeHours.ToString();
            TbOvertimePay.Text = employee.OvertimePayRate.ToString();
            TbBonus.Text = employee.Bonus.ToString();

            // Mostrar deducciones existentes
            LblINSS.Text = employee.INSSDeduction.ToString("C");
            LblIR.Text = employee.IRDeduction.ToString("C");
        }
    }
}
