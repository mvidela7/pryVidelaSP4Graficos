using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryVidelaSP4Graficos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            cboTipoGrafico.SelectedIndex = 0;
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            clsConexionBD conexion = new clsConexionBD();
            conexion.ConectarBD(lblConexion);
        }

        private void btnCamion_Click(object sender, EventArgs e)
        {
        
            clsConexionBD clsConexionBD = new clsConexionBD();
            clsConexionBD.fillChartKM(chartGrafico, cboTipoGrafico.SelectedIndex);
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {

            clsConexionBD clsConexionBD = new clsConexionBD();
            clsConexionBD.GastosPorCamion(chartGrafico, cboTipoGrafico.SelectedIndex);
        }

        private void btnKgCamion_Click(object sender, EventArgs e)
        {
            clsConexionBD clsConexionBD = new clsConexionBD();
            clsConexionBD.GastosPorCamion(chartGrafico, cboTipoGrafico.SelectedIndex);
        }

        private void btnGastosViaticos_Click(object sender, EventArgs e)
        {
            clsConexionBD clsConexionBD = new clsConexionBD();
            clsConexionBD.GastosViaticos(chartGrafico, cboTipoGrafico.SelectedIndex);
        }
    }
}
