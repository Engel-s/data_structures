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
    public partial class FormArbolBalanceado : Form
    {
        public struct Compras
        {
            public string codigo, producto;
            public decimal precio, subtotal;
            public int cantidad;
        }

        private Compras[] compra = new Compras[0];
        private DibujaBalanceado _avl;

        public FormArbolBalanceado()
        {
            InitializeComponent();


            _avl = new DibujaBalanceado(pnlArbol, this.Font);


            btnAgregar.Click += btnAgregar_Click;
            btnEliminar.Click += btnEliminar_Click;

            btnInOrden.Click += (s, e) => _avl.InOrden(IstRecorridos);
            btnPreOrden.Click += (s, e) => _avl.PreOrden(IstRecorridos);
            btnPosOrden.Click += (s, e) => _avl.PosOrden(IstRecorridos);

            ConfigurarGrid();
        }


        private void btnAgregar_Click(object? sender, EventArgs e)
        {
            string codigo = txtCodigo.Text.Trim();
            string producto = (cmbProducto.SelectedItem ?? cmbProducto.Text ?? string.Empty).ToString().Trim();

            if (string.IsNullOrWhiteSpace(producto))
            { MessageBox.Show("Seleccione un producto."); return; }

            if (!decimal.TryParse(txtPrecio.Text, out var precio) || precio <= 0m)
            { MessageBox.Show("Precio inválido."); return; }

            if (!int.TryParse(txtCantidad.Text, out var cantidad) || cantidad <= 0)
            { MessageBox.Show("Cantidad inválida."); return; }

            bool yaExisteCantidad = dgvCompra.Rows
                .Cast<DataGridViewRow>()
                .Any(r => !r.IsNewRow &&
                          r.Cells["CANTIDAD"]?.Value != null &&
                          Convert.ToInt32(r.Cells["CANTIDAD"].Value) == cantidad);

            if (yaExisteCantidad)
            {
                MessageBox.Show("Esa cantidad ya existe. El árbol balanceado no permite duplicados.");
                return;
            }

            _avl.Insertar(cantidad);

            var item = new Compras
            {
                codigo = codigo,
                producto = producto,
                precio = precio,
                cantidad = cantidad,
                subtotal = precio * cantidad
            };

            Array.Resize(ref compra, compra.Length + 1);
            compra[^1] = item;

            dgvCompra.Rows.Add(item.codigo, item.producto, item.precio, item.cantidad, item.subtotal);

            ActualizarTotal();

            txtCodigo.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            cmbProducto.SelectedIndex = -1;
            txtCodigo.Focus();
        }


        private void btnEliminar_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(txtEliminar.Text, out var cantidadAEliminar))
            { MessageBox.Show("Ingrese una cantidad válida a eliminar."); return; }


            int fila = -1;
            for (int i = 0; i < dgvCompra.Rows.Count; i++)
            {
                if (!dgvCompra.Rows[i].IsNewRow &&
                    Convert.ToInt32(dgvCompra.Rows[i].Cells["CANTIDAD"].Value) == cantidadAEliminar)
                { fila = i; break; }
            }
            if (fila >= 0) dgvCompra.Rows.RemoveAt(fila);

            int idx = Array.FindIndex(compra, c => c.cantidad == cantidadAEliminar);
            if (idx >= 0)
            {
                for (int i = idx + 1; i < compra.Length; i++) compra[i - 1] = compra[i];
                Array.Resize(ref compra, compra.Length - 1);
            }


            _avl.Eliminar(cantidadAEliminar);
            ActualizarTotal();
        }


        private void ConfigurarGrid()
        {
            dgvCompra.AutoGenerateColumns = false;
            dgvCompra.AllowUserToAddRows = false;
            dgvCompra.ReadOnly = true;

            if (dgvCompra.Columns.Count == 0)
            {
                dgvCompra.Columns.Add("CODIGO", "CÓDIGO");
                dgvCompra.Columns.Add("PRODUCTO", "PRODUCTO");
                dgvCompra.Columns.Add("PRECIO", "PRECIO");
                dgvCompra.Columns.Add("CANTIDAD", "CANTIDAD");
                dgvCompra.Columns.Add("SUBTOTAL", "SUBTOTAL");
            }
        }


        private void ActualizarTotal()
        {
            var col = dgvCompra.Columns["SUBTOTAL"] ??
                      dgvCompra.Columns.Cast<DataGridViewColumn>()
                             .FirstOrDefault(c => string.Equals(c.HeaderText, "SUBTOTAL",
                                 StringComparison.OrdinalIgnoreCase));

            decimal total = 0m;
            if (col != null)
            {
                foreach (DataGridViewRow r in dgvCompra.Rows)
                    if (!r.IsNewRow && r.Cells[col.Index].Value != null)
                        total += Convert.ToDecimal(r.Cells[col.Index].Value);
            }
            txtTotal.Text = total.ToString("0.00");
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Welcome welcomeForm = new Welcome();
            welcomeForm.Show();
            this.Close();
        }
    }
}
