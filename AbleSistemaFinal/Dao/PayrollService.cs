using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbleSistemaFinal.Dao
{
    public class PayrollService
    {
        private const decimal INSS_RATE = 0.0625m;

        // Calcular el pago de horas extras
        public decimal CalculateOvertimePayment(decimal rate, int hours) => rate * hours;

        // Calcular el INSS
        public decimal CalculateINSS(decimal totalSalary) => totalSalary * INSS_RATE;

        // Calcular el IR en base al salario después del INSS
        public decimal CalculateIR(decimal salaryAfterINSS)
        {
            if (salaryAfterINSS <= 10000)
                return 0;
            else if (salaryAfterINSS <= 20000)
                return salaryAfterINSS * 0.1m;
            else if (salaryAfterINSS <= 35000)
                return salaryAfterINSS * 0.15m;
            else
                return salaryAfterINSS * 0.2m;
        }

        // Calcular el salario neto
        public decimal CalculateNetSalary(decimal totalSalary, decimal inss, decimal ir) =>
            totalSalary - inss - ir;
    }
}
