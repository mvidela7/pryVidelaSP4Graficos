using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace pryVidelaSP4Graficos
{
    internal class clsConexionBD
    {
        
        OleDbConnection conexionBaseDatos;
        OleDbCommand comandoBaseDatos;
        public string mensaje = "";
        public void ConectarBD(ToolStripLabel lblmensaje)
        {
            try
            {
                conexionBaseDatos = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\Archivos\\control_transporte.accdb");
                mensaje = "Conexion Exitosa a la Base de Datos";
                lblmensaje.Text = mensaje;
                lblmensaje.BackColor = Color.LightGreen;
                

            }
            catch (Exception error)
            {
                lblmensaje.Text = "Error de conexion a la Base de Datos" + error.ToString();
                lblmensaje.BackColor = System.Drawing.Color.Red;
            }
        }
        public void fillChart(Chart grafico)
        {
            Series datosSerie = new Series("KM recorridos por camión");
            datosSerie.ChartType = SeriesChartType.Column;

            try
            {
                conexionBaseDatos.Open();
                string consultaSQL = "SELECT [Camión], [Kilómetros] FROM transporte";

                comandoBaseDatos = new OleDbCommand(consultaSQL, conexionBaseDatos);
                OleDbDataReader lectorDatos = comandoBaseDatos.ExecuteReader();

                grafico.Series.Clear();
                Random random = new Random();

                while (lectorDatos.Read())
                {
                    string nombreCamion = lectorDatos["Camión"].ToString();
                    decimal kilometrosRecorridos = Convert.ToDecimal(lectorDatos["Kilómetros"]);
                    int index = datosSerie.Points.AddXY(nombreCamion, kilometrosRecorridos);

                    // Agrego un color difente a cada barra
                    datosSerie.Points[index].Color = Color.FromArgb
                       (
                        random.Next(50, 256),
                        random.Next(50, 256),
                        random.Next(50, 256)
                        );
                }

                grafico.Series.Add(datosSerie);
            }
            catch (Exception error)
            {
                Console.WriteLine("Error al llenar el gráfico: " + error.Message);
            }
        }

    }

}
