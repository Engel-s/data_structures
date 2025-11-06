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
    public partial class FormArbolBinario : Form
    {
        public struct Compras
        {
            public string codigo, producto;
            public decimal precio, subtotal;
            public int cantidad;
        }

        Compras[] compra = new Compras[0];
        Arbol _arbol;

        public FormArbolBinario()
        {
            InitializeComponent();

            _arbol = new Arbol(pnlArbol.CreateGraphics(), this.Font);
            pnlArbol.Paint += (s, e) => _arbol.ActualizarArbol(e, pnlArbol.BackColor);

            btnAgregar.Click += btnAgregar_Click;
            btnInOrden.Click += (s, e) => _arbol.InOrden(IstRecorridos);
            btnPreOrden.Click += (s, e) => _arbol.PreOrden(IstRecorridos);
            btnPosOrden.Click += (s, e) => _arbol.PosOrden(IstRecorridos);
            btnEliminar.Click += btnEliminar_Click;
        }

        void btnAgregar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text.Trim();
            string producto = (cmbProducto.SelectedItem ?? "").ToString();
            if (!decimal.TryParse(txtPrecio.Text, out var precio) || precio <= 0) { MessageBox.Show("Precio inválido"); return; }
            if (!int.TryParse(txtCantidad.Text, out var cantidad) || cantidad <= 0) { MessageBox.Show("Cantidad inválida"); return; }

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

            _arbol.Insertar(cantidad);
            pnlArbol.Invalidate();
            ActualizarTotal();
            txtCodigo.Clear(); txtPrecio.Clear(); txtCantidad.Clear(); cmbProducto.SelectedIndex = -1;
        }

        void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtEliminar.Text, out var cantidad)) { MessageBox.Show("Ingrese la cantidad a eliminar"); return; }
            bool ok = _arbol.Eliminar(cantidad);


            for (int i = 0; i < dgvCompra.Rows.Count; i++)
            {
                if (Convert.ToInt32(dgvCompra.Rows[i].Cells["CANTIDAD"].Value) == cantidad)
                { dgvCompra.Rows.RemoveAt(i); break; }
            }
            int idx = Array.FindIndex(compra, c => c.cantidad == cantidad);
            if (idx >= 0)
            {
                for (int i = idx + 1; i < compra.Length; i++) compra[i - 1] = compra[i];
                Array.Resize(ref compra, compra.Length - 1);
            }

            pnlArbol.Invalidate();
            ActualizarTotal();
            MessageBox.Show(ok ? "Nodo eliminado" : "Nodo no encontrado");
        }

        void ActualizarTotal()
        {
            decimal total = 0m;
            foreach (DataGridViewRow r in dgvCompra.Rows)
                if (r.Cells["SUBTOTAL"].Value != null)
                    total += Convert.ToDecimal(r.Cells["SUBTOTAL"].Value);
            txtTotal.Text = total.ToString("0.00");
        }

        private void FormArbolBinario_Load(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.Show();
            this.Hide();
        }
    }
}
