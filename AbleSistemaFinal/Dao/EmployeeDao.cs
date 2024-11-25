using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbleSistemaFinal.Models;

namespace AbleSistemaFinal.Dao
{
    public static class EmployeeDao
    {
        public static List<Employee> Employees = new List<Employee>();

        public static void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public static void DeleteEmployee(string employeeId)
        {
            Employees.RemoveAll(e => e.EmployeeID == employeeId);
        }

        public static Employee GetEmployee(string employeeId)
        {
            return Employees.Find(e => e.EmployeeID == employeeId);
        }

        public static List<Employee> GetAllEmployees()
        {
            return Employees;
        }
        // Método para actualizar un empleado existente
        public static bool UpdateEmployee(Employee updatedEmployee)
        {
            // Buscar el empleado en la lista por su ID
            var existingEmployee = Employees.FirstOrDefault(emp => emp.EmployeeID == updatedEmployee.EmployeeID);

            if (existingEmployee == null)
            {
                // Si no se encuentra, retornar false
                return false;
            }

            // Actualizar los datos del empleado
            existingEmployee.Names = updatedEmployee.Names;
            existingEmployee.LastNames = updatedEmployee.LastNames;
            existingEmployee.IdNumber = updatedEmployee.IdNumber;
            existingEmployee.Birthdate = updatedEmployee.Birthdate;
            existingEmployee.PhoneNumber = updatedEmployee.PhoneNumber;
            existingEmployee.Email = updatedEmployee.Email;
            existingEmployee.Address = updatedEmployee.Address;
            existingEmployee.Area = updatedEmployee.Area;
            existingEmployee.HiringDate = updatedEmployee.HiringDate;

            return true; // Indicar que la actualización fue exitosa
        }
    }
}
