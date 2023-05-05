namespace Lab06_WF_Arrays_Contreras
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnResumen = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtnDonut = new System.Windows.Forms.RadioButton();
            this.rbtnPastel = new System.Windows.Forms.RadioButton();
            this.rbtnBarras = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvResumen = new System.Windows.Forms.DataGridView();
            this.ColCondicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPorcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCondicion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chartBarras = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPastel = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDonut = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBarras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPastel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDonut)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResumen
            // 
            this.btnResumen.Location = new System.Drawing.Point(894, 114);
            this.btnResumen.Name = "btnResumen";
            this.btnResumen.Size = new System.Drawing.Size(96, 23);
            this.btnResumen.TabIndex = 28;
            this.btnResumen.Text = "Ver Resumen";
            this.btnResumen.UseVisualStyleBackColor = true;
            this.btnResumen.Click += new System.EventHandler(this.btnResumen_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chartDonut);
            this.groupBox3.Controls.Add(this.rbtnDonut);
            this.groupBox3.Controls.Add(this.chartPastel);
            this.groupBox3.Controls.Add(this.rbtnPastel);
            this.groupBox3.Controls.Add(this.chartBarras);
            this.groupBox3.Controls.Add(this.rbtnBarras);
            this.groupBox3.Location = new System.Drawing.Point(786, 379);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(315, 228);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // rbtnDonut
            // 
            this.rbtnDonut.AutoSize = true;
            this.rbtnDonut.Location = new System.Drawing.Point(223, 37);
            this.rbtnDonut.Name = "rbtnDonut";
            this.rbtnDonut.Size = new System.Drawing.Size(54, 17);
            this.rbtnDonut.TabIndex = 20;
            this.rbtnDonut.TabStop = true;
            this.rbtnDonut.Text = "Donut";
            this.rbtnDonut.UseVisualStyleBackColor = true;
            this.rbtnDonut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbtnDonut_MouseClick);
            // 
            // rbtnPastel
            // 
            this.rbtnPastel.AutoSize = true;
            this.rbtnPastel.Location = new System.Drawing.Point(136, 37);
            this.rbtnPastel.Name = "rbtnPastel";
            this.rbtnPastel.Size = new System.Drawing.Size(54, 17);
            this.rbtnPastel.TabIndex = 1;
            this.rbtnPastel.TabStop = true;
            this.rbtnPastel.Text = "Pastel";
            this.rbtnPastel.UseVisualStyleBackColor = true;
            this.rbtnPastel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbtnPastel_MouseClick);
            // 
            // rbtnBarras
            // 
            this.rbtnBarras.AutoSize = true;
            this.rbtnBarras.Location = new System.Drawing.Point(43, 37);
            this.rbtnBarras.Name = "rbtnBarras";
            this.rbtnBarras.Size = new System.Drawing.Size(55, 17);
            this.rbtnBarras.TabIndex = 0;
            this.rbtnBarras.TabStop = true;
            this.rbtnBarras.Text = "Barras";
            this.rbtnBarras.UseVisualStyleBackColor = true;
            this.rbtnBarras.CheckedChanged += new System.EventHandler(this.rbtnBarras_CheckedChanged);
            this.rbtnBarras.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbtnBarras_MouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvResumen);
            this.groupBox2.Location = new System.Drawing.Point(786, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 213);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resumen";
            // 
            // dgvResumen
            // 
            this.dgvResumen.AllowUserToAddRows = false;
            this.dgvResumen.AllowUserToDeleteRows = false;
            this.dgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCondicion,
            this.ColCantidad,
            this.ColPorcentaje});
            this.dgvResumen.Location = new System.Drawing.Point(6, 19);
            this.dgvResumen.Name = "dgvResumen";
            this.dgvResumen.ReadOnly = true;
            this.dgvResumen.Size = new System.Drawing.Size(303, 188);
            this.dgvResumen.TabIndex = 0;
            // 
            // ColCondicion
            // 
            this.ColCondicion.HeaderText = "Condición";
            this.ColCondicion.Name = "ColCondicion";
            this.ColCondicion.ReadOnly = true;
            this.ColCondicion.Width = 110;
            // 
            // ColCantidad
            // 
            this.ColCantidad.HeaderText = "Cantidad";
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.ReadOnly = true;
            this.ColCantidad.Width = 75;
            // 
            // ColPorcentaje
            // 
            this.ColPorcentaje.HeaderText = "Procentaje";
            this.ColPorcentaje.Name = "ColPorcentaje";
            this.ColPorcentaje.ReadOnly = true;
            this.ColPorcentaje.Width = 75;
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(169, 379);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.Size = new System.Drawing.Size(596, 228);
            this.dgvLista.TabIndex = 25;
            this.dgvLista.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvLista_CellFormatting);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCondicion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtStock);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.txtProducto);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(169, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 156);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del Producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(258, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Condición:";
            // 
            // txtCondicion
            // 
            this.txtCondicion.BackColor = System.Drawing.Color.White;
            this.txtCondicion.ForeColor = System.Drawing.Color.Black;
            this.txtCondicion.Location = new System.Drawing.Point(321, 113);
            this.txtCondicion.Name = "txtCondicion";
            this.txtCondicion.Size = new System.Drawing.Size(100, 20);
            this.txtCondicion.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(25, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Stock:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(25, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(25, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Producto:";
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtStock.ForeColor = System.Drawing.Color.Black;
            this.txtStock.Location = new System.Drawing.Point(123, 113);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 20);
            this.txtStock.TabIndex = 13;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPrecio.ForeColor = System.Drawing.Color.Black;
            this.txtPrecio.Location = new System.Drawing.Point(123, 72);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 12;
            // 
            // txtProducto
            // 
            this.txtProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtProducto.ForeColor = System.Drawing.Color.Black;
            this.txtProducto.Location = new System.Drawing.Point(123, 34);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(199, 20);
            this.txtProducto.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(166, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ingrese número:";
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtNumero.ForeColor = System.Drawing.Color.Black;
            this.txtNumero.Location = new System.Drawing.Point(255, 143);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 22;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(442, 143);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(361, 143);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 20;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(251, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Busqueda de Productos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chartBarras
            // 
            chartArea3.Name = "ChartArea1";
            this.chartBarras.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartBarras.Legends.Add(legend3);
            this.chartBarras.Location = new System.Drawing.Point(6, 60);
            this.chartBarras.Name = "chartBarras";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Agotado";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Por agotar";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Disponible";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Suficiente";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "En exceso";
            this.chartBarras.Series.Add(series3);
            this.chartBarras.Series.Add(series4);
            this.chartBarras.Series.Add(series5);
            this.chartBarras.Series.Add(series6);
            this.chartBarras.Series.Add(series7);
            this.chartBarras.Size = new System.Drawing.Size(303, 162);
            this.chartBarras.TabIndex = 29;
            this.chartBarras.Text = "chart1";
            // 
            // chartPastel
            // 
            chartArea2.Name = "ChartArea1";
            this.chartPastel.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartPastel.Legends.Add(legend2);
            this.chartPastel.Location = new System.Drawing.Point(6, 60);
            this.chartPastel.Name = "chartPastel";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Condicion";
            this.chartPastel.Series.Add(series2);
            this.chartPastel.Size = new System.Drawing.Size(303, 162);
            this.chartPastel.TabIndex = 30;
            this.chartPastel.Text = "chart1";
            // 
            // chartDonut
            // 
            chartArea1.Name = "Condicion";
            this.chartDonut.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDonut.Legends.Add(legend1);
            this.chartDonut.Location = new System.Drawing.Point(6, 60);
            this.chartDonut.Name = "chartDonut";
            series1.ChartArea = "Condicion";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Condicion";
            this.chartDonut.Series.Add(series1);
            this.chartDonut.Size = new System.Drawing.Size(303, 162);
            this.chartDonut.TabIndex = 31;
            this.chartDonut.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 702);
            this.Controls.Add(this.btnResumen);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBarras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPastel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDonut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResumen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtnDonut;
        private System.Windows.Forms.RadioButton rbtnPastel;
        private System.Windows.Forms.RadioButton rbtnBarras;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvResumen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCondicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPorcentaje;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCondicion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBarras;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPastel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDonut;
    }
}

