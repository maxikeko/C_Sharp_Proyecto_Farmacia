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
    public partial class FimagenCasoUso : Form
    {
        public FimagenCasoUso()
        {
            InitializeComponent();

            string ruta = "C:/Users/Notebook Keko/Desktop/TP_Farmacia/TP_Farmacia/TP_Farmacia/casos de usos/casos de usos.png";
            pictureBox1.Image = Image.FromFile(ruta);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

        }
    }
}
