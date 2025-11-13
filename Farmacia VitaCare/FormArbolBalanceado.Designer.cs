namespace Farmacia_VitaCare
{
    partial class FormArbolBalanceado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArbolBalanceado));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label9 = new Label();
            btnsalir = new PictureBox();
            dgvCompra = new DataGridView();
            CODIGO = new DataGridViewTextBoxColumn();
            PRODUCTO = new DataGridViewTextBoxColumn();
            PRECIO = new DataGridViewTextBoxColumn();
            CANTIDAD = new DataGridViewTextBoxColumn();
            SUBTOTAL = new DataGridViewTextBoxColumn();
            txtTotal = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btnAgregar = new Button();
            txtCantidad = new TextBox();
            txtPrecio = new TextBox();
            cmbProducto = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            txtCodigo = new TextBox();
            label4 = new Label();
            IstRecorridos = new ListBox();
            pnlArbol = new Panel();
            gbRecorridos = new GroupBox();
            btnPreOrden = new Button();
            btnPosOrden = new Button();
            btnInOrden = new Button();
            gbEliminar = new GroupBox();
            btnEliminar = new Button();
            txtEliminar = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnsalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCompra).BeginInit();
            groupBox2.SuspendLayout();
            gbRecorridos.SuspendLayout();
            gbEliminar.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(219, 219, 184);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Location = new Point(0, -3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1582, 137);
            tableLayoutPanel1.TabIndex = 57;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(67, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(21, 71, 130);
            label1.Location = new Point(319, 41);
            label1.Name = "label1";
            label1.Size = new Size(456, 54);
            label1.TabIndex = 1;
            label1.Text = "GESTIÓN DE COMPRAS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Candara", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(12, 651);
            label9.Name = "label9";
            label9.Size = new Size(223, 21);
            label9.TabIndex = 71;
            label9.Text = "Elaborado por: Engel Chavarria";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnsalir
            // 
            btnsalir.Image = (Image)resources.GetObject("btnsalir.Image");
            btnsalir.Location = new Point(790, 628);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(61, 44);
            btnsalir.SizeMode = PictureBoxSizeMode.StretchImage;
            btnsalir.TabIndex = 70;
            btnsalir.TabStop = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // dgvCompra
            // 
            dgvCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCompra.BackgroundColor = Color.White;
            dgvCompra.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(14, 47, 86);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompra.Columns.AddRange(new DataGridViewColumn[] { CODIGO, PRODUCTO, PRECIO, CANTIDAD, SUBTOTAL });
            dgvCompra.GridColor = Color.FromArgb(17, 141, 240);
            dgvCompra.Location = new Point(0, 304);
            dgvCompra.Name = "dgvCompra";
            dgvCompra.RowHeadersWidth = 51;
            dgvCompra.Size = new Size(851, 318);
            dgvCompra.TabIndex = 69;
            // 
            // CODIGO
            // 
            CODIGO.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CODIGO.HeaderText = "CÓDIGO";
            CODIGO.MinimumWidth = 6;
            CODIGO.Name = "CODIGO";
            CODIGO.Width = 229;
            // 
            // PRODUCTO
            // 
            PRODUCTO.HeaderText = "PRODUCTO";
            PRODUCTO.MinimumWidth = 6;
            PRODUCTO.Name = "PRODUCTO";
            // 
            // PRECIO
            // 
            PRECIO.HeaderText = "PRECIO";
            PRECIO.MinimumWidth = 6;
            PRECIO.Name = "PRECIO";
            // 
            // CANTIDAD
            // 
            CANTIDAD.HeaderText = "CANTIDAD";
            CANTIDAD.MinimumWidth = 6;
            CANTIDAD.Name = "CANTIDAD";
            // 
            // SUBTOTAL
            // 
            SUBTOTAL.HeaderText = "SUBTOTAL";
            SUBTOTAL.MinimumWidth = 6;
            SUBTOTAL.Name = "SUBTOTAL";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(319, 646);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(135, 27);
            txtTotal.TabIndex = 68;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(252, 645);
            label2.Name = "label2";
            label2.Size = new Size(61, 28);
            label2.TabIndex = 67;
            label2.Text = "Total";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Controls.Add(txtCantidad);
            groupBox2.Controls.Add(txtPrecio);
            groupBox2.Controls.Add(cmbProducto);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtCodigo);
            groupBox2.Font = new Font("Candara", 13.8F, FontStyle.Bold);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(0, 140);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(851, 158);
            groupBox2.TabIndex = 66;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ingresar datos";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(219, 219, 184);
            btnAgregar.Font = new Font("Candara", 13.8F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.FromArgb(14, 47, 86);
            btnAgregar.Location = new Point(9, 116);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(105, 36);
            btnAgregar.TabIndex = 66;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(692, 63);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(132, 36);
            txtCantidad.TabIndex = 45;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(472, 63);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(167, 36);
            txtPrecio.TabIndex = 44;
            // 
            // cmbProducto
            // 
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Items.AddRange(new object[] { "Paracetamol", "Ibuprofeno", "Aspirina", "Omeprazol", "Suero oral", "Alcohol etílico", "Agua oxigenada ", "Gasas estériles", "Gel antibacterial", "Condones", "Pruebas de embarazo", "Termómetros digitales", "Jarabes para la tos", "Banditas adhesivas", "Antidiarreicos", "Colirios", "Algodón" });
            cmbProducto.Location = new Point(207, 63);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(225, 36);
            cmbProducto.TabIndex = 43;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Candara", 13.8F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(472, 32);
            label7.Name = "label7";
            label7.Size = new Size(75, 28);
            label7.TabIndex = 42;
            label7.Text = "Precio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Candara", 13.8F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(692, 32);
            label6.Name = "label6";
            label6.Size = new Size(100, 28);
            label6.TabIndex = 41;
            label6.Text = "Cantidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Candara", 13.8F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(207, 32);
            label5.Name = "label5";
            label5.Size = new Size(103, 28);
            label5.TabIndex = 40;
            label5.Text = "Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Candara", 13.8F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(6, 32);
            label3.Name = "label3";
            label3.Size = new Size(89, 28);
            label3.TabIndex = 38;
            label3.Text = "Código:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(9, 63);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(161, 36);
            txtCodigo.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Candara", 13.8F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(1042, 140);
            label4.Name = "label4";
            label4.Size = new Size(103, 28);
            label4.TabIndex = 76;
            label4.Text = "Observar";
            // 
            // IstRecorridos
            // 
            IstRecorridos.FormattingEnabled = true;
            IstRecorridos.Location = new Point(1042, 179);
            IstRecorridos.Name = "IstRecorridos";
            IstRecorridos.Size = new Size(225, 104);
            IstRecorridos.TabIndex = 75;
            // 
            // pnlArbol
            // 
            pnlArbol.Location = new Point(859, 292);
            pnlArbol.Name = "pnlArbol";
            pnlArbol.Size = new Size(718, 385);
            pnlArbol.TabIndex = 74;
            // 
            // gbRecorridos
            // 
            gbRecorridos.Controls.Add(btnPreOrden);
            gbRecorridos.Controls.Add(btnPosOrden);
            gbRecorridos.Controls.Add(btnInOrden);
            gbRecorridos.Font = new Font("Candara", 13.8F, FontStyle.Bold);
            gbRecorridos.ForeColor = Color.Black;
            gbRecorridos.Location = new Point(882, 140);
            gbRecorridos.Name = "gbRecorridos";
            gbRecorridos.Size = new Size(143, 147);
            gbRecorridos.TabIndex = 73;
            gbRecorridos.TabStop = false;
            gbRecorridos.Text = "Recorridos:";
            // 
            // btnPreOrden
            // 
            btnPreOrden.BackColor = Color.FromArgb(219, 219, 184);
            btnPreOrden.ForeColor = Color.FromArgb(14, 47, 86);
            btnPreOrden.Location = new Point(12, 105);
            btnPreOrden.Name = "btnPreOrden";
            btnPreOrden.Size = new Size(121, 36);
            btnPreOrden.TabIndex = 40;
            btnPreOrden.Text = "PreOrden";
            btnPreOrden.UseVisualStyleBackColor = false;
            // 
            // btnPosOrden
            // 
            btnPosOrden.BackColor = Color.FromArgb(219, 219, 184);
            btnPosOrden.ForeColor = Color.FromArgb(14, 47, 86);
            btnPosOrden.Location = new Point(12, 65);
            btnPosOrden.Name = "btnPosOrden";
            btnPosOrden.Size = new Size(121, 36);
            btnPosOrden.TabIndex = 39;
            btnPosOrden.Text = "PosOrden";
            btnPosOrden.UseVisualStyleBackColor = false;
            // 
            // btnInOrden
            // 
            btnInOrden.BackColor = Color.FromArgb(219, 219, 184);
            btnInOrden.ForeColor = Color.FromArgb(14, 47, 86);
            btnInOrden.Location = new Point(12, 27);
            btnInOrden.Name = "btnInOrden";
            btnInOrden.Size = new Size(121, 36);
            btnInOrden.TabIndex = 38;
            btnInOrden.Text = "InOrden";
            btnInOrden.UseVisualStyleBackColor = false;
            // 
            // gbEliminar
            // 
            gbEliminar.Controls.Add(btnEliminar);
            gbEliminar.Controls.Add(txtEliminar);
            gbEliminar.Font = new Font("Candara", 13.8F, FontStyle.Bold);
            gbEliminar.ForeColor = Color.Black;
            gbEliminar.Location = new Point(1273, 144);
            gbEliminar.Name = "gbEliminar";
            gbEliminar.Size = new Size(295, 142);
            gbEliminar.TabIndex = 72;
            gbEliminar.TabStop = false;
            gbEliminar.Text = "Eliminar";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(219, 219, 184);
            btnEliminar.ForeColor = Color.FromArgb(14, 47, 86);
            btnEliminar.Location = new Point(138, 63);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(102, 37);
            btnEliminar.TabIndex = 38;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // txtEliminar
            // 
            txtEliminar.Location = new Point(30, 64);
            txtEliminar.Name = "txtEliminar";
            txtEliminar.Size = new Size(73, 36);
            txtEliminar.TabIndex = 39;
            // 
            // FormArbolBalanceado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1576, 684);
            Controls.Add(label4);
            Controls.Add(IstRecorridos);
            Controls.Add(pnlArbol);
            Controls.Add(gbRecorridos);
            Controls.Add(gbEliminar);
            Controls.Add(label9);
            Controls.Add(btnsalir);
            Controls.Add(dgvCompra);
            Controls.Add(txtTotal);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(tableLayoutPanel1);
            MaximumSize = new Size(1594, 731);
            MinimumSize = new Size(1594, 731);
            Name = "FormArbolBalanceado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormArbolBalanceado";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnsalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCompra).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            gbRecorridos.ResumeLayout(false);
            gbEliminar.ResumeLayout(false);
            gbEliminar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label9;
        private PictureBox btnsalir;
        private DataGridView dgvCompra;
        private DataGridViewTextBoxColumn CODIGO;
        private DataGridViewTextBoxColumn PRODUCTO;
        private DataGridViewTextBoxColumn PRECIO;
        private DataGridViewTextBoxColumn CANTIDAD;
        private DataGridViewTextBoxColumn SUBTOTAL;
        private TextBox txtTotal;
        private Label label2;
        private GroupBox groupBox2;
        private Button btnAgregar;
        private TextBox txtCantidad;
        private TextBox txtPrecio;
        private ComboBox cmbProducto;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private TextBox txtCodigo;
        private Label label4;
        private ListBox IstRecorridos;
        private Panel pnlArbol;
        private GroupBox gbRecorridos;
        private Button btnPreOrden;
        private Button btnPosOrden;
        private Button btnInOrden;
        private GroupBox gbEliminar;
        private Button btnEliminar;
        private TextBox txtEliminar;
    }
}