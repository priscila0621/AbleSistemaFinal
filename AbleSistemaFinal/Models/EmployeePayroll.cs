using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbleSistemaFinal.Models
{
    public class EmployeePayroll
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal BaseSalary { get; set; }
        public decimal OvertimeHours { get; set; }
        public decimal OvertimePayRate { get; set; }
        public decimal Bonus { get; set; }
        public decimal INSSDeduction { get; set; }
        public decimal IRDeduction { get; set; }
        public decimal TotalSalary { get; set; }
    }
}
