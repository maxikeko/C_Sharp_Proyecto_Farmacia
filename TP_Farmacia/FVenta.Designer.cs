namespace TP_Farmacia
{
    partial class FVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cb_clientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_stock = new System.Windows.Forms.DataGridView();
            this.btn_agregarCarrito = new System.Windows.Forms.Button();
            this.btn_terminarVenta = new System.Windows.Forms.Button();
            this.btn_ComprobarCliente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.cb_stock = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.dgv_BolsaCompras = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioXunidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lab_total = new System.Windows.Forms.Label();
            this.btn_PagarDeuda = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Denominacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVenc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagenes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Baja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Receta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BolsaCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_clientes
            // 
            this.cb_clientes.DisplayMember = "Consumidor Final";
            this.cb_clientes.FormattingEnabled = true;
            this.cb_clientes.Items.AddRange(new object[] {
            "Consumidor Final"});
            this.cb_clientes.Location = new System.Drawing.Point(62, 2);
            this.cb_clientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_clientes.Name = "cb_clientes";
            this.cb_clientes.Size = new System.Drawing.Size(328, 21);
            this.cb_clientes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente";
            // 
            // dgv_stock
            // 
            this.dgv_stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv_stock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Marca,
            this.Denominacion,
            this.Dosis,
            this.FechaVenc,
            this.Unidades,
            this.Imagenes,
            this.Precio,
            this.NroLote,
            this.Baja,
            this.Receta});
            this.dgv_stock.Location = new System.Drawing.Point(9, 80);
            this.dgv_stock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_stock.MultiSelect = false;
            this.dgv_stock.Name = "dgv_stock";
            this.dgv_stock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_stock.RowHeadersVisible = false;
            this.dgv_stock.RowHeadersWidth = 51;
            this.dgv_stock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_stock.RowTemplate.Height = 24;
            this.dgv_stock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_stock.Size = new System.Drawing.Size(786, 193);
            this.dgv_stock.TabIndex = 3;
            // 
            // btn_agregarCarrito
            // 
            this.btn_agregarCarrito.Location = new System.Drawing.Point(268, 292);
            this.btn_agregarCarrito.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_agregarCarrito.Name = "btn_agregarCarrito";
            this.btn_agregarCarrito.Size = new System.Drawing.Size(110, 37);
            this.btn_agregarCarrito.TabIndex = 4;
            this.btn_agregarCarrito.Text = "Agregar al carrito de compras";
            this.btn_agregarCarrito.UseVisualStyleBackColor = true;
            this.btn_agregarCarrito.Click += new System.EventHandler(this.btn_agregarCarrito_Click);
            // 
            // btn_terminarVenta
            // 
            this.btn_terminarVenta.Enabled = false;
            this.btn_terminarVenta.Location = new System.Drawing.Point(685, 561);
            this.btn_terminarVenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_terminarVenta.Name = "btn_terminarVenta";
            this.btn_terminarVenta.Size = new System.Drawing.Size(110, 37);
            this.btn_terminarVenta.TabIndex = 6;
            this.btn_terminarVenta.Text = "Terminar Venta";
            this.btn_terminarVenta.UseVisualStyleBackColor = true;
            this.btn_terminarVenta.Click += new System.EventHandler(this.btn_terminarVenta_Click);
            // 
            // btn_ComprobarCliente
            // 
            this.btn_ComprobarCliente.Location = new System.Drawing.Point(268, 561);
            this.btn_ComprobarCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ComprobarCliente.Name = "btn_ComprobarCliente";
            this.btn_ComprobarCliente.Size = new System.Drawing.Size(110, 37);
            this.btn_ComprobarCliente.TabIndex = 7;
            this.btn_ComprobarCliente.Text = "Comprobar cliente";
            this.btn_ComprobarCliente.UseVisualStyleBackColor = true;
            this.btn_ComprobarCliente.Click += new System.EventHandler(this.btn_ComprobarCliente_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cb_clientes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 26);
            this.panel1.TabIndex = 8;
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Location = new System.Drawing.Point(78, 56);
            this.txt_busqueda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(114, 20);
            this.txt_busqueda.TabIndex = 9;
            // 
            // cb_stock
            // 
            this.cb_stock.FormattingEnabled = true;
            this.cb_stock.Items.AddRange(new object[] {
            "Marca",
            "Denominacion",
            "Ambas"});
            this.cb_stock.Location = new System.Drawing.Point(196, 56);
            this.cb_stock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_stock.Name = "cb_stock";
            this.cb_stock.Size = new System.Drawing.Size(143, 21);
            this.cb_stock.TabIndex = 10;
            this.cb_stock.SelectedIndexChanged += new System.EventHandler(this.cb_stock_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Busqueda";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(342, 55);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(56, 19);
            this.btn_buscar.TabIndex = 12;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // dgv_BolsaCompras
            // 
            this.dgv_BolsaCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv_BolsaCompras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_BolsaCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BolsaCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.PrecioXunidad});
            this.dgv_BolsaCompras.Location = new System.Drawing.Point(9, 344);
            this.dgv_BolsaCompras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_BolsaCompras.MultiSelect = false;
            this.dgv_BolsaCompras.Name = "dgv_BolsaCompras";
            this.dgv_BolsaCompras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_BolsaCompras.RowHeadersVisible = false;
            this.dgv_BolsaCompras.RowHeadersWidth = 51;
            this.dgv_BolsaCompras.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_BolsaCompras.RowTemplate.Height = 24;
            this.dgv_BolsaCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_BolsaCompras.Size = new System.Drawing.Size(786, 193);
            this.dgv_BolsaCompras.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 43;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 62;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Denominacion";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Dosis";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 58;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "FechaVenc";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 87;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Unidades";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 77;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Imagenes";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 78;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn8.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 62;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "NroLote";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 70;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Baja";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 53;
            // 
            // PrecioXunidad
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.PrecioXunidad.DefaultCellStyle = dataGridViewCellStyle6;
            this.PrecioXunidad.HeaderText = "PrecioXunidad";
            this.PrecioXunidad.Name = "PrecioXunidad";
            this.PrecioXunidad.Width = 101;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 329);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Carrito de Compras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 562);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "TOTAL: $";
            // 
            // lab_total
            // 
            this.lab_total.AutoSize = true;
            this.lab_total.Location = new System.Drawing.Point(76, 561);
            this.lab_total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_total.Name = "lab_total";
            this.lab_total.Size = new System.Drawing.Size(0, 13);
            this.lab_total.TabIndex = 16;
            // 
            // btn_PagarDeuda
            // 
            this.btn_PagarDeuda.Location = new System.Drawing.Point(391, 562);
            this.btn_PagarDeuda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_PagarDeuda.Name = "btn_PagarDeuda";
            this.btn_PagarDeuda.Size = new System.Drawing.Size(110, 37);
            this.btn_PagarDeuda.TabIndex = 17;
            this.btn_PagarDeuda.Text = "Pagar Deuda";
            this.btn_PagarDeuda.UseVisualStyleBackColor = true;
            this.btn_PagarDeuda.Click += new System.EventHandler(this.btn_PagarDeuda_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 43;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 6;
            this.Marca.Name = "Marca";
            this.Marca.Width = 62;
            // 
            // Denominacion
            // 
            this.Denominacion.HeaderText = "Denominacion";
            this.Denominacion.MinimumWidth = 6;
            this.Denominacion.Name = "Denominacion";
            // 
            // Dosis
            // 
            this.Dosis.HeaderText = "Dosis";
            this.Dosis.MinimumWidth = 6;
            this.Dosis.Name = "Dosis";
            this.Dosis.Width = 58;
            // 
            // FechaVenc
            // 
            this.FechaVenc.HeaderText = "FechaVenc";
            this.FechaVenc.MinimumWidth = 6;
            this.FechaVenc.Name = "FechaVenc";
            this.FechaVenc.Width = 87;
            // 
            // Unidades
            // 
            this.Unidades.HeaderText = "Unidades";
            this.Unidades.MinimumWidth = 6;
            this.Unidades.Name = "Unidades";
            this.Unidades.Width = 77;
            // 
            // Imagenes
            // 
            this.Imagenes.HeaderText = "Imagenes";
            this.Imagenes.MinimumWidth = 6;
            this.Imagenes.Name = "Imagenes";
            this.Imagenes.Width = 78;
            // 
            // Precio
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle4;
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 62;
            // 
            // NroLote
            // 
            this.NroLote.HeaderText = "NroLote";
            this.NroLote.MinimumWidth = 6;
            this.NroLote.Name = "NroLote";
            this.NroLote.Width = 70;
            // 
            // Baja
            // 
            this.Baja.HeaderText = "Baja";
            this.Baja.MinimumWidth = 6;
            this.Baja.Name = "Baja";
            this.Baja.Width = 53;
            // 
            // Receta
            // 
            this.Receta.HeaderText = "Receta";
            this.Receta.Name = "Receta";
            this.Receta.Width = 67;
            // 
            // FVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 609);
            this.Controls.Add(this.btn_PagarDeuda);
            this.Controls.Add(this.lab_total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_BolsaCompras);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_stock);
            this.Controls.Add(this.txt_busqueda);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_ComprobarCliente);
            this.Controls.Add(this.btn_terminarVenta);
            this.Controls.Add(this.btn_agregarCarrito);
            this.Controls.Add(this.dgv_stock);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FVenta";
            this.Text = "FVenta";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BolsaCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_clientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_stock;
        private System.Windows.Forms.Button btn_agregarCarrito;
        private System.Windows.Forms.Button btn_terminarVenta;
        private System.Windows.Forms.Button btn_ComprobarCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.ComboBox cb_stock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridView dgv_BolsaCompras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lab_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioXunidad;
        private System.Windows.Forms.Button btn_PagarDeuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Denominacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVenc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imagenes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Baja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Receta;
    }
}