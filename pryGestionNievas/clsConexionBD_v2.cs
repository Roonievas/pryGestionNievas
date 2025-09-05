using System;
using System.Collections.Generic;
//Para conectar el acces
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Windows.Forms;


namespace pryGestionNievas
{
    internal class clsConexionBD_v2
    {
        //cadena de conexion
        //sql - string cadenaConexion = "Server=localhost;Database=Ventas2;Trusted_Connection=True;";
        string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../productos.accdb";
        //conector
        //SqlConnection coneccionBaseDatos;
        OleDbConnection coneccionBaseDatos;
        //comando
        //SqlCommand comandoBaseDatos;
        OleDbCommand comandoBaseDatos;

        //para leer la base de datos
        //va si o si
        OleDbDataReader lectorDataReader;

        public string nombreBaseDeDatos;

        public void ConectarBD()
        {
            try
            {
                //coneccionBaseDatos = new SqlConnection(cadenaConexion);
                coneccionBaseDatos = new OleDbConnection(cadenaConexion);

                nombreBaseDeDatos = Path.GetFileName( coneccionBaseDatos.DataSource);

                coneccionBaseDatos.Open();

                MessageBox.Show("Conectado a " + nombreBaseDeDatos);
            }
            catch (Exception error)
            {
                MessageBox.Show("Tiene un errorcito - " + error.Message);
            }

        }

        public void cargarCategorias(ComboBox listaCategoria)
        {
            //Creo en memoria el objeto
            comandoBaseDatos = new OleDbCommand();
            //dar indicaciones que quiero hacer en la bd
            comandoBaseDatos.Connection = coneccionBaseDatos;
            //setencia sql para consultar la base
            comandoBaseDatos.CommandType = System.Data.CommandType.Text;

            comandoBaseDatos.CommandText = "SELECT Nombre FROM tablaproducto";

            lectorDataReader = comandoBaseDatos.ExecuteReader();

            while (lectorDataReader.Read())
            {
                listaCategoria.Items.Add(lectorDataReader[0]);

            }
        }
    }
}
