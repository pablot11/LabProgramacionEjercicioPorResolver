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
    public partial class frmCargaVentas : Form
    {
        public frmCargaVentas()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            StreamWriter srCargarVentas = new StreamWriter("./Ventas.txt", true);
            srCargarVentas.WriteLine(lstClienteId.Text + "," + lstVendedorId.Text + "," + mskNumeroFactura.Text + "," + mskTipoFactura.Text + "," + mskFechaVenta.Text + "," + mskMontoVenta.Text);
            MessageBox.Show("Venta Cargada");
            srCargarVentas.Close();
            lstClienteId.SelectedIndex = -1;
            lstVendedorId.SelectedIndex = -1;
            mskNumeroFactura.Text = "";
            mskTipoFactura.Text = "";
            mskFechaVenta.Text = "";
            mskMontoVenta.Text = "";

        }

        private void frmCargaVentas_Load(object sender, EventArgs e)
        {
            StreamReader srLeerIDVendedor = new StreamReader("./CargaVendedores.txt");
            
            while (!srLeerIDVendedor.EndOfStream)
            {
                string varLeerIDVendedor = srLeerIDVendedor.ReadLine();
                string[] vecLeerIDVendedor = varLeerIDVendedor.Split(',');
                lstVendedorId.Items.Add(vecLeerIDVendedor[0]);
            }
            srLeerIDVendedor.Close();

            StreamReader srLeerIDCliente = new StreamReader("./Clientes.txt");
            while (!srLeerIDCliente.EndOfStream)
            {
                string varLeerIDCliente = srLeerIDCliente.ReadLine();
                string[] vecLeerIDCliente = varLeerIDCliente.Split(',');
                lstClienteId.Items.Add(vecLeerIDCliente[0]);
            }
            srLeerIDCliente.Close();



        }
    }
}
