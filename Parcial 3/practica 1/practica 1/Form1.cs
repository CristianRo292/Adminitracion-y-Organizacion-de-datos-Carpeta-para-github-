using System.Text.RegularExpressions;

namespace practica_1
{
    public partial class Practica1 : Form
    {
        crud manejadorArchivos = new crud();
        public Practica1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string usuario, pasware;
            usuario = txtUsuario.Text;
            pasware = txtPasware.Text;
            if (usuario.Length == 0 || pasware.Length == 0)
            {
                MessageBox.Show("Error Faltan Datos", "Error"); // permite colocar texto, y titurlo a la ventan emergente
                return;
            }
            // corroboramos si el archivo existe
            //if (File.Exists("usuario.csv"))
            //{
            //    MessageBox.Show("El acrivo, si existe");
            //}
            //else
            //{
            //    MessageBox.Show("NO hay usuarios Registrados");
            //}
            if (!File.Exists("usuario.csv"))
            {
                MessageBox.Show("No hay usuarios Registrados");
                return;
            }
            // MessageBox.Show("El archivo, si existe");
            StreamReader leerArchivo = File.OpenText("usuario.csv");
            string datoExtraido = "";
            bool estado = false;

            do
            {
                datoExtraido = leerArchivo.ReadLine();
                if (datoExtraido != null)
                {
                    string[] dartos = datoExtraido.Split(" , ");
                    if (usuario.Equals(dartos[0]) && pasware.Equals(dartos[1]))
                    {
                        // MessageBox.Show("El usuario si existe");
                        estado = true;
                        break;

                    }

                }

            }
            while (datoExtraido != null); // se repite mientras el renglon no este bacio

            leerArchivo.Close();
            txtPasware.Clear();
            txtUsuario.Clear();

            if (!estado)
            {
                MessageBox.Show("El usuario no existe", "Error");
                return;
            }
            crud ventCrud = new crud();
            this.Hide(); // ocultamos la ventana actual
            ventCrud.ShowDialog(); // madamos a llamar la otra vetana 
            

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string usuario, pasware;
            usuario = txtUsuario.Text;
            pasware = txtPasware.Text;
            if (usuario.Length == 0 || pasware.Length == 0)
            {
                MessageBox.Show("Error Faltan Datos", "Error"); // permite colocar texto, y titurlo a la ventan emergente
                return;
            }
            if (manejadorArchivos.Cooncidencias(usuario))
            {
                MessageBox.Show("El nombre de usuario \n ya ha sido registrado");
                txtUsuario.Clear();
                txtPasware.Clear();
                return;
            }
            StreamWriter archivo = null;
            archivo = File.AppendText("usuario.csv"); // cramos el archivo
            archivo.WriteLine(usuario + " , " + pasware);
            archivo.Close();
            MessageBox.Show("El usuario se ha guardado", "Guardado");
            // borramos las cajas de texto
            txtUsuario.Clear();
            txtPasware.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //char c = e.KeyChar; // detecta cada caracter que se este precionando en el teclado
            //MessageBox.Show(c.ToString());

            if (!(e.KeyChar >= 97 && e.KeyChar <= 122 
                || e.KeyChar == 32 || e.KeyChar == 8))
            {
                e.Handled = true; // bloquea todos los caratenres que no cumplen con la condicion
            }
        }

        private void txtPasware_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 97 && e.KeyChar <= 122 
                || e.KeyChar == 8 || (e.KeyChar >= 47 && e.KeyChar <= 57)))
            {
                e.Handled = true; // bloquea todos los caratenres que no cumplen con la condicion
            }
        }
    }
}
