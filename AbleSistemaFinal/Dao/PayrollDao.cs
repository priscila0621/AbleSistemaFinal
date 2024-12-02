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
        // Ruta del archivo donde se almacenarán los datos de nómina
        private readonly string PayrollFilePath = "payroll.dat";

        // Instancia de la clase auxiliar para manejo de archivos
        private FileHelper fileHelper = new FileHelper();

        private List<EmployeePayroll> employees = LoadPayrollFromFile();

        // Agrega un nuevo empleado a la nómina y guarda los cambios en el archivo
        public void AddEmployee(EmployeePayroll employee)
        {
            employees.Add(employee);
            SavePayrollToFile();
        }

        // Obtiene todos los empleados de la nómina
        public List<EmployeePayroll> GetAllEmployees()
        {
            return employees;
        }

        // Actualiza la información de un empleado en la nómina
        public void UpdateEmployee(EmployeePayroll updatedEmployee)
        {
            // Busca el empleado existente por su ID.
            var employee = employees.Find(e => e.Id == updatedEmployee.Id);
            if (employee != null) // Si el empleado existe, actualiza su información
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

        // Elimina un empleado de la nómina según su ID
        public void DeleteEmployee(string id)
        {
            employees.RemoveAll(e => e.Id == id);
            SavePayrollToFile();
        }

        // Guarda la lista de nómina en el archivo especificado
        private void SavePayrollToFile()
        {
            fileHelper.SavePayroll(employees, PayrollFilePath);
        }

        // Carga la lista de nómina desde el archivo
        private static List<EmployeePayroll> LoadPayrollFromFile()
        {
            return new FileHelper().LoadPayroll("payroll.dat");
        }
    }
}
