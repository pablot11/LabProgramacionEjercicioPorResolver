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
            if (txtNombreVendedor.Text != "" && mskIdVendedor.Text != "" && mskActivo.Text != "" && mskComision.Text != "")
            {
                //El streamreader se usa para leer el archivo, inicializa la instancia streamreader en el archivo 
                StreamReader srControlVendedores = new StreamReader("./CargaVendedores.txt");
                //se crea un booleano con valor de false
                bool bandera = false;
                //mientras sea distinto a eof pasa lo siguiente
                while (!srControlVendedores.EndOfStream)
                {
                    //crea una variable que se le asigna un registro del archivo
                    string auxVendedores = srControlVendedores.ReadLine();
                    //se crea un vector que se le asigna la variable, el split divide la cadena en comas
                    string[] vecVendedores = auxVendedores.Split(',');
                    //Pregunta si la masked es igual al ID almacenado en el vector
                    if (vecVendedores[0] == auxVendedores)
                    {
                        MessageBox.Show("Numero del cliente repetido");
                        mskIdVendedor.Text = "";
                        // el booleano toma el true, por lo cual no entra al siguiente if
                        bandera = true;
                    }
                }
                srControlVendedores.Close();
                //Si el booleano tiene el valor false entra
                if (bandera == false)
                {
                    //streamwriter crea y editar el archivo, true para que verifique que el archivo existe lo va a recorrer si no lo crea
                    StreamWriter srCargaVentas = new StreamWriter("./CargaVendedores.txt", true);
                    //escribe un registro con los siguientes controles++
                    srCargaVentas.WriteLine(mskIdVendedor.Text + "," + mskActivo.Text + "," + mskComision.Text + "," + txtNombreVendedor.Text);
                    MessageBox.Show("Venta Cargada");
                    srCargaVentas.Close();
                    mskActivo.Text = "";
                    mskComision.Text = "";
                    mskIdVendedor.Text = "";
                    txtNombreVendedor.Text = "";


                }

            }
            else
            {
                MessageBox.Show("Complete todos los campos");
            }




        }

        private void frmCargaVendedor_Load(object sender, EventArgs e)
        {

        }
    }
}
