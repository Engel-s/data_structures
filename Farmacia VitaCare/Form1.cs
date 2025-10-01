using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;

namespace Farmacia_VitaCare
{
    public partial class FormCompraVitaCare : Form
    {
        public struct Compras
        {
            public string codigo, producto;
            public decimal precio, subtotal;
            public int cantidad;
        }

        Compras[] compras = new Compras[0];
        public FormCompraVitaCare()
        {
            InitializeComponent();
        }
        //esto lo vamos a usar para refrescar el datagrid
        private void refrescarData()
        {
            dtgcompras.Rows.Clear();
            foreach (var c in compras)
                dtgcompras.Rows.Add(c.codigo, c.producto, c.cantidad, c.precio, c.subtotal);
        }

        private void FormCompraVitaCare_Load(object sender, EventArgs e)
        {
            dtgcompras.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(21, 71, 130);
            dtgcompras.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgcompras.EnableHeadersVisualStyles = false;
            dtgcompras.AllowUserToAddRows = false;


            btnburbuja.Visible = false;
            btnquiscksot.Visible = false;
            btnmergesort.Visible = false;

            MessageBox.Show("Ingrese una compra y luego seleccione recursividad o metodo de ordenamiento");
            labelrecursividad.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tipoRecursividad_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.Show();

            this.Hide();
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void cOMPRASToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void burbujaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnburbuja.Visible = true;
            btnquiscksot.Visible = false;
            btnmergesort.Visible = false;
        }

        private void quickSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnquiscksot.Visible = true;
            btnburbuja.Visible = false;
            btnmergesort.Visible = false;
        }

        private void mergeSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnquiscksot.Visible = false;
            btnburbuja.Visible = false;
            btnmergesort.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        private void limpiarCampos()
        {
            txtcodigo.Clear();
            cmbproducto.SelectedIndex = -1;
            txtcantidad.Clear();
            txtprecio.Clear();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                //aqui llamamos al struct y llenamos los datos con la comparacion de los textboxs
                Compras newcompra = new Compras();
                {
                    newcompra.codigo = txtcodigo.Text;
                    newcompra.producto = cmbproducto.Text;
                    newcompra.cantidad = int.Parse(txtcantidad.Text);
                    newcompra.precio = decimal.Parse(txtprecio.Text);
                    newcompra.subtotal = int.Parse(txtcantidad.Text) * decimal.Parse(txtprecio.Text);
                }
;

                if (Convert.ToInt32(txtcantidad.Text) <= 0 || txtcodigo.Text == "" || Convert.ToDecimal(txtprecio.Text) <= 0
                    || cmbproducto.Text == "")
                {
                    MessageBox.Show("Debe llenar todos los campos", "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                Compras[] temporal = new Compras[compras.Length + 1]; //Esto sirve para aumentar el tamano del arreglo 
                for (int i = 0; i < compras.Length; i++)
                    temporal[i] = compras[i];//copia los elementos anteriores al nuevo arreglo

                temporal[temporal.Length - 1] = newcompra; //aqui se agrega el nuevo elemento
                compras = temporal;//se asigna el nuevo arreglo al arreglo original

                refrescarData();//llamamos al foreach que hicimos para refrescar el datagrid
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar");
            }
            labelrecursividad.Visible = true;
        }

        private void btnburbuja_Click(object sender, EventArgs e)
        {
            Metodos_Ordenamiento ordenar = new Metodos_Ordenamiento();
            ordenar.ordenarBurbuja(compras);
            refrescarData();
        }

        private void btnmergesort_Click(object sender, EventArgs e)
        {
            if (compras.Length == 0)
            {
                MessageBox.Show("No hay compras para ordenar.");
                return;
            }
            int contador = compras.Length;
            string archivo = "compras.txt";

            Metodos_Ordenamiento.Mezcla_Directa_Externa(compras, contador, archivo);
            refrescarData();
            MessageBox.Show($"Archivo final ordenado: {archivo}");
        }

        private void btnquiscksot_Click(object sender, EventArgs e)
        {
            if (compras.Length > 0)
            {
                Metodos_Ordenamiento ordenamiento = new Metodos_Ordenamiento();
                ordenamiento.QuickSort(compras, 0, compras.Length - 1);
                refrescarData();
            }
        }

        private void recursividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recursividad r = new Recursividad();
            decimal total = r.CalcularTotal(compras, 0);

            var cultureCordoba = new CultureInfo("es-NI");
            txttotal.Text = total.ToString("C", cultureCordoba);
            labelrecursividad.Visible = true;
        }

        private void quickSortToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            btnquiscksot.Visible = true;
            btnburbuja.Visible = false;
            btnmergesort.Visible = false;
        }

        private void mergeSortToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            btnquiscksot.Visible = false;
            btnburbuja.Visible = false;
            btnmergesort.Visible = true;
        }

        private void quickSortToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            btnquiscksot.Visible = true;
            btnburbuja.Visible = false;
            btnmergesort.Visible = false;
        }

        private void mergeSortToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            btnquiscksot.Visible = false;
            btnburbuja.Visible = false;
            btnmergesort.Visible = true;
        }

        private void quickSortToolStripMenuItem_Click_3(object sender, EventArgs e)
        {
            btnquiscksot.Visible = true;
            btnburbuja.Visible = false;
            btnmergesort.Visible = false;
        }

        private void mergeSortToolStripMenuItem_Click_3(object sender, EventArgs e)
        {
            btnquiscksot.Visible = false;
            btnburbuja.Visible = false;
            btnmergesort.Visible = true;
        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void pilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPilas formPilas = new FormPilas();
            formPilas.Show();

            this.Hide();
        }

        private void simplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colas_Simples colas_Simples = new Colas_Simples();
            colas_Simples.Show();
            this.Hide();
        }

        private void circularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormColaCirulares colas_Circulares = new FormColaCirulares();
            colas_Circulares.Show();

            this.Hide();
        }
    }
}
