using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Farmacia
{
    [Serializable]
    public class Farmacia
    {
        private List<LoteRemedios> lotesRemedios; //lista stock
        private List<LoteRemedios> lotesRemediosCOPIA; //lista stock copia solo se usa temporalmente para el carrito de compras
        private List<Cliente> clientes; //lista cliente
        private List<Venta> ventas; //lista de ventas
        private List<Proveedores> listaProveedores;
        private List<LoteRemedios> listaBolsaDeCompras;

        public Farmacia()
        {
            LotesRemedios = new List<LoteRemedios>();
            Clientes = new List<Cliente>();
            Ventas = new List<Venta>();
            listaProveedores = new List<Proveedores>();
            //StockPorDefecto();
        }
        public void NuevaBolsa()
        {
            ListaBolsaDeCompras= new List<LoteRemedios>();
            lotesRemediosCOPIA = new List<LoteRemedios>();
            lotesRemediosCOPIA = lotesRemedios;
        }
        public void AgregarLoteRemedios(LoteRemedios lote)
        {
            //alta de lotes o post compra a proveedores
            LotesRemedios.Add(lote);
            lote.Id = LotesRemedios.Count;

            MessageBox.Show("Se ha cargado correctamente el Lote de Remedios");
        }

        public void AgregarCliente(Cliente cliente)
        {
            //alta de cliente o cargar cliente
            clientes.Add(cliente);
            cliente.Id = clientes.Count;

            MessageBox.Show("Se ha cargado correctamente el cliente");
        }

        public void StockPorDefecto()
        {
            Proveedores unProveedor = new Proveedores("Cardinal Health", "Rondeau 1111", "cardinal@gmail.com", 11111);
            Proveedores unProveedor2 = new Proveedores("McKesson Corporation", "Almirante Brown 2222", "McKesson@gmail.com", 2222);
            Proveedores unProveedor3 = new Proveedores("Farmacity", "Don Bosco 3333", "farmacity@gmail.com", 3333);
            Proveedores unProveedor4 = new Proveedores("Farmacos SA", "Av Ramirez 4444", "Farmacos SA@gmail.com", 4444);

            ArrayList imagenes = new ArrayList();
            //ruta absoluta     CAMBIAR RUTAS POR LAS DUDAS 
            imagenes.Add("C:/Users/Notebook Keko/Desktop/TP_Farmacia/TP_Farmacia/TP_Farmacia/imagenes/remedios/paracetamol_bayer1.jpg");
            imagenes.Add("C:/Users/Notebook Keko/Desktop/TP_Farmacia/TP_Farmacia/TP_Farmacia/imagenes/remedios/paracetamol_bayer2.png");
            //ruta relativa
            //imagenes.Add("imagenes/remedios/paracetamol_bayer1.jpg");
            //imagenes.Add("imagenes/remedios/paracetamol_bayer2.png");
            LoteRemedios lote1 = new LoteRemedios("Ibupirac", "Ibuprofeno", "400gr", new DateTime(2023, 7, 27), 12, "1", imagenes, 1200, unProveedor);
            LoteRemedios lote2 = new LoteRemedios("Tylenol", "Paracetamol", "600gr", new DateTime(2023, 7, 30), 20, "2", imagenes, 1500, unProveedor2);
            LoteRemedios lote3 = new LoteRemedios("Advil", "Ibuprofeno", "400gr", new DateTime(2023, 8, 1), 30, "3", imagenes, 2000, unProveedor2);
            LoteRemedios lote4 = new LoteRemedios("Tums ", "Carbonato de Calcio", "750gr", new DateTime(2023, 9, 21), 20, "4", imagenes, 1700, unProveedor2);
            LoteRemedios lote5 = new LoteRemedios("Benadryl", "Difenhidramina", "25gr", new DateTime(2023, 8, 10), 12, "5", imagenes, 800, unProveedor3);
            LoteRemedios lote6 = new LoteRemedios("Pepto-Bismol", "Subsalicilato de Bismuto", "262gr", new DateTime(2023, 7, 10), 10, "6", imagenes, 500, unProveedor3);
            LoteRemedios lote7 = new LoteRemedios("Rennie", "Hidróxido de Magnesio y Carbonato de Calcio", "680mg + 80mg", new DateTime(2023, 8, 9), 5, "7", imagenes, 700, unProveedor4);

            lote1.Precio = 1200;
            lote2.Precio = 600;
            lote3.Precio = 500;
            lote4.Precio = 3000;
            lote5.Precio = 200;
            lote6.Precio = 4500;
            lote7.Precio = 1000;



            AgregarProveedor(unProveedor);
            AgregarProveedor(unProveedor2);
            AgregarProveedor(unProveedor3);
            AgregarProveedor(unProveedor4);

            AgregarLoteRemedios(lote1);
            AgregarLoteRemedios(lote2);
            AgregarLoteRemedios(lote3);
            AgregarLoteRemedios(lote4);
            AgregarLoteRemedios(lote5);
            AgregarLoteRemedios(lote6);
            AgregarLoteRemedios(lote7);
            

        }
        public void AgregarProveedor(Proveedores proveedor)
        {
            listaProveedores.Add(proveedor);
        }
       
        public string AgregarBolsa(LoteRemedios unLoteBolsa)
        {
            string msg;
            LoteRemedios loteEncontrado=null;
            // Verificar disponibilidad de los remedios
            foreach (LoteRemedios loteStock in LotesRemedios)
            {
                
                if(loteStock.Id == unLoteBolsa.Id)
                {
                    loteEncontrado = loteStock;
                }
            }
            
                //si el lote en stock esta vacio o si hay menos unidades en stock que los que solicitan en la venta entonces error
                if (loteEncontrado == null || loteEncontrado.Unidades < unLoteBolsa.Unidades)
                {
                    msg = "El lote de remedios no está disponible para la venta. Debido que no hay suficiente stock";

                    return msg;
                }
                //o si fecha de vencimiento es menor a la fecha actual entonces error
                if (loteEncontrado.FechaVencimiento < DateTime.Now)
                {
                    msg = "El lote de remedios no esta disponible para la venta. Debido que el lote tiene un fecha de vencimiento inferior a la actual (vencido)";
                    return msg;
                }
                //o si lote en stock esta dado de baja entonces error
                if (loteEncontrado.Baja)
                {
                    msg = "El lote de remedios está dado de baja y no puede ser vendido.";
                    return msg;
                }

            

            //agrego a la bolsa de compras
            ListaBolsaDeCompras.Add(unLoteBolsa);


            //Ventas.Add(venta);
            msg = "Se ha agregado el producto exitosamente.";
            return msg;


        }

        public string TerminarVenta()
        {
            string msg="";
            foreach (LoteRemedios loteStock in lotesRemedios)
            {
                foreach (LoteRemedios loteBolsa in listaBolsaDeCompras)
                {
                    if(loteStock.Id == loteBolsa.Id)
                    {
                        
                        //si el lote en stock esta vacio o si hay menos unidades en stock que los que solicitan en la venta entonces error
                        if (loteStock == null || loteStock.Unidades < loteBolsa.Unidades)
                        {
                            msg = "El lote de remedios no está disponible para la venta. Debido que no hay suficiente stock";

                            return msg;
                        }
                        // Realizar la venta y actualizar el stock de remedios
                        loteStock.Unidades -= loteBolsa.Unidades;
                    }
                }
            }

            
            return msg = "Se ha realizado con exito la Venta.";
           
            
        }
        public void AgregarVenta(Venta unaVenta)
        {
            ventas.Add(unaVenta);
            unaVenta.Id = ventas.Count;
        }


        public List<LoteRemedios> LotesRemedios { get => lotesRemedios; set => lotesRemedios = value; }
        public List<Cliente> Clientes { get => clientes; set => clientes = value; }
        public List<Venta> Ventas { get => ventas; set => ventas = value; }
        public List<LoteRemedios> ListaBolsaDeCompras { get => listaBolsaDeCompras; set => listaBolsaDeCompras = value; }

        // Otros métodos y funcionalidades necesarios

        public void GuardarDatos()
        {

            FileStream stream = new FileStream("Lista_datos", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();

                formatter.Serialize(stream, LotesRemedios);
                formatter.Serialize(stream, Clientes);
                formatter.Serialize(stream, Ventas);
                formatter.Serialize(stream, listaProveedores);
            stream.Close();
        }

        public void CargarDatos()
        {
            if (File.Exists("Lista_datos"))
            {
                    FileStream stream = new FileStream("Lista_datos", FileMode.Open);
                    BinaryFormatter formatter = new BinaryFormatter();

                    LotesRemedios = (List<LoteRemedios>)formatter.Deserialize(stream);
                    Clientes = (List<Cliente>)formatter.Deserialize(stream);
                    Ventas = (List<Venta>)formatter.Deserialize(stream);
                    listaProveedores= (List<Proveedores>)formatter.Deserialize(stream);
                    stream.Close();
            }
        }
    }
}
