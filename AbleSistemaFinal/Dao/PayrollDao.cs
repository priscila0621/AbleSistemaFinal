using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbleSistemaFinal.Models;
using AbleSistemaFinal.Services;

namespace AbleSistemaFinal.Dao
{
    public class PayrollDao
    {
        private readonly string PayrollFilePath = "payroll.dat";
        private FileHelper fileHelper = new FileHelper();

        private List<EmployeePayroll> employees = LoadPayrollFromFile();

        public void AddEmployee(EmployeePayroll employee)
        {
            employees.Add(employee);
            SavePayrollToFile();
        }

        public List<EmployeePayroll> GetAllEmployees()
        {
            return employees;
        }

        public void UpdateEmployee(EmployeePayroll updatedEmployee)
        {
            var employee = employees.Find(e => e.Id == updatedEmployee.Id);
            if (employee != null)
            {
                employee.Name = updatedEmployee.Name;
                employee.BaseSalary = updatedEmployee.BaseSalary;
                employee.OvertimeHours = updatedEmployee.OvertimeHours;
                employee.OvertimePayRate = updatedEmployee.OvertimePayRate;
                employee.Bonus = updatedEmployee.Bonus;
                employee.INSSDeduction = updatedEmployee.INSSDeduction;
                employee.IRDeduction = updatedEmployee.IRDeduction;
                employee.TotalSalary = updatedEmployee.TotalSalary;
                SavePayrollToFile();
            }
        }

        public void DeleteEmployee(string id)
        {
            employees.RemoveAll(e => e.Id == id);
            SavePayrollToFile();
        }

        private void SavePayrollToFile()
        {
            fileHelper.SavePayroll(employees, PayrollFilePath);
        }

        private static List<EmployeePayroll> LoadPayrollFromFile()
        {
            return new FileHelper().LoadPayroll("payroll.dat");
        }
    }
}
