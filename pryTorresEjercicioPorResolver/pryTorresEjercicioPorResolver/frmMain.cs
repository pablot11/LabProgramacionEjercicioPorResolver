using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTorresEjercicioPorResolver
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargaCliente objVentanaCarga = new frmCargaCliente();
            objVentanaCarga.ShowDialog();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargaVendedor objVentanaCargaVendedor = new frmCargaVendedor();
            objVentanaCargaVendedor.ShowDialog();
        }

        private void vendeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargaVentas objVentanaCargaVenta = new frmCargaVentas();
            objVentanaCargaVenta.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarCliente objVentanaConsultaCliente = new frmConsultarCliente();
            objVentanaConsultaCliente.ShowDialog();        
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsulta objVentanaVentas = new frmConsulta();
            objVentanaVentas.ShowDialog();  
        }
    }
}
