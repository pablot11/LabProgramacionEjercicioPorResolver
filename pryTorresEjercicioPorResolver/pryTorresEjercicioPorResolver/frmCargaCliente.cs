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
    public partial class frmCargaCliente : Form
    {
        public frmCargaCliente()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            StreamReader srControlClientes = new StreamReader("./Clientes.txt");

            bool bandera = false;
            while (!srControlClientes.EndOfStream)
            {
                string auxClientes = srControlClientes.ReadLine();
                string[] Clientes = auxClientes.Split(',');


                if (mskIdCliente.Text == Clientes[0]) 
                {
                    MessageBox.Show("Numero del cliente repetido");
                    mskIdCliente.Text = "";
                    bandera = true;
                }
            }
            srControlClientes.Close();

            if (bandera == false)
            {
                StreamWriter srCargaClientes = new StreamWriter("./Clientes.txt", true);
                srCargaClientes.WriteLine(mskIdCliente.Text + "," + txtNombreCliente.Text);
                MessageBox.Show("Cliente cargado");
                srCargaClientes.Close();
                txtNombreCliente.Text = "";
                mskIdCliente.Text = "";
            }





            //true para que no sobreescriba en el archiv

        }   
    }
}
