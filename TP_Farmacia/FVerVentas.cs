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
    public partial class FVerVentas : Form
    {
        Farmacia unaFarmacia;
        public FVerVentas(Farmacia unaFarmacia)
        {
            InitializeComponent();
            this.unaFarmacia = unaFarmacia;
            foreach (Venta unaVenta in unaFarmacia.Ventas)
            {
                string nombre;
                if (unaVenta.NoCliente == "")
                {
                    nombre = unaVenta.Cliente1.Nombre;
                }
                else
                {
                    nombre = unaVenta.NoCliente;
                }

                dgv_Ventas.Rows.Add(unaVenta.Id, nombre, unaVenta.FechaVenta1, unaVenta.RemediosVendidos1);
            }
        }

        private void dgv_Ventas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtener los valores de la fila seleccionada
            DataGridViewRow filaSeleccionada = dgv_Ventas.SelectedRows[0];
            int idFila = Convert.ToInt32(filaSeleccionada.Cells["ID"].Value.ToString());
            Venta ventaEncontrada=null;
            foreach (Venta ventasStock in unaFarmacia.Ventas)
            {
                if(ventasStock.Id == idFila)
                {
                    ventaEncontrada = ventasStock;
                }
            }
            if (ventaEncontrada == null)
            {
                MessageBox.Show("Venta no encontrada.");
            }
            else
            {

            FImprimirVenta unaVentaImprimir = new FImprimirVenta(ventaEncontrada);
                unaVentaImprimir.ShowDialog();
            }
            //FImagenes unaVentanaImagenes = new FImagenes(idFila, unaFarmacia, 1);
            //unaVentanaImagenes.ShowDialog();
        }

        private void FVerVentas_Enter(object sender, EventArgs e)
        {

            /*
           
            */
        }

        private void dgv_Ventas_Enter(object sender, EventArgs e)
        {
            /*
            // Obtener los valores de la fila seleccionada
            DataGridViewRow filaSeleccionada = dgv_Ventas.SelectedRows[0];
            int idFila = Convert.ToInt32(filaSeleccionada.Cells["ID"].Value.ToString());
            Venta ventaEncontrada = null;
            foreach (Venta ventasStock in unaFarmacia.Ventas)
            {
                if (ventasStock.Id == idFila)
                {
                    ventaEncontrada = ventasStock;
                }
            }
            //enviar el objeto con receta
            FimagenReceta unaventanita = new FimagenReceta(ventaEncontrada);
            unaventanita.ShowDialog();
        */
        }

        private void dgv_Ventas_SelectionChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Evento seleccion change");
        }
    }
}
