namespace TP_Farmacia
{
    partial class FAgregarProveedor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_receta = new System.Windows.Forms.CheckBox();
            this.label_imagenes = new System.Windows.Forms.Label();
            this.btn_cargarImagenes = new System.Windows.Forms.Button();
            this.nud_costo = new System.Windows.Forms.NumericUpDown();
            this.nud_unidades = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_nroLote = new System.Windows.Forms.TextBox();
            this.txt_dosis = new System.Windows.Forms.TextBox();
            this.txt_denominacion = new System.Windows.Forms.TextBox();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nud_telefono = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nud_precio = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_costo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_unidades)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_telefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_precio)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_agregar);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(23, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 416);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(392, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_agregar
            // 
            this.btn_agregar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_agregar.Location = new System.Drawing.Point(119, 383);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(178, 30);
            this.btn_agregar.TabIndex = 2;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nud_precio);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cb_receta);
            this.groupBox2.Controls.Add(this.label_imagenes);
            this.groupBox2.Controls.Add(this.btn_cargarImagenes);
            this.groupBox2.Controls.Add(this.nud_costo);
            this.groupBox2.Controls.Add(this.nud_unidades);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.txt_nroLote);
            this.groupBox2.Controls.Add(this.txt_dosis);
            this.groupBox2.Controls.Add(this.txt_denominacion);
            this.groupBox2.Controls.Add(this.txt_marca);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(44, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(697, 258);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lote Remedio";
            // 
            // cb_receta
            // 
            this.cb_receta.AutoSize = true;
            this.cb_receta.Location = new System.Drawing.Point(15, 121);
            this.cb_receta.Name = "cb_receta";
            this.cb_receta.Size = new System.Drawing.Size(129, 20);
            this.cb_receta.TabIndex = 21;
            this.cb_receta.Text = "Requiere Receta";
            this.cb_receta.UseVisualStyleBackColor = true;
            // 
            // label_imagenes
            // 
            this.label_imagenes.AutoSize = true;
            this.label_imagenes.Location = new System.Drawing.Point(12, 216);
            this.label_imagenes.Name = "label_imagenes";
            this.label_imagenes.Size = new System.Drawing.Size(11, 16);
            this.label_imagenes.TabIndex = 20;
            this.label_imagenes.Text = "-";
            // 
            // btn_cargarImagenes
            // 
            this.btn_cargarImagenes.Location = new System.Drawing.Point(15, 181);
            this.btn_cargarImagenes.Name = "btn_cargarImagenes";
            this.btn_cargarImagenes.Size = new System.Drawing.Size(620, 32);
            this.btn_cargarImagenes.TabIndex = 19;
            this.btn_cargarImagenes.Text = "Cargar Imagen";
            this.btn_cargarImagenes.UseVisualStyleBackColor = true;
            this.btn_cargarImagenes.Click += new System.EventHandler(this.btn_cargarImagenes_Click);
            // 
            // nud_costo
            // 
            this.nud_costo.Location = new System.Drawing.Point(535, 32);
            this.nud_costo.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nud_costo.Name = "nud_costo";
            this.nud_costo.Size = new System.Drawing.Size(120, 22);
            this.nud_costo.TabIndex = 18;
            // 
            // nud_unidades
            // 
            this.nud_unidades.Location = new System.Drawing.Point(535, 60);
            this.nud_unidades.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_unidades.Name = "nud_unidades";
            this.nud_unidades.Size = new System.Drawing.Size(120, 22);
            this.nud_unidades.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(190, 153);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(445, 22);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // txt_nroLote
            // 
            this.txt_nroLote.Location = new System.Drawing.Point(535, 88);
            this.txt_nroLote.Name = "txt_nroLote";
            this.txt_nroLote.Size = new System.Drawing.Size(100, 22);
            this.txt_nroLote.TabIndex = 14;
            // 
            // txt_dosis
            // 
            this.txt_dosis.Location = new System.Drawing.Point(190, 91);
            this.txt_dosis.Name = "txt_dosis";
            this.txt_dosis.Size = new System.Drawing.Size(100, 22);
            this.txt_dosis.TabIndex = 10;
            // 
            // txt_denominacion
            // 
            this.txt_denominacion.Location = new System.Drawing.Point(190, 63);
            this.txt_denominacion.Name = "txt_denominacion";
            this.txt_denominacion.Size = new System.Drawing.Size(100, 22);
            this.txt_denominacion.TabIndex = 9;
            // 
            // txt_marca
            // 
            this.txt_marca.Location = new System.Drawing.Point(190, 36);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(100, 22);
            this.txt_marca.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(450, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Nro Lote";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(450, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Unidades";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(450, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Costo";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fecha Vencimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Dosis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Denominacion Generica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Marca";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nud_telefono);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_direccion);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(41, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proveedor";
            // 
            // nud_telefono
            // 
            this.nud_telefono.Location = new System.Drawing.Point(429, 55);
            this.nud_telefono.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nud_telefono.Name = "nud_telefono";
            this.nud_telefono.Size = new System.Drawing.Size(120, 22);
            this.nud_telefono.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(344, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "Telefono";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(429, 26);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 22);
            this.txt_email.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(344, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Direccion";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(183, 54);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(100, 22);
            this.txt_direccion.TabIndex = 3;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(183, 26);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 22);
            this.txt_nombre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del Proveedor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(427, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Precio x unidad";
            // 
            // nud_precio
            // 
            this.nud_precio.Location = new System.Drawing.Point(535, 116);
            this.nud_precio.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nud_precio.Name = "nud_precio";
            this.nud_precio.Size = new System.Drawing.Size(120, 22);
            this.nud_precio.TabIndex = 23;
            // 
            // FAgregarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.panel1);
            this.Name = "FAgregarProveedor";
            this.Text = "FAgregarProveedor";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_costo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_unidades)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_telefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_precio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.NumericUpDown nud_unidades;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_nroLote;
        private System.Windows.Forms.TextBox txt_dosis;
        private System.Windows.Forms.TextBox txt_denominacion;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nud_costo;
        private System.Windows.Forms.Button btn_cargarImagenes;
        public System.Windows.Forms.Label label_imagenes;
        private System.Windows.Forms.NumericUpDown nud_telefono;
        private System.Windows.Forms.CheckBox cb_receta;
        private System.Windows.Forms.NumericUpDown nud_precio;
        private System.Windows.Forms.Label label9;
    }
}