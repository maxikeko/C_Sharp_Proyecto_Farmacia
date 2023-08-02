using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Farmacia
{
    [Serializable]
    public class Cliente
    {
        private int id;
        private string nombre;
        private string direccion;
        private double limiteCredito;
        private double limiteCreditoOriginal;
        private DateTime fechaPago;
        private string foto;

        public Cliente(string nombre, string direccion, double limiteCredito)
        {
           
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.LimiteCredito = limiteCredito;
            this.LimiteCreditoOriginal= limiteCredito;
            this.fechaPago= new DateTime(2000, 01, 01);
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        
        public DateTime FechaPago { get => fechaPago; set => fechaPago = value; }
        public string Foto { get => foto; set => foto = value; }
        public double LimiteCredito { get => limiteCredito; set => limiteCredito = value; }
        public double LimiteCreditoOriginal { get => limiteCreditoOriginal; set => limiteCreditoOriginal = value; }
    }
}
