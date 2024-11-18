using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbleSistemaFinal.Models
{
    public class Payroll
    {
        public string Id { get; set; } // Cambiado de int a string
        public string Name { get; set; }
        public decimal BaseSalary { get; set; }
        public decimal OvertimeRate { get; set; }
        public int OvertimeHours { get; set; }
        public decimal OvertimePayment { get; set; }
        public decimal Bonus { get; set; }
        public decimal TotalSalary { get; set; }
        public decimal INSS { get; set; }
        public decimal IR { get; set; }
        public decimal NetSalary { get; set; }
    }
}
