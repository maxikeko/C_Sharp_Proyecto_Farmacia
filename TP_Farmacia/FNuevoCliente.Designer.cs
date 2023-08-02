namespace TP_Farmacia
{
    partial class FNuevoCliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbnombre = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_CargarImagen = new System.Windows.Forms.Button();
            this.nud_limite = new System.Windows.Forms.NumericUpDown();
            this.lb_rutaFoto = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_limite)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_rutaFoto);
            this.groupBox1.Controls.Add(this.nud_limite);
            this.groupBox1.Controls.Add(this.btn_CargarImagen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbnombre);
            this.groupBox1.Controls.Add(this.txt_direccion);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Location = new System.Drawing.Point(17, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Foto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Limite Credito";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Direccion";
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Location = new System.Drawing.Point(24, 35);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(56, 16);
            this.lbnombre.TabIndex = 12;
            this.lbnombre.Text = "Nombre";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(94, 70);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(100, 22);
            this.txt_direccion.TabIndex = 9;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(94, 32);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 22);
            this.txt_nombre.TabIndex = 8;
            // 
            // btn_guardar
            // 
            this.btn_guardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_guardar.Location = new System.Drawing.Point(136, 237);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 1;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(35, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_CargarImagen
            // 
            this.btn_CargarImagen.Location = new System.Drawing.Point(94, 106);
            this.btn_CargarImagen.Name = "btn_CargarImagen";
            this.btn_CargarImagen.Size = new System.Drawing.Size(75, 30);
            this.btn_CargarImagen.TabIndex = 16;
            this.btn_CargarImagen.Text = "Cargar";
            this.btn_CargarImagen.UseVisualStyleBackColor = true;
            this.btn_CargarImagen.Click += new System.EventHandler(this.btn_CargarImagen_Click);
            // 
            // nud_limite
            // 
            this.nud_limite.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_limite.Location = new System.Drawing.Point(93, 163);
            this.nud_limite.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nud_limite.Name = "nud_limite";
            this.nud_limite.Size = new System.Drawing.Size(120, 22);
            this.nud_limite.TabIndex = 17;
            this.nud_limite.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // lb_rutaFoto
            // 
            this.lb_rutaFoto.AutoSize = true;
            this.lb_rutaFoto.Location = new System.Drawing.Point(6, 137);
            this.lb_rutaFoto.Name = "lb_rutaFoto";
            this.lb_rutaFoto.Size = new System.Drawing.Size(11, 16);
            this.lb_rutaFoto.TabIndex = 18;
            this.lb_rutaFoto.Text = "-";
            // 
            // FNuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 282);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FNuevoCliente";
            this.Text = "FNuevoCliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_limite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_CargarImagen;
        private System.Windows.Forms.NumericUpDown nud_limite;
        private System.Windows.Forms.Label lb_rutaFoto;
    }
}