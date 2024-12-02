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
        private ErrorProvider errorProvider = new ErrorProvider(); // ErrorProvider para mostrar los errores
        public FrmPayroll()
        {
            InitializeComponent();
            // Configurar la cultura a Español - Nicaragua
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("es-NI");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("es-NI");
        }


        private void BtnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Limpiar los errores previos
                errorProvider.Clear();

                
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

        private void TbId_TextChanged(object sender, EventArgs e)
        {
            if (TbId.Text.Length != 8)
            {
                errorProvider.SetError(TbId, "El ID debe tener exactamente 8 caracteres.");
            }
            else
            {
                errorProvider.SetError(TbId, string.Empty); // Limpiar el error si es válido
            }
        }

        private void TbName_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(TbName.Text, @"^[a-zA-Z\s]+$"))
            {
                errorProvider.SetError(TbName, "El nombre solo puede contener letras y espacios.");
            }
            else
            {
                errorProvider.SetError(TbName, string.Empty); // Limpiar el error si es válido
            }
        }

        private void TbBaseSalary_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbBaseSalary.Text) || !decimal.TryParse(TbBaseSalary.Text, out _))
            {
                errorProvider.SetError(TbBaseSalary, "Por favor, ingrese un salario válido.");
            }
            else
            {
                errorProvider.SetError(TbBaseSalary, string.Empty); // Limpiar el error si es válido
            }
        }

        private void TbOvertimePay_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbOvertimePay.Text) || !decimal.TryParse(TbOvertimePay.Text, out _))
            {
                errorProvider.SetError(TbOvertimePay, "Por favor, ingrese un valor válido para la tarifa de horas extra.");
            }
            else
            {
                errorProvider.SetError(TbOvertimePay, string.Empty); // Limpiar el error si es válido
            }
        }

        private void TbOvertime_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbOvertime.Text) || !decimal.TryParse(TbOvertime.Text, out _))
            {
                errorProvider.SetError(TbOvertime, "Por favor, ingrese un valor válido para horas extra.");
            }
            else
            {
                errorProvider.SetError(TbOvertime, string.Empty); // Limpiar el error si es válido
            }
        }

        private void TbBonus_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbBonus.Text) || !decimal.TryParse(TbBonus.Text, out _))
            {
                errorProvider.SetError(TbBonus, "Por favor, ingrese un valor válido para la bonificación.");
            }
            else
            {
                errorProvider.SetError(TbBonus, string.Empty); // Limpiar el error si es válido
            }
        }
    }
}
