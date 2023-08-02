using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Farmacia
{
    [Serializable]
    public class Proveedores
    {
        private string nombre;
        private string direccion;
        private string email;
        private int telefono;
        
        public Proveedores(string nombre,string direccion,string email, int telefono)
        {
            this.nombre=nombre;
            this.direccion=direccion;
            this.email=email;
            this.telefono=telefono;
        }

        // solo se puede obtener los datos, solo se puede escribir desde el constructor
        public string Nombre { get => nombre; }
        public string Direccion { get => direccion; }
        public string Email { get => email; }
        public int Telefono { get => telefono; }
    }
}
