using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Farmacia_VitaCare.PIla;

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

        private Pila<Compras> pilaCompra;
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
                // crea la pila con el tamaño especificado
                pilaCompra = new Pila<Compras>(sizePila);

                dtgcompraspila.Rows.Clear();
                for (int i = 0; i < sizePila; i++)
                {
                    dtgcompraspila.Rows.Add();
                }

                txttotalpila.Text = "0";
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

            try
            {
                if (!pilaCompra.PilaLlena())
                {
   
                    string codigo = txtcodigopila.Text;
                    string producto = cmbproductopila.Text;
                    decimal precio = decimal.TryParse(txtpreciopila.Text, out var p) ? p : 0;
                    int cantidad = int.TryParse(txtcantidadpila.Text, out var c) ? c : 0;
                    decimal subtotal = precio * cantidad;

                    // crea la compra
                    Compras prod = new Compras
                    {
                        Codigo = codigo,
                        producto = producto,
                        Precio = precio,
                        Cantidad = cantidad,
                        Subtotal = subtotal
                    };
               
                    pilaCompra.Pone(prod);
           
                    int rowIndex = pilaCompra.Tope - 1;
                    dtgcompraspila.Rows[rowIndex].SetValues(codigo, producto, precio, cantidad, subtotal);
                   
                    ActualizarTotal();

                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("La pila está llena.", "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btneliminarpila_Click(object sender, EventArgs e)
        {
            try
            {

                if (!pilaCompra.PilaVacia())
                {
  
                    Compras elementoEliminado = pilaCompra.Quita();

 
                    int rowIndex = pilaCompra.Tope; 
                    for (int i = 0; i < dtgcompraspila.Columns.Count; i++)
                    {
                        dtgcompraspila.Rows[rowIndex].Cells[i].Value = null;
                    }

                    ActualizarTotal();
                }
                else
                {
                    MessageBox.Show("La pila está vacía.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ActualizarTotal()
        {
            decimal total = 0;

            for (int i = 0; i < pilaCompra.Tope; i++)
            {
                if (dtgcompraspila.Rows[i].Cells[4].Value != null)
                {
                    total += Convert.ToDecimal(dtgcompraspila.Rows[i].Cells[4].Value);
                }
            }

            txttotalpila.Text = $"{total}";
        }
        private void LimpiarCampos()
        {
            txtcodigopila.Text = "";
            cmbproductopila.SelectedIndex = -1;
            txtcantidadpila.Text = "";
            txtpreciopila.Text = "";
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
