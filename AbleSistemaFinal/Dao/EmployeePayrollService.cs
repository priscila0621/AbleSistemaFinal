using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbleSistemaFinal.Models;

namespace AbleSistemaFinal.Dao
{
    public class EmployeePayrollService
    {
        List<Payroll> payrollRecords = new List<Payroll>();


        // Método para agregar un nuevo registro de nómina
        public void AddPayrollRecord(Payroll payroll)
        {

            if (payrollRecords.Any(p => p.Id == payroll.Id))
            {
                throw new InvalidOperationException($"Ya existe un registro con el ID {payroll.Id}.");
            }

            payrollRecords.Add(payroll);
        }

        // Método para actualizar un registro existente de nómina
        public void UpdatePayrollRecord(Payroll updatedPayroll)
        {
            var payroll = payrollRecords.Find(p => p.Id == updatedPayroll.Id);
            if (payroll != null)
            {
                payroll.Name = updatedPayroll.Name;
                payroll.BaseSalary = updatedPayroll.BaseSalary;
                payroll.OvertimeRate = updatedPayroll.OvertimeRate;
                payroll.OvertimeHours = updatedPayroll.OvertimeHours;
                payroll.OvertimePayment = updatedPayroll.OvertimePayment; // Actualización adicional
                payroll.Bonus = updatedPayroll.Bonus;
                payroll.TotalSalary = updatedPayroll.TotalSalary;
                payroll.INSS = updatedPayroll.INSS;
                payroll.IR = updatedPayroll.IR;
                payroll.NetSalary = updatedPayroll.NetSalary;
            }
        }

        // Método para eliminar un registro de nómina
        public void DeletePayrollRecord(string id)
        {
            payrollRecords.RemoveAll(p => p.Id == id);
        }

        // Método para calcular el pago total de nómina
        public Payroll CalculatePayroll(string id, string name, decimal baseSalary, decimal overtimeRate, int overtimeHours, decimal bonus)
        {
            Payroll payroll = new Payroll
            {
                Id = id,
                Name = name,
                BaseSalary = baseSalary,
                OvertimeRate = overtimeRate,
                OvertimeHours = overtimeHours,
                OvertimePayment = CalculateOvertimePayment(overtimeRate, overtimeHours),
                Bonus = bonus
            };

            payroll.TotalSalary = baseSalary + payroll.OvertimePayment + bonus;
            payroll.INSS = CalculateINSS(payroll.TotalSalary);
            payroll.IR = CalculateIR(payroll.TotalSalary - payroll.INSS);
            payroll.NetSalary = CalculateNetSalary(payroll.TotalSalary, payroll.INSS, payroll.IR);

            return payroll;
        }

        // Método para calcular el pago por horas extras
        public decimal CalculateOvertimePayment(decimal overtimeRate, int overtimeHours)
        {
            return overtimeRate * overtimeHours;
        }

        // Método para calcular la deducción de INSS (6.25% del salario total)
        public decimal CalculateINSS(decimal totalSalary)
        {
            return totalSalary * 0.0625m;
        }

        // Método para calcular la deducción del IR (Impuesto sobre la Renta) basado en el salario neto después del INSS
        public decimal CalculateIR(decimal netSalaryAfterINSS)
        {
            decimal ir = 0;

            if (netSalaryAfterINSS > 100000)
            {
                ir = netSalaryAfterINSS * 0.30m; // 30% para salarios mayores de 100,000
            }
            else if (netSalaryAfterINSS > 50000)
            {
                ir = netSalaryAfterINSS * 0.20m; // 20% para salarios entre 50,001 y 100,000
            }
            else if (netSalaryAfterINSS > 25000)
            {
                ir = netSalaryAfterINSS * 0.10m; // 10% para salarios entre 25,001 y 50,000
            }

            return ir;
        }

        // Método para calcular el salario neto después de deducciones
        public decimal CalculateNetSalary(decimal totalSalary, decimal inss, decimal ir)
        {
            return totalSalary - inss - ir;
        }

        // Método para obtener todos los registros de nómina
        public List<Payroll> GetAllPayrollRecords()
        {
            return payrollRecords;
        }
    }
}
