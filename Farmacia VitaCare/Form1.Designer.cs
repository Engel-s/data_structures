namespace Farmacia_VitaCare
{
    partial class FormCompraVitaCare
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompraVitaCare));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            labelrecursividad = new Label();
            btnburbuja = new Button();
            btnquiscksot = new Button();
            btnmergesort = new Button();
            cmbproducto = new ComboBox();
            button1 = new Button();
            txtcantidad = new TextBox();
            txtprecio = new TextBox();
            txtcodigo = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            dtgcompras = new DataGridView();
            menuStrip1 = new MenuStrip();
            cOMPRASToolStripMenuItem = new ToolStripMenuItem();
            recursividadToolStripMenuItem = new ToolStripMenuItem();
            metodosDeOrdenamientoToolStripMenuItem = new ToolStripMenuItem();
            burbujaToolStripMenuItem = new ToolStripMenuItem();
            quickSortToolStripMenuItem = new ToolStripMenuItem();
            mergeSortToolStripMenuItem = new ToolStripMenuItem();
            estructurasDeDatosDinamicasToolStripMenuItem = new ToolStripMenuItem();
            pilasToolStripMenuItem = new ToolStripMenuItem();
            colasToolStripMenuItem = new ToolStripMenuItem();
            simplesToolStripMenuItem = new ToolStripMenuItem();
            circularesToolStripMenuItem = new ToolStripMenuItem();
            listasEnlazadasToolStripMenuItem = new ToolStripMenuItem();
            arbolesBinariosToolStripMenuItem = new ToolStripMenuItem();
            binariosToolStripMenuItem = new ToolStripMenuItem();
            binariosBalanceadosToolStripMenuItem = new ToolStripMenuItem();
            metodosDeOrdenamientoToolStripMenuItem1 = new ToolStripMenuItem();
            pictureBox2 = new PictureBox();
            txttotal = new TextBox();
            label8 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgcompras).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            tableLayoutPanel1.Location = new Point(0, 31);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1196, 163);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 13);
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
            label1.Location = new Point(242, 54);
            label1.Name = "label1";
            label1.Size = new Size(456, 54);
            label1.TabIndex = 1;
            label1.Text = "GESTION DE COMPRAS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelrecursividad);
            groupBox1.Controls.Add(btnburbuja);
            groupBox1.Controls.Add(btnquiscksot);
            groupBox1.Controls.Add(btnmergesort);
            groupBox1.Controls.Add(cmbproducto);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtcantidad);
            groupBox1.Controls.Add(txtprecio);
            groupBox1.Controls.Add(txtcodigo);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(0, 195);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1196, 176);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingresar datos";
            groupBox1.Enter += groupBox1_Enter_1;
            // 
            // labelrecursividad
            // 
            labelrecursividad.AutoSize = true;
            labelrecursividad.ForeColor = Color.Red;
            labelrecursividad.Location = new Point(138, 140);
            labelrecursividad.Name = "labelrecursividad";
            labelrecursividad.Size = new Size(611, 28);
            labelrecursividad.TabIndex = 19;
            labelrecursividad.Text = "Para saber el total use en el menustrip la opcion recursividad";
            // 
            // btnburbuja
            // 
            btnburbuja.BackColor = Color.FromArgb(14, 47, 86);
            btnburbuja.FlatStyle = FlatStyle.Flat;
            btnburbuja.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnburbuja.ForeColor = Color.White;
            btnburbuja.Location = new Point(1075, 30);
            btnburbuja.Name = "btnburbuja";
            btnburbuja.Size = new Size(115, 42);
            btnburbuja.TabIndex = 18;
            btnburbuja.Text = "Burbuja";
            btnburbuja.UseVisualStyleBackColor = false;
            btnburbuja.Click += btnburbuja_Click;
            // 
            // btnquiscksot
            // 
            btnquiscksot.BackColor = Color.FromArgb(14, 47, 86);
            btnquiscksot.FlatStyle = FlatStyle.Flat;
            btnquiscksot.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnquiscksot.ForeColor = Color.White;
            btnquiscksot.Location = new Point(1075, 78);
            btnquiscksot.Name = "btnquiscksot";
            btnquiscksot.Size = new Size(115, 42);
            btnquiscksot.TabIndex = 17;
            btnquiscksot.Text = "Quiscksort";
            btnquiscksot.UseVisualStyleBackColor = false;
            btnquiscksot.Click += btnquiscksot_Click;
            // 
            // btnmergesort
            // 
            btnmergesort.BackColor = Color.FromArgb(14, 47, 86);
            btnmergesort.FlatStyle = FlatStyle.Flat;
            btnmergesort.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnmergesort.ForeColor = Color.White;
            btnmergesort.Location = new Point(1075, 126);
            btnmergesort.Name = "btnmergesort";
            btnmergesort.Size = new Size(115, 42);
            btnmergesort.TabIndex = 16;
            btnmergesort.Text = "MergeSort";
            btnmergesort.UseVisualStyleBackColor = false;
            btnmergesort.Click += btnmergesort_Click;
            // 
            // cmbproducto
            // 
            cmbproducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbproducto.FormattingEnabled = true;
            cmbproducto.Items.AddRange(new object[] { "Paracetamol", "Ibuprofeno", "Aspirina", "Omeprazol", "Suero oral", "Alcohol etílico", "Agua oxigenada ", "Gasas estériles", "Gel antibacterial", "Condones", "Pruebas de embarazo", "Termómetros digitales", "Jarabes para la tos", "Banditas adhesivas", "Antidiarreicos", "Colirios", "Algodón" });
            cmbproducto.Location = new Point(242, 75);
            cmbproducto.Name = "cmbproducto";
            cmbproducto.Size = new Size(276, 36);
            cmbproducto.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(14, 47, 86);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 128);
            button1.Name = "button1";
            button1.Size = new Size(115, 42);
            button1.TabIndex = 14;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_2;
            // 
            // txtcantidad
            // 
            txtcantidad.BorderStyle = BorderStyle.FixedSingle;
            txtcantidad.Location = new Point(805, 75);
            txtcantidad.Multiline = true;
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(173, 37);
            txtcantidad.TabIndex = 12;
            // 
            // txtprecio
            // 
            txtprecio.BorderStyle = BorderStyle.FixedSingle;
            txtprecio.Location = new Point(565, 76);
            txtprecio.Multiline = true;
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(173, 37);
            txtprecio.TabIndex = 11;
            // 
            // txtcodigo
            // 
            txtcodigo.BorderStyle = BorderStyle.FixedSingle;
            txtcodigo.Location = new Point(12, 76);
            txtcodigo.Multiline = true;
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(169, 37);
            txtcodigo.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(790, 104);
            label7.Name = "label7";
            label7.Size = new Size(0, 28);
            label7.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(805, 44);
            label5.Name = "label5";
            label5.Size = new Size(100, 28);
            label5.TabIndex = 6;
            label5.Text = "Cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(565, 44);
            label4.Name = "label4";
            label4.Size = new Size(75, 28);
            label4.TabIndex = 5;
            label4.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(242, 44);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 4;
            label3.Text = "Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(83, 28);
            label2.TabIndex = 3;
            label2.Text = "Código";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Candara", 13.8F, FontStyle.Bold);
            label6.Location = new Point(1038, 559);
            label6.Name = "label6";
            label6.Size = new Size(61, 28);
            label6.TabIndex = 15;
            label6.Text = "Total";
            // 
            // Column5
            // 
            Column5.HeaderText = "SUBTOTAL";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column4
            // 
            Column4.HeaderText = "CANTIDAD";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column3
            // 
            Column3.HeaderText = "PRECIO";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column2
            // 
            Column2.HeaderText = "PRODUCTO";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column1.HeaderText = "CODIGO";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 229;
            // 
            // dtgcompras
            // 
            dtgcompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgcompras.BackgroundColor = Color.White;
            dtgcompras.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(14, 47, 86);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgcompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgcompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgcompras.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dtgcompras.GridColor = Color.FromArgb(17, 141, 240);
            dtgcompras.Location = new Point(0, 377);
            dtgcompras.Name = "dtgcompras";
            dtgcompras.RowHeadersWidth = 51;
            dtgcompras.Size = new Size(1017, 268);
            dtgcompras.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cOMPRASToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1196, 32);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // cOMPRASToolStripMenuItem
            // 
            cOMPRASToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { recursividadToolStripMenuItem, metodosDeOrdenamientoToolStripMenuItem, estructurasDeDatosDinamicasToolStripMenuItem, arbolesBinariosToolStripMenuItem, metodosDeOrdenamientoToolStripMenuItem1 });
            cOMPRASToolStripMenuItem.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cOMPRASToolStripMenuItem.ForeColor = Color.FromArgb(21, 71, 130);
            cOMPRASToolStripMenuItem.Name = "cOMPRASToolStripMenuItem";
            cOMPRASToolStripMenuItem.Size = new Size(112, 28);
            cOMPRASToolStripMenuItem.Text = "COMPRAS";
            cOMPRASToolStripMenuItem.Click += cOMPRASToolStripMenuItem_Click;
            // 
            // recursividadToolStripMenuItem
            // 
            recursividadToolStripMenuItem.Name = "recursividadToolStripMenuItem";
            recursividadToolStripMenuItem.Size = new Size(358, 28);
            recursividadToolStripMenuItem.Text = "Recursividad ";
            recursividadToolStripMenuItem.Click += recursividadToolStripMenuItem_Click;
            // 
            // metodosDeOrdenamientoToolStripMenuItem
            // 
            metodosDeOrdenamientoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { burbujaToolStripMenuItem, quickSortToolStripMenuItem, mergeSortToolStripMenuItem });
            metodosDeOrdenamientoToolStripMenuItem.Name = "metodosDeOrdenamientoToolStripMenuItem";
            metodosDeOrdenamientoToolStripMenuItem.Size = new Size(358, 28);
            metodosDeOrdenamientoToolStripMenuItem.Text = "Metodos de Ordenamiento";
            // 
            // burbujaToolStripMenuItem
            // 
            burbujaToolStripMenuItem.Name = "burbujaToolStripMenuItem";
            burbujaToolStripMenuItem.Size = new Size(186, 28);
            burbujaToolStripMenuItem.Text = "Burbuja";
            burbujaToolStripMenuItem.Click += burbujaToolStripMenuItem_Click;
            // 
            // quickSortToolStripMenuItem
            // 
            quickSortToolStripMenuItem.Name = "quickSortToolStripMenuItem";
            quickSortToolStripMenuItem.Size = new Size(186, 28);
            quickSortToolStripMenuItem.Text = "QuickSort";
            quickSortToolStripMenuItem.Click += quickSortToolStripMenuItem_Click_3;
            // 
            // mergeSortToolStripMenuItem
            // 
            mergeSortToolStripMenuItem.Name = "mergeSortToolStripMenuItem";
            mergeSortToolStripMenuItem.Size = new Size(186, 28);
            mergeSortToolStripMenuItem.Text = "MergeSort";
            mergeSortToolStripMenuItem.Click += mergeSortToolStripMenuItem_Click_3;
            // 
            // estructurasDeDatosDinamicasToolStripMenuItem
            // 
            estructurasDeDatosDinamicasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pilasToolStripMenuItem, colasToolStripMenuItem, listasEnlazadasToolStripMenuItem });
            estructurasDeDatosDinamicasToolStripMenuItem.Name = "estructurasDeDatosDinamicasToolStripMenuItem";
            estructurasDeDatosDinamicasToolStripMenuItem.Size = new Size(358, 28);
            estructurasDeDatosDinamicasToolStripMenuItem.Text = "Estructuras de datos dinamicas";
            // 
            // pilasToolStripMenuItem
            // 
            pilasToolStripMenuItem.Name = "pilasToolStripMenuItem";
            pilasToolStripMenuItem.Size = new Size(231, 28);
            pilasToolStripMenuItem.Text = "Pilas";
            pilasToolStripMenuItem.Click += pilasToolStripMenuItem_Click;
            // 
            // colasToolStripMenuItem
            // 
            colasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { simplesToolStripMenuItem, circularesToolStripMenuItem });
            colasToolStripMenuItem.Name = "colasToolStripMenuItem";
            colasToolStripMenuItem.Size = new Size(231, 28);
            colasToolStripMenuItem.Text = "Colas";
            // 
            // simplesToolStripMenuItem
            // 
            simplesToolStripMenuItem.Name = "simplesToolStripMenuItem";
            simplesToolStripMenuItem.Size = new Size(224, 28);
            simplesToolStripMenuItem.Text = "Simples";
            simplesToolStripMenuItem.Click += simplesToolStripMenuItem_Click;
            // 
            // circularesToolStripMenuItem
            // 
            circularesToolStripMenuItem.Name = "circularesToolStripMenuItem";
            circularesToolStripMenuItem.Size = new Size(224, 28);
            circularesToolStripMenuItem.Text = "Circulares";
            circularesToolStripMenuItem.Click += circularesToolStripMenuItem_Click;
            // 
            // listasEnlazadasToolStripMenuItem
            // 
            listasEnlazadasToolStripMenuItem.Name = "listasEnlazadasToolStripMenuItem";
            listasEnlazadasToolStripMenuItem.Size = new Size(231, 28);
            listasEnlazadasToolStripMenuItem.Text = "Listas Enlazadas";
            // 
            // arbolesBinariosToolStripMenuItem
            // 
            arbolesBinariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { binariosToolStripMenuItem, binariosBalanceadosToolStripMenuItem });
            arbolesBinariosToolStripMenuItem.Name = "arbolesBinariosToolStripMenuItem";
            arbolesBinariosToolStripMenuItem.Size = new Size(358, 28);
            arbolesBinariosToolStripMenuItem.Text = "Arboles binarios";
            // 
            // binariosToolStripMenuItem
            // 
            binariosToolStripMenuItem.Name = "binariosToolStripMenuItem";
            binariosToolStripMenuItem.Size = new Size(274, 28);
            binariosToolStripMenuItem.Text = "Binarios";
            // 
            // binariosBalanceadosToolStripMenuItem
            // 
            binariosBalanceadosToolStripMenuItem.Name = "binariosBalanceadosToolStripMenuItem";
            binariosBalanceadosToolStripMenuItem.Size = new Size(274, 28);
            binariosBalanceadosToolStripMenuItem.Text = "Binarios balanceados";
            // 
            // metodosDeOrdenamientoToolStripMenuItem1
            // 
            metodosDeOrdenamientoToolStripMenuItem1.Name = "metodosDeOrdenamientoToolStripMenuItem1";
            metodosDeOrdenamientoToolStripMenuItem1.Size = new Size(358, 28);
            metodosDeOrdenamientoToolStripMenuItem1.Text = "Metodos de Ordenamiento";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1120, 651);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // txttotal
            // 
            txttotal.BorderStyle = BorderStyle.FixedSingle;
            txttotal.Location = new Point(1038, 590);
            txttotal.Multiline = true;
            txttotal.Name = "txttotal";
            txttotal.ReadOnly = true;
            txttotal.Size = new Size(146, 37);
            txttotal.TabIndex = 15;
            txttotal.TextChanged += txttotal_TextChanged;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Candara", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(12, 671);
            label8.Name = "label8";
            label8.Size = new Size(223, 21);
            label8.TabIndex = 16;
            label8.Text = "Elaborado por: Engel Chavarria";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormCompraVitaCare
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 253, 252);
            ClientSize = new Size(1196, 701);
            Controls.Add(label8);
            Controls.Add(txttotal);
            Controls.Add(label6);
            Controls.Add(pictureBox2);
            Controls.Add(dtgcompras);
            Controls.Add(groupBox1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(1214, 748);
            MinimumSize = new Size(1214, 748);
            Name = "FormCompraVitaCare";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VitaCare";
            Load += FormCompraVitaCare_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgcompras).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtcodigo;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtcantidad;
        private TextBox txtprecio;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridView dtgcompras;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cOMPRASToolStripMenuItem;
        private ToolStripMenuItem recursividadToolStripMenuItem;
        private ToolStripMenuItem metodosDeOrdenamientoToolStripMenuItem;
        private ToolStripMenuItem estructurasDeDatosDinamicasToolStripMenuItem;
        private ToolStripMenuItem arbolesBinariosToolStripMenuItem;
        private PictureBox pictureBox2;
        private Button button1;
        private Label label6;
        private TextBox txttotal;
        private ComboBox cmbproducto;
        private ToolStripMenuItem burbujaToolStripMenuItem;
        private ToolStripMenuItem quickSortToolStripMenuItem;
        private ToolStripMenuItem mergeSortToolStripMenuItem;
        private ToolStripMenuItem pilasToolStripMenuItem;
        private ToolStripMenuItem colasToolStripMenuItem;
        private ToolStripMenuItem simplesToolStripMenuItem;
        private ToolStripMenuItem circularesToolStripMenuItem;
        private ToolStripMenuItem listasEnlazadasToolStripMenuItem;
        private ToolStripMenuItem binariosToolStripMenuItem;
        private ToolStripMenuItem binariosBalanceadosToolStripMenuItem;
        private Button btnburbuja;
        private Button btnquiscksot;
        private Button btnmergesort;
        private Label labelrecursividad;
        private ToolStripMenuItem metodosDeOrdenamientoToolStripMenuItem1;
        private Label label8;
    }
}
