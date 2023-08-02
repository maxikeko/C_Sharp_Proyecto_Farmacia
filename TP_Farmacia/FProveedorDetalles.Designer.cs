namespace TP_Farmacia
{
    partial class FProveedorDetalles
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
            this.dgv_proveedoresDetalles = new System.Windows.Forms.DataGridView();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Denominacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVenc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagenes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proveedoresDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_proveedoresDetalles
            // 
            this.dgv_proveedoresDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv_proveedoresDetalles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_proveedoresDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_proveedoresDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Marca,
            this.Denominacion,
            this.Dosis,
            this.FechaVenc,
            this.Costo,
            this.Unidades,
            this.NroLote,
            this.Imagenes,
            this.Proveedor});
            this.dgv_proveedoresDetalles.Location = new System.Drawing.Point(-1, 21);
            this.dgv_proveedoresDetalles.MultiSelect = false;
            this.dgv_proveedoresDetalles.Name = "dgv_proveedoresDetalles";
            this.dgv_proveedoresDetalles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_proveedoresDetalles.RowHeadersVisible = false;
            this.dgv_proveedoresDetalles.RowHeadersWidth = 51;
            this.dgv_proveedoresDetalles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_proveedoresDetalles.RowTemplate.Height = 24;
            this.dgv_proveedoresDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_proveedoresDetalles.Size = new System.Drawing.Size(901, 275);
            this.dgv_proveedoresDetalles.TabIndex = 1;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 6;
            this.Marca.Name = "Marca";
            this.Marca.Width = 74;
            // 
            // Denominacion
            // 
            this.Denominacion.HeaderText = "Denominacion";
            this.Denominacion.MinimumWidth = 6;
            this.Denominacion.Name = "Denominacion";
            this.Denominacion.Width = 123;
            // 
            // Dosis
            // 
            this.Dosis.HeaderText = "Dosis";
            this.Dosis.MinimumWidth = 6;
            this.Dosis.Name = "Dosis";
            this.Dosis.Width = 71;
            // 
            // FechaVenc
            // 
            this.FechaVenc.HeaderText = "FechaVenc";
            this.FechaVenc.MinimumWidth = 6;
            this.FechaVenc.Name = "FechaVenc";
            this.FechaVenc.Width = 105;
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.MinimumWidth = 6;
            this.Costo.Name = "Costo";
            this.Costo.Width = 71;
            // 
            // Unidades
            // 
            this.Unidades.HeaderText = "Unidades";
            this.Unidades.MinimumWidth = 6;
            this.Unidades.Name = "Unidades";
            this.Unidades.Width = 95;
            // 
            // NroLote
            // 
            this.NroLote.HeaderText = "NroLote";
            this.NroLote.MinimumWidth = 6;
            this.NroLote.Name = "NroLote";
            this.NroLote.Width = 84;
            // 
            // Imagenes
            // 
            this.Imagenes.HeaderText = "Imagenes";
            this.Imagenes.MinimumWidth = 6;
            this.Imagenes.Name = "Imagenes";
            this.Imagenes.Width = 96;
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.MinimumWidth = 6;
            this.Proveedor.Name = "Proveedor";
            // 
            // FProveedorDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 310);
            this.Controls.Add(this.dgv_proveedoresDetalles);
            this.Name = "FProveedorDetalles";
            this.Text = "FProveedorDetalles";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proveedoresDetalles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_proveedoresDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Denominacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVenc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imagenes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
    }
}