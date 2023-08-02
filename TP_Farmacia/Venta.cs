using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Farmacia
{
    [Serializable]
    public class Venta
    {
        private int id;
        private Cliente Cliente;
        private string noCliente = "";
        private DateTime FechaVenta;
        private List<LoteRemedios> RemediosVendidos;
        private string FotoReceta;

        public Venta(DateTime FechaVenta, List<LoteRemedios> RemediosVendidos)
        {
            this.FechaVenta1 = FechaVenta;
            this.RemediosVendidos1 = RemediosVendidos;
            this.NoCliente = "Consumidor Final";
        }
        public Venta(DateTime FechaVenta, List<LoteRemedios> RemediosVendidos, string FotoReceta)
        {
            this.FechaVenta1 = FechaVenta;
            this.RemediosVendidos1 = RemediosVendidos;
            this.NoCliente = "Consumidor Final";
            this.FotoReceta1 = FotoReceta;
        }
        public Venta(Cliente Cliente, DateTime FechaVenta, List<LoteRemedios> RemediosVendidos) { 
            this.Cliente1 = Cliente; 
            this.FechaVenta1 = FechaVenta;
            this.RemediosVendidos1 = RemediosVendidos;
        }
        public Venta(Cliente Cliente, DateTime FechaVenta, List<LoteRemedios> RemediosVendidos, string FotoReceta)
        {
            this.Cliente1 = Cliente;
            this.FechaVenta1 = FechaVenta;
            this.RemediosVendidos1 = RemediosVendidos;
            this.FotoReceta1 = FotoReceta;
        }

        public Cliente Cliente1 { get => Cliente; set => Cliente = value; }
        public DateTime FechaVenta1 { get => FechaVenta; set => FechaVenta = value; }
        public List<LoteRemedios> RemediosVendidos1 { get => RemediosVendidos; set => RemediosVendidos = value; }
        public string FotoReceta1 { get => FotoReceta; set => FotoReceta = value; }
        public int Id { get => id; set => id = value; }
        public string NoCliente { get => noCliente; set => noCliente = value; }
    }
}
