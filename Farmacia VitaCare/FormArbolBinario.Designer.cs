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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArbolBinario));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            pnlArbol = new Panel();
            groupBox5 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            btnsalir = new PictureBox();
            dtgcompras = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            txttotal = new TextBox();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtcantidad = new TextBox();
            txtprecio = new TextBox();
            cmbproducto = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            txtcodigo = new TextBox();
            groupBox1 = new GroupBox();
            btnok = new Button();
            txtsize = new TextBox();
            groupBox3 = new GroupBox();
            btneliminar = new Button();
            txteliminar = new TextBox();
            IstRecorridos = new ListBox();
            label4 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnsalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgcompras).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(67, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pnlArbol
            // 
            pnlArbol.Location = new Point(850, 297);
            pnlArbol.Name = "pnlArbol";
            pnlArbol.Size = new Size(718, 385);
            pnlArbol.TabIndex = 62;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(button1);
            groupBox5.Controls.Add(button2);
            groupBox5.Controls.Add(button3);
            groupBox5.Font = new Font("Candara", 13.8F, FontStyle.Bold);
            groupBox5.ForeColor = Color.Black;
            groupBox5.Location = new Point(651, 176);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(365, 116);
            groupBox5.TabIndex = 61;
            groupBox5.TabStop = false;
            groupBox5.Text = "Recorridos:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(219, 219, 184);
            button1.ForeColor = Color.FromArgb(14, 47, 86);
            button1.Location = new Point(240, 45);
            button1.Name = "button1";
            button1.Size = new Size(117, 36);
            button1.TabIndex = 40;
            button1.Text = "PreOrden";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(219, 219, 184);
            button2.ForeColor = Color.FromArgb(14, 47, 86);
            button2.Location = new Point(114, 45);
            button2.Name = "button2";
            button2.Size = new Size(120, 36);
            button2.TabIndex = 39;
            button2.Text = "PosOrden";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(219, 219, 184);
            button3.ForeColor = Color.FromArgb(14, 47, 86);
            button3.Location = new Point(6, 45);
            button3.Name = "button3";
            button3.Size = new Size(102, 36);
            button3.TabIndex = 38;
            button3.Text = "InOrden";
            button3.UseVisualStyleBackColor = false;
            // 
            // btnsalir
            // 
            btnsalir.Image = (Image)resources.GetObject("btnsalir.Image");
            btnsalir.Location = new Point(783, 637);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(61, 44);
            btnsalir.SizeMode = PictureBoxSizeMode.StretchImage;
            btnsalir.TabIndex = 60;
            btnsalir.TabStop = false;
            // 
            // dtgcompras
            // 
            dtgcompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgcompras.BackgroundColor = Color.White;
            dtgcompras.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(14, 47, 86);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtgcompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtgcompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgcompras.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dtgcompras.GridColor = Color.FromArgb(17, 141, 240);
            dtgcompras.Location = new Point(-7, 400);
            dtgcompras.Name = "dtgcompras";
            dtgcompras.RowHeadersWidth = 51;
            dtgcompras.Size = new Size(851, 231);
            dtgcompras.TabIndex = 59;
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
            // txttotal
            // 
            txttotal.Location = new Point(312, 655);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(135, 27);
            txttotal.TabIndex = 58;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(245, 654);
            label2.Name = "label2";
            label2.Size = new Size(61, 28);
            label2.TabIndex = 57;
            label2.Text = "Total";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(219, 219, 184);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Location = new Point(-7, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1587, 170);
            tableLayoutPanel1.TabIndex = 56;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(21, 71, 130);
            label1.Location = new Point(320, 58);
            label1.Name = "label1";
            label1.Size = new Size(456, 54);
            label1.TabIndex = 1;
            label1.Text = "GESTION DE COMPRAS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            groupBox2.Location = new Point(-4, 280);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(848, 114);
            groupBox2.TabIndex = 54;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ingresar datos";
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(692, 63);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(148, 36);
            txtcantidad.TabIndex = 45;
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(472, 63);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(167, 36);
            txtprecio.TabIndex = 44;
            // 
            // cmbproducto
            // 
            cmbproducto.FormattingEnabled = true;
            cmbproducto.Location = new Point(207, 63);
            cmbproducto.Name = "cmbproducto";
            cmbproducto.Size = new Size(225, 36);
            cmbproducto.TabIndex = 43;
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
            label7.Click += label7_Click;
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
            label3.Text = "Codigo:";
            // 
            // txtcodigo
            // 
            txtcodigo.Location = new Point(9, 63);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(161, 36);
            txtcodigo.TabIndex = 39;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnok);
            groupBox1.Controls.Add(txtsize);
            groupBox1.Font = new Font("Candara", 13.8F, FontStyle.Bold);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(12, 176);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(277, 98);
            groupBox1.TabIndex = 53;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipos de articulos";
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
            // txtsize
            // 
            txtsize.Location = new Point(18, 52);
            txtsize.Name = "txtsize";
            txtsize.Size = new Size(112, 36);
            txtsize.TabIndex = 39;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btneliminar);
            groupBox3.Controls.Add(txteliminar);
            groupBox3.Font = new Font("Candara", 13.8F, FontStyle.Bold);
            groupBox3.ForeColor = Color.Black;
            groupBox3.Location = new Point(1264, 176);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(295, 115);
            groupBox3.TabIndex = 55;
            groupBox3.TabStop = false;
            groupBox3.Text = "Eliminar";
            // 
            // btneliminar
            // 
            btneliminar.BackColor = Color.FromArgb(219, 219, 184);
            btneliminar.ForeColor = Color.FromArgb(14, 47, 86);
            btneliminar.Location = new Point(138, 34);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(102, 37);
            btneliminar.TabIndex = 38;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = false;
            // 
            // txteliminar
            // 
            txteliminar.Location = new Point(30, 35);
            txteliminar.Name = "txteliminar";
            txteliminar.Size = new Size(73, 36);
            txteliminar.TabIndex = 39;
            // 
            // IstRecorridos
            // 
            IstRecorridos.FormattingEnabled = true;
            IstRecorridos.Location = new Point(1033, 204);
            IstRecorridos.Name = "IstRecorridos";
            IstRecorridos.Size = new Size(225, 84);
            IstRecorridos.TabIndex = 63;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Candara", 13.8F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(1033, 176);
            label4.Name = "label4";
            label4.Size = new Size(121, 28);
            label4.TabIndex = 64;
            label4.Text = "Recorridos";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Candara", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(5, 660);
            label9.Name = "label9";
            label9.Size = new Size(223, 21);
            label9.TabIndex = 65;
            label9.Text = "Elaborado por: Engel Chavarria";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormArbolBinario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1576, 684);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(IstRecorridos);
            Controls.Add(pnlArbol);
            Controls.Add(groupBox5);
            Controls.Add(btnsalir);
            Controls.Add(dtgcompras);
            Controls.Add(txttotal);
            Controls.Add(label2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Name = "FormArbolBinario";
            Text = "FormArbolBinario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnsalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgcompras).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel pnlArbol;
        private GroupBox groupBox5;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox btnsalir;
        private DataGridView dtgcompras;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private TextBox txttotal;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtcantidad;
        private TextBox txtprecio;
        private ComboBox cmbproducto;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private TextBox txtcodigo;
        private GroupBox groupBox1;
        private Button btnok;
        private TextBox txtsize;
        private GroupBox groupBox3;
        private Button btneliminar;
        private TextBox txteliminar;
        private ListBox IstRecorridos;
        private Label label4;
        private Label label9;
    }
}