using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbleSistemaFinal.Models;

namespace AbleSistemaFinal.Services
{
    public class PayrollService
    {
        private const decimal INSSRate = 0.07m; // 7% de deducción por INSS
        private const decimal IRThreshold = 100000m; // Umbral para aplicar IR

        public EmployeePayroll CalculateDeductions(EmployeePayroll employee)
        {
            employee.INSSDeduction = employee.BaseSalary * INSSRate;

            decimal taxableIncome = employee.BaseSalary - employee.INSSDeduction + employee.Bonus;
            employee.IRDeduction = taxableIncome > IRThreshold ? (taxableIncome - IRThreshold) * 0.15m : 0;

            decimal overtimePay = employee.OvertimeHours * employee.OvertimePayRate;
            employee.TotalSalary = employee.BaseSalary + overtimePay + employee.Bonus - employee.INSSDeduction - employee.IRDeduction;

            return employee;
        }
    }
}
