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
        public class Producto
        {
            public string Codigo { get; set; }
            public string Nombre { get; set; }
            public decimal Precio { get; set; }
            public int Cantidad { get; set; }
            public decimal Subtotal { get; set; }
        }

        private Stack<Producto> pilaProducto = new Stack<Producto>();
        private int sizePila = 0;

        public FormPilas()
        {
            InitializeComponent();

            panelData.Enabled = false;
        }

        private void FormPilas_Load(object sender, EventArgs e)
        {

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
                pilaProducto.Clear();
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
            if (pilaProducto.Count < sizePila)
            {
                // Obtiene los datos de los campos
                string codigo = txtcodigopila.Text;
                string producto = cmbproductopila.Text;
                decimal precio = decimal.TryParse(txtpreciopila.Text, out var p) ? p : 0;
                int cantidad = int.TryParse(txtcantidadpila.Text, out var c) ? c : 0;
                decimal subtotal = precio * cantidad;

                // Crea el producto y lo agrega a la pila
                Producto prod = new Producto
                {
                    Codigo = codigo,
                    Nombre = producto,
                    Precio = precio,
                    Cantidad = cantidad,
                    Subtotal = subtotal
                };

                pilaProducto.Push(prod);


                int rowIndex = pilaProducto.Count - 1;
                dtgcompraspila.Rows[rowIndex].SetValues(codigo, producto, precio, cantidad, subtotal);


                decimal total = 0;
                foreach (var item in pilaProducto)
                {
                    total += item.Subtotal;
                }
                txttotalpila.Text = $"{total}";
            }
            else
            {
                MessageBox.Show("La pila está llena.");
            }
        }

        private void btneliminarpila_Click(object sender, EventArgs e)
        {
            if (pilaProducto.Count > 0)
            {
                int rowIndex = pilaProducto.Count - 1;
                pilaProducto.Pop();


                for (int i = 0; i < dtgcompraspila.Columns.Count; i++)
                {
                    dtgcompraspila.Rows[rowIndex].Cells[i].Value = null;
                }


                decimal total = 0;
                foreach (var item in pilaProducto)
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
    }
}
