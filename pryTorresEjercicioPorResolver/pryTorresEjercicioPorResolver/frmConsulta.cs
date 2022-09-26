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
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void btnConsultarVenta_Click(object sender, EventArgs e)
        {
            StreamReader srLectorVentas = new StreamReader("./Ventas.txt");
            while (!srLectorVentas.EndOfStream)
            {
                string varVentas = srLectorVentas.ReadLine();
                string[] vecVentas = varVentas.Split(',');
                dgvConsultaVentas.Rows.Add(vecVentas[3], vecVentas[2], vecVentas[4], vecVentas[0], vecVentas[1], vecVentas[5]);

            }
            srLectorVentas.Close();

        }
    }
}
