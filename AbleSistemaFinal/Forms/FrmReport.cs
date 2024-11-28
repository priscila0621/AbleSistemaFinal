using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;


namespace AbleSistemaFinal.Forms
{
    public partial class FrmReport : Form
    {
        private string reportPath;
        private object reportData;
        public FrmReport(string reportPath, object reportData)
        {
            InitializeComponent();
            this.reportPath = reportPath;
            this.reportData = reportData;
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            try
            {
                // Configurar la ruta del reporte
                string basePath = AppDomain.CurrentDomain.BaseDirectory;
                ReportViewer.LocalReport.ReportPath = System.IO.Path.Combine(basePath, "Reports", reportPath);

                // Determinar el nombre del DataSource dinámicamente
                string dataSourceName = reportPath.Contains("Payroll") ? "DsPayroll" : "DsEmployee";

                // Limpiar y cargar los datos al ReportViewer
                ReportDataSource dataSource = new ReportDataSource(dataSourceName, reportData);
                ReportViewer.LocalReport.DataSources.Clear();
                ReportViewer.LocalReport.DataSources.Add(dataSource);

                // Refrescar el ReportViewer
                ReportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error mientras se cargaba el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
