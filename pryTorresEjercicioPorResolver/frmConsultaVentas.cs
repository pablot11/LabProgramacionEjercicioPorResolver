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
    public partial class frmConsultaVentas : Form
    {
        public frmConsultaVentas()
        {
            InitializeComponent();
        }
     
        private void btnConsultarVenta_Click(object sender, EventArgs e)
        {
            dgvConsultaVentas.Rows.Clear(); 


            //Streamreader es para leer archivos y se le asigna a una variable, inicializa la instancia streamreader para el archivo
            StreamReader srLectorVentas = new StreamReader("./Ventas.txt");
 
            // Mientras sea distinto a final de archivo
            while (!srLectorVentas.EndOfStream)
            {   
                    // se crea una variable para leer un registro del archivo
                    string varVentas = srLectorVentas.ReadLine();
                    // se crea un vector para la variable varVentas y con el split divide la cadena que contiene y lo hace subcadena 
                    //separando con una coma
                    string[] vecVentas = varVentas.Split(',');
                    // Añade filas a la grilla con las posiciones del vector
                    dgvConsultaVentas.Rows.Add(vecVentas[3], vecVentas[2], vecVentas[4], vecVentas[0], vecVentas[1], vecVentas[5]);
                    
            }
            srLectorVentas.Close();

        }

        private void frmConsultaVentas_Load(object sender, EventArgs e)
        {

        }
    }
}
