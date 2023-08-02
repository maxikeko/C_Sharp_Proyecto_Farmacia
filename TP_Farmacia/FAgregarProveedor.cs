using System;
using System.Collections;
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
    public partial class FAgregarProveedor : Form
    {
        ArrayList listaRutas;
        Farmacia unaFarmacia;
        public FAgregarProveedor(Farmacia unaFarmacia)
        {
            InitializeComponent();
            listaRutas = new ArrayList();//lista de rutas de imagenes 
            this.unaFarmacia = unaFarmacia; 
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        
        private void btn_cargarImagenes_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagen = new OpenFileDialog();
            if(abrirImagen.ShowDialog() == DialogResult.OK)
            {
                listaRutas.Add(abrirImagen.FileName);
                string ruta= abrirImagen.FileName;
                label_imagenes.Text += ruta+"\n";
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Proveedores unProveedor = new Proveedores(
                    txt_nombre.Text,
                    txt_direccion.Text,
                    txt_email.Text,
                    Convert.ToInt32(nud_telefono.Value)
                );
            LoteRemedios unLote = new LoteRemedios(
                    txt_marca.Text,
                    txt_denominacion.Text,
                    txt_dosis.Text,
                    dateTimePicker1.Value,
                    Convert.ToInt32(nud_unidades.Value),
                    txt_nroLote.Text, 
                    listaRutas,
                    Convert.ToDouble(nud_costo.Value),
                    unProveedor
                );
            unLote.Precio= Convert.ToDouble(nud_precio.Value);
            if(cb_receta.Checked )
            {
                unLote.Receta = true;
            }
            unaFarmacia.AgregarProveedor( unProveedor );
            unaFarmacia.AgregarLoteRemedios(unLote);
        }
    }
}
