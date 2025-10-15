using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia_VitaCare
{
    public partial class FormColaCirulares : Form
    {
        int i, _cantidad;

        public struct Compras
        {
            public string codigo, producto;
            public decimal precio, subtotal;
            public int cantidad;
        }

        Compras[] compra;

        Colas_circulares cola;

        public FormColaCirulares()
        {
            InitializeComponent();
            panelData.Enabled = false;
        }

        private void txttotalcola_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormColaCirulares_Load(object sender, EventArgs e)
        {
            dtgcomprascircular.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(21, 71, 130);
            dtgcomprascircular.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgcomprascircular.EnableHeadersVisualStyles = false;
            dtgcomprascircular.AllowUserToAddRows = false;
        }
        private void limpiarCampos()
        {
            txtcodigocircular.Clear();
            cmbproductocircular.SelectedIndex = -1;
            txtcantidadcircular.Clear();
            txtpreciocircular.Clear();
        }

        private void btnokcircular_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtsizecircular.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida");
                return;
            }

            // Configurar DataGridView
            dtgcomprascircular.Rows.Clear();
            for (int a = 0; a < cantidad; a++)
                dtgcomprascircular.Rows.Add();

            _cantidad = cantidad;
            cola = new Colas_circulares(_cantidad);
            compra = new Compras[_cantidad];

            btnokcircular.Enabled = false;
            txtsizecircular.Enabled = false;
            panelData.Enabled = true;
        }

        private void btnagregarcircular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtcodigocircular.Text) ||
                string.IsNullOrWhiteSpace(cmbproductocircular.Text) ||
                string.IsNullOrWhiteSpace(txtcantidadcircular.Text) ||
                string.IsNullOrWhiteSpace(txtpreciocircular.Text))
            {
                MessageBox.Show("Debe llenar todos los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (cola.ColaLlena())
            {
                MessageBox.Show("La cola está llena.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idxInsertar = cola.Final == -1
                ? 0
                : (cola.Final + 1) % cola.Max;

            compra[idxInsertar].codigo = txtcodigocircular.Text;
            compra[idxInsertar].producto = cmbproductocircular.Text;
            compra[idxInsertar].cantidad = Convert.ToInt32(txtcantidadcircular.Text);
            compra[idxInsertar].precio = Convert.ToDecimal(txtpreciocircular.Text);
            compra[idxInsertar].subtotal = compra[idxInsertar].cantidad * compra[idxInsertar].precio;

       
            cola.insertar(idxInsertar); 

            MostrarCola();
            limpiarCampos();
        }

        private void btneliminarcircular_Click(object sender, EventArgs e)
        {

            if (cola.ColaVacia())
            {
                MessageBox.Show("La cola está vacía.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            cola.ELiminar();
            MostrarCola();
        }

        private void MostrarCola()
        {
            for (int fila = 0; fila < dtgcomprascircular.Rows.Count; fila++)
            {
                for (int col = 0; col < dtgcomprascircular.Columns.Count; col++)
                    dtgcomprascircular.Rows[fila].Cells[col].Value = null;


                if (!cola.ColaVacia())
                {
                    int pos = cola.Frente;
                    decimal total = 0;

                    while (true)
                    {
                        int idxCompra = cola.ColaC[pos];

                       
                        dtgcomprascircular.Rows[pos].Cells[0].Value = compra[idxCompra].codigo;
                        dtgcomprascircular.Rows[pos].Cells[1].Value = compra[idxCompra].producto;
                        dtgcomprascircular.Rows[pos].Cells[2].Value = compra[idxCompra].cantidad;
                        dtgcomprascircular.Rows[pos].Cells[3].Value = compra[idxCompra].precio;
                        dtgcomprascircular.Rows[pos].Cells[4].Value = compra[idxCompra].subtotal;

                        total += compra[idxCompra].subtotal;

                        if (pos == cola.Final)
                            break;

                        pos = (pos + 1) % cola.Max;
                    }

                    txttotalcircular.Text = total.ToString("0.00");
                }
                else
                {
                    txttotalcircular.Text = "0.00";
                }
            }
        }


        private void btnsalir_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.Show();
            this.Hide();
        }
    }
}
