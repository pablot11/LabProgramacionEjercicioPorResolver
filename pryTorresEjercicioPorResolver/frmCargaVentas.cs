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
            //El streamreader se usa para leer el archivo, inicializa la instancia streamreader en el archivo 
            StreamReader srLeerIDVendedor = new StreamReader("./CargaVendedores.txt");

            //mientras sea distinto a eof pasa lo siguiente
            while (!srLeerIDVendedor.EndOfStream)
            {
                //crea una variable que se le asigna un registro del archivo
                string varLeerIDVendedor = srLeerIDVendedor.ReadLine();
                //se crea un vector que se le asigna la variable, el split divide la cadena en comas
                string[] vecLeerIDVendedor = varLeerIDVendedor.Split(',');
                //Añade a la lista lo que esta en la posicion del vector 
                lstVendedorId.Items.Add(vecLeerIDVendedor[0]);
            }
            srLeerIDVendedor.Close();
            //El streamreader se usa para leer el archivo, inicializa la instancia streamreader en el archivo 
            StreamReader srLeerIDCliente = new StreamReader("./Clientes.txt");
            //mientras sea distinto a eof pasa lo siguiente
            while (!srLeerIDCliente.EndOfStream)
            {
                //crea una variable que se le asigna un registro del archivo
                string varLeerIDCliente = srLeerIDCliente.ReadLine();
                //se crea un vector que se le asigna la variable, el split divide la cadena en comas
                string[] vecLeerIDCliente = varLeerIDCliente.Split(',');
                //Añade a la lista lo que esta en la posicion del vector 
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
