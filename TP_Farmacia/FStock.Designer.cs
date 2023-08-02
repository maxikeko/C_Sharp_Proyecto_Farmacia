namespace TP_Farmacia
{
    partial class FStock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_stock = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Denominacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVenc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagenes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Baja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_asignarPrecio = new System.Windows.Forms.Button();
            this.nud_precio = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_baja = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_bajaNro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_precio)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_stock
            // 
            this.dgv_stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv_stock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NroLote,
            this.Marca,
            this.Denominacion,
            this.Dosis,
            this.FechaVenc,
            this.Unidades,
            this.Imagenes,
            this.Baja,
            this.Precio,
            this.Costo,
            this.Proveedor});
            this.dgv_stock.Location = new System.Drawing.Point(12, 82);
            this.dgv_stock.MultiSelect = false;
            this.dgv_stock.Name = "dgv_stock";
            this.dgv_stock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_stock.RowHeadersVisible = false;
            this.dgv_stock.RowHeadersWidth = 51;
            this.dgv_stock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_stock.RowTemplate.Height = 24;
            this.dgv_stock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_stock.Size = new System.Drawing.Size(1113, 246);
            this.dgv_stock.TabIndex = 2;
            this.dgv_stock.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_stock_CellDoubleClick);
            this.dgv_stock.SelectionChanged += new System.EventHandler(this.dgv_stock_SelectionChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 45;
            // 
            // NroLote
            // 
            this.NroLote.HeaderText = "NroLote";
            this.NroLote.MinimumWidth = 6;
            this.NroLote.Name = "NroLote";
            this.NroLote.Width = 80;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 6;
            this.Marca.Name = "Marca";
            this.Marca.Width = 70;
            // 
            // Denominacion
            // 
            this.Denominacion.HeaderText = "Denominacion";
            this.Denominacion.MinimumWidth = 6;
            this.Denominacion.Name = "Denominacion";
            this.Denominacion.Width = 119;
            // 
            // Dosis
            // 
            this.Dosis.HeaderText = "Dosis";
            this.Dosis.MinimumWidth = 6;
            this.Dosis.Name = "Dosis";
            this.Dosis.Width = 67;
            // 
            // FechaVenc
            // 
            this.FechaVenc.HeaderText = "FechaVenc";
            this.FechaVenc.MinimumWidth = 6;
            this.FechaVenc.Name = "FechaVenc";
            this.FechaVenc.Width = 101;
            // 
            // Unidades
            // 
            this.Unidades.HeaderText = "Unidades";
            this.Unidades.MinimumWidth = 6;
            this.Unidades.Name = "Unidades";
            this.Unidades.Width = 91;
            // 
            // Imagenes
            // 
            this.Imagenes.HeaderText = "Imagenes";
            this.Imagenes.MinimumWidth = 6;
            this.Imagenes.Name = "Imagenes";
            this.Imagenes.Width = 92;
            // 
            // Baja
            // 
            this.Baja.HeaderText = "Baja";
            this.Baja.MinimumWidth = 6;
            this.Baja.Name = "Baja";
            this.Baja.Width = 60;
            // 
            // Precio
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle2;
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 71;
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.MinimumWidth = 6;
            this.Costo.Name = "Costo";
            this.Costo.Width = 67;
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.Width = 96;
            // 
            // btn_asignarPrecio
            // 
            this.btn_asignarPrecio.Location = new System.Drawing.Point(795, 20);
            this.btn_asignarPrecio.Name = "btn_asignarPrecio";
            this.btn_asignarPrecio.Size = new System.Drawing.Size(89, 46);
            this.btn_asignarPrecio.TabIndex = 3;
            this.btn_asignarPrecio.Text = "Modificar Precio";
            this.btn_asignarPrecio.UseVisualStyleBackColor = true;
            this.btn_asignarPrecio.Click += new System.EventHandler(this.btn_asignarPrecio_Click);
            // 
            // nud_precio
            // 
            this.nud_precio.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nud_precio.Location = new System.Drawing.Point(669, 33);
            this.nud_precio.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nud_precio.Name = "nud_precio";
            this.nud_precio.Size = new System.Drawing.Size(120, 22);
            this.nud_precio.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_baja);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_bajaNro);
            this.groupBox1.Location = new System.Drawing.Point(131, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 64);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dar de baja";
            // 
            // btn_baja
            // 
            this.btn_baja.Location = new System.Drawing.Point(279, 21);
            this.btn_baja.Name = "btn_baja";
            this.btn_baja.Size = new System.Drawing.Size(75, 28);
            this.btn_baja.TabIndex = 1;
            this.btn_baja.Text = "Baja";
            this.btn_baja.UseVisualStyleBackColor = true;
            this.btn_baja.Click += new System.EventHandler(this.btn_baja_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero de Lote";
            // 
            // txt_bajaNro
            // 
            this.txt_bajaNro.Location = new System.Drawing.Point(148, 27);
            this.txt_bajaNro.Name = "txt_bajaNro";
            this.txt_bajaNro.Size = new System.Drawing.Size(100, 22);
            this.txt_bajaNro.TabIndex = 0;
            // 
            // FStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 340);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nud_precio);
            this.Controls.Add(this.btn_asignarPrecio);
            this.Controls.Add(this.dgv_stock);
            this.Name = "FStock";
            this.Text = "FStock";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_precio)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_stock;
        private System.Windows.Forms.Button btn_asignarPrecio;
        private System.Windows.Forms.NumericUpDown nud_precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Denominacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVenc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imagenes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Baja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_baja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_bajaNro;
    }
}