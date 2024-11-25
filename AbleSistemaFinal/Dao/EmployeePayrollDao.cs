using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbleSistemaFinal.Models;

namespace AbleSistemaFinal.Dao
{
    public class EmployeePayrollDao
    {
        private const decimal INSSRate = 0.07m; // 7% de deducción por INSS
        private const decimal IRThreshold = 8333.33m; // Exención de IR (mensual)
        private const decimal IRRate = 0.15m; // Tasa IR del 15%

        public EmployeePayroll CalculateDeductions(EmployeePayroll employee)
        {
            // Calcular el pago por horas extras
            decimal overtimePay = employee.OvertimeHours * employee.OvertimePayRate;

            // Calcular el salario bruto (Base + Horas Extras + Bonificaciones)
            decimal grossSalary = employee.BaseSalary + overtimePay + employee.Bonus;

            // Calcular deducción por INSS
            employee.INSSDeduction = grossSalary * INSSRate;

            // Calcular la base imponible para IR (Salario Bruto - INSS)
            decimal taxableIncome = grossSalary - employee.INSSDeduction;

            // Calcular deducción por IR si excede el umbral
            employee.IRDeduction = taxableIncome > IRThreshold
                ? (taxableIncome - IRThreshold) * IRRate
                : 0;

            // Calcular el salario neto (Salario Bruto - Deducciones)
            employee.TotalSalary = grossSalary - employee.INSSDeduction - employee.IRDeduction;

            return employee;
        }
    }
}
