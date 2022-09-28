using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

        }

        private void vendeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
     
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (File.Exists("./Clientes.txt"))
            {
               
            }
            else
            {
                File.Create("./Clientes.txt");
             
            }
            if (File.Exists("./CargaVendedores.txt"))
            {



            }
            else
            {
                File.Create("./CargaVendedores.txt");

            }
            if (File.Exists("./Ventas.txt"))
            {

            }
            else
            {
                File.Create("./Ventas.txt");

            }
       

        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargaVendedor objVentanaVendedor = new frmCargaVendedor();
            objVentanaVendedor.ShowDialog();
        }
       
        private void ventasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCargaVentas objVentanaVentas = new frmCargaVentas();
            objVentanaVentas.ShowDialog();
        }

        private void ventasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmConsultaVentas objVentanaConsultaVentas = new frmConsultaVentas();
            objVentanaConsultaVentas.ShowDialog();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
