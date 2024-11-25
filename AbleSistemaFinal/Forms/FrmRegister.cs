using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AbleSistemaFinal.Dao;
using AbleSistemaFinal.Models;

namespace AbleSistemaFinal.Forms
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
            ConfigureDataGridView();
            LoadEmployees();
        }
        private void LoadEmployees()
        {
            DgvRegister.Rows.Clear();
            foreach (var employee in EmployeeDao.GetAllEmployees())
            {
                DgvRegister.Rows.Add(
                    employee.EmployeeID,
                    employee.Names,
                    employee.LastNames,
                    employee.IdNumber,
                    employee.Birthdate.ToShortDateString(),
                    employee.PhoneNumber,
                    employee.Email,
                    employee.Address,
                    employee.Area,
                    employee.HiringDate.ToShortDateString()
                );
            }
        }
        private void ConfigureDataGridView()
        {
            // Limpiar columnas existentes
            DgvRegister.Columns.Clear();

            // Configurar columnas
            DgvRegister.Columns.Add("colEmployeeID", "ID de Empleado");
            DgvRegister.Columns["colEmployeeID"].DataPropertyName = "EmployeeID";

            DgvRegister.Columns.Add("colNames", "Nombres");
            DgvRegister.Columns["colNames"].DataPropertyName = "Names";

            DgvRegister.Columns.Add("colLastNames", "Apellidos");
            DgvRegister.Columns["colLastNames"].DataPropertyName = "LastNames";

            DgvRegister.Columns.Add("colIdNumber", "Número de Identificación");
            DgvRegister.Columns["colIdNumber"].DataPropertyName = "IdNumber";

            DgvRegister.Columns.Add("colBirthdate", "Fecha de Nacimiento");
            DgvRegister.Columns["colBirthdate"].DataPropertyName = "Birthdate";

            DgvRegister.Columns.Add("colPhoneNumber", "Teléfono");
            DgvRegister.Columns["colPhoneNumber"].DataPropertyName = "PhoneNumber";

            DgvRegister.Columns.Add("colEmail", "Correo Electrónico");
            DgvRegister.Columns["colEmail"].DataPropertyName = "Email";

            DgvRegister.Columns.Add("colAddress", "Dirección");
            DgvRegister.Columns["colAddress"].DataPropertyName = "Address";

            DgvRegister.Columns.Add("colArea", "Área");
            DgvRegister.Columns["colArea"].DataPropertyName = "Area";

            DgvRegister.Columns.Add("colHiringDate", "Fecha de Contratación");
            DgvRegister.Columns["colHiringDate"].DataPropertyName = "HiringDate";

            // Ajustar el tamaño de las columnas automáticamente
            DgvRegister.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (DgvRegister.SelectedRows.Count > 0)
            {
                string employeeId = DgvRegister.SelectedRows[0].Cells[0].Value.ToString();
                EmployeeDao.DeleteEmployee(employeeId);
                LoadEmployees();
                MessageBox.Show("Empleado eliminado.");
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (DgvRegister.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un registro para editar.");
                return;
            }

            // Obtener el ID del empleado seleccionado
            string employeeId = DgvRegister.SelectedRows[0].Cells["colEmployeeID"].Value.ToString();
            var employee = EmployeeDao.GetEmployee(employeeId);

            if (employee == null)
            {
                MessageBox.Show("No se encontró el registro del empleado.");
                return;
            }

            // Crear y mostrar el formulario de edición
            FrmEmployeeReg editForm = new FrmEmployeeReg
            {
                IsEditMode = true // Establecer el formulario en modo de edición
            };

            // Llenar los campos del formulario con los datos del empleado
            editForm.TbID.Text = employee.EmployeeID;
            editForm.TbNames.Text = employee.Names;
            editForm.TbLastNames.Text = employee.LastNames;
            editForm.TbIdNumber.Text = employee.IdNumber;
            editForm.DtpBirthdate.Value = employee.Birthdate;
            editForm.TbPhoneNumber.Text = employee.PhoneNumber;
            editForm.TbEmail.Text = employee.Email;
            editForm.TbAddress.Text = employee.Address;
            editForm.CbArea.Text = employee.Area;
            editForm.DtpHiringDate.Value = employee.HiringDate;

            // Mostrar el formulario de edición como modal
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                // Crear un objeto empleado actualizado
                var updatedEmployee = new Employee
                {
                    EmployeeID = editForm.TbID.Text,
                    Names = editForm.TbNames.Text,
                    LastNames = editForm.TbLastNames.Text,
                    IdNumber = editForm.TbIdNumber.Text,
                    Birthdate = editForm.DtpBirthdate.Value,
                    PhoneNumber = editForm.TbPhoneNumber.Text,
                    Email = editForm.TbEmail.Text,
                    Address = editForm.TbAddress.Text,
                    Area = editForm.CbArea.Text,
                    HiringDate = editForm.DtpHiringDate.Value
                };

                // Llamar al método UpdateEmployee para actualizar los datos
                bool isUpdated = EmployeeDao.UpdateEmployee(updatedEmployee);

                if (isUpdated)
                {
                    MessageBox.Show("Registro del empleado actualizado exitosamente.");
                    LoadEmployees(); // Actualizar el DataGridView
                }
                else
                {
                    MessageBox.Show("Error al actualizar el registro del empleado.");
                }
            }
        }

        private void MnuRegister_Click(object sender, EventArgs e)
        {
            FrmEmployeeReg employeeregisterForm = new FrmEmployeeReg();
            employeeregisterForm.Show();
        }

        private void BtnReportRegister_Click(object sender, EventArgs e)
        {

        }
    }
}
