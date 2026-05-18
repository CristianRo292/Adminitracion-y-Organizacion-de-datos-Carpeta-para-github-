using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_1
{
    public partial class crud : Form
    {
        // Variables para guardar la celda seleccionada / Variables to store selected cell
        int _idCeldaSelec = -1, _idColumnaSelec = -1;

        // Guardamos el usuario actual / Store current user
        string _usuario = "";

        public crud() // consturctor de la clase
        {
            InitializeComponent();
            precargaDeDatos();
        }

        // Cargamos los datos desde el archivo / Load data from file
        private void precargaDeDatos()
        {
            dataUsuario_crud.Rows.Clear();
            int contRegist = 0;

            // Abrimos el archivo csv / Open csv file
            StreamReader leerArchivo = File.OpenText("usuario.csv");
            string datoExtraido = "";

            do
            {
                datoExtraido = leerArchivo.ReadLine();

                if (datoExtraido != null)
                {
                    // Separamos los datos / Split data
                    string[] datos = datoExtraido.Split(" , ");
                    contRegist++;

                    // Agregamos datos a la tabla / Add data to table
                    dataUsuario_crud.Rows.Add(contRegist.ToString(), datos[0], datos[1]);
                }

            }
            while (datoExtraido != null); // se repite mientras el renglon no este bacio

            // Cerramos el archivo / Close file
            leerArchivo.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_crud_Click(object sender, EventArgs e)
        {
            Application.Exit(); // forzamos a cerrar todo el programa
        }

        private void dataUsuario_crud_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("Se ha actuva por el click");

        }

        private void dataUsuario_crud_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Se ha actuva por el click en la celda");

            // Guardamos la fila y columna seleccionada / Save selected row and column
            _idCeldaSelec = e.RowIndex;
            _idColumnaSelec = e.ColumnIndex;

            if (_idCeldaSelec != -1)
            {
                // Extraemos datos de la tabla / Extract data from table
                string idT = dataUsuario_crud.Rows[_idCeldaSelec].Cells[0].Value.ToString(); // del valor de la tanbla seleeciona el valor y damelo
                string usuarioT = dataUsuario_crud.Rows[_idCeldaSelec].Cells[1].Value.ToString();
                string paswareT = dataUsuario_crud.Rows[_idCeldaSelec].Cells[2].Value.ToString();

                // Guardamos el usuario seleccionado / Store selected user
                _usuario = usuarioT;

                // Mostramos datos en textbox / Show data in textbox
                txtUsuario_crud.Text = usuarioT;
                txtPasware_crud.Text = paswareT;

                // Activamos botones / Enable buttons
                btnEliminar_crud.Enabled = true;
                btnAcivar_crud.Enabled = true;
            }
        }

        private void btnAcivar_crud_Click(object sender, EventArgs e)
        {
            // Mostramos botones de edición / Show edit buttons
            btnModificar_crud.Visible = true;
            btnEliminar_crud.Visible = false;
            btnAcivar_crud.Visible = false;

            // Activamos los textbox / Enable textboxes
            txtUsuario_crud.Enabled = true;
            txtPasware_crud.Enabled = true;
        }

        private void btnEliminar_crud_Click(object sender, EventArgs e)
        {
            // Validamos selección / Validate selection
            if (_idCeldaSelec == -1)
            {
                return;
            }

            // Eliminamos fila seleccionada / Remove selected row
            dataUsuario_crud.Rows.RemoveAt(_idCeldaSelec); // eliminamos un elemto de la tabla

            // Desactivamos botones / Disable buttons
            btnEliminar_crud.Enabled = false;
            btnAcivar_crud.Enabled = false;

            // Reiniciamos variables / Reset variables
            _idCeldaSelec = -1; // receteamos la variable

            // Eliminamos del archivo / Delete from file
            EliminarDelArchivo();

            // Limpiamos cajas de texto / Clear textboxes
            txtPasware_crud.Clear();
            txtUsuario_crud.Clear();
        }

        // Eliminamos usuario del archivo / Delete user from file
        private void EliminarDelArchivo()
        {
            string usuarioName = txtUsuario_crud.Text;
            string datoExtraido = "";

            // Abrimos archivos / Open files
            StreamReader lectorArchivo = File.OpenText("usuario.csv");
            StreamWriter auxiliar = File.AppendText("temp.csv");

            do
            {
                datoExtraido = lectorArchivo.ReadLine();

                if (datoExtraido != null)
                {
                    // Dividimos datos / Split data
                    string[] datos = datoExtraido.Split(" , ");

                    // Verificamos usuario / Verify user
                    if (usuarioName.Equals(datos[0]))
                    {

                    }
                    else
                    {
                        // Guardamos datos temporales / Save temp data
                        auxiliar.WriteLine(datoExtraido);
                    }
                }

            }
            while (datoExtraido != null); // se repite mientras el renglon no este bacio

            // Cerramos archivos / Close files
            auxiliar.Close();
            lectorArchivo.Close();

            // Reemplazamos archivo original / Replace original file
            File.Delete("usuario.csv");
            File.Move("temp.csv", "usuario.csv"); // cambiamos el nombre al archio auxiliar

            MessageBox.Show("El usuario ha sido eliminado 🧐");
        }

        // Buscamos coincidencias / Search matches
        public bool Cooncidencias(string datosBusqueda, string nombreArchivo = "usuario.csv")
        {
            try
            {
                // Abrimos archivo / Open file
                StreamReader lectorArchivo = File.OpenText(nombreArchivo);
                string datosTem = "";

                //bool estado = false;
                do
                {
                    datosTem = lectorArchivo.ReadLine();

                    if (datosTem != null)
                    {
                        // Dividimos datos / Split data
                        string[] datoB = datosTem.Split(" , ");

                        // Validamos coincidencia / Validate match
                        if (datoB[0].Equals(datosBusqueda))
                        {
                            //estado = true;

                            // Cerramos archivo / Close file
                            lectorArchivo.Close();
                            return true;
                        }
                    }

                }
                while (datosTem != null);

                // Cerramos archivo / Close file
                lectorArchivo.Close();
                return false;
            }
            catch (Exception ex)
            {
                // Mostramos error en consola / Show error in console
                Debug.WriteLine("Error: " + ex.Message);
                return false;
            }

        }

        private void btnModificar_crud_Click(object sender, EventArgs e)
        {
            // Validamos selección / Validate selection
            if (_idCeldaSelec == -1)
            {
                return;
            }

            // Modificamos usuario / Modify user
            modificarUsuario();

            // Recargamos datos / Reload data
            precargaDeDatos();

            // Limpiamos textbox / Clear textboxes
            txtPasware_crud.Clear();
            txtUsuario_crud.Clear();

            // Desactivamos edición / Disable editing
            txtPasware_crud.Enabled = false;
            txtUsuario_crud.Enabled = false;

            //btnModificar_crud.Enabled = false;

            // Restauramos botones / Restore buttons
            btnEliminar_crud.Enabled = false;
            btnEliminar_crud.Visible = true;
            btnModificar_crud.Visible = false;
            btnAcivar_crud.Visible = true;
            btnAcivar_crud.Enabled = false;
        }

        // Modificamos usuario en archivo / Modify user in file
        private void modificarUsuario()
        {
            string usuarioName = txtUsuario_crud.Text;
            string pasware = txtPasware_crud.Text;

            //if (! Cooncidencias(usuarioName))
            //{
            //    MessageBox.Show("El usuario ya esta registrado");
            //    return;
            //}

            string datoExtraido = "";

            // Abrimos archivos / Open files
            StreamReader lectorArchivo = File.OpenText("usuario.csv");
            StreamWriter auxiliar = File.AppendText("temp.csv");

            do
            {
                datoExtraido = lectorArchivo.ReadLine();

                if (datoExtraido != null)
                {
                    // Separamos datos / Split data
                    string[] datos = datoExtraido.Split(" , ");

                    // Validamos usuario / Validate user
                    if (_usuario.Equals(datos[0])) // si el usuarioe s igual al registrado
                    {
                        // Guardamos datos modificados / Save modified data
                        auxiliar.WriteLine(usuarioName + " , " + pasware); // guardamos los nuevos datos en el temporal
                    }
                    else
                    {
                        // Copiamos datos sin cambios / Copy unchanged data
                        auxiliar.WriteLine(datoExtraido); // el resto lo copiamos igual en el temporal
                    }
                }

            }
            while (datoExtraido != null); // se repite mientras el renglon no este bacio

            // cerramos los archivos
            // Close files
            auxiliar.Close();
            lectorArchivo.Close();

            // Reemplazamos archivo original / Replace original file
            File.Delete("usuario.csv");
            File.Move("temp.csv", "usuario.csv"); // cambiamos el nombre al archio auxiliar

            MessageBox.Show("El usuario fue Modificado 😉", "Modificar Usuario");
        }
    }
}
