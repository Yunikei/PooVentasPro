namespace PooVentasPro
{
    partial class Form1
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
            Ccantidad = new Label();
            txtCan = new TextBox();
            RdContado = new RadioButton();
            RdCredito = new RadioButton();
            Pprecio = new Label();
            txtPre = new TextBox();
            DgvArticulos = new DataGridView();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Contado = new DataGridViewTextBoxColumn();
            Crédito = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtTotContado = new TextBox();
            txtTotCredito = new TextBox();
            label2 = new Label();
            txtTotalNeto = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DgvArticulos).BeginInit();
            SuspendLayout();
            // 
            // Ccantidad
            // 
            Ccantidad.AutoSize = true;
            Ccantidad.Location = new Point(97, 59);
            Ccantidad.Name = "Ccantidad";
            Ccantidad.Size = new Size(58, 15);
            Ccantidad.TabIndex = 0;
            Ccantidad.Text = "Cantidad:";
            // 
            // txtCan
            // 
            txtCan.BackColor = SystemColors.ScrollBar;
            txtCan.Location = new Point(172, 56);
            txtCan.Name = "txtCan";
            txtCan.Size = new Size(100, 23);
            txtCan.TabIndex = 2;
            // 
            // RdContado
            // 
            RdContado.AutoSize = true;
            RdContado.Location = new Point(97, 112);
            RdContado.Name = "RdContado";
            RdContado.Size = new Size(71, 19);
            RdContado.TabIndex = 2;
            RdContado.TabStop = true;
            RdContado.Text = "Contado";
            RdContado.UseVisualStyleBackColor = true;
            RdContado.Click += RdContado_Click;
            RdContado.KeyDown += RdContado_KeyDown;
            // 
            // RdCredito
            // 
            RdCredito.AutoSize = true;
            RdCredito.Location = new Point(287, 112);
            RdCredito.Name = "RdCredito";
            RdCredito.Size = new Size(64, 19);
            RdCredito.TabIndex = 3;
            RdCredito.TabStop = true;
            RdCredito.Text = "Crédito";
            RdCredito.UseVisualStyleBackColor = true;
            RdCredito.Click += RdCredito_Click;
            // 
            // Pprecio
            // 
            Pprecio.AutoSize = true;
            Pprecio.Location = new Point(97, 28);
            Pprecio.Name = "Pprecio";
            Pprecio.Size = new Size(43, 15);
            Pprecio.TabIndex = 4;
            Pprecio.Text = "Precio:";
            // 
            // txtPre
            // 
            txtPre.BackColor = SystemColors.ScrollBar;
            txtPre.Location = new Point(172, 28);
            txtPre.Name = "txtPre";
            txtPre.Size = new Size(100, 23);
            txtPre.TabIndex = 1;
            // 
            // DgvArticulos
            // 
            DgvArticulos.BackgroundColor = SystemColors.HotTrack;
            DgvArticulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvArticulos.Columns.AddRange(new DataGridViewColumn[] { Precio, Cantidad, Contado, Crédito });
            DgvArticulos.Location = new Point(12, 157);
            DgvArticulos.Name = "DgvArticulos";
            DgvArticulos.Size = new Size(443, 190);
            DgvArticulos.TabIndex = 6;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // Contado
            // 
            Contado.HeaderText = "Contado";
            Contado.Name = "Contado";
            // 
            // Crédito
            // 
            Crédito.HeaderText = "Crédito";
            Crédito.Name = "Crédito";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(187, 360);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 7;
            label1.Text = "Totales: ";
            // 
            // txtTotContado
            // 
            txtTotContado.BackColor = SystemColors.InactiveCaption;
            txtTotContado.Location = new Point(251, 352);
            txtTotContado.Name = "txtTotContado";
            txtTotContado.Size = new Size(100, 23);
            txtTotContado.TabIndex = 8;
            // 
            // txtTotCredito
            // 
            txtTotCredito.BackColor = SystemColors.InactiveCaption;
            txtTotCredito.Location = new Point(352, 352);
            txtTotCredito.Name = "txtTotCredito";
            txtTotCredito.Size = new Size(100, 23);
            txtTotCredito.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(187, 385);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 10;
            label2.Text = "TotalNeto:";
            // 
            // txtTotalNeto
            // 
            txtTotalNeto.BackColor = SystemColors.ScrollBar;
            txtTotalNeto.Location = new Point(287, 382);
            txtTotalNeto.Name = "txtTotalNeto";
            txtTotalNeto.Size = new Size(142, 23);
            txtTotalNeto.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 465);
            Controls.Add(txtTotalNeto);
            Controls.Add(label2);
            Controls.Add(txtTotCredito);
            Controls.Add(txtTotContado);
            Controls.Add(label1);
            Controls.Add(DgvArticulos);
            Controls.Add(txtPre);
            Controls.Add(Pprecio);
            Controls.Add(RdCredito);
            Controls.Add(RdContado);
            Controls.Add(txtCan);
            Controls.Add(Ccantidad);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DgvArticulos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Ccantidad;
        private TextBox txtCan;
        private RadioButton RdContado;
        private RadioButton RdCredito;
        private Label Pprecio;
        private TextBox txtPre;
        private DataGridView DgvArticulos;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Contado;
        private DataGridViewTextBoxColumn Crédito;
        private Label label1;
        private TextBox txtTotContado;
        private TextBox txtTotCredito;
        private Label label2;
        private TextBox txtTotalNeto;
    }
}
