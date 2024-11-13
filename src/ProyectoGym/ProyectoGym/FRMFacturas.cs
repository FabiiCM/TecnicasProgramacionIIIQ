using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

namespace ProyectoGym
{
    public partial class FRMFacturas : Form
    {
        private const string CarpetaAccess = "Access";
        private const string ArchivoFacturas = "C:\\sources\\RepoQ3\\src\\ProyectoGym\\ProyectoGym\\bin\\Debug\\net8.0-windows\\Assets\\clientes.xlsx";

        public FRMFacturas()
        {
            InitializeComponent();
        }

        private void FRMFacturas_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerarFacturas_Click(object sender, EventArgs e)
        {
           

            // Confirmación al usuario
            MessageBox.Show("Facturas generadas y guardadas en el archivo Excel.", "Facturación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GenerarFacturasExcel(List<Cliente> clientes)
        {
            throw new NotImplementedException();
        }

        private List<Cliente> ObtenerClientes()
        {
            throw new NotImplementedException();
        }
    }
}
