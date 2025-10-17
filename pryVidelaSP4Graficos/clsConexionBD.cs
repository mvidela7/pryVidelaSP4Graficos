using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace pryVidelaSP4Graficos
{
    internal class clsConexionBD
    {
        
        OleDbConnection conexionBaseDatos;
        public string mensaje = "";
        public void ConectarBD(System.Windows.Forms. ToolStripLabel lblmensaje)
        {

            try
            {
                coneccionBaseDatos = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\BaseDatos\\control_transporte.accdb");
                coneccionBaseDatos.Open();

                lblmensaje.Text = "Conectado a la Base de Datos";
                lblmensaje.BackColor = System.Drawing.Color.Green;

            }
            catch (Exception error)
            {
                lblmensaje.Text = "Error de conexion a la Base de Datos" + error.ToString();
                lblmensaje.BackColor = System.Drawing.Color.Red;
            }
        }
        public void Graficos()
        {
            coneccionBaseDatos.Open();

        }
    }
    
}
