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
    public partial class FAgregarAlaBolsa : Form
    {
        
        
        public FAgregarAlaBolsa(LoteRemedios loteEncontrado)
        {
            InitializeComponent();
            
            
            lb_marca.Text= loteEncontrado.MarcaComercial.ToString();
            lb_denominacion.Text= loteEncontrado.DenominacionGenerica.ToString();
            lb_precio.Text= loteEncontrado.Precio.ToString();
            lb_stock.Text= loteEncontrado.Unidades.ToString();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
