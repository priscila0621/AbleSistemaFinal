using AbleSistemaFinal.Dao;
using AbleSistemaFinal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbleSistemaFinal.Forms
{
    public partial class FrmPayrollRegister : Form
    {
        private readonly EmployeePayrollService _employeePayrollService;
        public FrmPayrollRegister(EmployeePayrollService employeePayrollService)
        {
            _employeePayrollService = employeePayrollService;
            InitializeComponent();

            ConfigureDataGridView(); // Configuración de las columnas del DataGridView
            LoadPayrollRecords();    // Carga los registros al DataGridView
        }
        // Método para configurar las columnas del DataGridView
        private void ConfigureDataGridView()
        {
            DgvPayrollRegister.AutoGenerateColumns = false; // Deshabilita la generación automática de columnas
            DgvPayrollRegister.Columns.Clear();            // Limpia columnas existentes

            // Agrega columnas manualmente
            DgvPayrollRegister.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = "Id", // Propiedad del modelo
                Name = "colId",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            DgvPayrollRegister.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Nombre",
                DataPropertyName = "Name",
                Name = "colName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            DgvPayrollRegister.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Salario Base",
                DataPropertyName = "BaseSalary",
                Name = "colBaseSalary",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }, // Formato monetario
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            DgvPayrollRegister.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Horas Extras",
                DataPropertyName = "OvertimeHours",
                Name = "colOvertimeHours",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            DgvPayrollRegister.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Bono",
                DataPropertyName = "Bonus",
                Name = "colBonus",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" },
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            DgvPayrollRegister.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Salario Neto",
                DataPropertyName = "NetSalary",
                Name = "colNetSalary",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" },
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }

        // Método para cargar registros en el DataGridView
        private void LoadPayrollRecords()
        {
            try
            {
                // Obtiene todos los registros de nómina
                List<Payroll> payrollRecords = _employeePayrollService.GetAllPayrollRecords();

                if (payrollRecords == null || payrollRecords.Count == 0)
                {
                    MessageBox.Show("No hay registros de nómina para mostrar.");
                    DgvPayrollRegister.DataSource = null;
                }
                else
                {
                    DgvPayrollRegister.DataSource = null; // Limpia la fuente de datos
                    DgvPayrollRegister.DataSource = payrollRecords;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los registros: {ex.Message}");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (DgvPayrollRegister.SelectedRows.Count > 0)
            {
                string id = (string)DgvPayrollRegister.SelectedRows[0].Cells["colId"].Value; // Usa el Name de la columna
                _employeePayrollService.DeletePayrollRecord(id);
                LoadPayrollRecords();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un registro para eliminar.");
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (DgvPayrollRegister.SelectedRows.Count > 0)
            {
                // Obtiene el ID del registro seleccionado
                string id = (string)DgvPayrollRegister.SelectedRows[0].Cells["colId"].Value; // Usa el Name de la columna

                // Obtiene el registro del servicio
                Payroll payroll = _employeePayrollService.GetAllPayrollRecords().FirstOrDefault(p => p.Id == id);

                if (payroll != null)
                {
                    // Abre el formulario de edición y le pasa el registro a editar
                    FrmPayroll editForm = new FrmPayroll(payroll, _employeePayrollService);
                    editForm.ShowDialog();

                    // Refresca el DataGridView después de editar
                    LoadPayrollRecords();
                }
                else
                {
                    MessageBox.Show("El registro no fue encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un registro para editar.");
            }
        }

        private void MnuPayroll_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
