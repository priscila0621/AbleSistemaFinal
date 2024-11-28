using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbleSistemaFinal.Models;

namespace AbleSistemaFinal.Services
{
    public class FileHelper
    {
        // Guardar empleados en archivo binario
        public void SaveEmployees(List<Employee> employees, string filePath)
        {
            using (FileStream file = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                using (BinaryWriter writer = new BinaryWriter(file))
                {
                    foreach (var employee in employees)
                    {
                        writer.Write(employee.EmployeeID);
                        writer.Write(employee.Names.Length);
                        writer.Write(employee.Names.ToCharArray());
                        writer.Write(employee.LastNames.Length);
                        writer.Write(employee.LastNames.ToCharArray());
                        writer.Write(employee.IdNumber);
                        writer.Write(employee.Birthdate.ToBinary());
                        writer.Write(employee.PhoneNumber);
                        writer.Write(employee.Email.Length);
                        writer.Write(employee.Email.ToCharArray());
                        writer.Write(employee.Address.Length);
                        writer.Write(employee.Address.ToCharArray());
                        writer.Write(employee.Area);
                        writer.Write(employee.HiringDate.ToBinary());
                    }
                }
            }
        }

        // Cargar empleados desde archivo binario
        public List<Employee> LoadEmployees(string filePath)
        {
            var employees = new List<Employee>();
            if (!File.Exists(filePath))
                return employees;

            using (FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader reader = new BinaryReader(file))
                {
                    while (file.Position != file.Length)
                    {
                        var employee = new Employee
                        {
                            EmployeeID = reader.ReadString(),
                            Names = new string(reader.ReadChars(reader.ReadInt32())),
                            LastNames = new string(reader.ReadChars(reader.ReadInt32())),
                            IdNumber = reader.ReadString(),
                            Birthdate = DateTime.FromBinary(reader.ReadInt64()),
                            PhoneNumber = reader.ReadString(),
                            Email = new string(reader.ReadChars(reader.ReadInt32())),
                            Address = new string(reader.ReadChars(reader.ReadInt32())),
                            Area = reader.ReadString(),
                            HiringDate = DateTime.FromBinary(reader.ReadInt64())
                        };
                        employees.Add(employee);
                    }
                }
            }

            return employees;
        }

        // Guardar registros de nómina en archivo binario
        public void SavePayroll(List<EmployeePayroll> payroll, string filePath)
        {
            using (FileStream file = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                using (BinaryWriter writer = new BinaryWriter(file))
                {
                    foreach (var record in payroll)
                    {
                        writer.Write(record.Id);
                        writer.Write(record.Name.Length);
                        writer.Write(record.Name.ToCharArray());
                        writer.Write(record.BaseSalary);
                        writer.Write(record.OvertimeHours);
                        writer.Write(record.OvertimePayRate);
                        writer.Write(record.Bonus);
                        writer.Write(record.INSSDeduction);
                        writer.Write(record.IRDeduction);
                        writer.Write(record.TotalSalary);
                    }
                }
            }
        }

        // Cargar registros de nómina desde archivo binario
        public List<EmployeePayroll> LoadPayroll(string filePath)
        {
            var payroll = new List<EmployeePayroll>();
            if (!File.Exists(filePath))
                return payroll;

            using (FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader reader = new BinaryReader(file))
                {
                    while (file.Position != file.Length)
                    {
                        var record = new EmployeePayroll
                        {
                            Id = reader.ReadString(),
                            Name = new string(reader.ReadChars(reader.ReadInt32())),
                            BaseSalary = reader.ReadDecimal(),
                            OvertimeHours = reader.ReadDecimal(),
                            OvertimePayRate = reader.ReadDecimal(),
                            Bonus = reader.ReadDecimal(),
                            INSSDeduction = reader.ReadDecimal(),
                            IRDeduction = reader.ReadDecimal(),
                            TotalSalary = reader.ReadDecimal()
                        };
                        payroll.Add(record);
                    }
                }
            }

            return payroll;
        }
    }
}
