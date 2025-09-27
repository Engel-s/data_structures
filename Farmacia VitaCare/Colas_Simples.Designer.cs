namespace Farmacia_VitaCare
{
    partial class Colas_Simples
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Colas_Simples));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label9 = new Label();
            txttotalcola = new TextBox();
            label8 = new Label();
            btnsalir = new PictureBox();
            dtgcomprascola = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            btnokcola = new Button();
            txtsizecola = new TextBox();
            label6 = new Label();
            panelData = new GroupBox();
            btneliminarcola = new Button();
            cmbproductocola = new ComboBox();
            btnagregarcola = new Button();
            txtcantidadcola = new TextBox();
            txtpreciocola = new TextBox();
            txtcodigocola = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)btnsalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgcomprascola).BeginInit();
            panelData.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Candara", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(12, 678);
            label9.Name = "label9";
            label9.Size = new Size(223, 21);
            label9.TabIndex = 34;
            label9.Text = "Elaborado por: Engel Chavarria";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txttotalcola
            // 
            txttotalcola.BorderStyle = BorderStyle.FixedSingle;
            txttotalcola.Location = new Point(1038, 591);
            txttotalcola.Multiline = true;
            txttotalcola.Name = "txttotalcola";
            txttotalcola.ReadOnly = true;
            txttotalcola.Size = new Size(146, 37);
            txttotalcola.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Candara", 13.8F, FontStyle.Bold);
            label8.Location = new Point(1038, 560);
            label8.Name = "label8";
            label8.Size = new Size(61, 28);
            label8.TabIndex = 32;
            label8.Text = "Total";
            // 
            // btnsalir
            // 
            btnsalir.Image = (Image)resources.GetObject("btnsalir.Image");
            btnsalir.Location = new Point(1120, 652);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(64, 47);
            btnsalir.SizeMode = PictureBoxSizeMode.StretchImage;
            btnsalir.TabIndex = 31;
            btnsalir.TabStop = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // dtgcomprascola
            // 
            dtgcomprascola.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgcomprascola.BackgroundColor = Color.White;
            dtgcomprascola.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(14, 47, 86);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgcomprascola.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgcomprascola.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgcomprascola.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dtgcomprascola.GridColor = Color.FromArgb(17, 141, 240);
            dtgcomprascola.Location = new Point(6, 439);
            dtgcomprascola.Name = "dtgcomprascola";
            dtgcomprascola.RowHeadersWidth = 51;
            dtgcomprascola.Size = new Size(1017, 230);
            dtgcomprascola.TabIndex = 30;
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
            // btnokcola
            // 
            btnokcola.BackColor = Color.FromArgb(14, 47, 86);
            btnokcola.FlatStyle = FlatStyle.Flat;
            btnokcola.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnokcola.ForeColor = Color.White;
            btnokcola.Location = new Point(143, 206);
            btnokcola.Name = "btnokcola";
            btnokcola.Size = new Size(67, 42);
            btnokcola.TabIndex = 29;
            btnokcola.Text = "Ok";
            btnokcola.UseVisualStyleBackColor = false;
            btnokcola.Click += btnokcola_Click;
            // 
            // txtsizecola
            // 
            txtsizecola.BorderStyle = BorderStyle.FixedSingle;
            txtsizecola.Location = new Point(12, 211);
            txtsizecola.Multiline = true;
            txtsizecola.Name = "txtsizecola";
            txtsizecola.Size = new Size(115, 37);
            txtsizecola.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Candara", 13.8F, FontStyle.Bold);
            label6.Location = new Point(12, 179);
            label6.Name = "label6";
            label6.Size = new Size(186, 28);
            label6.TabIndex = 27;
            label6.Text = "Tipos de articulos";
            // 
            // panelData
            // 
            panelData.Controls.Add(btneliminarcola);
            panelData.Controls.Add(cmbproductocola);
            panelData.Controls.Add(btnagregarcola);
            panelData.Controls.Add(txtcantidadcola);
            panelData.Controls.Add(txtpreciocola);
            panelData.Controls.Add(txtcodigocola);
            panelData.Controls.Add(label7);
            panelData.Controls.Add(label5);
            panelData.Controls.Add(label4);
            panelData.Controls.Add(label3);
            panelData.Controls.Add(label2);
            panelData.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelData.ForeColor = Color.Black;
            panelData.Location = new Point(0, 263);
            panelData.Name = "panelData";
            panelData.Size = new Size(1196, 176);
            panelData.TabIndex = 26;
            panelData.TabStop = false;
            panelData.Text = "Ingresar datos";
            // 
            // btneliminarcola
            // 
            btneliminarcola.BackColor = Color.FromArgb(14, 47, 86);
            btneliminarcola.FlatStyle = FlatStyle.Flat;
            btneliminarcola.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btneliminarcola.ForeColor = Color.White;
            btneliminarcola.Location = new Point(1069, 128);
            btneliminarcola.Name = "btneliminarcola";
            btneliminarcola.Size = new Size(115, 42);
            btneliminarcola.TabIndex = 16;
            btneliminarcola.Text = "Eliminar";
            btneliminarcola.UseVisualStyleBackColor = false;
            btneliminarcola.Click += btneliminarcola_Click;
            // 
            // cmbproductocola
            // 
            cmbproductocola.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbproductocola.FormattingEnabled = true;
            cmbproductocola.Items.AddRange(new object[] { "Paracetamol", "Ibuprofeno", "Aspirina", "Omeprazol", "Suero oral", "Alcohol etílico", "Agua oxigenada ", "Gasas estériles", "Gel antibacterial", "Condones", "Pruebas de embarazo", "Termómetros digitales", "Jarabes para la tos", "Banditas adhesivas", "Antidiarreicos", "Colirios", "Algodón" });
            cmbproductocola.Location = new Point(242, 77);
            cmbproductocola.Name = "cmbproductocola";
            cmbproductocola.Size = new Size(262, 36);
            cmbproductocola.TabIndex = 15;
            // 
            // btnagregarcola
            // 
            btnagregarcola.BackColor = Color.FromArgb(14, 47, 86);
            btnagregarcola.FlatStyle = FlatStyle.Flat;
            btnagregarcola.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnagregarcola.ForeColor = Color.White;
            btnagregarcola.Location = new Point(12, 128);
            btnagregarcola.Name = "btnagregarcola";
            btnagregarcola.Size = new Size(115, 42);
            btnagregarcola.TabIndex = 14;
            btnagregarcola.Text = "Agregar";
            btnagregarcola.UseVisualStyleBackColor = false;
            btnagregarcola.Click += btnagregarcola_Click;
            // 
            // txtcantidadcola
            // 
            txtcantidadcola.BorderStyle = BorderStyle.FixedSingle;
            txtcantidadcola.Location = new Point(782, 75);
            txtcantidadcola.Multiline = true;
            txtcantidadcola.Name = "txtcantidadcola";
            txtcantidadcola.Size = new Size(173, 37);
            txtcantidadcola.TabIndex = 12;
            // 
            // txtpreciocola
            // 
            txtpreciocola.BorderStyle = BorderStyle.FixedSingle;
            txtpreciocola.Location = new Point(542, 76);
            txtpreciocola.Multiline = true;
            txtpreciocola.Name = "txtpreciocola";
            txtpreciocola.Size = new Size(173, 37);
            txtpreciocola.TabIndex = 11;
            // 
            // txtcodigocola
            // 
            txtcodigocola.BorderStyle = BorderStyle.FixedSingle;
            txtcodigocola.Location = new Point(12, 76);
            txtcodigocola.Multiline = true;
            txtcodigocola.Name = "txtcodigocola";
            txtcodigocola.Size = new Size(169, 37);
            txtcodigocola.TabIndex = 9;
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(219, 219, 184);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Location = new Point(0, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1197, 163);
            tableLayoutPanel1.TabIndex = 25;
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
            // Colas_Simples
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1196, 701);
            Controls.Add(label9);
            Controls.Add(txttotalcola);
            Controls.Add(label8);
            Controls.Add(btnsalir);
            Controls.Add(dtgcomprascola);
            Controls.Add(btnokcola);
            Controls.Add(txtsizecola);
            Controls.Add(label6);
            Controls.Add(panelData);
            Controls.Add(tableLayoutPanel1);
            MaximumSize = new Size(1214, 748);
            MinimumSize = new Size(1214, 748);
            Name = "Colas_Simples";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Colas_Simples";
            Load += Colas_Simples_Load;
            ((System.ComponentModel.ISupportInitialize)btnsalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgcomprascola).EndInit();
            panelData.ResumeLayout(false);
            panelData.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private TextBox txttotalcola;
        private Label label8;
        private PictureBox btnsalir;
        private DataGridView dtgcomprascola;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button btnokcola;
        private TextBox txtsizecola;
        private Label label6;
        private GroupBox panelData;
        private Button btneliminarcola;
        private ComboBox cmbproductocola;
        private Button btnagregarcola;
        private TextBox txtcantidadcola;
        private TextBox txtpreciocola;
        private TextBox txtcodigocola;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private Label label1;
    }
}