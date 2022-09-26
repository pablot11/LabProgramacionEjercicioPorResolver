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
            //Si estan todos los campos completos pasa al if
            if (mskTipoFactura.Text != "" && lstClienteId.SelectedIndex != -1 && lstVendedorId.SelectedIndex != -1 && mskNumeroFactura.Text != "" && mskFechaVenta.Text != "" && mskMontoVenta.Text != "" )
            {
                //Streamwriter nos permite crear y editar un archivo
                StreamWriter srCargarVentas = new StreamWriter("./Ventas.txt", true);
                // Crea un registro con los siguientes controles
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
            else
            {
                MessageBox.Show("Complete todos los campos");
            }


        }

        private void frmCargaVentas_Load(object sender, EventArgs e)

        {
            //
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

        private void txtNumeroFactura_TextChanged(object sender, EventArgs e)
        {

        }

        private void mskNumeroFactura_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskMontoVenta_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
