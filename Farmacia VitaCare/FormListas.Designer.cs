namespace Farmacia_VitaCare
{
    partial class FormListas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListas));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            insertarAlInicioToolStripMenuItem = new ToolStripMenuItem();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            finalToolStripMenuItem = new ToolStripMenuItem();
            antesDeXToolStripMenuItem = new ToolStripMenuItem();
            despuesDeXToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            eliminarinicioToolStripMenuItem1 = new ToolStripMenuItem();
            eliminarfinalToolStripMenuItem1 = new ToolStripMenuItem();
            eliminarXToolStripMenuItem1 = new ToolStripMenuItem();
            eliminardespuesDeXToolStripMenuItem1 = new ToolStripMenuItem();
            despuesDeXToolStripMenuItem1 = new ToolStripMenuItem();
            busquedaToolStripMenuItem = new ToolStripMenuItem();
            ordenadaToolStripMenuItem = new ToolStripMenuItem();
            desordenadaToolStripMenuItem = new ToolStripMenuItem();
            recursivaToolStripMenuItem = new ToolStripMenuItem();
            recorridosToolStripMenuItem = new ToolStripMenuItem();
            iterativoToolStripMenuItem = new ToolStripMenuItem();
            recursivoToolStripMenuItem = new ToolStripMenuItem();
            label9 = new Label();
            txttotallista = new TextBox();
            lblTotal = new Label();
            btnsalir = new PictureBox();
            dtglistas = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            panelData = new GroupBox();
            cmbproductolista = new ComboBox();
            txtcantidadlista = new TextBox();
            txtpreciolista = new TextBox();
            txtcodigolista = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnInsertarDespuesX = new Button();
            btnInsertarFinal = new Button();
            btnInsertarAntesX = new Button();
            btnInsertarInicio = new Button();
            tablepanel = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panelBuscar = new GroupBox();
            txtbuscar = new TextBox();
            label10 = new Label();
            pnlBtnInsertar = new Panel();
            btnEliminarDespuesX = new Button();
            btnEliminarAntesX = new Button();
            btnEliminarFinal = new Button();
            btnEliminarInicio = new Button();
            pnlEliminar = new Panel();
            btnEliminarX = new Button();
            pnlBusqueda = new Panel();
            btnbusquedaRecursiva = new Button();
            btnbusquedaDesordenada = new Button();
            btnbusquedaOrdenada = new Button();
            pnlRecorrido = new Panel();
            btnRecorrerR = new Button();
            btnRecorrerI = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnsalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtglistas).BeginInit();
            panelData.SuspendLayout();
            tablepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBuscar.SuspendLayout();
            pnlBtnInsertar.SuspendLayout();
            pnlEliminar.SuspendLayout();
            pnlBusqueda.SuspendLayout();
            pnlRecorrido.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { insertarAlInicioToolStripMenuItem, eliminarToolStripMenuItem, busquedaToolStripMenuItem, recorridosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1196, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // insertarAlInicioToolStripMenuItem
            // 
            insertarAlInicioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, finalToolStripMenuItem, antesDeXToolStripMenuItem, despuesDeXToolStripMenuItem });
            insertarAlInicioToolStripMenuItem.Name = "insertarAlInicioToolStripMenuItem";
            insertarAlInicioToolStripMenuItem.Size = new Size(72, 24);
            insertarAlInicioToolStripMenuItem.Text = "Insertar";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(182, 26);
            inicioToolStripMenuItem.Text = "Inicio";
            inicioToolStripMenuItem.Click += inicioToolStripMenuItem_Click;
            // 
            // finalToolStripMenuItem
            // 
            finalToolStripMenuItem.Name = "finalToolStripMenuItem";
            finalToolStripMenuItem.Size = new Size(182, 26);
            finalToolStripMenuItem.Text = "Final";
            finalToolStripMenuItem.Click += finalToolStripMenuItem_Click;
            // 
            // antesDeXToolStripMenuItem
            // 
            antesDeXToolStripMenuItem.Name = "antesDeXToolStripMenuItem";
            antesDeXToolStripMenuItem.Size = new Size(182, 26);
            antesDeXToolStripMenuItem.Text = "Antes de X";
            antesDeXToolStripMenuItem.Click += antesDeXToolStripMenuItem_Click;
            // 
            // despuesDeXToolStripMenuItem
            // 
            despuesDeXToolStripMenuItem.Name = "despuesDeXToolStripMenuItem";
            despuesDeXToolStripMenuItem.Size = new Size(182, 26);
            despuesDeXToolStripMenuItem.Text = "Despues de X";
            despuesDeXToolStripMenuItem.Click += despuesDeXToolStripMenuItem_Click;
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { eliminarinicioToolStripMenuItem1, eliminarfinalToolStripMenuItem1, eliminarXToolStripMenuItem1, eliminardespuesDeXToolStripMenuItem1, despuesDeXToolStripMenuItem1 });
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(77, 24);
            eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // eliminarinicioToolStripMenuItem1
            // 
            eliminarinicioToolStripMenuItem1.Name = "eliminarinicioToolStripMenuItem1";
            eliminarinicioToolStripMenuItem1.Size = new Size(182, 26);
            eliminarinicioToolStripMenuItem1.Text = "Inicio";
            eliminarinicioToolStripMenuItem1.Click += eliminarinicioToolStripMenuItem1_Click;
            // 
            // eliminarfinalToolStripMenuItem1
            // 
            eliminarfinalToolStripMenuItem1.Name = "eliminarfinalToolStripMenuItem1";
            eliminarfinalToolStripMenuItem1.Size = new Size(182, 26);
            eliminarfinalToolStripMenuItem1.Text = "Final";
            eliminarfinalToolStripMenuItem1.Click += eliminarfinalToolStripMenuItem1_Click;
            // 
            // eliminarXToolStripMenuItem1
            // 
            eliminarXToolStripMenuItem1.Name = "eliminarXToolStripMenuItem1";
            eliminarXToolStripMenuItem1.Size = new Size(182, 26);
            eliminarXToolStripMenuItem1.Text = "Eliminar X";
            eliminarXToolStripMenuItem1.Click += eliminarantesDeXToolStripMenuItem1_Click;
            // 
            // eliminardespuesDeXToolStripMenuItem1
            // 
            eliminardespuesDeXToolStripMenuItem1.Name = "eliminardespuesDeXToolStripMenuItem1";
            eliminardespuesDeXToolStripMenuItem1.Size = new Size(182, 26);
            eliminardespuesDeXToolStripMenuItem1.Text = "Antes de X";
            eliminardespuesDeXToolStripMenuItem1.Click += eliminardespuesDeXToolStripMenuItem1_Click;
            // 
            // despuesDeXToolStripMenuItem1
            // 
            despuesDeXToolStripMenuItem1.Name = "despuesDeXToolStripMenuItem1";
            despuesDeXToolStripMenuItem1.Size = new Size(182, 26);
            despuesDeXToolStripMenuItem1.Text = "Despues de X";
            despuesDeXToolStripMenuItem1.Click += despuesDeXToolStripMenuItem1_Click;
            // 
            // busquedaToolStripMenuItem
            // 
            busquedaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ordenadaToolStripMenuItem, desordenadaToolStripMenuItem, recursivaToolStripMenuItem });
            busquedaToolStripMenuItem.Name = "busquedaToolStripMenuItem";
            busquedaToolStripMenuItem.Size = new Size(88, 24);
            busquedaToolStripMenuItem.Text = "Busqueda";
            // 
            // ordenadaToolStripMenuItem
            // 
            ordenadaToolStripMenuItem.Name = "ordenadaToolStripMenuItem";
            ordenadaToolStripMenuItem.Size = new Size(181, 26);
            ordenadaToolStripMenuItem.Text = "Ordenada";
            ordenadaToolStripMenuItem.Click += ordenadaToolStripMenuItem_Click;
            // 
            // desordenadaToolStripMenuItem
            // 
            desordenadaToolStripMenuItem.Name = "desordenadaToolStripMenuItem";
            desordenadaToolStripMenuItem.Size = new Size(181, 26);
            desordenadaToolStripMenuItem.Text = "Desordenada";
            desordenadaToolStripMenuItem.Click += desordenadaToolStripMenuItem_Click;
            // 
            // recursivaToolStripMenuItem
            // 
            recursivaToolStripMenuItem.Name = "recursivaToolStripMenuItem";
            recursivaToolStripMenuItem.Size = new Size(181, 26);
            recursivaToolStripMenuItem.Text = "Recursiva";
            recursivaToolStripMenuItem.Click += recursivaToolStripMenuItem_Click;
            // 
            // recorridosToolStripMenuItem
            // 
            recorridosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { iterativoToolStripMenuItem, recursivoToolStripMenuItem });
            recorridosToolStripMenuItem.Name = "recorridosToolStripMenuItem";
            recorridosToolStripMenuItem.Size = new Size(94, 24);
            recorridosToolStripMenuItem.Text = "Recorridos";
            // 
            // iterativoToolStripMenuItem
            // 
            iterativoToolStripMenuItem.Name = "iterativoToolStripMenuItem";
            iterativoToolStripMenuItem.Size = new Size(155, 26);
            iterativoToolStripMenuItem.Text = "Iterativo";
            iterativoToolStripMenuItem.Click += iterativoToolStripMenuItem_Click;
            // 
            // recursivoToolStripMenuItem
            // 
            recursivoToolStripMenuItem.Name = "recursivoToolStripMenuItem";
            recursivoToolStripMenuItem.Size = new Size(155, 26);
            recursivoToolStripMenuItem.Text = "Recursivo";
            recursivoToolStripMenuItem.Click += recursivoToolStripMenuItem_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Candara", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(12, 672);
            label9.Name = "label9";
            label9.Size = new Size(223, 21);
            label9.TabIndex = 54;
            label9.Text = "Elaborado por: Engel Chavarria";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txttotallista
            // 
            txttotallista.BorderStyle = BorderStyle.FixedSingle;
            txttotallista.Location = new Point(1038, 603);
            txttotallista.Multiline = true;
            txttotallista.Name = "txttotallista";
            txttotallista.ReadOnly = true;
            txttotallista.Size = new Size(146, 37);
            txttotallista.TabIndex = 53;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Candara", 13.8F, FontStyle.Bold);
            lblTotal.Location = new Point(1038, 572);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(61, 28);
            lblTotal.TabIndex = 52;
            lblTotal.Text = "Total";
            // 
            // btnsalir
            // 
            btnsalir.Image = (Image)resources.GetObject("btnsalir.Image");
            btnsalir.Location = new Point(1120, 646);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(64, 47);
            btnsalir.SizeMode = PictureBoxSizeMode.StretchImage;
            btnsalir.TabIndex = 51;
            btnsalir.TabStop = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // dtglistas
            // 
            dtglistas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtglistas.BackgroundColor = Color.White;
            dtglistas.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(14, 47, 86);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtglistas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtglistas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtglistas.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Subtotal });
            dtglistas.GridColor = Color.FromArgb(17, 141, 240);
            dtglistas.Location = new Point(0, 440);
            dtglistas.Name = "dtglistas";
            dtglistas.RowHeadersWidth = 51;
            dtglistas.Size = new Size(1017, 204);
            dtglistas.TabIndex = 50;
            dtglistas.CellContentClick += dtglistas_CellContentClick;
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
            // Subtotal
            // 
            Subtotal.HeaderText = "SUBTOTAL";
            Subtotal.MinimumWidth = 6;
            Subtotal.Name = "Subtotal";
            // 
            // panelData
            // 
            panelData.Controls.Add(cmbproductolista);
            panelData.Controls.Add(txtcantidadlista);
            panelData.Controls.Add(txtpreciolista);
            panelData.Controls.Add(txtcodigolista);
            panelData.Controls.Add(label7);
            panelData.Controls.Add(label5);
            panelData.Controls.Add(label4);
            panelData.Controls.Add(label3);
            panelData.Controls.Add(label2);
            panelData.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelData.ForeColor = Color.Black;
            panelData.Location = new Point(0, 212);
            panelData.Name = "panelData";
            panelData.Size = new Size(877, 132);
            panelData.TabIndex = 46;
            panelData.TabStop = false;
            panelData.Text = "Ingresar datos";
            // 
            // cmbproductolista
            // 
            cmbproductolista.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbproductolista.FormattingEnabled = true;
            cmbproductolista.Items.AddRange(new object[] { "Paracetamol", "Ibuprofeno", "Aspirina", "Omeprazol", "Suero oral", "Alcohol etílico", "Agua oxigenada ", "Gasas estériles", "Gel antibacterial", "Condones", "Pruebas de embarazo", "Termómetros digitales", "Jarabes para la tos", "Banditas adhesivas", "Antidiarreicos", "Colirios", "Algodón" });
            cmbproductolista.Location = new Point(198, 77);
            cmbproductolista.Name = "cmbproductolista";
            cmbproductolista.Size = new Size(262, 36);
            cmbproductolista.TabIndex = 15;
            // 
            // txtcantidadlista
            // 
            txtcantidadlista.BorderStyle = BorderStyle.FixedSingle;
            txtcantidadlista.Location = new Point(693, 78);
            txtcantidadlista.Multiline = true;
            txtcantidadlista.Name = "txtcantidadlista";
            txtcantidadlista.Size = new Size(173, 37);
            txtcantidadlista.TabIndex = 12;
            // 
            // txtpreciolista
            // 
            txtpreciolista.BorderStyle = BorderStyle.FixedSingle;
            txtpreciolista.Location = new Point(491, 78);
            txtpreciolista.Multiline = true;
            txtpreciolista.Name = "txtpreciolista";
            txtpreciolista.Size = new Size(173, 37);
            txtpreciolista.TabIndex = 11;
            // 
            // txtcodigolista
            // 
            txtcodigolista.BorderStyle = BorderStyle.FixedSingle;
            txtcodigolista.Location = new Point(12, 76);
            txtcodigolista.Multiline = true;
            txtcodigolista.Name = "txtcodigolista";
            txtcodigolista.Size = new Size(169, 37);
            txtcodigolista.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(767, 104);
            label7.Name = "label7";
            label7.Size = new Size(0, 28);
            label7.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(693, 44);
            label5.Name = "label5";
            label5.Size = new Size(100, 28);
            label5.TabIndex = 6;
            label5.Text = "Cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(491, 44);
            label4.Name = "label4";
            label4.Size = new Size(75, 28);
            label4.TabIndex = 5;
            label4.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(198, 44);
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
            // btnInsertarDespuesX
            // 
            btnInsertarDespuesX.BackColor = Color.FromArgb(14, 47, 86);
            btnInsertarDespuesX.FlatStyle = FlatStyle.Flat;
            btnInsertarDespuesX.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsertarDespuesX.ForeColor = Color.White;
            btnInsertarDespuesX.Location = new Point(28, 22);
            btnInsertarDespuesX.Name = "btnInsertarDespuesX";
            btnInsertarDespuesX.Size = new Size(115, 42);
            btnInsertarDespuesX.TabIndex = 20;
            btnInsertarDespuesX.Text = "Agregar ";
            btnInsertarDespuesX.UseVisualStyleBackColor = false;
            btnInsertarDespuesX.Click += btnInsertarDespuesX_Click;
            // 
            // btnInsertarFinal
            // 
            btnInsertarFinal.BackColor = Color.FromArgb(14, 47, 86);
            btnInsertarFinal.FlatStyle = FlatStyle.Flat;
            btnInsertarFinal.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsertarFinal.ForeColor = Color.White;
            btnInsertarFinal.Location = new Point(28, 22);
            btnInsertarFinal.Name = "btnInsertarFinal";
            btnInsertarFinal.Size = new Size(115, 42);
            btnInsertarFinal.TabIndex = 19;
            btnInsertarFinal.Text = "Agregar ";
            btnInsertarFinal.UseVisualStyleBackColor = false;
            btnInsertarFinal.Click += btnInsertarFinal_Click;
            // 
            // btnInsertarAntesX
            // 
            btnInsertarAntesX.BackColor = Color.FromArgb(14, 47, 86);
            btnInsertarAntesX.FlatStyle = FlatStyle.Flat;
            btnInsertarAntesX.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsertarAntesX.ForeColor = Color.White;
            btnInsertarAntesX.Location = new Point(28, 22);
            btnInsertarAntesX.Name = "btnInsertarAntesX";
            btnInsertarAntesX.Size = new Size(115, 42);
            btnInsertarAntesX.TabIndex = 18;
            btnInsertarAntesX.Text = "Agregar ";
            btnInsertarAntesX.UseVisualStyleBackColor = false;
            btnInsertarAntesX.Click += btnInsertarAntesX_Click;
            // 
            // btnInsertarInicio
            // 
            btnInsertarInicio.BackColor = Color.FromArgb(14, 47, 86);
            btnInsertarInicio.FlatStyle = FlatStyle.Flat;
            btnInsertarInicio.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsertarInicio.ForeColor = Color.White;
            btnInsertarInicio.Location = new Point(28, 22);
            btnInsertarInicio.Name = "btnInsertarInicio";
            btnInsertarInicio.Size = new Size(115, 42);
            btnInsertarInicio.TabIndex = 14;
            btnInsertarInicio.Text = "Agregar ";
            btnInsertarInicio.UseVisualStyleBackColor = false;
            btnInsertarInicio.Click += btnInsertarInicio_Click;
            // 
            // tablepanel
            // 
            tablepanel.BackColor = Color.FromArgb(219, 219, 184);
            tablepanel.ColumnCount = 2;
            tablepanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tablepanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tablepanel.Controls.Add(pictureBox1, 0, 0);
            tablepanel.Controls.Add(label1, 1, 0);
            tablepanel.Location = new Point(0, 31);
            tablepanel.Name = "tablepanel";
            tablepanel.RowCount = 1;
            tablepanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tablepanel.Size = new Size(1197, 175);
            tablepanel.TabIndex = 45;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 19);
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
            label1.Location = new Point(242, 60);
            label1.Name = "label1";
            label1.Size = new Size(456, 54);
            label1.TabIndex = 1;
            label1.Text = "GESTION DE COMPRAS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelBuscar
            // 
            panelBuscar.Controls.Add(txtbuscar);
            panelBuscar.Controls.Add(label10);
            panelBuscar.Font = new Font("Candara", 13.8F, FontStyle.Bold);
            panelBuscar.Location = new Point(883, 212);
            panelBuscar.Name = "panelBuscar";
            panelBuscar.Size = new Size(301, 132);
            panelBuscar.TabIndex = 55;
            panelBuscar.TabStop = false;
            panelBuscar.Text = "Buscar";
            // 
            // txtbuscar
            // 
            txtbuscar.BorderStyle = BorderStyle.FixedSingle;
            txtbuscar.Location = new Point(6, 78);
            txtbuscar.Multiline = true;
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(173, 37);
            txtbuscar.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 44);
            label10.Name = "label10";
            label10.Size = new Size(83, 28);
            label10.TabIndex = 4;
            label10.Text = "Código";
            // 
            // pnlBtnInsertar
            // 
            pnlBtnInsertar.Controls.Add(btnInsertarAntesX);
            pnlBtnInsertar.Controls.Add(btnInsertarFinal);
            pnlBtnInsertar.Controls.Add(btnInsertarDespuesX);
            pnlBtnInsertar.Controls.Add(btnInsertarInicio);
            pnlBtnInsertar.Location = new Point(0, 350);
            pnlBtnInsertar.Name = "pnlBtnInsertar";
            pnlBtnInsertar.Size = new Size(153, 84);
            pnlBtnInsertar.TabIndex = 56;
            // 
            // btnEliminarDespuesX
            // 
            btnEliminarDespuesX.BackColor = Color.DarkRed;
            btnEliminarDespuesX.FlatStyle = FlatStyle.Flat;
            btnEliminarDespuesX.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarDespuesX.ForeColor = Color.White;
            btnEliminarDespuesX.Location = new Point(18, 20);
            btnEliminarDespuesX.Name = "btnEliminarDespuesX";
            btnEliminarDespuesX.Size = new Size(115, 42);
            btnEliminarDespuesX.TabIndex = 57;
            btnEliminarDespuesX.Text = "Eliminar";
            btnEliminarDespuesX.UseVisualStyleBackColor = false;
            btnEliminarDespuesX.Click += btnEliminarDespuesX_Click;
            // 
            // btnEliminarAntesX
            // 
            btnEliminarAntesX.BackColor = Color.DarkRed;
            btnEliminarAntesX.FlatStyle = FlatStyle.Flat;
            btnEliminarAntesX.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarAntesX.ForeColor = Color.White;
            btnEliminarAntesX.Location = new Point(18, 20);
            btnEliminarAntesX.Name = "btnEliminarAntesX";
            btnEliminarAntesX.Size = new Size(115, 42);
            btnEliminarAntesX.TabIndex = 58;
            btnEliminarAntesX.Text = "Eliminar";
            btnEliminarAntesX.UseVisualStyleBackColor = false;
            btnEliminarAntesX.Click += btnEliminarAntesX_Click;
            // 
            // btnEliminarFinal
            // 
            btnEliminarFinal.BackColor = Color.DarkRed;
            btnEliminarFinal.FlatStyle = FlatStyle.Flat;
            btnEliminarFinal.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarFinal.ForeColor = Color.White;
            btnEliminarFinal.Location = new Point(18, 20);
            btnEliminarFinal.Name = "btnEliminarFinal";
            btnEliminarFinal.Size = new Size(115, 42);
            btnEliminarFinal.TabIndex = 60;
            btnEliminarFinal.Text = "Eliminar";
            btnEliminarFinal.UseVisualStyleBackColor = false;
            btnEliminarFinal.Click += btnEliminarFinal_Click;
            // 
            // btnEliminarInicio
            // 
            btnEliminarInicio.BackColor = Color.DarkRed;
            btnEliminarInicio.FlatStyle = FlatStyle.Flat;
            btnEliminarInicio.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarInicio.ForeColor = Color.White;
            btnEliminarInicio.Location = new Point(18, 20);
            btnEliminarInicio.Name = "btnEliminarInicio";
            btnEliminarInicio.Size = new Size(115, 42);
            btnEliminarInicio.TabIndex = 59;
            btnEliminarInicio.Text = "Eliminar";
            btnEliminarInicio.UseVisualStyleBackColor = false;
            btnEliminarInicio.Click += btnEliminarInicio_Click;
            // 
            // pnlEliminar
            // 
            pnlEliminar.Controls.Add(btnEliminarInicio);
            pnlEliminar.Controls.Add(btnEliminarDespuesX);
            pnlEliminar.Controls.Add(btnEliminarX);
            pnlEliminar.Controls.Add(btnEliminarFinal);
            pnlEliminar.Controls.Add(btnEliminarAntesX);
            pnlEliminar.Location = new Point(159, 350);
            pnlEliminar.Name = "pnlEliminar";
            pnlEliminar.Size = new Size(148, 84);
            pnlEliminar.TabIndex = 61;
            // 
            // btnEliminarX
            // 
            btnEliminarX.BackColor = Color.DarkRed;
            btnEliminarX.FlatStyle = FlatStyle.Flat;
            btnEliminarX.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarX.ForeColor = Color.White;
            btnEliminarX.Location = new Point(18, 20);
            btnEliminarX.Name = "btnEliminarX";
            btnEliminarX.Size = new Size(115, 42);
            btnEliminarX.TabIndex = 61;
            btnEliminarX.Text = "Eliminar";
            btnEliminarX.UseVisualStyleBackColor = false;
            btnEliminarX.Click += btnEliminarX_Click;
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.Controls.Add(btnbusquedaRecursiva);
            pnlBusqueda.Controls.Add(btnbusquedaDesordenada);
            pnlBusqueda.Controls.Add(btnbusquedaOrdenada);
            pnlBusqueda.Location = new Point(313, 353);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(149, 81);
            pnlBusqueda.TabIndex = 62;
            // 
            // btnbusquedaRecursiva
            // 
            btnbusquedaRecursiva.BackColor = Color.DimGray;
            btnbusquedaRecursiva.FlatStyle = FlatStyle.Flat;
            btnbusquedaRecursiva.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnbusquedaRecursiva.ForeColor = Color.White;
            btnbusquedaRecursiva.Location = new Point(17, 17);
            btnbusquedaRecursiva.Name = "btnbusquedaRecursiva";
            btnbusquedaRecursiva.Size = new Size(115, 42);
            btnbusquedaRecursiva.TabIndex = 17;
            btnbusquedaRecursiva.Text = "Buscar";
            btnbusquedaRecursiva.UseVisualStyleBackColor = false;
            // 
            // btnbusquedaDesordenada
            // 
            btnbusquedaDesordenada.BackColor = Color.DimGray;
            btnbusquedaDesordenada.FlatStyle = FlatStyle.Flat;
            btnbusquedaDesordenada.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnbusquedaDesordenada.ForeColor = Color.White;
            btnbusquedaDesordenada.Location = new Point(17, 17);
            btnbusquedaDesordenada.Name = "btnbusquedaDesordenada";
            btnbusquedaDesordenada.Size = new Size(115, 42);
            btnbusquedaDesordenada.TabIndex = 16;
            btnbusquedaDesordenada.Text = "Buscar";
            btnbusquedaDesordenada.UseVisualStyleBackColor = false;
            btnbusquedaDesordenada.Click += btnbusquedaDesordenada_Click;
            // 
            // btnbusquedaOrdenada
            // 
            btnbusquedaOrdenada.BackColor = Color.DimGray;
            btnbusquedaOrdenada.FlatStyle = FlatStyle.Flat;
            btnbusquedaOrdenada.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnbusquedaOrdenada.ForeColor = Color.White;
            btnbusquedaOrdenada.Location = new Point(17, 17);
            btnbusquedaOrdenada.Name = "btnbusquedaOrdenada";
            btnbusquedaOrdenada.Size = new Size(115, 42);
            btnbusquedaOrdenada.TabIndex = 15;
            btnbusquedaOrdenada.Text = "Buscar";
            btnbusquedaOrdenada.UseVisualStyleBackColor = false;
            btnbusquedaOrdenada.Click += btnbusquedaOrdenada_Click;
            // 
            // pnlRecorrido
            // 
            pnlRecorrido.Controls.Add(btnRecorrerR);
            pnlRecorrido.Controls.Add(btnRecorrerI);
            pnlRecorrido.Location = new Point(468, 353);
            pnlRecorrido.Name = "pnlRecorrido";
            pnlRecorrido.Size = new Size(152, 81);
            pnlRecorrido.TabIndex = 63;
            // 
            // btnRecorrerR
            // 
            btnRecorrerR.BackColor = Color.DimGray;
            btnRecorrerR.FlatStyle = FlatStyle.Flat;
            btnRecorrerR.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRecorrerR.ForeColor = Color.White;
            btnRecorrerR.Location = new Point(20, 19);
            btnRecorrerR.Name = "btnRecorrerR";
            btnRecorrerR.Size = new Size(115, 42);
            btnRecorrerR.TabIndex = 17;
            btnRecorrerR.Text = "Recorrer";
            btnRecorrerR.UseVisualStyleBackColor = false;
            btnRecorrerR.Click += btnRecorrerR_Click;
            // 
            // btnRecorrerI
            // 
            btnRecorrerI.BackColor = Color.DimGray;
            btnRecorrerI.FlatStyle = FlatStyle.Flat;
            btnRecorrerI.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRecorrerI.ForeColor = Color.White;
            btnRecorrerI.Location = new Point(20, 19);
            btnRecorrerI.Name = "btnRecorrerI";
            btnRecorrerI.Size = new Size(115, 42);
            btnRecorrerI.TabIndex = 16;
            btnRecorrerI.Text = "Recorrer";
            btnRecorrerI.UseVisualStyleBackColor = false;
            btnRecorrerI.Click += btnRecorrerI_Click;
            // 
            // FormListas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1196, 701);
            Controls.Add(pnlRecorrido);
            Controls.Add(pnlBusqueda);
            Controls.Add(pnlEliminar);
            Controls.Add(pnlBtnInsertar);
            Controls.Add(panelBuscar);
            Controls.Add(label9);
            Controls.Add(txttotallista);
            Controls.Add(lblTotal);
            Controls.Add(btnsalir);
            Controls.Add(dtglistas);
            Controls.Add(panelData);
            Controls.Add(tablepanel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(1214, 748);
            MinimumSize = new Size(1214, 748);
            Name = "FormListas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormListas";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnsalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtglistas).EndInit();
            panelData.ResumeLayout(false);
            panelData.PerformLayout();
            tablepanel.ResumeLayout(false);
            tablepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelBuscar.ResumeLayout(false);
            panelBuscar.PerformLayout();
            pnlBtnInsertar.ResumeLayout(false);
            pnlEliminar.ResumeLayout(false);
            pnlBusqueda.ResumeLayout(false);
            pnlRecorrido.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem insertarAlInicioToolStripMenuItem;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem finalToolStripMenuItem;
        private ToolStripMenuItem antesDeXToolStripMenuItem;
        private ToolStripMenuItem despuesDeXToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem eliminarinicioToolStripMenuItem1;
        private ToolStripMenuItem eliminarfinalToolStripMenuItem1;
        private ToolStripMenuItem eliminarXToolStripMenuItem1;
        private ToolStripMenuItem eliminardespuesDeXToolStripMenuItem1;
        private ToolStripMenuItem busquedaToolStripMenuItem;
        private ToolStripMenuItem ordenadaToolStripMenuItem;
        private ToolStripMenuItem desordenadaToolStripMenuItem;
        private ToolStripMenuItem recursivaToolStripMenuItem;
        private ToolStripMenuItem recorridosToolStripMenuItem;
        private ToolStripMenuItem iterativoToolStripMenuItem;
        private ToolStripMenuItem recursivoToolStripMenuItem;
        private Label label9;
        private TextBox txttotallista;
        private Label lblTotal;
        private PictureBox btnsalir;
        private DataGridView dtglistas;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private GroupBox panelData;
        private ComboBox cmbproductolista;
        private Button btnInsertarInicio;
        private TextBox txtcantidadlista;
        private TextBox txtpreciolista;
        private TextBox txtcodigolista;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TableLayoutPanel tablepanel;
        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox panelBuscar;
        private Label label10;
        private TextBox txtbuscar;
        private Button btnInsertarDespuesX;
        private Button btnInsertarFinal;
        private Button btnInsertarAntesX;
        private Panel pnlBtnInsertar;
        private DataGridViewTextBoxColumn Subtotal;
        private Button btnEliminarDespuesX;
        private Button btnEliminarAntesX;
        private Button btnEliminarFinal;
        private Button btnEliminarInicio;
        private Panel pnlEliminar;
        private Button btnEliminarX;
        private ToolStripMenuItem despuesDeXToolStripMenuItem1;
        private Panel pnlBusqueda;
        private Button btnbusquedaRecursiva;
        private Button btnbusquedaDesordenada;
        private Button btnbusquedaOrdenada;
        private Panel pnlRecorrido;
        private Button btnRecorrerI;
        private Button btnRecorrerR;
    }
}