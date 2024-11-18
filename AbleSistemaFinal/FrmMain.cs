using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbleSistemaFinal
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            SidePanel.Height = BtnCoordination.Height;
            SidePanel.Top = BtnCoordination.Top;
        }

        private void BtnCoordination_Click(object sender, EventArgs e)
        {
            OpenLogInForm("Coordinator");
            SidePanel.Height = BtnCoordination.Height;
            SidePanel.Top = BtnCoordination.Top;
            FrmLogIn logInForm = new FrmLogIn();
            logInForm.Show();
        }

        private void BtnAdministration_Click(object sender, EventArgs e)
        {
            OpenLogInForm("Admin");
            SidePanel.Height = BtnAdministration.Height;
            SidePanel.Top = BtnAdministration.Top;
            FrmLogIn logInForm = new FrmLogIn();
            logInForm.Show();
        }

        private void BtnPrincipal_Click(object sender, EventArgs e)
        {
            OpenLogInForm("Principal");
            SidePanel.Height = BtnPrincipal.Height;
            SidePanel.Top = BtnPrincipal.Top;
            FrmLogIn logInForm = new FrmLogIn();
            logInForm.Show();
        }

        // Método para abrir el formulario de inicio de sesión y pasar el rol de usuario esperado
        private void OpenLogInForm(string role)
        {
            FrmLogIn logInForm = new FrmLogIn();
            logInForm.Tag = role; // Pasar el rol como información adicional al formulario de inicio de sesión
            logInForm.ShowDialog();
        }
    }
}
