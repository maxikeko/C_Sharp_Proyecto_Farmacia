using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TP_Farmacia
{
    public partial class Form1 : Form
    {
        int nivelUser;
        Farmacia unaFarmacia;
        public Form1()
        {
            InitializeComponent();
            
            nivelUser = 2;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            unaFarmacia= new Farmacia();
            unaFarmacia.CargarDatos();

            string usuario = txt_usuario.Text;
            string contraseña = txt_contraseña.Text;

            if ((usuario == "admin") && (contraseña == "admin"))
            {
                nivelUser = 1;
            }
            else
            {
                if ((usuario == "vendedor1") && (contraseña == "vendedor1"))
                {
                    nivelUser = 2;
                }
                else
                {
                     MessageBox.Show("Usuario y/o contraseña invalido.");      //descomentar
                    nivelUser = 3;
                }
            }

            //nivelUser = 1;//comentar
            if ((nivelUser == 1) || (nivelUser == 2))
            {
                menuStrip1.Enabled = true;
                panelLogin.Enabled = false;
                panelLogin.Visible = false;

                if (nivelUser == 2)
                {
                    compraAProveedoresToolStripMenuItem.Enabled = false;
                }

            }
            if(nivelUser == 3)
            {
                menuStrip1.Enabled = false;
            }



        }

        private void compraAProveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FAgregarProveedor unaVentanaProveedor = new FAgregarProveedor(unaFarmacia);

            if (unaVentanaProveedor.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void verStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FStock unaVentanaStock = new FStock(unaFarmacia);
            unaVentanaStock.ShowDialog();
        }

        private void darDeBajaLoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FNuevoCliente unaVentanaCliente= new FNuevoCliente(unaFarmacia);
            if(unaVentanaCliente.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void verClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FVerClientes unaVentaClientes= new FVerClientes(unaFarmacia);
            unaVentaClientes.ShowDialog();
        }

        private void crearNuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FVenta unaVentanaVenta= new FVenta(unaFarmacia );
            if(unaVentanaVenta.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void verVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FVerVentas unaVentanaVerVentas= new FVerVentas(unaFarmacia);
            unaVentanaVerVentas.ShowDialog();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unaFarmacia.GuardarDatos();
        }

        private void nosotrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                
                string rutaArchivoHTML = "C:/Users/Notebook Keko/Desktop/TP_Farmacia/TP_Farmacia/TP_Farmacia/html/AcercaDe.html";

                
                Process.Start(rutaArchivoHTML);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el archivo HTML: " + ex.Message);
            }
        }

        private void preguntasFrecuentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                string rutaArchivoHTML = "C:/Users/Notebook Keko/Desktop/TP_Farmacia/TP_Farmacia/TP_Farmacia/html/PreguntasFecuentes.html";


                Process.Start(rutaArchivoHTML);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el archivo HTML: " + ex.Message);
            }
        }

        private void guiaDeUsoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FimagenCasoUso unaVentana = new FimagenCasoUso();
            unaVentana.ShowDialog();
        }

        private void importarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string linea="";
            List<String> listaString = new List<String>();
            StreamReader sr = new StreamReader("C:/Users/Notebook Keko/Desktop/importacion/archivo.txt");
             sr.ReadLine();
            while (linea != null)
            {

                linea = sr.ReadLine();
                listaString.Add(linea);
                //string[] parts = line.Split(';');
            }
            
            sr.Close();
            int contador = 1;
            string[] separados2;
            foreach(string unaLinea in listaString)
            {
                if(unaLinea != null)
                {

                    //List<String> separados = new List<String>();
                    separados2 = unaLinea.Split(';');
                    string[] tiempoSeparado = separados2[3].Split('-');
                    int[] tiemposeparadoINT = { Convert.ToInt32(tiempoSeparado[0].Trim()), Convert.ToInt32(tiempoSeparado[1].Trim()), Convert.ToInt32(tiempoSeparado[2].Trim()) };

                    ArrayList imagenes = new ArrayList();

                    imagenes.Add("C:/Users/Notebook Keko/Desktop/importacion/medicamento"+contador+".jpg");

                    

                    LoteRemedios unLoteimportado = new LoteRemedios(separados2[0].Trim(), separados2[1].Trim(), separados2[2].Trim(), new DateTime(tiemposeparadoINT[0], tiemposeparadoINT[1], tiemposeparadoINT[2]), Convert.ToInt32(separados2[4].Trim()), separados2[5].Trim(), imagenes, 0, new Proveedores(separados2[9], "asd@asd", "almafuerte", 111));
                    unLoteimportado.Foto = "C:/Users/Notebook Keko/Desktop/importacion/medicamento" + contador + ".jpg";
                    unLoteimportado.Precio = Convert.ToDouble( separados2[6].Trim());

                    string receta = separados2[7].Trim();
                    receta = receta.ToLower();
                    if (receta == "no")
                    {
                        unLoteimportado.Receta = false;
                    }
                    else
                    {
                        unLoteimportado.Receta = true;
                    }

                    unaFarmacia.AgregarLoteRemedios(unLoteimportado);

                    contador++;
                }

            } 
            
            


            

        }
    }
}
