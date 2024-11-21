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
    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();
        }


        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            string id = TbId.Text;
            string password = TbPw.Text;
            string expectedRole = this.Tag?.ToString(); // Obtener el rol esperado desde el formulario principal

            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            User user = UserService.Authenticate(id, password);

            if (user == null)
            {
                MessageBox.Show("ID o contraseña incorrecta.");
                return;
            }

            // Verificar si el rol del usuario coincide con el rol esperado
            if (user.Role != expectedRole)
            {
                MessageBox.Show("Acceso denegado para este rol.");
                return;
            }

            // Redireccionar según el rol del usuario
            switch (user.Role)
            {
                case "Coordinator":
                    FrmEmployeeReg employeeRegForm = new FrmEmployeeReg();
                    employeeRegForm.ShowDialog();
                    break;
                case "Admin":
                    // Crear los objetos necesarios para FrmPayroll
                    Payroll payroll = new Payroll(); // Aquí deberías inicializar los datos correctamente
                    EmployeePayrollService employeePayrollService = new EmployeePayrollService(); // Asegúrate de tener el servicio configurado

                    FrmPayroll payrollForm = new FrmPayroll(payroll, employeePayrollService);  // Pasar los objetos al constructor
                    payrollForm.ShowDialog();  // Mostrar el formulario de nómina
                    break;
                case "Principal":
                    MessageBox.Show("Bienvenida, Directora.");
                    // Aquí puedes abrir el formulario correspondiente para Dirección si lo necesitas
                    break;
            }

            this.Close();
        }
    }
}
