namespace Farmacia_VitaCare
{
    partial class FormArbolBinario
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArbolBinario));
            groupBox1 = new GroupBox();
            txtsize = new TextBox();
            btnok = new Button();
            groupBox2 = new GroupBox();
            label3 = new Label();
            txtcodigo = new TextBox();
            groupBox3 = new GroupBox();
            btneliminar = new Button();
            label4 = new Label();
            txteliminar = new TextBox();
            tabControl1 = new TabControl();
            tabpagedatos = new TabPage();
            tabpagearbol = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cmbproducto = new ComboBox();
            txtprecio = new TextBox();
            txtcantidad = new TextBox();
            txttotal = new TextBox();
            label2 = new Label();
            dtgcompras = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            btnsalir = new PictureBox();
            groupBox4 = new GroupBox();
            btnInorden = new Button();
            btnposorden = new Button();
            btnpreorden = new Button();
            IstRecorridos = new ListBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            tabControl1.SuspendLayout();
            tabpagedatos.SuspendLayout();
            tabpagearbol.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgcompras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnsalir).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnok);
            groupBox1.Controls.Add(txtsize);
            groupBox1.Font = new Font("Candara", 13.8F, FontStyle.Bold);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(0, 174);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(277, 98);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipos de articulos";
            // 
            // txtsize
            // 
            txtsize.Location = new Point(18, 52);
            txtsize.Name = "txtsize";
            txtsize.Size = new Size(112, 36);
            txtsize.TabIndex = 39;
            // 
            // btnok
            // 
            btnok.BackColor = Color.FromArgb(219, 219, 184);
            btnok.ForeColor = Color.FromArgb(14, 47, 86);
            btnok.Location = new Point(155, 52);
            btnok.Name = "btnok";
            btnok.Size = new Size(94, 36);
            btnok.TabIndex = 38;
            btnok.Text = "Ok";
            btnok.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtcantidad);
            groupBox2.Controls.Add(txtprecio);
            groupBox2.Controls.Add(cmbproducto);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtcodigo);
            groupBox2.Font = new Font("Candara", 13.8F, FontStyle.Bold);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(3, 304);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1190, 148);
            groupBox2.TabIndex = 38;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ingresar datos";
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
            label3.Text = "Codigo:";
            // 
            // txtcodigo
            // 
            txtcodigo.Location = new Point(9, 63);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(161, 36);
            txtcodigo.TabIndex = 39;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btneliminar);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(txteliminar);
            groupBox3.Font = new Font("Candara", 13.8F, FontStyle.Bold);
            groupBox3.ForeColor = Color.Black;
            groupBox3.Location = new Point(908, 169);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(269, 140);
            groupBox3.TabIndex = 39;
            groupBox3.TabStop = false;
            groupBox3.Text = "Eliminar";
            // 
            // btneliminar
            // 
            btneliminar.BackColor = Color.FromArgb(219, 219, 184);
            btneliminar.ForeColor = Color.FromArgb(14, 47, 86);
            btneliminar.Location = new Point(59, 91);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(161, 37);
            btneliminar.TabIndex = 38;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Candara", 13.8F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(15, 21);
            label4.Name = "label4";
            label4.Size = new Size(246, 28);
            label4.TabIndex = 38;
            label4.Text = "Ingrese dato a eliminar:";
            // 
            // txteliminar
            // 
            txteliminar.Location = new Point(59, 52);
            txteliminar.Name = "txteliminar";
            txteliminar.Size = new Size(161, 36);
            txteliminar.TabIndex = 39;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabpagedatos);
            tabControl1.Controls.Add(tabpagearbol);
            tabControl1.Location = new Point(0, -3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1198, 705);
            tabControl1.TabIndex = 40;
            // 
            // tabpagedatos
            // 
            tabpagedatos.Controls.Add(btnsalir);
            tabpagedatos.Controls.Add(dtgcompras);
            tabpagedatos.Controls.Add(txttotal);
            tabpagedatos.Controls.Add(label2);
            tabpagedatos.Controls.Add(tableLayoutPanel1);
            tabpagedatos.Controls.Add(groupBox2);
            tabpagedatos.Controls.Add(groupBox1);
            tabpagedatos.Controls.Add(groupBox3);
            tabpagedatos.Location = new Point(4, 29);
            tabpagedatos.Name = "tabpagedatos";
            tabpagedatos.Padding = new Padding(3);
            tabpagedatos.Size = new Size(1190, 672);
            tabpagedatos.TabIndex = 0;
            tabpagedatos.Text = "Informacion";
            tabpagedatos.UseVisualStyleBackColor = true;
            // 
            // tabpagearbol
            // 
            tabpagearbol.Controls.Add(label8);
            tabpagearbol.Controls.Add(IstRecorridos);
            tabpagearbol.Controls.Add(groupBox4);
            tabpagearbol.Location = new Point(4, 29);
            tabpagearbol.Name = "tabpagearbol";
            tabpagearbol.Padding = new Padding(3);
            tabpagearbol.Size = new Size(1190, 672);
            tabpagearbol.TabIndex = 1;
            tabpagearbol.Text = "Arbol binario";
            tabpagearbol.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(219, 219, 184);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1190, 168);
            tableLayoutPanel1.TabIndex = 40;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 136);
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
            label1.Location = new Point(241, 57);
            label1.Name = "label1";
            label1.Size = new Size(456, 54);
            label1.TabIndex = 1;
            label1.Text = "GESTION DE COMPRAS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            // cmbproducto
            // 
            cmbproducto.FormattingEnabled = true;
            cmbproducto.Location = new Point(207, 63);
            cmbproducto.Name = "cmbproducto";
            cmbproducto.Size = new Size(225, 36);
            cmbproducto.TabIndex = 43;
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(472, 63);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(167, 36);
            txtprecio.TabIndex = 44;
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(692, 63);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(148, 36);
            txtcantidad.TabIndex = 45;
            // 
            // txttotal
            // 
            txttotal.Location = new Point(1042, 582);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(135, 27);
            txttotal.TabIndex = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(1042, 551);
            label2.Name = "label2";
            label2.Size = new Size(61, 28);
            label2.TabIndex = 45;
            label2.Text = "Total";
            // 
            // dtgcompras
            // 
            dtgcompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgcompras.BackgroundColor = Color.White;
            dtgcompras.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(14, 47, 86);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgcompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtgcompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgcompras.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dtgcompras.GridColor = Color.FromArgb(17, 141, 240);
            dtgcompras.Location = new Point(12, 458);
            dtgcompras.Name = "dtgcompras";
            dtgcompras.RowHeadersWidth = 51;
            dtgcompras.Size = new Size(1017, 205);
            dtgcompras.TabIndex = 47;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column1.HeaderText = "CODIGO";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 229;
            // 
            // Column2
            // 
            Column2.HeaderText = "PRODUCTO";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "PRECIO";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "CANTIDAD";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "SUBTOTAL";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // btnsalir
            // 
            btnsalir.Image = (Image)resources.GetObject("btnsalir.Image");
            btnsalir.Location = new Point(1116, 616);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(64, 47);
            btnsalir.SizeMode = PictureBoxSizeMode.StretchImage;
            btnsalir.TabIndex = 48;
            btnsalir.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnpreorden);
            groupBox4.Controls.Add(btnposorden);
            groupBox4.Controls.Add(btnInorden);
            groupBox4.Font = new Font("Candara", 13.8F, FontStyle.Bold);
            groupBox4.ForeColor = Color.Black;
            groupBox4.Location = new Point(8, 20);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(365, 98);
            groupBox4.TabIndex = 38;
            groupBox4.TabStop = false;
            groupBox4.Text = "Recorridos:";
            // 
            // btnInorden
            // 
            btnInorden.BackColor = Color.FromArgb(219, 219, 184);
            btnInorden.ForeColor = Color.FromArgb(14, 47, 86);
            btnInorden.Location = new Point(6, 45);
            btnInorden.Name = "btnInorden";
            btnInorden.Size = new Size(102, 36);
            btnInorden.TabIndex = 38;
            btnInorden.Text = "InOrden";
            btnInorden.UseVisualStyleBackColor = false;
            // 
            // btnposorden
            // 
            btnposorden.BackColor = Color.FromArgb(219, 219, 184);
            btnposorden.ForeColor = Color.FromArgb(14, 47, 86);
            btnposorden.Location = new Point(114, 45);
            btnposorden.Name = "btnposorden";
            btnposorden.Size = new Size(120, 36);
            btnposorden.TabIndex = 39;
            btnposorden.Text = "PosOrden";
            btnposorden.UseVisualStyleBackColor = false;
            // 
            // btnpreorden
            // 
            btnpreorden.BackColor = Color.FromArgb(219, 219, 184);
            btnpreorden.ForeColor = Color.FromArgb(14, 47, 86);
            btnpreorden.Location = new Point(240, 45);
            btnpreorden.Name = "btnpreorden";
            btnpreorden.Size = new Size(117, 36);
            btnpreorden.TabIndex = 40;
            btnpreorden.Text = "PreOrden";
            btnpreorden.UseVisualStyleBackColor = false;
            // 
            // IstRecorridos
            // 
            IstRecorridos.FormattingEnabled = true;
            IstRecorridos.Location = new Point(8, 160);
            IstRecorridos.Name = "IstRecorridos";
            IstRecorridos.Size = new Size(206, 204);
            IstRecorridos.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Candara", 13.8F, FontStyle.Bold);
            label8.Location = new Point(8, 129);
            label8.Name = "label8";
            label8.Size = new Size(111, 28);
            label8.TabIndex = 40;
            label8.Text = "Recorrido";
            // 
            // FormArbolBinario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 47, 86);
            ClientSize = new Size(1196, 701);
            Controls.Add(tabControl1);
            Name = "FormArbolBinario";
            Text = "FormArbolBinario";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabpagedatos.ResumeLayout(false);
            tabpagedatos.PerformLayout();
            tabpagearbol.ResumeLayout(false);
            tabpagearbol.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgcompras).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnsalir).EndInit();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private TextBox txtsize;
        private Button btnok;
        private GroupBox groupBox2;
        private Label label3;
        private TextBox txtcodigo;
        private GroupBox groupBox3;
        private Button btneliminar;
        private Label label4;
        private TextBox txteliminar;
        private TabControl tabControl1;
        private TabPage tabpagedatos;
        private TabPage tabpagearbol;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private ComboBox cmbproducto;
        private TextBox txtprecio;
        private TextBox txtcantidad;
        private TextBox txttotal;
        private Label label2;
        private DataGridView dtgcompras;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private PictureBox btnsalir;
        private ListBox IstRecorridos;
        private GroupBox groupBox4;
        private Button btnpreorden;
        private Button btnposorden;
        private Button btnInorden;
        private Label label8;
    }
}