namespace Farmacia_VitaCare
{
    partial class FormColaCirulares
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormColaCirulares));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label9 = new Label();
            txttotalcircular = new TextBox();
            label8 = new Label();
            btnsalir = new PictureBox();
            dtgcomprascircular = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            btnokcircular = new Button();
            txtsizecircular = new TextBox();
            label6 = new Label();
            panelData = new GroupBox();
            btneliminarcircular = new Button();
            cmbproductocircular = new ComboBox();
            btnagregarcircular = new Button();
            txtcantidadcircular = new TextBox();
            txtpreciocircular = new TextBox();
            txtcodigocircular = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)btnsalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgcomprascircular).BeginInit();
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
            label9.TabIndex = 44;
            label9.Text = "Elaborado por: Engel Chavarria";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txttotalcircular
            // 
            txttotalcircular.BorderStyle = BorderStyle.FixedSingle;
            txttotalcircular.Location = new Point(1038, 591);
            txttotalcircular.Multiline = true;
            txttotalcircular.Name = "txttotalcircular";
            txttotalcircular.ReadOnly = true;
            txttotalcircular.Size = new Size(146, 37);
            txttotalcircular.TabIndex = 43;
            txttotalcircular.TextChanged += txttotalcola_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Candara", 13.8F, FontStyle.Bold);
            label8.Location = new Point(1038, 560);
            label8.Name = "label8";
            label8.Size = new Size(61, 28);
            label8.TabIndex = 42;
            label8.Text = "Total";
            // 
            // btnsalir
            // 
            btnsalir.Image = (Image)resources.GetObject("btnsalir.Image");
            btnsalir.Location = new Point(1120, 652);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(64, 47);
            btnsalir.SizeMode = PictureBoxSizeMode.StretchImage;
            btnsalir.TabIndex = 41;
            btnsalir.TabStop = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // dtgcomprascircular
            // 
            dtgcomprascircular.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgcomprascircular.BackgroundColor = Color.White;
            dtgcomprascircular.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(14, 47, 86);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgcomprascircular.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgcomprascircular.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgcomprascircular.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dtgcomprascircular.GridColor = Color.FromArgb(17, 141, 240);
            dtgcomprascircular.Location = new Point(6, 439);
            dtgcomprascircular.Name = "dtgcomprascircular";
            dtgcomprascircular.RowHeadersWidth = 51;
            dtgcomprascircular.Size = new Size(1017, 230);
            dtgcomprascircular.TabIndex = 40;
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
            // btnokcircular
            // 
            btnokcircular.BackColor = Color.FromArgb(14, 47, 86);
            btnokcircular.FlatStyle = FlatStyle.Flat;
            btnokcircular.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnokcircular.ForeColor = Color.White;
            btnokcircular.Location = new Point(143, 206);
            btnokcircular.Name = "btnokcircular";
            btnokcircular.Size = new Size(67, 42);
            btnokcircular.TabIndex = 39;
            btnokcircular.Text = "Ok";
            btnokcircular.UseVisualStyleBackColor = false;
            btnokcircular.Click += btnokcircular_Click;
            // 
            // txtsizecircular
            // 
            txtsizecircular.BorderStyle = BorderStyle.FixedSingle;
            txtsizecircular.Location = new Point(12, 211);
            txtsizecircular.Multiline = true;
            txtsizecircular.Name = "txtsizecircular";
            txtsizecircular.Size = new Size(115, 37);
            txtsizecircular.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Candara", 13.8F, FontStyle.Bold);
            label6.Location = new Point(12, 179);
            label6.Name = "label6";
            label6.Size = new Size(186, 28);
            label6.TabIndex = 37;
            label6.Text = "Tipos de artículos";
            // 
            // panelData
            // 
            panelData.Controls.Add(btneliminarcircular);
            panelData.Controls.Add(cmbproductocircular);
            panelData.Controls.Add(btnagregarcircular);
            panelData.Controls.Add(txtcantidadcircular);
            panelData.Controls.Add(txtpreciocircular);
            panelData.Controls.Add(txtcodigocircular);
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
            panelData.TabIndex = 36;
            panelData.TabStop = false;
            panelData.Text = "Ingresar datos";
            // 
            // btneliminarcircular
            // 
            btneliminarcircular.BackColor = Color.FromArgb(14, 47, 86);
            btneliminarcircular.FlatStyle = FlatStyle.Flat;
            btneliminarcircular.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btneliminarcircular.ForeColor = Color.White;
            btneliminarcircular.Location = new Point(1069, 128);
            btneliminarcircular.Name = "btneliminarcircular";
            btneliminarcircular.Size = new Size(115, 42);
            btneliminarcircular.TabIndex = 16;
            btneliminarcircular.Text = "Eliminar";
            btneliminarcircular.UseVisualStyleBackColor = false;
            btneliminarcircular.Click += btneliminarcircular_Click;
            // 
            // cmbproductocircular
            // 
            cmbproductocircular.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbproductocircular.FormattingEnabled = true;
            cmbproductocircular.Items.AddRange(new object[] { "Paracetamol", "Ibuprofeno", "Aspirina", "Omeprazol", "Suero oral", "Alcohol etílico", "Agua oxigenada ", "Gasas estériles", "Gel antibacterial", "Condones", "Pruebas de embarazo", "Termómetros digitales", "Jarabes para la tos", "Banditas adhesivas", "Antidiarreicos", "Colirios", "Algodón" });
            cmbproductocircular.Location = new Point(242, 77);
            cmbproductocircular.Name = "cmbproductocircular";
            cmbproductocircular.Size = new Size(262, 36);
            cmbproductocircular.TabIndex = 15;
            // 
            // btnagregarcircular
            // 
            btnagregarcircular.BackColor = Color.FromArgb(14, 47, 86);
            btnagregarcircular.FlatStyle = FlatStyle.Flat;
            btnagregarcircular.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnagregarcircular.ForeColor = Color.White;
            btnagregarcircular.Location = new Point(12, 128);
            btnagregarcircular.Name = "btnagregarcircular";
            btnagregarcircular.Size = new Size(115, 42);
            btnagregarcircular.TabIndex = 14;
            btnagregarcircular.Text = "Agregar";
            btnagregarcircular.UseVisualStyleBackColor = false;
            btnagregarcircular.Click += btnagregarcircular_Click;
            // 
            // txtcantidadcircular
            // 
            txtcantidadcircular.BorderStyle = BorderStyle.FixedSingle;
            txtcantidadcircular.Location = new Point(782, 75);
            txtcantidadcircular.Multiline = true;
            txtcantidadcircular.Name = "txtcantidadcircular";
            txtcantidadcircular.Size = new Size(173, 37);
            txtcantidadcircular.TabIndex = 12;
            // 
            // txtpreciocircular
            // 
            txtpreciocircular.BorderStyle = BorderStyle.FixedSingle;
            txtpreciocircular.Location = new Point(542, 76);
            txtpreciocircular.Multiline = true;
            txtpreciocircular.Name = "txtpreciocircular";
            txtpreciocircular.Size = new Size(173, 37);
            txtpreciocircular.TabIndex = 11;
            // 
            // txtcodigocircular
            // 
            txtcodigocircular.BorderStyle = BorderStyle.FixedSingle;
            txtcodigocircular.Location = new Point(12, 76);
            txtcodigocircular.Multiline = true;
            txtcodigocircular.Name = "txtcodigocircular";
            txtcodigocircular.Size = new Size(169, 37);
            txtcodigocircular.TabIndex = 9;
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
            tableLayoutPanel1.TabIndex = 35;
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
            label1.Text = "GESTIÓN DE COMPRAS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormColaCirulares
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1196, 701);
            Controls.Add(label9);
            Controls.Add(txttotalcircular);
            Controls.Add(label8);
            Controls.Add(btnsalir);
            Controls.Add(dtgcomprascircular);
            Controls.Add(btnokcircular);
            Controls.Add(txtsizecircular);
            Controls.Add(label6);
            Controls.Add(panelData);
            Controls.Add(tableLayoutPanel1);
            MaximumSize = new Size(1214, 748);
            MinimumSize = new Size(1214, 748);
            Name = "FormColaCirulares";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormColaCirulares";
            Load += FormColaCirulares_Load;
            ((System.ComponentModel.ISupportInitialize)btnsalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgcomprascircular).EndInit();
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
        private TextBox txttotalcircular;
        private Label label8;
        private PictureBox btnsalir;
        private DataGridView dtgcomprascircular;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button btnokcircular;
        private TextBox txtsizecircular;
        private Label label6;
        private GroupBox panelData;
        private Button btneliminarcircular;
        private ComboBox cmbproductocircular;
        private Button btnagregarcircular;
        private TextBox txtcantidadcircular;
        private TextBox txtpreciocircular;
        private TextBox txtcodigocircular;
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