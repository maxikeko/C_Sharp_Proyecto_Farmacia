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

namespace TP_Farmacia
{
    public partial class FImagenes : Form
    {
        Timer timer;
        int currentIndex;
        ArrayList listaImagenes;
        public FImagenes(int idFila, Farmacia unaFarmacia, int num)
        {
            InitializeComponent();

            //depende el numero es de donde se llama la ventana (muestra imagenes de lotes o clientes)
            if(num == 1)
            {
                ////traigo la lista de remedios 
                //List<LoteRemedios> lista = unaFarmacia.LotesRemedios;
                ////traigo el lote con el mismo id
                //LoteRemedios unlote = (LoteRemedios)lista[idFila - 1];
                ////lista de imagenes del lote
                //listaImagenes = unlote.Imagenes;

                //timer = new Timer();
                //timer.Interval = 3000;
                //timer.Tick += Timer_Tick;
                //currentIndex = 0;
                //timer.Start();

                foreach (LoteRemedios unlote in unaFarmacia.LotesRemedios)
                {
                    if (unlote.Id == idFila)
                    {

                        string ruta = unlote.Foto;
                        pictureBox1.Image = Image.FromFile(ruta);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }
            else
            {
                //traigo la lista de remedios 
                List<Cliente> lista = unaFarmacia.Clientes;
                //traigo el lote con el mismo id
                foreach (Cliente unCliente in lista)
                {
                    if(unCliente.Id == idFila)
                    {
                        
                        string ruta = unCliente.Foto;
                        pictureBox1.Image = Image.FromFile(ruta);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }

               
            }

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (currentIndex < listaImagenes.Count)
            {
                // Realizar una acción con el elemento actual del ciclo
                pictureBox1.Image = Image.FromFile((String)listaImagenes[currentIndex]);

                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                currentIndex++;
            }
            else
            {
                // Si ya se completaron todas las iteraciones, detener el Timer
                timer.Stop();
            }
        }
    }
}
