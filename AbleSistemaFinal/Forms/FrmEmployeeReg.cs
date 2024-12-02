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
    public partial class FrmEmployeeReg : Form
    {
        // Objeto ErrorProvider para mostrar mensajes de error directamente en los controles
        private ErrorProvider errorProvider = new ErrorProvider();

        // Propiedad para identificar si el formulario está en modo de edición
        public bool IsEditMode { get; set; } = false;
        public FrmEmployeeReg()
        {
            InitializeComponent();
            // Inicializar el ComboBox con las áreas disponibles
            CbArea.Items.AddRange(new string[] { "Preescolar", "Primaria", "Mantenimiento", "Limpieza", "Coordinacion", "Direccion" });
        }
                      

        private void BtnSave_Click_1(object sender, EventArgs e)
        {
            // Validar los datos antes de continuar
            if (!ValidarDatos())
            {
                return; // Detener la ejecución si los datos no son válidos
            }

            try
            {
                // Crear un objeto Employee con los datos del formulario
                Employee employee = new Employee
                {
                    EmployeeID = TbID.Text,
                    Names = TbNames.Text,
                    LastNames = TbLastNames.Text,
                    IdNumber = TbIdNumber.Text,
                    Birthdate = DtpBirthdate.Value,
                    PhoneNumber = TbPhoneNumber.Text,
                    Email = TbEmail.Text,
                    Address = TbAddress.Text,
                    Area = CbArea.Text,
                    HiringDate = DtpHiringDate.Value
                };

                // Verificar si el formulario está en modo de edición
                if (IsEditMode)
                {
                    // Actualizar un empleado existente
                    EmployeeDao.UpdateEmployee(employee);
                    MessageBox.Show("Empleado actualizado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Resetear el modo de edición
                    IsEditMode = false;
                }
                else
                {
                    // Agregar un nuevo empleado
                    EmployeeDao.AddEmployee(employee);
                    MessageBox.Show("Empleado registrado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Limpiar los campos después de guardar
                ClearFields();
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error si ocurre una excepción
                MessageBox.Show($"Ocurrió un error al guardar el empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        // Método para limpiar los campos del formulario después de guardar.
        private void ClearFields()
        {
            TbID.Clear();
            TbNames.Clear();
            TbLastNames.Clear();
            TbIdNumber.Clear();
            DtpBirthdate.Value = DateTime.Now;
            TbPhoneNumber.Clear();
            TbEmail.Clear();
            TbAddress.Clear();
            CbArea.SelectedIndex = -1; // Restablecer el ComboBox
            DtpHiringDate.Value = DateTime.Now;

        }

        private void BtnCancel_Click_1(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo de confirmación
            DialogResult result = MessageBox.Show("¿Está seguro de que desea salir sin guardar los cambios?",
                                                  "Confirmación",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            // Cerrar el formulario si el usuario confirma
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
       
        private bool ValidarDatos()
        {
            
            // Validar que el campo de nombres no esté vacío y solo contenga letras
            if (string.IsNullOrWhiteSpace(TbNames.Text) || !TbNames.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                errorProvider.SetError(TbNames, "Ingrese un nombre válido (solo letras y espacios).");
                return false;
            }
            if (TbNames.Text.Length > 50) // Validar que el nombre no exceda 50 caracteres
            {
                errorProvider.SetError(TbNames, "El nombre no puede exceder los 50 caracteres.");
                return false;
            }

            // Validar que el campo de apellidos no esté vacío y solo contenga letras
            if (string.IsNullOrWhiteSpace(TbLastNames.Text) || !TbLastNames.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                errorProvider.SetError(TbLastNames, "Ingrese apellidos válidos (solo letras y espacios).");
                return false;
            }
            if (TbLastNames.Text.Length > 50) // Validar que los apellidos no excedan 50 caracteres
            {
                errorProvider.SetError(TbLastNames, "Los apellidos no pueden exceder los 50 caracteres.");
                return false;
            }

            // Validar que el campo de cédula solo contenga letras o números y tenga 14 caracteres
            if (string.IsNullOrWhiteSpace(TbIdNumber.Text) || !TbIdNumber.Text.All(char.IsLetterOrDigit))
            {
                errorProvider.SetError(TbIdNumber, "La cédula solo puede contener letras y números.");
                return false;
            }
            if (TbIdNumber.Text.Length != 14) // Validar que la cédula tenga exactamente 14 caracteres
            {
                errorProvider.SetError(TbIdNumber, "La cédula debe tener exactamente 14 caracteres.");
                return false;
            }

            // Validar que el número de teléfono solo contenga 8 dígitos
            if (string.IsNullOrWhiteSpace(TbPhoneNumber.Text) || TbPhoneNumber.Text.Length != 8 || !TbPhoneNumber.Text.All(char.IsDigit))
            {
                errorProvider.SetError(TbPhoneNumber, "El número de teléfono debe tener exactamente 8 dígitos.");
                return false;
            }

            // Validar que la dirección no exceda 100 caracteres
            if (TbAddress.Text.Length > 100)
            {
                errorProvider.SetError(TbAddress, "La dirección no puede exceder los 100 caracteres.");
                return false;
            }

            // Validar que el ID no exceda 8 caracteres
            if (string.IsNullOrWhiteSpace(TbID.Text) || TbID.Text.Length > 8)
            {
                errorProvider.SetError(TbID, "El ID no puede exceder los 8 caracteres.");
                return false;
            }

            // Validar que el correo electrónico sea válido (contenga '@' y '.')
            if (string.IsNullOrWhiteSpace(TbEmail.Text) || !TbEmail.Text.Contains("@") || !TbEmail.Text.Contains("."))
            {
                errorProvider.SetError(TbEmail, "Ingrese un correo electrónico válido.");
                return false;
            }
            if (DtpBirthdate.Value >= DateTime.Now)
            {
                errorProvider.SetError(DtpBirthdate, "La fecha de nacimiento no puede ser futura.");
                return false;
            }

            if (DtpHiringDate.Value > DateTime.Now)
            {
                errorProvider.SetError(DtpHiringDate, "La fecha de contratación no puede ser futura.");
                return false;
            }

            // Si todas las validaciones pasan, devolver true
            return true;
        }

        private void MnuSeeRegister_Click_1(object sender, EventArgs e)
        {
            // Abrir el formulario de registros
            FrmRegister registerForm = new FrmRegister();
            registerForm.Show();

        }
    }

}
