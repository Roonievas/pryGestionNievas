using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace pryGestionNievas
{
    internal class clsConexionBD_v3
    {

        //cadena de conexion
        string cadenaConexion = "Server=localhost;Database=ventas2;Trusted_Connection=True;";
        //string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../dbGestionInventario1.accdb";
        //conector
        SqlConnection coneccionBaseDatos;
        //OleDbConnection coneccionBaseDatos;
        //comando
        SqlCommand comandoBaseDatos;
        //OleDbCommand comandoBaseDatos;
        //OleDbDataReader lectorDataReader;
        public string nombreBaseDeDatos;

        public void ConectarBD()
        {
            try
            {
                coneccionBaseDatos = new SqlConnection(cadenaConexion);
                //coneccionBaseDatos = new OleDbConnection(cadenaConexion);


                nombreBaseDeDatos = Path.GetFileName(coneccionBaseDatos.DataSource);
                coneccionBaseDatos.Open();

                MessageBox.Show("Conectado a " + nombreBaseDeDatos);
            }
            catch (Exception error)
            {
                MessageBox.Show("Tiene un errorcito - " + error.Message);
            }

        }




    }
}
