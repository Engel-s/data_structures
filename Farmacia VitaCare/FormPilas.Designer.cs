namespace Farmacia_VitaCare
{
    partial class FormPilas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPilas));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panelData = new GroupBox();
            btneliminarpila = new Button();
            cmbproductopila = new ComboBox();
            btnagregarpila = new Button();
            txtcantidadpila = new TextBox();
            txtpreciopila = new TextBox();
            txtcodigopila = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtsizepila = new TextBox();
            label6 = new Label();
            btnok = new Button();
            dtgcompraspila = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            txttotalpila = new TextBox();
            label8 = new Label();
            btnsalir = new PictureBox();
            label9 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgcompraspila).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnsalir).BeginInit();
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
            tableLayoutPanel1.Location = new Point(0, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1197, 163);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
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
            // panelData
            // 
            panelData.Controls.Add(btneliminarpila);
            panelData.Controls.Add(cmbproductopila);
            panelData.Controls.Add(btnagregarpila);
            panelData.Controls.Add(txtcantidadpila);
            panelData.Controls.Add(txtpreciopila);
            panelData.Controls.Add(txtcodigopila);
            panelData.Controls.Add(label7);
            panelData.Controls.Add(label5);
            panelData.Controls.Add(label4);
            panelData.Controls.Add(label3);
            panelData.Controls.Add(label2);
            panelData.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelData.ForeColor = Color.Black;
            panelData.Location = new Point(0, 262);
            panelData.Name = "panelData";
            panelData.Size = new Size(1196, 176);
            panelData.TabIndex = 3;
            panelData.TabStop = false;
            panelData.Text = "Ingresar datos";
            // 
            // btneliminarpila
            // 
            btneliminarpila.BackColor = Color.FromArgb(14, 47, 86);
            btneliminarpila.FlatStyle = FlatStyle.Flat;
            btneliminarpila.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btneliminarpila.ForeColor = Color.White;
            btneliminarpila.Location = new Point(1069, 128);
            btneliminarpila.Name = "btneliminarpila";
            btneliminarpila.Size = new Size(115, 42);
            btneliminarpila.TabIndex = 16;
            btneliminarpila.Text = "Eliminar";
            btneliminarpila.UseVisualStyleBackColor = false;
            btneliminarpila.Click += btneliminarpila_Click;
            // 
            // cmbproductopila
            // 
            cmbproductopila.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbproductopila.FormattingEnabled = true;
            cmbproductopila.Items.AddRange(new object[] { "Paracetamol", "Ibuprofeno", "Aspirina", "Omeprazol", "Suero oral", "Alcohol etílico", "Agua oxigenada ", "Gasas estériles", "Gel antibacterial", "Condones", "Pruebas de embarazo", "Termómetros digitales", "Jarabes para la tos", "Banditas adhesivas", "Antidiarreicos", "Colirios", "Algodón" });
            cmbproductopila.Location = new Point(242, 77);
            cmbproductopila.Name = "cmbproductopila";
            cmbproductopila.Size = new Size(262, 36);
            cmbproductopila.TabIndex = 15;
            // 
            // btnagregarpila
            // 
            btnagregarpila.BackColor = Color.FromArgb(14, 47, 86);
            btnagregarpila.FlatStyle = FlatStyle.Flat;
            btnagregarpila.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnagregarpila.ForeColor = Color.White;
            btnagregarpila.Location = new Point(12, 128);
            btnagregarpila.Name = "btnagregarpila";
            btnagregarpila.Size = new Size(115, 42);
            btnagregarpila.TabIndex = 14;
            btnagregarpila.Text = "Agregar";
            btnagregarpila.UseVisualStyleBackColor = false;
            btnagregarpila.Click += btnagregarpila_Click;
            // 
            // txtcantidadpila
            // 
            txtcantidadpila.BorderStyle = BorderStyle.FixedSingle;
            txtcantidadpila.Location = new Point(782, 75);
            txtcantidadpila.Multiline = true;
            txtcantidadpila.Name = "txtcantidadpila";
            txtcantidadpila.Size = new Size(173, 37);
            txtcantidadpila.TabIndex = 12;
            // 
            // txtpreciopila
            // 
            txtpreciopila.BorderStyle = BorderStyle.FixedSingle;
            txtpreciopila.Location = new Point(542, 76);
            txtpreciopila.Multiline = true;
            txtpreciopila.Name = "txtpreciopila";
            txtpreciopila.Size = new Size(173, 37);
            txtpreciopila.TabIndex = 11;
            // 
            // txtcodigopila
            // 
            txtcodigopila.BorderStyle = BorderStyle.FixedSingle;
            txtcodigopila.Location = new Point(12, 76);
            txtcodigopila.Multiline = true;
            txtcodigopila.Name = "txtcodigopila";
            txtcodigopila.Size = new Size(169, 37);
            txtcodigopila.TabIndex = 9;
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
            label5.Location = new Point(782, 44);
            label5.Name = "label5";
            label5.Size = new Size(100, 28);
            label5.TabIndex = 6;
            label5.Text = "Cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(542, 44);
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
            // txtsizepila
            // 
            txtsizepila.BorderStyle = BorderStyle.FixedSingle;
            txtsizepila.Location = new Point(12, 210);
            txtsizepila.Multiline = true;
            txtsizepila.Name = "txtsizepila";
            txtsizepila.Size = new Size(115, 37);
            txtsizepila.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Candara", 13.8F, FontStyle.Bold);
            label6.Location = new Point(12, 178);
            label6.Name = "label6";
            label6.Size = new Size(186, 28);
            label6.TabIndex = 10;
            label6.Text = "Tipos de articulos";
            // 
            // btnok
            // 
            btnok.BackColor = Color.FromArgb(14, 47, 86);
            btnok.FlatStyle = FlatStyle.Flat;
            btnok.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnok.ForeColor = Color.White;
            btnok.Location = new Point(143, 205);
            btnok.Name = "btnok";
            btnok.Size = new Size(67, 42);
            btnok.TabIndex = 19;
            btnok.Text = "Ok";
            btnok.UseVisualStyleBackColor = false;
            btnok.Click += btnok_Click;
            // 
            // dtgcompraspila
            // 
            dtgcompraspila.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgcompraspila.BackgroundColor = Color.White;
            dtgcompraspila.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(14, 47, 86);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgcompraspila.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgcompraspila.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgcompraspila.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dtgcompraspila.GridColor = Color.FromArgb(17, 141, 240);
            dtgcompraspila.Location = new Point(6, 438);
            dtgcompraspila.Name = "dtgcompraspila";
            dtgcompraspila.RowHeadersWidth = 51;
            dtgcompraspila.Size = new Size(1017, 230);
            dtgcompraspila.TabIndex = 20;
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
            // txttotalpila
            // 
            txttotalpila.BorderStyle = BorderStyle.FixedSingle;
            txttotalpila.Location = new Point(1038, 590);
            txttotalpila.Multiline = true;
            txttotalpila.Name = "txttotalpila";
            txttotalpila.ReadOnly = true;
            txttotalpila.Size = new Size(146, 37);
            txttotalpila.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Candara", 13.8F, FontStyle.Bold);
            label8.Location = new Point(1038, 559);
            label8.Name = "label8";
            label8.Size = new Size(61, 28);
            label8.TabIndex = 22;
            label8.Text = "Total";
            // 
            // btnsalir
            // 
            btnsalir.Image = (Image)resources.GetObject("btnsalir.Image");
            btnsalir.Location = new Point(1120, 651);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(64, 47);
            btnsalir.SizeMode = PictureBoxSizeMode.StretchImage;
            btnsalir.TabIndex = 21;
            btnsalir.TabStop = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Candara", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(12, 677);
            label9.Name = "label9";
            label9.Size = new Size(223, 21);
            label9.TabIndex = 24;
            label9.Text = "Elaborado por: Engel Chavarria";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormPilas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1196, 701);
            Controls.Add(label9);
            Controls.Add(txttotalpila);
            Controls.Add(label8);
            Controls.Add(btnsalir);
            Controls.Add(dtgcompraspila);
            Controls.Add(btnok);
            Controls.Add(txtsizepila);
            Controls.Add(label6);
            Controls.Add(panelData);
            Controls.Add(tableLayoutPanel1);
            MaximumSize = new Size(1214, 748);
            MinimumSize = new Size(1214, 748);
            Name = "FormPilas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPilas";
            Load += FormPilas_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelData.ResumeLayout(false);
            panelData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgcompraspila).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnsalir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox panelData;
        private Button btneliminarpila;
        private ComboBox cmbproductopila;
        private Button btnagregarpila;
        private TextBox txtcantidadpila;
        private TextBox txtpreciopila;
        private TextBox txtcodigopila;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtsizepila;
        private Label label6;
        private Button btnok;
        private DataGridView dtgcompraspila;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private TextBox txttotalpila;
        private Label label8;
        private PictureBox btnsalir;
        private Label label9;
    }
}