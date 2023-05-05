using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06_WF_Arrays_Contreras
{
    public partial class Form1 : Form
    {
        private DataGridViewColumn[] titulo = new DataGridViewColumn[5];
        string[] productos = { "Laptop", "Monitor", "Teclado",
            "Mouse", "Camara Web", "Disco Duro", "Scanner",
            "Impresora", "Tarjeta Grafica", "Memoria RAM",
            "Tarjeta de Red", "Lapiz Optico" };

        double[] precio = { 5800, 999.99, 65.50, 50.00, 120.50,
            200.00, 350.00, 750, 1500, 120, 85, 199 };

        int[] stock = { 10, 15, 0, 5, 30, 25, 12, 8, 0, 50, 35, 7 };

        string condicion = "";

        //Variables para el resumen ejecutivo
        string[] cantidad = new string[10];
        double[] porcentaje = new double[10];
        double tagotado = 0, tporagotar = 0, tdisponible = 0,
            tsuficiente = 0, texceso = 0;
        double total = 0;
        public Form1()
        {
            InitializeComponent();

            titulo[0] = new DataGridViewTextBoxColumn(); //Tipo de Dato
            titulo[0].HeaderText = "Nro.";
            titulo[0].Name = "ColNro";
            titulo[0].Width = 50;

            titulo[1] = new DataGridViewTextBoxColumn();
            titulo[1].HeaderText = "Producto";
            titulo[1].Name = "ColProducto";
            titulo[1].Width = 150;

            titulo[2] = new DataGridViewTextBoxColumn();
            titulo[2].HeaderText = "Precio";
            titulo[2].Name = "ColPrecio";
            titulo[2].Width = 100;

            titulo[3] = new DataGridViewTextBoxColumn();
            titulo[3].HeaderText = "Stock";
            titulo[3].Name = "ColStock";
            titulo[3].Width = 80;

            titulo[4] = new DataGridViewTextBoxColumn();
            titulo[4].HeaderText = "Condición";
            titulo[4].Name = "ColCondicion";
            titulo[4].Width = 150;

            dgvLista.Columns.AddRange(titulo);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvLista_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow Row in dgvLista.Rows)
            {
                //Para filas pares e impares
                int f = Row.Index;

                if ((f % 2) == 0) //Pares
                {
                    Row.DefaultCellStyle.BackColor = Color.SkyBlue;
                }
                else //Impares
                {
                    Row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192);
                }

                //Para la columna condición
                if ((Row.Cells[4].Value).Equals("Agotado"))
                {
                    Row.Cells[4].Style.BackColor = Color.Red;
                    Row.Cells[4].Style.ForeColor = Color.White;
                }
                else if ((Row.Cells[4].Value).Equals("Por agotarse"))
                {
                    Row.Cells[4].Style.BackColor = Color.Orange;
                    Row.Cells[4].Style.ForeColor = Color.White;
                }
                else if ((Row.Cells[4].Value).Equals("Disponible"))
                {
                    Row.Cells[4].Style.BackColor = Color.Yellow;
                    Row.Cells[4].Style.ForeColor = Color.Black;
                }
                else if ((Row.Cells[4].Value).Equals("Suficiente"))
                {
                    Row.Cells[4].Style.BackColor = Color.Blue;
                    Row.Cells[4].Style.ForeColor = Color.White;
                }
                else if ((Row.Cells[4].Value).Equals("Excesivo"))
                {
                    Row.Cells[4].Style.BackColor = Color.Green;
                    Row.Cells[4].Style.ForeColor = Color.White;
                }
            }
        }

        private void rbtnBarras_MouseClick(object sender, MouseEventArgs e)
        {
            chartBarras.Series["Agotado"].Points.Clear();
            chartBarras.Series["Por agotar"].Points.Clear();
            chartBarras.Series["Disponible"].Points.Clear();
            chartBarras.Series["Suficiente"].Points.Clear();
            chartBarras.Series["En exceso"].Points.Clear();
            chartPastel.Visible = false;
            chartDonut.Visible = false;
            chartBarras.Visible = true;

            chartBarras.Series["Agotado"].IsValueShownAsLabel = true;
            chartBarras.Series["Por agotar"].IsValueShownAsLabel = true;
            chartBarras.Series["Disponible"].IsValueShownAsLabel = true;
            chartBarras.Series["Suficiente"].IsValueShownAsLabel = true;
            chartBarras.Series["En exceso"].IsValueShownAsLabel = true;

            chartBarras.Series["Agotado"].Points.AddXY(tagotado, tagotado + 0);
            chartBarras.Series["Por agotar"].Points.AddXY(tporagotar, tporagotar + 0);
            chartBarras.Series["Disponible"].Points.AddXY(tdisponible, tdisponible + 0);
            chartBarras.Series["Suficiente"].Points.AddXY(tsuficiente, tsuficiente + 0);
            chartBarras.Series["En exceso"].Points.AddXY(texceso, texceso + 0);

        }

        private void rbtnPastel_MouseClick(object sender, MouseEventArgs e)
        {
            chartPastel.Series["Condicion"].Points.Clear();
            chartBarras.Visible = false;
            chartDonut.Visible = false;
            chartPastel.Visible = true;

            chartPastel.Series["Condicion"].IsValueShownAsLabel = true;

            chartPastel.Series["Condicion"].Points.AddXY("Agotado", tagotado);
            chartPastel.Series["Condicion"].Points.AddXY("Por agotar", tporagotar);
            chartPastel.Series["Condicion"].Points.AddXY("Disponible", tdisponible);
            chartPastel.Series["Condicion"].Points.AddXY("Suficiente", tsuficiente);
            chartPastel.Series["Condicion"].Points.AddXY("En exceso", texceso);
        }

        private void rbtnDonut_MouseClick(object sender, MouseEventArgs e)
        {
            chartDonut.Series["Condicion"].Points.Clear();
            chartBarras.Visible = false;
            chartPastel.Visible = false;
            chartDonut.Visible = true;

            chartDonut.Series["Condicion"].IsValueShownAsLabel = true;

            chartDonut.Series["Condicion"].Points.AddXY("Agotado", tagotado);
            chartDonut.Series["Condicion"].Points.AddXY("Por agotar", tporagotar);
            chartDonut.Series["Condicion"].Points.AddXY("Disponible", tdisponible);
            chartDonut.Series["Condicion"].Points.AddXY("Suficiente", tsuficiente);
            chartDonut.Series["Condicion"].Points.AddXY("En exceso", texceso);
        }

        private void rbtnBarras_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)

        {
            int buscar, stocks;

            buscar = Convert.ToInt32(txtNumero.Text);
            buscar = buscar - 1;

            if (buscar <= productos.Length)
            {
                txtProducto.Text = productos[buscar];
                txtPrecio.Text = precio[buscar].ToString();
                txtStock.Text = stock[buscar].ToString();
                stocks = stock[buscar];

                if (stocks == 0)
                {
                    condicion = "Agotado";
                    txtCondicion.ForeColor = Color.Red;
                }
                else if (stocks > 0 && stocks <= 10)
                {
                    condicion = "Por agotarse";
                    txtCondicion.ForeColor = Color.Orange;
                }
                else if (stocks > 10 && stocks <= 20)
                {
                    condicion = "Disponible";
                    txtCondicion.ForeColor = Color.YellowGreen;
                }
                else if (stocks > 20 && stocks <= 30)
                {
                    condicion = "Suficiente";
                    txtCondicion.ForeColor = Color.Blue;
                }
                else if (stocks > 30)
                {
                    condicion = "Excesivo";
                    txtCondicion.ForeColor = Color.Green;
                }
                txtCondicion.Text = condicion;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = string.Empty;
            txtProducto.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtStock.Text = string.Empty;
            txtCondicion.Text = string.Empty;
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            double totalPorcentaje = 0;
            dgvResumen.Rows.Clear();
            dgvResumen.Rows.Add("Agotados", tagotado, porcentaje[0]);
            dgvResumen.Rows.Add("Por agotar", tporagotar, porcentaje[1]);
            dgvResumen.Rows.Add("Disponible", tdisponible, porcentaje[2]);
            dgvResumen.Rows.Add("Suficiente", tsuficiente, porcentaje[3]);
            dgvResumen.Rows.Add("Excesivo", texceso, porcentaje[4]);

            totalPorcentaje = Math.Round(porcentaje[0] + porcentaje[1] + porcentaje[2] + porcentaje[3] + porcentaje[4]);

            dgvResumen.Rows.Add("TOTAL", total, totalPorcentaje);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cantidad[0] = 0.ToString();
            cantidad[1] = 0.ToString();
            cantidad[2] = 0.ToString();
            cantidad[3] = 0.ToString();
            cantidad[4] = 0.ToString();

            porcentaje[0] = 0;
            porcentaje[1] = 0;
            porcentaje[2] = 0;
            porcentaje[3] = 0;
            porcentaje[4] = 0;

            dgvLista.Rows.Clear();

            for (int i = 0; i < productos.Length; i++)
            {
                if (stock[i] == 0)
                {
                    condicion = "Agotado";
                    tagotado++;
                }
                else if (stock[i] > 0 && stock[i] <= 10)
                {
                    condicion = "Por agotarse";
                    tporagotar++;
                }
                else if (stock[i] > 10 && stock[i] <= 20)
                {
                    condicion = "Disponible";
                    tdisponible++;
                }
                else if (stock[i] > 20 && stock[i] <= 30)
                {
                    condicion = "Suficiente";
                    tsuficiente++;
                }
                else if (stock[i] > 30)
                {
                    condicion = "Excesivo";
                    texceso++;
                }

                dgvLista.Rows.Add(i + 1, productos[i], precio[i], stock[i], condicion);

                //Igualar las cantidades
                cantidad[0] = Convert.ToString(tagotado);
                cantidad[1] = Convert.ToString(tporagotar);
                cantidad[2] = Convert.ToString(tdisponible);
                cantidad[3] = Convert.ToString(tsuficiente);
                cantidad[4] = Convert.ToString(texceso);

                //Total
                total = tagotado + tporagotar + tdisponible + tsuficiente + texceso;

                //Calculo de porcentaje
                porcentaje[0] = Math.Round(Convert.ToDouble((tagotado / total) * 100), 2);
                porcentaje[1] = Math.Round(Convert.ToDouble((tporagotar / total) * 100), 2);
                porcentaje[2] = Math.Round(Convert.ToDouble((tdisponible / total) * 100), 2);
                porcentaje[3] = Math.Round(Convert.ToDouble((tsuficiente / total) * 100), 2);
                porcentaje[4] = Math.Round(Convert.ToDouble((texceso / total) * 100), 2);
            }
        }
    }
}
