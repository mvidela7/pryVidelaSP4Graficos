namespace pryVidelaSP4Graficos
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.statusStripPrincipal = new System.Windows.Forms.StatusStrip();
            this.lblConexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.chartGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCamion = new System.Windows.Forms.Button();
            this.btnGastosViaticos = new System.Windows.Forms.Button();
            this.btnGastos = new System.Windows.Forms.Button();
            this.btnKgCamion = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cboTipoGrafico = new System.Windows.Forms.ComboBox();
            this.statusStripPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrafico)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripPrincipal
            // 
            this.statusStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblConexion});
            this.statusStripPrincipal.Location = new System.Drawing.Point(0, 455);
            this.statusStripPrincipal.Name = "statusStripPrincipal";
            this.statusStripPrincipal.Size = new System.Drawing.Size(822, 22);
            this.statusStripPrincipal.TabIndex = 1;
            this.statusStripPrincipal.Text = "statusStrip1";
            // 
            // lblConexion
            // 
            this.lblConexion.Name = "lblConexion";
            this.lblConexion.Size = new System.Drawing.Size(118, 17);
            this.lblConexion.Text = "toolStripStatusLabel1";
            this.lblConexion.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // chartGrafico
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGrafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGrafico.Legends.Add(legend1);
            this.chartGrafico.Location = new System.Drawing.Point(260, 116);
            this.chartGrafico.Name = "chartGrafico";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGrafico.Series.Add(series1);
            this.chartGrafico.Size = new System.Drawing.Size(501, 254);
            this.chartGrafico.TabIndex = 0;
            this.chartGrafico.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnCamion);
            this.panel1.Controls.Add(this.btnGastosViaticos);
            this.panel1.Controls.Add(this.btnGastos);
            this.panel1.Controls.Add(this.btnKgCamion);
            this.panel1.Location = new System.Drawing.Point(72, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 300);
            this.panel1.TabIndex = 9;
            // 
            // btnCamion
            // 
            this.btnCamion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCamion.Location = new System.Drawing.Point(14, 22);
            this.btnCamion.Name = "btnCamion";
            this.btnCamion.Size = new System.Drawing.Size(135, 45);
            this.btnCamion.TabIndex = 4;
            this.btnCamion.Text = "Kilometros por Camión";
            this.btnCamion.UseVisualStyleBackColor = true;
            this.btnCamion.Click += new System.EventHandler(this.btnCamion_Click);
            // 
            // btnGastosViaticos
            // 
            this.btnGastosViaticos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGastosViaticos.Location = new System.Drawing.Point(14, 224);
            this.btnGastosViaticos.Name = "btnGastosViaticos";
            this.btnGastosViaticos.Size = new System.Drawing.Size(135, 45);
            this.btnGastosViaticos.TabIndex = 7;
            this.btnGastosViaticos.Text = "Gastos/Viaticos por Camión";
            this.btnGastosViaticos.UseVisualStyleBackColor = true;
            this.btnGastosViaticos.Click += new System.EventHandler(this.btnGastosViaticos_Click);
            // 
            // btnGastos
            // 
            this.btnGastos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGastos.Location = new System.Drawing.Point(14, 86);
            this.btnGastos.Name = "btnGastos";
            this.btnGastos.Size = new System.Drawing.Size(135, 45);
            this.btnGastos.TabIndex = 5;
            this.btnGastos.Text = "Gastos por Camión";
            this.btnGastos.UseVisualStyleBackColor = true;
            this.btnGastos.Click += new System.EventHandler(this.btnGastos_Click);
            // 
            // btnKgCamion
            // 
            this.btnKgCamion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKgCamion.Location = new System.Drawing.Point(14, 158);
            this.btnKgCamion.Name = "btnKgCamion";
            this.btnKgCamion.Size = new System.Drawing.Size(135, 45);
            this.btnKgCamion.TabIndex = 6;
            this.btnKgCamion.Text = "Kilogramos por Camión";
            this.btnKgCamion.UseVisualStyleBackColor = true;
            this.btnKgCamion.Click += new System.EventHandler(this.btnKgCamion_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(96, 36);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(114, 27);
            this.lblTipo.TabIndex = 12;
            this.lblTipo.Text = "Tipo de Gráfico:";
            // 
            // cboTipoGrafico
            // 
            this.cboTipoGrafico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoGrafico.FormattingEnabled = true;
            this.cboTipoGrafico.Items.AddRange(new object[] {
            "Columna",
            "Línea",
            "Barra",
            "Burbuja"});
            this.cboTipoGrafico.Location = new System.Drawing.Point(72, 65);
            this.cboTipoGrafico.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipoGrafico.Name = "cboTipoGrafico";
            this.cboTipoGrafico.Size = new System.Drawing.Size(169, 21);
            this.cboTipoGrafico.TabIndex = 11;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(822, 477);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cboTipoGrafico);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartGrafico);
            this.Controls.Add(this.statusStripPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.statusStripPrincipal.ResumeLayout(false);
            this.statusStripPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrafico)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStripPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel lblConexion;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrafico;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCamion;
        private System.Windows.Forms.Button btnGastosViaticos;
        private System.Windows.Forms.Button btnGastos;
        private System.Windows.Forms.Button btnKgCamion;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cboTipoGrafico;
    }
}

