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
    public partial class FProveedorDetalles : Form
    {
        Farmacia unaFarmacia;
        public FProveedorDetalles(Farmacia unaFarmacia)
        {
            InitializeComponent();
            this.unaFarmacia = unaFarmacia;

            //List<Proveedores> listaProveedores = unaFarmacia.VerProveedores();
            //foreach (Proveedores prov in listaProveedores)
            //{
            //    foreach (LoteRemedios item in prov.LoteRemediosPr)
            //    {
            //        dgv_proveedoresDetalles.Rows.Add(item.MarcaComercial, item.DenominacionGenerica, item.Dosis,item.FechaVencimiento, item.Costo, item.Unidades,item.NumeroLote,item.Imagenes, prov.Nombre);

            //    }
            //    //marca,denominacion,dosis,fechavec,costo,unidades,nrolote, imagenes , nombre proveedor
            //}

        }

    }
}
