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
    public partial class FimagenReceta : Form
    {

        public FimagenReceta(Venta unaVenta)
        {
            InitializeComponent();

            string ruta = unaVenta.FotoReceta1;
            pictureBox1.Image = Image.FromFile(ruta);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
