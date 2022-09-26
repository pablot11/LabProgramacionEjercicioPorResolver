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
    public partial class frmConsultarCliente : Form
    {
        public frmConsultarCliente()
        {
            InitializeComponent();
        }

        private void dgvConsultaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            StreamReader srClientes = new StreamReader("./Clientes.txt");

            while (!srClientes.EndOfStream)
            {
                string ID = srClientes.ReadLine();
                string [] Clientes = ID.Split(',');
                dgvConsultaCliente.Rows.Add(Clientes[0], Clientes[1]);

            }
            srClientes.Close();


        }
    }
}
