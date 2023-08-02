using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Farmacia
{
    public partial class FNuevoCliente : Form
    {
        Farmacia unaFarmacia;

        string nombre, direccion,foto="";
        
        public FNuevoCliente(Farmacia unaFarmacia)
        {
            InitializeComponent();
            this.unaFarmacia = unaFarmacia; 
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            nombre= txt_nombre.Text;
            direccion= txt_direccion.Text;
            double limite =Convert.ToDouble( nud_limite.Value);
            
            Cliente unCliente = new Cliente(nombre,direccion,limite);
            unCliente.Foto = foto;
            unaFarmacia.AgregarCliente(unCliente);
            

            
        }

        private void btn_CargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagen = new OpenFileDialog();
            if (abrirImagen.ShowDialog() == DialogResult.OK)
            {
                
                foto = abrirImagen.FileName;
                lb_rutaFoto.Text = foto;

            }
        }
    }
}
