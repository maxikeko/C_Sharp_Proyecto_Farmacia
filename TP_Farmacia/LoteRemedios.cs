using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Farmacia
{
    [Serializable]
    public class LoteRemedios
    {
        private int id;
        private string marcaComercial;
        private string denominacionGenerica;
        private string dosis;
        private DateTime fechaVencimiento;
        private double costo;
        private double precio;
        private int unidades;//unidades x lotes
        private string numeroLote;
        private ArrayList imagenes;
        private bool baja;
        Proveedores unProveedor;
        private bool receta = false;
        private string rutaReceta = "";
        private string foto = "";

        public LoteRemedios(string marcaComercial, string denominacionGenerica,string dosis,DateTime fechaVencimiento,int unidades, string numeroLote, ArrayList imagenes, double costo, Proveedores unProveedor) {

            
            this.MarcaComercial = marcaComercial;
            this.DenominacionGenerica = denominacionGenerica;
            this.Dosis = dosis;
            this.FechaVencimiento = fechaVencimiento;
            this.Unidades = unidades;
            this.NumeroLote = numeroLote;
            this.Imagenes = imagenes;
            this.Baja = false;
            this.Costo = costo;
            this.UnProveedor = unProveedor;

        
        
        }

        public string MarcaComercial { get => marcaComercial; set => marcaComercial = value; }
        public string DenominacionGenerica { get => denominacionGenerica; set => denominacionGenerica = value; }
        public string Dosis { get => dosis; set => dosis = value; }
        public DateTime FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }
        public double Costo { get => costo; set => costo = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Unidades { get => unidades; set => unidades = value; }
        public string NumeroLote { get => numeroLote; set => numeroLote = value; }
        public ArrayList Imagenes { get => imagenes; set => imagenes = value; }
        public bool Baja { get => baja; set => baja = value; }
        public Proveedores UnProveedor { get => unProveedor; set => unProveedor = value; }
        public int Id { get => id; set => id = value; }
        public bool Receta { get => receta; set => receta = value; }

        public string Foto { get => foto; set => foto = value; }
        public string RutaReceta { get => rutaReceta; set => rutaReceta = value; }
    }
}
