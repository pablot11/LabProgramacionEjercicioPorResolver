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
            if (mskIdCliente.Text != "" && txtNombreCliente.Text != "")
            {
                //El streamreader se usa para leer el archivo, inicializa la instancia streamreader en el archivo 
                StreamReader srControlClientes = new StreamReader("./Clientes.txt");
                //se crea un booleano con valor de false
                bool bandera = false;
                //mientras sea distinto a eof pasa lo siguiente
                while (!srControlClientes.EndOfStream)
                {
                    //crea una variable que se le asigna un registro del archivo
                    string auxClientes = srControlClientes.ReadLine();
                    //se crea un vector que se le asigna la variable, el split divide la cadena en comas
                    string[] Clientes = auxClientes.Split(',');
      
                    //Pregunta si la masked es igual al ID almacenado en el vector
                    if (mskIdCliente.Text == Clientes[0])
                    {
                        MessageBox.Show("Numero del cliente repetido");
                        mskIdCliente.Text = "";
                        // el booleano toma el true, por lo cual no entra al siguiente if
                        bandera = true;
                    }
                }
                srControlClientes.Close();
                //Si el booleano tiene el valor false entra
                if (bandera == false)
                {
                    //streamwriter crea y editar el archivo, true para que verifique que el archivo existe y no se sobreescriba si no lo crea
                    StreamWriter srCargaClientes = new StreamWriter("./Clientes.txt", true);
                    //escribe un registro con los siguientes controles
                    srCargaClientes.WriteLine(mskIdCliente.Text + "," + txtNombreCliente.Text);
                    MessageBox.Show("Cliente cargado");
                    srCargaClientes.Close();
                    txtNombreCliente.Text = "";
                    mskIdCliente.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Complete todos los campos");
            }
   


        }

 

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void mskIdCliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
          
        }

        private void frmCargaCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
