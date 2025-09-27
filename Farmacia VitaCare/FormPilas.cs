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
    public partial class FormPilas : Form
    {
        public struct Compras
        {
            public string Codigo, producto;
            public decimal Precio, Subtotal;
            public int Cantidad;
        }

        private Stack<Compras> pilaCompra = new Stack<Compras>();
        private int sizePila = 0;

        public FormPilas()
        {
            InitializeComponent();

            panelData.Enabled = false;
        }

        private void FormPilas_Load(object sender, EventArgs e)
        {
            dtgcompraspila.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(21, 71, 130);
            dtgcompraspila.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgcompraspila.EnableHeadersVisualStyles = false;
            dtgcompraspila.AllowUserToAddRows = false;

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtsizepila.Text, out sizePila) && sizePila > 0)
            {
                dtgcompraspila.Rows.Clear();
                for (int i = 0; i < sizePila; i++)
                {
                    dtgcompraspila.Rows.Add();
                }
                pilaCompra.Clear();
                txttotalpila.Text = " 0";

                panelData.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ingrese una cantidad válida.");
            }
        }

        private void btnagregarpila_Click(object sender, EventArgs e)
        {
            if (txtcodigopila.Text == "" || cmbproductopila.Text == "" || txtcantidadpila.Text == "" || txtpreciopila.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            if (pilaCompra.Count < sizePila)
            {
                // Obtiene los datos de los campos
                string codigo = txtcodigopila.Text;
                string producto = cmbproductopila.Text;
                decimal precio = decimal.TryParse(txtpreciopila.Text, out var p) ? p : 0;
                int cantidad = int.TryParse(txtcantidadpila.Text, out var c) ? c : 0;
                decimal subtotal = precio * cantidad;

                // Crea el producto y lo agrega a la pila
                Compras prod = new Compras
                {
                    Codigo = codigo,
                    producto = producto,
                    Precio = precio,
                    Cantidad = cantidad,
                    Subtotal = subtotal
                };

                pilaCompra.Push(prod);


                int rowIndex = pilaCompra.Count - 1;
                dtgcompraspila.Rows[rowIndex].SetValues(codigo, producto, precio, cantidad, subtotal);


                decimal total = 0;
                foreach (var item in pilaCompra)
                {
                    total += item.Subtotal;
                }
                txttotalpila.Text = $"{total}";
            }
            else
            {
                MessageBox.Show("La pila está llena.", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btneliminarpila_Click(object sender, EventArgs e)
        {
            if (pilaCompra.Count > 0)
            {
                int rowIndex = pilaCompra.Count - 1;
                pilaCompra.Pop();


                for (int i = 0; i < dtgcompraspila.Columns.Count; i++)
                {
                    dtgcompraspila.Rows[rowIndex].Cells[i].Value = null;
                }


                decimal total = 0;
                foreach (var item in pilaCompra)
                {
                    total += item.Subtotal;
                }
                txttotalpila.Text = $"{total}";
            }
            else
            {
                MessageBox.Show("La pila está vacía.");
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.Show();

            this.Hide();
        }

        private void panelData_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
