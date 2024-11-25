using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbleSistemaFinal.Models;

namespace AbleSistemaFinal.Dao
{
    public class PayrollDao
    {
        private List<EmployeePayroll> employees = new List<EmployeePayroll>();

        // Agregar un empleado a la lista
        public void AddEmployee(EmployeePayroll employee)
        {
            employees.Add(employee);
        }

        // Obtener todos los empleados
        public List<EmployeePayroll> GetAllEmployees()
        {
            return employees;
        }

        // Editar empleado
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
            }
        }

        // Eliminar empleado
        public void DeleteEmployee(string id)
        {
            employees.RemoveAll(e => e.Id == id);
        }
    }
}
