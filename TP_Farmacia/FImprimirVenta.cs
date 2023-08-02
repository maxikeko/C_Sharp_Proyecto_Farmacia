using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace TP_Farmacia
{
    public partial class FImprimirVenta : Form
    {
        Venta unaVenta;
        public FImprimirVenta(Venta unaVenta)
        {
            InitializeComponent();
            this.unaVenta = unaVenta;
            listBox1.Items.Clear();
            string nombre;
            if (unaVenta.NoCliente == "")
            {
                nombre = unaVenta.Cliente1.Nombre;
            }
            else
            {
                nombre = unaVenta.NoCliente;
            }
            listBox1.Items.Add("ID: " + unaVenta.Id);
            listBox1.Items.Add("Cliente: "+nombre);
            listBox1.Items.Add("Fecha de venta: " + unaVenta.FechaVenta1);
            listBox1.Items.Add("");
            listBox1.Items.Add("Productos: ");
            double acumulado=0;
            foreach (LoteRemedios unlote in unaVenta.RemediosVendidos1)
            {
                listBox1.Items.Add(unlote.MarcaComercial + " " + unlote.DenominacionGenerica + " cantidad: " + unlote.Unidades + " Precio: $" + (unlote.Unidades * unlote.Precio));
                acumulado = (unlote.Unidades * unlote.Precio)+ acumulado;
            }
            listBox1.Items.Add("");
            listBox1.Items.Add("TOTAL: "+ acumulado);





        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {

            GenerarPDF(listBox1);
            try
            {

                string rutaArchivoPDF = "C:/Users/Notebook Keko/Desktop/TP_Farmacia/TP_Farmacia/TP_Farmacia/pdf/archivo.pdf";


                Process.Start(rutaArchivoPDF);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el archivo HTML: " + ex.Message);
            }
        }

        static void GenerarPDF(ListBox listBox)
        {
            // Crear el documento PDF
            Document doc = new Document();
            // Establecer la ruta y nombre del archivo PDF
            string filePath = "C:/Users/Notebook Keko/Desktop/TP_Farmacia/TP_Farmacia/TP_Farmacia/pdf/archivo.pdf";

            // Crear un flujo de datos para escribir en el archivo PDF
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                // Vincular el flujo de datos con el documento PDF
                PdfWriter writer = PdfWriter.GetInstance(doc, fs);

                // Abrir el documento PDF para escritura
                doc.Open();

                // Agregar el contenido del ListBox al documento PDF
                foreach (var item in listBox.Items)
                {
                    doc.Add(new Paragraph(item.ToString()));
                }

                // Cerrar el documento PDF
                doc.Close();
            }
        }

    }
}
