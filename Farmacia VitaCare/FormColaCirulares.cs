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

        Colas_circulares cola = new Colas_circulares();

        public FormColaCirulares()
        {
            InitializeComponent();
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
            int cantidad;

            if (string.IsNullOrWhiteSpace(txtsizecircular.Text) ||
                !int.TryParse(txtsizecircular.Text, out cantidad) ||
                cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida");
            }
            else
            {
                dtgcomprascircular.Rows.Clear();
                for (int a = 0; a < cantidad; a++)
                {
                    dtgcomprascircular.Rows.Add();
                }

                _cantidad = cantidad;
                cola = new Colas_circulares(_cantidad);
                compra = new Compras[_cantidad];
                btnokcircular.Enabled = false;
                txtsizecircular.Enabled = false;
                panelData.Enabled = true;
            }
        }

        private void btnagregarcircular_Click(object sender, EventArgs e)
        {
            if (i < _cantidad)
            {
                if (txtcodigocircular.Text == "" || cmbproductocircular.Text == "" || txtcantidadcircular.Text == "" || txtpreciocircular.Text == "")
                {
                    MessageBox.Show("Debe llenar todos los campos", "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    compra[i].codigo = txtcodigocircular.Text;
                    compra[i].producto = cmbproductocircular.Text;
                    compra[i].cantidad = Convert.ToInt32(txtcantidadcircular.Text);
                    compra[i].precio = Convert.ToDecimal(txtpreciocircular.Text);
                    compra[i].subtotal = Convert.ToDecimal(txtcantidadcircular.Text) * Convert.ToDecimal(txtpreciocircular.Text);

                    cola.insertar(i);

                    dtgcomprascircular.Rows[i].Cells[0].Value = compra[i].codigo;
                    dtgcomprascircular.Rows[i].Cells[1].Value = compra[i].producto;
                    dtgcomprascircular.Rows[i].Cells[2].Value = compra[i].cantidad;
                    dtgcomprascircular.Rows[i].Cells[3].Value = compra[i].precio;
                    dtgcomprascircular.Rows[i].Cells[4].Value = compra[i].subtotal;

                    i++;

                    decimal total = 0;
                    for (int j = 0; j < i; j++)
                    {
                        total += compra[j].subtotal;
                    }
                    txttotalcircular.Text = $"{total}";

                    limpiarCampos();
                }
            }
            else
            {
                cola.insertar(i);
            }
        }

        private void btneliminarcircular_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                cola.ELiminar();

                for (int c = 0; c < dtgcomprascircular.Columns.Count; c++)
                {
                    dtgcomprascircular.Rows[0].Cells[c].Value = null;
                }

                for (int k = 0; k < i - 1; k++)
                {
                    compra[k] = compra[k + 1];

                    dtgcomprascircular.Rows[k].Cells[0].Value = compra[k].codigo;
                    dtgcomprascircular.Rows[k].Cells[1].Value = compra[k].producto;
                    dtgcomprascircular.Rows[k].Cells[2].Value = compra[k].cantidad;
                    dtgcomprascircular.Rows[k].Cells[3].Value = compra[k].precio;
                    dtgcomprascircular.Rows[k].Cells[4].Value = compra[k].subtotal;
                }

                for (int c = 0; c < dtgcomprascircular.Columns.Count; c++)
                {
                    dtgcomprascircular.Rows[i - 1].Cells[c].Value = null;
                }

                decimal total = 0;
                for (int j = 0; j < i; j++)
                {
                    total += compra[j].subtotal;
                }
                txttotalcircular.Text = $"{total}";

                i--;
            }
            else
            {
                cola.ELiminar();
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
