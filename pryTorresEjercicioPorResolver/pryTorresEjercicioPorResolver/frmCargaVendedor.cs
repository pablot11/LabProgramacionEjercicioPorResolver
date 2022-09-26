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
    public partial class frmCargaVendedor : Form
    {
        public frmCargaVendedor()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {


            StreamReader srControlVendedores = new StreamReader("./CargaVendedores.txt");

            bool bandera = false;



            while (!srControlVendedores.EndOfStream)
            {
                string auxVendedores = srControlVendedores.ReadLine();
                string[] vecVendedores = auxVendedores.Split(',');
                if (vecVendedores[0] == auxVendedores)
                {
                    MessageBox.Show("Numero del cliente repetido");
                    mskIdVendedor.Text = "";
                    bandera = true;
                }
            }
            srControlVendedores.Close();

            if (bandera == false)
            {
                StreamWriter srCargaVentas = new StreamWriter("./CargaVendedores.txt", true);
                srCargaVentas.WriteLine(mskIdVendedor.Text + "," + mskActivo.Text + "," + mskComision.Text + "," + txtVendedor.Text);
                MessageBox.Show("Venta Cargada");
                srCargaVentas.Close();
                mskActivo.Text = "";
                mskComision.Text = "";
                mskIdVendedor.Text = "";
                txtVendedor.Text = "";


            }

    


        }
    }
}
