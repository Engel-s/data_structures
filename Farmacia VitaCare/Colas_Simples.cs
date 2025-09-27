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
    public partial class Colas_Simples : Form
    {
        int i, _cantidad;

        public struct Compras
        {
            public string codigo, producto;
            public decimal precio, subtotal;
            public int cantidad;
        }

        Compras[] compra;

        cola_simple cola = new cola_simple();

        public Colas_Simples()
        {
            InitializeComponent();
            panelData.Enabled = false;
        }

        private void Colas_Simples_Load(object sender, EventArgs e)
        {
            dtgcomprascola.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(21, 71, 130);
            dtgcomprascola.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgcomprascola.EnableHeadersVisualStyles = false;
            dtgcomprascola.AllowUserToAddRows = false;
        }
        private void limpiarCampos()
        {
            txtcodigocola.Clear();
            cmbproductocola.SelectedIndex = -1;
            txtcantidadcola.Clear();
            txtpreciocola.Clear();
        }

        private void btnokcola_Click(object sender, EventArgs e)
        {
            int cantidad;

            if (string.IsNullOrWhiteSpace(txtsizecola.Text) ||
                !int.TryParse(txtsizecola.Text, out cantidad) ||
                cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida");
            }
            else
            {
                dtgcomprascola.Rows.Clear();
                for(int a = 0; a < cantidad; a++)
                {
                    dtgcomprascola.Rows.Add();
                }

                _cantidad = cantidad;
                cola = new cola_simple(_cantidad);
                compra = new Compras[_cantidad];
                btnokcola.Enabled = false;
                txtsizecola.Enabled = false;
                panelData.Enabled = true;
            }
        }

        private void btnagregarcola_Click(object sender, EventArgs e)
        {
            if (i < _cantidad)
            {
                if (txtcodigocola.Text == "" || cmbproductocola.Text == "" || txtcantidadcola.Text == "" || txtpreciocola.Text == "")
                {
                    MessageBox.Show("Debe llenar todos los campos", "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    compra[i].codigo = txtcodigocola.Text;
                    compra[i].producto = cmbproductocola.Text;
                    compra[i].cantidad = Convert.ToInt32(txtcantidadcola.Text);
                    compra[i].precio = Convert.ToDecimal(txtpreciocola.Text);
                    compra[i].subtotal = Convert.ToDecimal(txtcantidadcola.Text) * Convert.ToDecimal(txtpreciocola.Text);

                    cola.insertar(i);

                    dtgcomprascola.Rows[i].Cells[0].Value = compra[i].codigo;
                    dtgcomprascola.Rows[i].Cells[1].Value = compra[i].producto;
                    dtgcomprascola.Rows[i].Cells[2].Value = compra[i].cantidad;
                    dtgcomprascola.Rows[i].Cells[3].Value = compra[i].precio;
                    dtgcomprascola.Rows[i].Cells[4].Value = compra[i].subtotal;

                    i++;

                    decimal total = 0;
                    for (int j = 0; j < i; j++)
                    {
                        total += compra[j].subtotal;
                    }
                    txttotalcola.Text = $"{total}";

                    limpiarCampos();
                }
            }
            else
            {
                cola.insertar(i);
            }
        }

        private void btneliminarcola_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                cola.ELiminar();
                
                for(int c = 0; c < dtgcomprascola.Columns.Count; c++)
                {
                    dtgcomprascola.Rows[0].Cells[c].Value = null;
                }

                for (int k = 0; k < i - 1; k++)
                {
                    compra[k] = compra[k + 1];
                   
                    dtgcomprascola.Rows[k].Cells[0].Value = compra[k].codigo;
                    dtgcomprascola.Rows[k].Cells[1].Value = compra[k].producto;
                    dtgcomprascola.Rows[k].Cells[2].Value = compra[k].cantidad;
                    dtgcomprascola.Rows[k].Cells[3].Value = compra[k].precio;
                    dtgcomprascola.Rows[k].Cells[4].Value = compra[k].subtotal;
                }

                for (int c = 0; c < dtgcomprascola.Columns.Count; c++)
                {
                    dtgcomprascola.Rows[i - 1].Cells[c].Value = null;
                }

                decimal total = 0;
                for (int j = 0; j < i; j++)
                {
                    total += compra[j].subtotal;
                }
                txttotalcola.Text = $"{total}";

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
