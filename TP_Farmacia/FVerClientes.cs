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
    public partial class FVerClientes : Form
    {
        Farmacia unaFarmacia;
        public FVerClientes(Farmacia unaFarmacia)
        {
            InitializeComponent();
            this.unaFarmacia = unaFarmacia;
            RefrescarTabla();
        }
        public void RefrescarTabla()
        {
            dgv_clientes.Rows.Clear();

            foreach (Cliente unCliente in unaFarmacia.Clientes)
            {
                dgv_clientes.Rows.Add(unCliente.Id,unCliente.Nombre,unCliente.Direccion,unCliente.Foto,unCliente.LimiteCredito);
            }
            
        }

        private void dgv_clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgv_clientes.Rows[e.RowIndex];
            int idFila = Convert.ToInt32(filaSeleccionada.Cells["ID"].Value.ToString());

            FImagenes unaVentanaImagenes = new FImagenes(idFila, unaFarmacia,2);
            unaVentanaImagenes.ShowDialog();
        }
    }
}
