using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbleSistemaFinal.Models;
using AbleSistemaFinal.Services;

namespace AbleSistemaFinal.Dao
{
    public static class EmployeeDao
    {
        private static readonly string EmployeeFilePath = "employees.dat";
        private static FileHelper fileHelper = new FileHelper();

        public static List<Employee> Employees = LoadEmployeesFromFile();

        public static void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
            SaveEmployeesToFile();
        }

        public static void DeleteEmployee(string employeeId)
        {
            Employees.RemoveAll(e => e.EmployeeID == employeeId);
            SaveEmployeesToFile();
        }

        public static Employee GetEmployee(string employeeId)
        {
            return Employees.Find(e => e.EmployeeID == employeeId);
        }

        public static List<Employee> GetAllEmployees()
        {
            return Employees;
        }

        public static bool UpdateEmployee(Employee updatedEmployee)
        {
            var existingEmployee = Employees.FirstOrDefault(emp => emp.EmployeeID == updatedEmployee.EmployeeID);

            if (existingEmployee == null)
            {
                return false;
            }

            existingEmployee.Names = updatedEmployee.Names;
            existingEmployee.LastNames = updatedEmployee.LastNames;
            existingEmployee.IdNumber = updatedEmployee.IdNumber;
            existingEmployee.Birthdate = updatedEmployee.Birthdate;
            existingEmployee.PhoneNumber = updatedEmployee.PhoneNumber;
            existingEmployee.Email = updatedEmployee.Email;
            existingEmployee.Address = updatedEmployee.Address;
            existingEmployee.Area = updatedEmployee.Area;
            existingEmployee.HiringDate = updatedEmployee.HiringDate;

            SaveEmployeesToFile();
            return true;
        }

        private static void SaveEmployeesToFile()
        {
            fileHelper.SaveEmployees(Employees, EmployeeFilePath);
        }

        private static List<Employee> LoadEmployeesFromFile()
        {
            return fileHelper.LoadEmployees(EmployeeFilePath);
        }
    }
}
