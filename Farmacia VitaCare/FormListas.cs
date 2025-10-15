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
    public partial class FormListas : Form
    {
        string x;
        public struct Compras
        {
            public string codigo, producto;
            public decimal precio, subtotal;
            public int cantidad;
        }
        Compras[] compra = new Compras[0];
        Lista _lista = new Lista();
        Nodo nodo = new Nodo();

        public void OcultarCampos()
        {
            tablepanel.Visible = false;
            panelData.Visible = false;
            lblTotal.Visible = false;
            txttotallista.Visible = false;
            dtglistas.Visible = false;
            pnlBtnInsertar.Visible = false;
            panelBuscar.Visible = false;
            pnlEliminar.Visible = false;
            pnlBusqueda.Visible = false;
            pnlRecorrido.Visible = false;
        }
        private void MostrarBtnInsertar(string boton)
        {

            btnInsertarInicio.Visible = false;
            btnInsertarFinal.Visible = false;
            btnInsertarAntesX.Visible = false;
            btnInsertarDespuesX.Visible = false;


            switch (boton)
            {
                case "inicio":
                    btnInsertarInicio.Visible = true;
                    pnlEliminar.Visible = false;
                    break;
                case "final":
                    btnInsertarFinal.Visible = true;
                    pnlEliminar.Visible = false;
                    break;
                case "antes":
                    btnInsertarAntesX.Visible = true;
                    pnlEliminar.Visible = false;
                    break;
                case "despues":
                    btnInsertarDespuesX.Visible = true;
                    pnlEliminar.Visible = false;
                    break;
            }

            pnlBtnInsertar.Visible = true;
        }

        private void MostrarBtnEliminar(string boton)
        {
            btnEliminarInicio.Visible = false;
            btnEliminarFinal.Visible = false;
            btnEliminarX.Visible = false;
            btnEliminarAntesX.Visible = false;
            btnEliminarDespuesX.Visible = false;

            switch (boton)
            {
                case "inicio":
                    btnEliminarInicio.Visible = true;
                    pnlBtnInsertar.Visible = false;
                    break;
                case "final":
                    btnEliminarFinal.Visible = true;
                    pnlBtnInsertar.Visible = false;
                    break;
                case "x":
                    btnEliminarX.Visible = true;
                    pnlBtnInsertar.Visible = false;
                    break;
                case "antes":
                    btnEliminarAntesX.Visible = true;
                    pnlBtnInsertar.Visible = false;
                    break;
                case "despues":
                    btnEliminarDespuesX.Visible = true;
                    pnlBtnInsertar.Visible = false;
                    break;
            }
            pnlEliminar.Visible = true;
        }

        private void MostrarBtnBusqueda(string boton)
        {
            btnbusquedaOrdenada.Visible = false;
            btnbusquedaDesordenada.Visible = false;
            btnbusquedaRecursiva.Visible = false;
            switch (boton)
            {
                case "ordenada":
                    btnbusquedaOrdenada.Visible = true;
                    pnlRecorrido.Visible = false;
                    break;
                case "desordenada":
                    btnbusquedaDesordenada.Visible = true;
                    pnlRecorrido.Visible = false;
                    break;
                case "recursiva":
                    btnbusquedaRecursiva.Visible = true;
                    pnlRecorrido.Visible = false;
                    break;
            }
            pnlBusqueda.Visible = true;
        }

        public void MostrarBtnRecorrido(string boton)
        {
            btnRecorrerI.Visible = false;
            btnRecorrerR.Visible = false;
            switch (boton)
            {
                case "iterativo":
                    btnRecorrerI.Visible = true;
                    pnlBusqueda.Visible = false;
                    break;
                case "recursivo":
                    btnRecorrerR.Visible = true;
                    pnlBusqueda.Visible = false;
                    break;
            }
            pnlRecorrido.Visible = true;
        }

        public void MostrarCampos()
        {
            tablepanel.Visible = true;
            panelData.Visible = true;
            lblTotal.Visible = true;
            txttotallista.Visible = true;
            dtglistas.Visible = true;
            pnlBtnInsertar.Visible = true;
            pnlEliminar.Visible = true;
        }
        public FormListas()
        {
            InitializeComponent();
            OcultarCampos();

        }
        private void limpiarCampos()
        {
            txtcodigolista.Clear();
            cmbproductolista.SelectedIndex = -1;
            txtcantidadlista.Clear();
            txtpreciolista.Clear();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarCampos();
            MostrarBtnInsertar("inicio");
            panelBuscar.Visible = false;
        }

        private void CalcularTotal()
        {
            decimal total = 0;
            for (int i = 0; i < dtglistas.Rows.Count; i++)
            {
                if (dtglistas.Rows[i].Cells["Subtotal"].Value != null)
                    total += Convert.ToDecimal(dtglistas.Rows[i].Cells["Subtotal"].Value);
            }
            txttotallista.Text = $"{total}";
        }

        private void btnInsertarInicio_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtcodigolista.Text) ||
                    string.IsNullOrWhiteSpace(txtcantidadlista.Text) ||
                    string.IsNullOrWhiteSpace(txtpreciolista.Text) ||
                    string.IsNullOrWhiteSpace(cmbproductolista.Text))
                {
                    MessageBox.Show("Debe llenar todos los campos.", "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                if (!int.TryParse(txtcantidadlista.Text, out int cantidad) || cantidad <= 0 ||
                    !decimal.TryParse(txtpreciolista.Text, out decimal precio) || precio <= 0)
                {
                    MessageBox.Show("Cantidad y precio deben ser valores numéricos mayores a cero.", "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                Compras newcompra = new Compras();
                newcompra.codigo = txtcodigolista.Text;
                newcompra.producto = cmbproductolista.Text;
                newcompra.cantidad = cantidad;
                newcompra.precio = precio;
                newcompra.subtotal = newcompra.cantidad * newcompra.precio;

                _lista.InsertarInicio(newcompra.codigo, newcompra.producto, newcompra.cantidad, newcompra.precio, newcompra.subtotal, dtglistas);
                _lista.Mostrar(dtglistas);

                limpiarCampos();

                CalcularTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsertarFinal_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtcodigolista.Text) ||
                    string.IsNullOrWhiteSpace(txtcantidadlista.Text) ||
                    string.IsNullOrWhiteSpace(txtpreciolista.Text) ||
                    string.IsNullOrWhiteSpace(cmbproductolista.Text))
                {
                    MessageBox.Show("Debe llenar todos los campos.", "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                if (!int.TryParse(txtcantidadlista.Text, out int cantidad) || cantidad <= 0 ||
                    !decimal.TryParse(txtpreciolista.Text, out decimal precio) || precio <= 0)
                {
                    MessageBox.Show("Cantidad y precio deben ser valores numéricos mayores a cero.", "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                Compras newcompra = new Compras();
                newcompra.codigo = txtcodigolista.Text;
                newcompra.producto = cmbproductolista.Text;
                newcompra.cantidad = cantidad;
                newcompra.precio = precio;
                newcompra.subtotal = newcompra.cantidad * newcompra.precio;

                _lista.InsertarFinal(newcompra.codigo, newcompra.producto, newcompra.cantidad, newcompra.precio, newcompra.subtotal, dtglistas);
                _lista.Mostrar(dtglistas);

                limpiarCampos();

                CalcularTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void finalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarCampos();
            MostrarBtnInsertar("final");
            panelBuscar.Visible = false;
        }

        private void antesDeXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarCampos();
            panelBuscar.Visible = true;
            MostrarBtnInsertar("antes");
        }

        private void btnInsertarAntesX_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtcodigolista.Text) ||
                    string.IsNullOrWhiteSpace(txtcantidadlista.Text) ||
                    string.IsNullOrWhiteSpace(txtpreciolista.Text) ||
                    string.IsNullOrWhiteSpace(cmbproductolista.Text))
                {
                    MessageBox.Show("Debe llenar todos los campos.", "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                if (!int.TryParse(txtcantidadlista.Text, out int cantidad) || cantidad <= 0 ||
                    !decimal.TryParse(txtpreciolista.Text, out decimal precio) || precio <= 0)
                {
                    MessageBox.Show("Cantidad y precio deben ser valores numéricos mayores a cero.", "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtbuscar.Text))
                {
                    MessageBox.Show("Debe ingresar el código posterior de donde quiere ingresar el producto.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtbuscar.Focus();
                    return;
                }

                x = txtbuscar.Text;

                Compras newcompra = new Compras();
                newcompra.codigo = txtcodigolista.Text;
                newcompra.producto = cmbproductolista.Text;
                newcompra.cantidad = cantidad;
                newcompra.precio = precio;
                newcompra.subtotal = newcompra.cantidad * newcompra.precio;

                _lista.InsertarAntesX(newcompra.codigo, newcompra.producto, newcompra.cantidad, newcompra.precio, newcompra.subtotal, x);
                _lista.Mostrar(dtglistas);

                limpiarCampos();
                CalcularTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void despuesDeXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarCampos();
            panelBuscar.Visible = true;
            MostrarBtnInsertar("despues");
        }

        private void btnInsertarDespuesX_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtcodigolista.Text) ||
                    string.IsNullOrWhiteSpace(txtcantidadlista.Text) ||
                    string.IsNullOrWhiteSpace(txtpreciolista.Text) ||
                    string.IsNullOrWhiteSpace(cmbproductolista.Text))
                {
                    MessageBox.Show("Debe llenar todos los campos.", "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                if (!int.TryParse(txtcantidadlista.Text, out int cantidad) || cantidad <= 0 ||
                    !decimal.TryParse(txtpreciolista.Text, out decimal precio) || precio <= 0)
                {
                    MessageBox.Show("Cantidad y precio deben ser valores numéricos mayores a cero.", "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtbuscar.Text))
                {
                    MessageBox.Show("Debe ingresar el código anterior de donde quiere ingresar el producto.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtbuscar.Focus();
                    return;
                }

                x = txtbuscar.Text;

                Compras newcompra = new Compras();
                newcompra.codigo = txtcodigolista.Text;
                newcompra.producto = cmbproductolista.Text;
                newcompra.cantidad = cantidad;
                newcompra.precio = precio;
                newcompra.subtotal = newcompra.cantidad * newcompra.precio;

                _lista.InsertarDespuesX(newcompra.codigo, newcompra.producto, newcompra.cantidad, newcompra.precio, newcompra.subtotal, x);
                _lista.Mostrar(dtglistas);

                limpiarCampos();
                CalcularTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eliminarinicioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MostrarCampos();
            MostrarBtnEliminar("inicio");
            panelBuscar.Visible = false;
        }



        private void btnEliminarInicio_Click(object sender, EventArgs e)
        {
            _lista.EliminarInicio();
            _lista.Mostrar(dtglistas);
            CalcularTotal();
            MostrarCampos();
        }

        private void eliminarantesDeXToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MostrarCampos();
            pnlBtnInsertar.Visible = false;
            MostrarBtnEliminar("x");
            panelBuscar.Visible = true;
        }

        private void eliminarfinalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MostrarCampos();
            pnlBtnInsertar.Visible = false;
            MostrarBtnEliminar("final");
            panelBuscar.Visible = false;
        }

        private void btnEliminarFinal_Click(object sender, EventArgs e)
        {
            _lista.EliminarFinal();
            _lista.Mostrar(dtglistas);
            CalcularTotal();
        }

        private void btnEliminarX_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbuscar.Text))
            {
                MessageBox.Show("Debe ingresar el código que desea eliminar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbuscar.Focus();
                return;
            }

            x = txtbuscar.Text;

            _lista.EliminarX(x);
            _lista.Mostrar(dtglistas);
            CalcularTotal();
        }

        private void btnEliminarAntesX_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbuscar.Text))
            {
                MessageBox.Show("Debe ingresar el código posterior del cual desea eliminar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbuscar.Focus();
                return;
            }

            x = txtbuscar.Text;

            _lista.EliminarAntesX(x);
            _lista.Mostrar(dtglistas);
            CalcularTotal();
        }

        private void eliminardespuesDeXToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MostrarCampos();
            pnlBtnInsertar.Visible = true;
            MostrarBtnEliminar("antes");
            panelBuscar.Visible = true;
        }

        private void despuesDeXToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MostrarCampos();
            pnlBtnInsertar.Visible = true;
            MostrarBtnEliminar("despues");
            panelBuscar.Visible = true;
        }

        private void btnEliminarDespuesX_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbuscar.Text))
            {
                MessageBox.Show("Debe ingresar el código anterior del cual desea eliminar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbuscar.Focus();
                return;
            }

            x = txtbuscar.Text;

            _lista.EliminarDespuesX(x);
            _lista.Mostrar(dtglistas);
            CalcularTotal();
        }

        private void dtglistas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ordenadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarBtnBusqueda("ordenada");
            panelBuscar.Visible = true;
        }

        private void btnbusquedaOrdenada_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbuscar.Text))
            {
                MessageBox.Show("Debe ingresar el código por el cual desea hacer la busqueda ordenada.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbuscar.Focus();
                return;
            }

            x = txtbuscar.Text;
            _lista.BusquedaOrdenada(x);
        }

        private void btnbusquedaDesordenada_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbuscar.Text))
            {
                MessageBox.Show("Debe ingresar el código por el cual desea hacer la busqueda desordenada.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbuscar.Focus();
                return;
            }

            x = txtbuscar.Text;
            _lista.BusquedaDesordenada(x);
        }

        private void btnRecorrerI_Click(object sender, EventArgs e)
        {
            _lista.RecorridoIterativo(dtglistas);
        }

        private void btnRecorrerR_Click(object sender, EventArgs e)
        {
            _lista.RecorridoRecursivo(_lista.primerNodo);
        }

        private void desordenadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarBtnBusqueda("desordenada");
            panelBuscar.Visible = true;
        }

        private void recursivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarBtnBusqueda("recursiva");
            panelBuscar.Visible = true;
        }

        private void iterativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarBtnRecorrido("iterativo");
            panelBuscar.Visible = false;
        }

        private void recursivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarBtnRecorrido("recursivo");
            panelBuscar.Visible = false;
        }

        private void btnbusquedaRecursiva_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbuscar.Text))
            {
                MessageBox.Show("Debe ingresar el código por el cual desea hacer la busqueda recursiva.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbuscar.Focus();
                return;
            }

            x = txtbuscar.Text;
            _lista.BusquedaRecursiva(_lista.primerNodo, x);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.Show();
        }
    }
}
