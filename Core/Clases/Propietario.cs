using System;
using System.Collections.Generic;
using System.Text;

namespace VehiculosDB.Core.Clases
{
    internal class Propietario
    {
        private int idPropietario;
        private string nombre;
        private string apellido;
        private string dui;
        private string telefono;
        private string direccion;

        public Propietario(int idPropietario, 
                string nombre, 
                string apellido, 
                string dui,
                string telefono,
                string direccion)
        {
            this.idPropietario = idPropietario;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dui = dui;
            this.telefono = telefono;
            this.direccion = direccion;
        }

        public int IdPropietario { get => idPropietario; set => idPropietario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Dui { get => dui; set => dui = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
