using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace pryVidelaSP4Graficos
{
    internal class clsConexionBD
    {
        string CadenaConexion = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ..\\..\\Archivos\\ControlCamiones.accdb";
        OleDbConnection conexionBaseDatos;
        OleDbCommand comandoBaseDatos;
        OleDbDataReader lectorDatos;
        public string mensaje = "";
        
        public void ConectarBD(ToolStripLabel lblmensaje)
        {
            try
            {
                conexionBaseDatos = new OleDbConnection(CadenaConexion);
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
        public void fillChartKM(Chart grafico, Int32 indice)
        {
            try
            {
                grafico.Invalidate();
                grafico.Series.Add("Camiones");
                CambioGrafico(indice, grafico);
                grafico.ChartAreas[0].AxisX.Title = "Camiones";
                grafico.ChartAreas[0].AxisY.Title = "Kilometros";
                grafico.ChartAreas[0].AxisY.Maximum = 6000;
                grafico.ChartAreas[0].AxisY.Interval = 500;
                conexionBaseDatos = new OleDbConnection(CadenaConexion);
                conexionBaseDatos.Open();
                comandoBaseDatos = new OleDbCommand();
                comandoBaseDatos.Connection = conexionBaseDatos;
                lectorDatos = comandoBaseDatos.ExecuteReader();
                
                while (lectorDatos.Read())
                {
                    string nombreCamion = lectorDatos[0].ToString();
                    Int32 kilometros = Convert.ToInt32(lectorDatos[1]);
                    int index = grafico.Series[0].Points.AddY(kilometros);
                    grafico.Series[0].Points[index].AxisLabel = nombreCamion;


                }
                
            }
            catch (Exception error)
            {
                Console.WriteLine("Error al llenar el gráfico: " + error.Message);
            }
        }
        public void GastosPorCamion(Chart grafico, Int32 indice)
        {
            try
            {
                grafico.Invalidate();
                grafico.Series.Add("Camiones");
                CambioGrafico(indice, grafico);
                grafico.ChartAreas[0].AxisX.Title = "Camiones";
                grafico.ChartAreas[0].AxisY.Title = "Litros";
                grafico.ChartAreas[0].AxisY.Maximum = 500;
                grafico.ChartAreas[0].AxisY.Interval = 50;
                conexionBaseDatos = new OleDbConnection(CadenaConexion);
                conexionBaseDatos.Open();
                comandoBaseDatos = new OleDbCommand();
                comandoBaseDatos.Connection = conexionBaseDatos;
                comandoBaseDatos.CommandText = "SELECT Camión, Litros FROM TablaCamiones";
                lectorDatos = comandoBaseDatos.ExecuteReader();

                while (lectorDatos.Read())
                {
                    string nombreCamion = lectorDatos[0].ToString();
                    Int32 litros = Convert.ToInt32(lectorDatos[1]);
                    int index = grafico.Series[0].Points.AddY(litros);
                    grafico.Series[0].Points[index].AxisLabel = nombreCamion;

                }

            }
            catch (Exception error)
            {
                Console.WriteLine("Error al llenar el gráfico: " + error.Message);
            }

        }
        public void KgPorCamion(Chart grafico, Int32 indice)
        {
            try
            {
                grafico.Invalidate();
                grafico.Series.Add("Camiones");
                CambioGrafico(indice, grafico);
                grafico.ChartAreas[0].AxisX.Title = "Camiones";
                grafico.ChartAreas[0].AxisY.Title = "Kilogramos";
                grafico.ChartAreas[0].AxisY.Maximum = 80000;
                grafico.ChartAreas[0].AxisY.Interval = 5000;
                conexionBaseDatos = new OleDbConnection(CadenaConexion);
                conexionBaseDatos.Open();
                comandoBaseDatos = new OleDbCommand();
                comandoBaseDatos.Connection = conexionBaseDatos;
                comandoBaseDatos.CommandText = "SELECT Camión, kg FROM TablaCamiones";
                lectorDatos = comandoBaseDatos.ExecuteReader();

                while (lectorDatos.Read())
                {
                    string nombreCamion = lectorDatos[0].ToString();
                    Int32 litros = Convert.ToInt32(lectorDatos[1]);
                    int index = grafico.Series[0].Points.AddY(litros);
                    grafico.Series[0].Points[index].AxisLabel = nombreCamion;

                }

            }
            catch (Exception error)
            {
                Console.WriteLine("Error al llenar el gráfico: " + error.Message);
            }


        }
        public void GastosViaticos(Chart grafico, Int32 indice)
        {
            try
            {
                grafico.Invalidate();
                grafico.Series.Add("Camiones");
                CambioGrafico(indice, grafico);
                grafico.ChartAreas[0].AxisX.Title = "Camiones";
                grafico.ChartAreas[0].AxisY.Title = "Viaticos";
                grafico.ChartAreas[0].AxisY.Maximum = 600;
                grafico.ChartAreas[0].AxisY.Interval = 100;
                conexionBaseDatos = new OleDbConnection(CadenaConexion);
                conexionBaseDatos.Open();
                comandoBaseDatos = new OleDbCommand();
                comandoBaseDatos.Connection = conexionBaseDatos;
                comandoBaseDatos.CommandText = "SELECT Camión, Viáticos FROM TablaCamiones";
                lectorDatos = comandoBaseDatos.ExecuteReader();

                while (lectorDatos.Read())
                {
                    string nombreCamion = lectorDatos[0].ToString();
                    Int32 viatico = Convert.ToInt32(lectorDatos[1]);
                    int index = grafico.Series[0].Points.AddY(viatico);
                    grafico.Series[0].Points[index].AxisLabel = nombreCamion;

                }

            }
            catch (Exception error)
            {
                Console.WriteLine("Error al llenar el gráfico: " + error.Message);
            }


        }
        private void CambioGrafico(Int32 index, Chart grafico)
        {
            switch (index)
            {
                case 0:
                    grafico.Series[0].ChartType = SeriesChartType.Column;
                    break;
                case 1:
                    grafico.Series[0].ChartType = SeriesChartType.Line;
                    break;
                case 2:
                    grafico.Series[0].ChartType = SeriesChartType.Bar;
                    break;
                case 3:
                    grafico.Series[0].ChartType = SeriesChartType.Bubble;
                    break;
            }
        }


    }

}
