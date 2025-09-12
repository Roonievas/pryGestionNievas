using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestionNievas
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            clsConexionBD_v2 clsConexionBD_V2 = new clsConexionBD_v2();
            clsConexionBD_V2.ConectarBD();

            clsConexionBD_V2.CargarCategorias(cmbCategoría);


            clsConexionBD_v3 conexionSQL = new clsConexionBD_v3();
            conexionSQL.ConectarBD();
        }
    }
}
