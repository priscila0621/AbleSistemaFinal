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
        // Ruta del archivo donde se almacenarán los datos de los empleados
        private static readonly string EmployeeFilePath = "employees.dat";
        // Instancia de la clase auxiliar para manejo de archivos
        private static FileHelper fileHelper = new FileHelper();

        // Lista estática que contiene los empleados cargados desde el archivo
        public static List<Employee> Employees = LoadEmployeesFromFile();

        // Agrega un nuevo empleado a la lista y guarda los cambios en el archivo.
        public static void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
            SaveEmployeesToFile();
        }

        // Elimina un empleado de la lista según su ID y guarda los cambios en el archivo
        public static void DeleteEmployee(string employeeId)
        {
            Employees.RemoveAll(e => e.EmployeeID == employeeId); // Elimina empleados que coincidan con el ID
            SaveEmployeesToFile();
        }

        // Obtiene un empleado por su ID
        public static Employee GetEmployee(string employeeId)
        {
            return Employees.Find(e => e.EmployeeID == employeeId);
        }

        // Obtiene todos los empleados almacenados
        public static List<Employee> GetAllEmployees()
        {
            return Employees;
        }

        // Actualiza la información de un empleado existente
        public static bool UpdateEmployee(Employee updatedEmployee)
        {
            var existingEmployee = Employees.FirstOrDefault(emp => emp.EmployeeID == updatedEmployee.EmployeeID);

            if (existingEmployee == null)
            {
                return false;
            }

            // Actualiza las propiedades del empleado encontrado
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

        // Guarda la lista de empleados en el archivo especificado
        private static void SaveEmployeesToFile()
        {
            fileHelper.SaveEmployees(Employees, EmployeeFilePath);
        }

        // Carga la lista de empleados desde el archivo
        private static List<Employee> LoadEmployeesFromFile()
        {
            return fileHelper.LoadEmployees(EmployeeFilePath);
        }
    }
}
