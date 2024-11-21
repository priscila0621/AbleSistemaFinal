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
        private readonly Payroll _currentPayroll;
        private readonly EmployeePayrollService _employeePayrollService;
        public FrmPayroll(Payroll payroll, EmployeePayrollService employeePayrollService)
        {
            InitializeComponent();

            _currentPayroll = payroll;
            _employeePayrollService = employeePayrollService;

            // Carga los datos en los campos para editar
            TbId.Text = payroll.Id;
            TbName.Text = payroll.Name;
            TbBaseSalary.Text = payroll.BaseSalary.ToString();
            TbOvertimePay.Text = payroll.OvertimeRate.ToString();
            TbOvertime.Text = payroll.OvertimeHours.ToString();
            TbBonus.Text = payroll.Bonus.ToString();


        }



        private void BtnCalculate_Click_1(object sender, EventArgs e)
        {
            string id = TbId.Text; // Cambiado de int a string
            string name = TbName.Text;
            decimal baseSalary = decimal.Parse(TbBaseSalary.Text);
            decimal overtimeRate = decimal.Parse(TbOvertimePay.Text);
            int overtimeHours = int.Parse(TbOvertime.Text);
            decimal bonus = decimal.Parse(TbBonus.Text);

            Payroll payroll = _employeePayrollService.CalculatePayroll(id, name, baseSalary, overtimeRate, overtimeHours, bonus);

            // Usa la cultura "en-US" para formatear en dólares
            var culture = new CultureInfo("en-US");

            LblOvertimePayment.Text = payroll.OvertimePayment.ToString("C", culture);
            LblSalary.Text = payroll.TotalSalary.ToString("C", culture);
            LblINSS.Text = payroll.INSS.ToString("C", culture);
            LblIR.Text = payroll.IR.ToString("C", culture);
            LblNetSalary.Text = payroll.NetSalary.ToString("C", culture);
        }

        private void BtnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Obtiene los valores ingresados
                string id = TbId.Text;
                string name = TbName.Text;
                decimal baseSalary = decimal.Parse(TbBaseSalary.Text);
                decimal overtimeRate = decimal.Parse(TbOvertimePay.Text);
                int overtimeHours = int.Parse(TbOvertime.Text);
                decimal bonus = decimal.Parse(TbBonus.Text);

                // Verifica si es un registro nuevo o una edición
                if (_currentPayroll == null)
                {
                    // Nuevo registro
                    Payroll payroll = _employeePayrollService.CalculatePayroll(id, name, baseSalary, overtimeRate, overtimeHours, bonus);
                    _employeePayrollService.AddPayrollRecord(payroll);
                    MessageBox.Show("Registro guardado exitosamente.");
                }
                else
                {
                    // Edición de un registro existente
                    _currentPayroll.Name = name;
                    _currentPayroll.BaseSalary = baseSalary;
                    _currentPayroll.OvertimeRate = overtimeRate;
                    _currentPayroll.OvertimeHours = overtimeHours;
                    _currentPayroll.Bonus = bonus;

                    // Recalcula los valores usando el servicio
                    _currentPayroll.TotalSalary = _currentPayroll.BaseSalary +
                        _employeePayrollService.CalculateOvertimePayment(_currentPayroll.OvertimeRate, _currentPayroll.OvertimeHours) + _currentPayroll.Bonus;

                    _currentPayroll.INSS = _employeePayrollService.CalculateINSS(_currentPayroll.TotalSalary);
                    _currentPayroll.IR = _employeePayrollService.CalculateIR(_currentPayroll.TotalSalary - _currentPayroll.INSS);
                    _currentPayroll.NetSalary = _employeePayrollService.CalculateNetSalary(_currentPayroll.TotalSalary, _currentPayroll.INSS, _currentPayroll.IR);

                    // Actualiza el registro en la lista
                    _employeePayrollService.UpdatePayrollRecord(_currentPayroll);
                    MessageBox.Show("Registro actualizado exitosamente.");
                }


            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, asegúrese de que todos los campos numéricos tengan valores válidos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void MnuPayrollRegister_Click(object sender, EventArgs e)
        {
            FrmPayrollRegister frmPayrollRegister = new FrmPayrollRegister(_employeePayrollService);
            frmPayrollRegister.Show();
        }
    }
}
