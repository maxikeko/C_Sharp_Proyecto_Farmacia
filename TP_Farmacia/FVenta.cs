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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace TP_Farmacia
{
    public partial class FVenta : Form
    {
        Farmacia unaFarmacia;
        List<LoteRemedios> bolsaDeCompras;
        public FVenta(Farmacia unaFarmacia)
        {
            InitializeComponent();
            this.unaFarmacia = unaFarmacia;
            bolsaDeCompras = new List<LoteRemedios>();
            cb_clientes.SelectedItem = "Consumidor Final";
            cb_stock.SelectedItem = "Marca";
            RefrescarClientes();
            RefrescarStock();

            //creo una bolsa de compras en farmacia
            unaFarmacia.NuevaBolsa();
        }

        private void RefrescarClientes()
        {
            //limpio pantalla
            cb_clientes.Items.Clear();
            List<Cliente> listaClientes = unaFarmacia.Clientes;
            foreach (Cliente unCliente in listaClientes)
            {
                cb_clientes.Items.Add(unCliente.Id+" - "+unCliente.Nombre);
            }
        }
        private void RefrescarStock()
        {
            //limpio pantalla
            dgv_stock.Rows.Clear();
            //me traigo la lista de stock de farmacia
            List<LoteRemedios> loteStock = unaFarmacia.LotesRemedios;
            //recorro la lista de stock
            foreach (LoteRemedios item in loteStock)
            {

                //mini formateo para que aparezcan todas las rutas en la columna imagenes de cada lote
                ArrayList listaRutas = item.Imagenes;
                string rutasString = "";
                foreach (string item1 in listaRutas)
                {
                    rutasString += item1 + ",";//separo por coma cada elemnto en un solo string
                }

                //agrego elementos en orden de los headers
                dgv_stock.Rows.Add(item.Id, item.MarcaComercial, item.DenominacionGenerica, item.Dosis, item.FechaVencimiento, item.Unidades, rutasString, item.Precio,item.NumeroLote, item.Baja,item.Receta);
            }
        }

        private void cb_stock_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            //limpio pantalla
            dgv_stock.Rows.Clear();
            //me traigo la lista de stock de farmacia
            List<LoteRemedios> loteStock = unaFarmacia.LotesRemedios;
            //txt_busqueda buscar palabra en- depende combobox
            string partePalabra = txt_busqueda.Text;
            //lista de palabras encontradas:
            List<LoteRemedios> lotesEncontrados = new List<LoteRemedios>();

            if(string.IsNullOrEmpty(partePalabra))//si esta vacio muestra todos los datos
            {
                RefrescarStock();
            }
            else
            {
                //si tiene algo escrito buscar:
                string opcionCombo = cb_stock.Text;
                switch( opcionCombo )
                {
                    case "Marca":
                        //recorro la lista de stock
                        foreach (LoteRemedios lote in loteStock)
                        {
                            //si la marca del lote en minusculas,contiene parte de la palabra en minusculas
                            if (lote.MarcaComercial.ToLower().Contains(partePalabra.ToLower()))
                            {
                                //añado a la lista de encontrados
                                lotesEncontrados.Add(lote);
                            }
                            
                        }


                        break;
                    case "Denominacion":
                        //recorro la lista de stock
                        foreach (LoteRemedios lote in loteStock)
                        {
                            //si la marca del lote en minusculas,contiene parte de la palabra en minusculas
                            if (lote.DenominacionGenerica.ToLower().Contains(partePalabra.ToLower()))
                            {
                                //añado a la lista de encontrados
                                lotesEncontrados.Add(lote);
                            }
                        }
                            break;
                    case "Ambas":

                        //recorro la lista de stock
                        foreach (LoteRemedios lote in loteStock)
                        {
                            //si la marca del lote en minusculas,contiene parte de la palabra en minusculas
                            if ((lote.MarcaComercial.ToLower().Contains(partePalabra.ToLower())) || (lote.DenominacionGenerica.ToLower().Contains(partePalabra.ToLower())))
                            {
                                //añado a la lista de encontrados
                                lotesEncontrados.Add(lote);
                            }
                        }
                            break;

                    default:
                        MessageBox.Show("Error en seleccion de filtro ComboBox");
                        break;

                }



                //recorro la lista de encontrados
                foreach (LoteRemedios item in lotesEncontrados)
                {

                    //mini formateo para que aparezcan todas las rutas en la columna imagenes de cada lote
                    ArrayList listaRutas = item.Imagenes;
                    string rutasString = "";
                    foreach (string item1 in listaRutas)
                    {
                        rutasString += item1 + ",";//separo por coma cada elemnto en un solo string
                    }

                    //agrego elementos en orden de los headers
                    dgv_stock.Rows.Add(item.Id, item.MarcaComercial, item.DenominacionGenerica, item.Dosis, item.FechaVencimiento, item.Unidades, rutasString, item.Precio, item.NumeroLote, item.Baja);
                }


            }
        }

        private void btn_agregarCarrito_Click(object sender, EventArgs e)
        {
            


            //seleccionar fila 
            // Obtener los valores de la fila seleccionada
            DataGridViewRow filaSeleccionada = dgv_stock.SelectedRows[0];
            int idFila = Convert.ToInt32(filaSeleccionada.Cells["ID"].Value.ToString());

            LoteRemedios loteEncontrado=null;
            //buscar id
            foreach (LoteRemedios lote in unaFarmacia.LotesRemedios)
            {
                if (lote.Id == idFila)
                {
                    //añadirlo en una lista bolsa de compras
                   
                    loteEncontrado = lote;
                    
                }
            }
            if (loteEncontrado != null)
            {
                
                

                FAgregarAlaBolsa unaVentanaAgregar = new FAgregarAlaBolsa(loteEncontrado);
                if (unaVentanaAgregar.ShowDialog() == DialogResult.OK)
                {
                    int unidadesPedido = Convert.ToInt32(unaVentanaAgregar.nud_unidadesAg.Value);

                    //creo un lote para agregar a la bolsa y verifico en Farmacia las validaciones
                    
                    LoteRemedios unLoteBolsa =new LoteRemedios( loteEncontrado.MarcaComercial,loteEncontrado.DenominacionGenerica,loteEncontrado.Dosis,loteEncontrado.FechaVencimiento,loteEncontrado.Unidades,loteEncontrado.NumeroLote,loteEncontrado.Imagenes,loteEncontrado.Costo,loteEncontrado.UnProveedor);
                    unLoteBolsa.Unidades = unidadesPedido;
                    unLoteBolsa.Id = loteEncontrado.Id;
                    unLoteBolsa.Precio= loteEncontrado.Precio;
                    if (loteEncontrado.Receta)
                    {
                        MessageBox.Show("Este producto requiere foto de la Receta");

                        OpenFileDialog abrirImagen = new OpenFileDialog();
                        if (abrirImagen.ShowDialog() == DialogResult.OK)
                        {
                            
                            string rutaReceta = abrirImagen.FileName;
                            loteEncontrado.RutaReceta = rutaReceta;
                            unLoteBolsa.Receta = true;
                            unLoteBolsa.RutaReceta = rutaReceta;
                            //cargar en venta
                        }
                    }
                    string msg = unaFarmacia.AgregarBolsa(unLoteBolsa);
                    if (msg == "Se ha agregado el producto exitosamente.")
                    {
                       
                        //refresh datagrid bolsa y stock
                        RefrescarStock();
                        RefrescarBolsa();                                                         

                    }
                    else
                    {
                        MessageBox.Show(msg);
                    }
                }
            }
            else
            {
                MessageBox.Show("lote no encontrado");
            }
            double total=0;
            foreach (LoteRemedios item in unaFarmacia.ListaBolsaDeCompras)
            {
                total = (item.Precio * item.Unidades) + total;
            }
            lab_total.Text = total.ToString();
        }

        public void RefrescarBolsa()
        {
            //limpio pantalla
            dgv_BolsaCompras.Rows.Clear();
            //me traigo la lista de bolsa de compras de farmacia
            List<LoteRemedios> lotesBolsa = unaFarmacia.ListaBolsaDeCompras;
            //recorro la lista de stock
            foreach (LoteRemedios item in lotesBolsa)
            {

                //mini formateo para que aparezcan todas las rutas en la columna imagenes de cada lote
                ArrayList listaRutas2 = item.Imagenes;
                string rutasString2 = "";
                foreach (string item1 in listaRutas2)
                {
                    rutasString2 += item1 + ",";//separo por coma cada elemnto en un solo string
                }

                //agrego elementos en orden de los headers
                dgv_BolsaCompras.Rows.Add(item.Id, item.MarcaComercial, item.DenominacionGenerica, item.Dosis, item.FechaVencimiento, item.Unidades, rutasString2, item.Precio, item.NumeroLote, item.Baja,item.Precio * item.Unidades);
            }


      
        }

        private void btn_terminarVenta_Click(object sender, EventArgs e)
        {
            //abrir ventana para preguntar si paga en efectivo o cuenta corriente
            FPreguntaCuentaCorrriente unaVentaPrCuenta= new FPreguntaCuentaCorrriente();

            if(unaVentaPrCuenta.ShowDialog() == DialogResult.OK)
            {
                //tomar el limite del cliente
                Cliente clienteEncontrado=null;
                string combobox = cb_clientes.Text;
                string[] partes = combobox.Split('-');//separo en partes con el "-"
                int idBuscado = Convert.ToInt32(partes[0].Trim()); //guardo el id quitando los espacios(trim)
                foreach (Cliente ClienteStock in unaFarmacia.Clientes)
                {
                    if (ClienteStock.Id == idBuscado) 
                    {
                        clienteEncontrado = ClienteStock;
                    }
                }

                if(clienteEncontrado == null)
                {
                     MessageBox.Show("Cliente no encontrado.");

                }
                else
                {
                    //tener el acumulado de la bolsa
                    double acumulado = 0;
                    foreach (LoteRemedios loteBolsa in unaFarmacia.ListaBolsaDeCompras)
                    {
                        acumulado = (loteBolsa.Unidades * loteBolsa.Precio) + acumulado;
                    }


                    //si limite es > que total    -> paga con la cuenta
                    if (clienteEncontrado.LimiteCredito >= acumulado)
                    {
                        DateTime fechaHoy = DateTime.Now;
                        DateTime fechaMesDespues = fechaHoy.AddMonths(1);//asigno un mes 
                        clienteEncontrado.FechaPago = fechaMesDespues;//a la fecha de pago
                        MessageBox.Show("Se ha pagado la totalidad de "+acumulado+"con la cuenta corriente, fecha a pagar: "+clienteEncontrado.FechaPago);
                        MessageBox.Show(unaFarmacia.TerminarVenta());// resto stock - bolsa 

                    }
                    //si limite es < que total    ->tener una variable temporal restar total acumulado- limite 

                    else
                    {
                        double restoEfectivo = acumulado - clienteEncontrado.LimiteCredito;
                        
                        DateTime fechaHoy = DateTime.Now;
                        DateTime fechaMesDespues = fechaHoy.AddMonths(1);//asigno un mes 
                        clienteEncontrado.FechaPago = fechaMesDespues;//a la fecha de pago
                        MessageBox.Show("Se ha pagado " + clienteEncontrado.LimiteCreditoOriginal  + "con la cuenta corriente, fecha a pagar: " + clienteEncontrado.FechaPago+ " el resto a pagar en efectivo es de: "+restoEfectivo);
                        MessageBox.Show(unaFarmacia.TerminarVenta());// resto stock - bolsa 


                    }
                    string rutaReceta="";
                    foreach (LoteRemedios loteBolsa in unaFarmacia.ListaBolsaDeCompras)
                    {
                        if (loteBolsa.Receta)
                        {
                            rutaReceta= loteBolsa.RutaReceta.ToString();
                        }
                    }
                    Venta unaVenta;
                    if (rutaReceta == "")
                    {
                        //crear objeto venta
                         unaVenta = new Venta(clienteEncontrado, DateTime.Now, unaFarmacia.ListaBolsaDeCompras);

                    }
                    else
                    {
                        //crear objeto venta
                         unaVenta = new Venta(clienteEncontrado, DateTime.Now, unaFarmacia.ListaBolsaDeCompras,rutaReceta);

                    }
                    //mandarla a farmacia a guardar
                    unaFarmacia.AgregarVenta(unaVenta);

                }

               



            }
            else
            {
                //paga en efectivo
                double acumulado = 0;
                foreach (LoteRemedios loteBolsa in unaFarmacia.ListaBolsaDeCompras)
                {
                    acumulado = (loteBolsa.Unidades * loteBolsa.Precio) + acumulado;
                }
                MessageBox.Show("Se ha pagado en efectivo un total de: " + acumulado.ToString());
                MessageBox.Show(unaFarmacia.TerminarVenta());

                //crear venta
               // Venta unaVenta = new Venta( DateTime.Now, unaFarmacia.ListaBolsaDeCompras);
                string rutaReceta = "";
                foreach (LoteRemedios loteBolsa in unaFarmacia.ListaBolsaDeCompras)
                {
                    if (loteBolsa.Receta)
                    {
                        rutaReceta = loteBolsa.RutaReceta.ToString();
                    }
                }
                Venta unaVenta;
                if (rutaReceta == "")
                {
                    //crear objeto venta
                    unaVenta = new Venta( DateTime.Now, unaFarmacia.ListaBolsaDeCompras);

                }
                else
                {
                    //crear objeto venta
                    unaVenta = new Venta( DateTime.Now, unaFarmacia.ListaBolsaDeCompras, rutaReceta);

                }

                //mandarla a farmacia a guardar
                unaFarmacia.AgregarVenta(unaVenta);

            }

            
            this.Close();
        }

        private void btn_ComprobarCliente_Click(object sender, EventArgs e)
        {
            if(cb_clientes.Text == "Consumidor Final")
            {
                MessageBox.Show("El cliente es consumidor final y no tiene cuenta.");
                FPreguntaCliente unaVentaPregunta= new FPreguntaCliente();
                if(unaVentaPregunta.ShowDialog() == DialogResult.OK)
                {
                    FNuevoCliente unaVentaCliente = new FNuevoCliente(unaFarmacia);
                    if(unaVentaCliente.ShowDialog() == DialogResult.OK)
                    {
                        //no esta vacio, simplemente aqui deberia ir un mensaje de cliente creado exitosamente pero se encargan de esto en otro lugar xD

                    }
                }
                //desbloquear boton terminar venta
                btn_terminarVenta.Enabled = true;
            }
            else
            {
                string combobox = cb_clientes.Text;
                string[] partes = combobox.Split('-');//separo en partes con el "-"
                int idBuscado = Convert.ToInt32( partes[0].Trim()); //guardo el id quitando los espacios(trim)
                foreach (Cliente ClienteStock in unaFarmacia.Clientes)
                {
                    if (ClienteStock.Id == idBuscado)
                    {
                        //verificar si tiene fecha de pago, si NO tiene hacer.. desbloquear boton terminar venta
                        DateTime fechaBandera = new DateTime(2000, 01, 01);
                        if (ClienteStock.FechaPago == fechaBandera)
                        {
                            btn_terminarVenta.Enabled = true;
                            MessageBox.Show("El limite de este cliente es: " + ClienteStock.LimiteCredito + " y no adeuda nada");
                        }
                        else
                        {
                            if (ClienteStock.FechaPago > DateTime.Now)
                            {
                                // si tiene pero no esta vencida hacer..desbloquear boton terminar venta
                                btn_terminarVenta.Enabled = false;
                                MessageBox.Show("El limite de este cliente es: " + ClienteStock.LimiteCredito+ " adeuda pero no esta vencido, su fecha de vencimiento es: "+ClienteStock.FechaPago);
                            }
                            else
                            {
                                //si tiene fecha de pago y esta vencida.. mensaje de venta cancelada debe abonar lo adeudado

                                btn_terminarVenta.Enabled = false;
                                MessageBox.Show("ESTE CLIENTE ADEUDA Y NECESITA PAGAR PARA REALIZAR LA VENTA SU VENCIMIENTO FUE "+ClienteStock.FechaPago+ " y adeuda un total de: "+(ClienteStock.LimiteCreditoOriginal - ClienteStock.LimiteCredito));
                            }
                        }
                        
                    }


                        


            }


            }
            
        }

        private void btn_PagarDeuda_Click(object sender, EventArgs e)
        {
            if (cb_clientes.Text == "Consumidor Final")
            {
                MessageBox.Show("El cliente es consumidor final y no tiene cuenta.");
                
            }
            else
            {
                string combobox = cb_clientes.Text;
                string[] partes = combobox.Split('-');//separo en partes con el "-"
                int idBuscado = Convert.ToInt32(partes[0].Trim()); //guardo el id quitando los espacios(trim)
                foreach (Cliente ClienteStock in unaFarmacia.Clientes)
                {
                    if (ClienteStock.Id == idBuscado)
                    {
                        MessageBox.Show("El cliente pago un total de: " + (ClienteStock.LimiteCreditoOriginal - ClienteStock.LimiteCredito));
                        ClienteStock.LimiteCredito = ClienteStock.LimiteCreditoOriginal;
                        
                    }

                }


            }
        }
    }
}
