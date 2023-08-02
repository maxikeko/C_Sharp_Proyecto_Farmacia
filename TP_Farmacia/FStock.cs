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
    public partial class FStock : Form
    {
        Farmacia unaFarmacia;
        public FStock(Farmacia unaFarmacia)
        {
            InitializeComponent();
            this.unaFarmacia = unaFarmacia;
            RefrescarTabla();


        }

        private void RefrescarTabla()
        {
            dgv_stock.Rows.Clear();
            List<LoteRemedios> loteStock = unaFarmacia.LotesRemedios;
            foreach (LoteRemedios item in loteStock)
            {

                //el orden que se ingresan los datos estan ordenados por los headers del DATAGRIDVIEW
                ArrayList listaRutas = item.Imagenes;
                string rutasString = "";
                foreach (string item1 in listaRutas)
                {
                    rutasString += item1 + ",";
                }
                dgv_stock.Rows.Add(item.Id, item.NumeroLote, item.MarcaComercial, item.DenominacionGenerica, item.Dosis, item.FechaVencimiento, item.Unidades, rutasString, item.Baja, item.Precio, item.Costo, item.UnProveedor.Nombre);
            }

        }

        private void dgv_stock_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
                // Obtener los valores de la fila seleccionada
            DataGridViewRow filaSeleccionada = dgv_stock.Rows[e.RowIndex];
            int idFila =Convert.ToInt32( filaSeleccionada.Cells["ID"].Value.ToString());
                
            FImagenes unaVentanaImagenes = new FImagenes(idFila,unaFarmacia,1);
            unaVentanaImagenes.ShowDialog();

             
            

        }

        private void btn_asignarPrecio_Click(object sender, EventArgs e)
        {
            if (dgv_stock.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgv_stock.SelectedRows[0];
                // Obtener los valores de las celdas de la fila seleccionada
                int id = Convert.ToInt32(filaSeleccionada.Cells["ID"].Value);
                foreach (LoteRemedios lote in unaFarmacia.LotesRemedios)
                {
                    if(lote.Id == id)
                    {
                        lote.Precio = Convert.ToDouble(nud_precio.Value);
                        RefrescarTabla();
                    }
                }
                
            }


        }

        private void dgv_stock_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_stock.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgv_stock.SelectedRows[0];
                // Obtener los valores de las celdas de la fila seleccionada
                string nrolote = filaSeleccionada.Cells["NroLote"].Value.ToString();
                txt_bajaNro.Text= nrolote.ToString();

               

            }
        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
            string nroLote = txt_bajaNro.Text;
            bool error = true;
            foreach (LoteRemedios lote in unaFarmacia.LotesRemedios)
            {
                if (lote.NumeroLote==nroLote)
                {
                    error = false;
                    lote.Baja = true;
                    RefrescarTabla();
                    
                }
               
            }
            if(error)
            {
                MessageBox.Show("El numero de lote indicado no existe.");
            }
            else
            {
                MessageBox.Show("Se ha dado de baja el lote indicado.");
            }
        }
    }
}
