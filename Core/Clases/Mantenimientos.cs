using System;
using System.Collections.Generic;
using System.Text;

namespace VehiculosDB.Core.Clases
{
    internal class Mantenimientos
    {
        private int idMantenimiento;
        private Vehiculos vehiculo;
        private DateTime fecha;
        private decimal costo;
        private string observaciones;
        private TiposMantenimiento tiposMantenimiento;

        public Mantenimientos() {
            Vehiculo = new Vehiculos();
            TiposMantenimiento = new TiposMantenimiento();
        }

        public int IdMantenimiento { get => idMantenimiento; set => idMantenimiento = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public decimal Costo { get => costo; set => costo = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public Vehiculos Vehiculo { get => vehiculo; set => vehiculo = value; }
        public TiposMantenimiento TiposMantenimiento { get => tiposMantenimiento; set => tiposMantenimiento = value; }

        // uso d clases anidadas 

        public int IdVehiculo { get => vehiculo.IdVehiculo; set => vehiculo.IdVehiculo = value; }
        public string Placa { get => vehiculo.Placa; set => vehiculo.Placa = value; } 
        public int IdTipoMantenimiento { get => tiposMantenimiento.IdTipoMantenimiento; set => tiposMantenimiento.IdTipoMantenimiento = value; }
        public string NombreTipo { get => tiposMantenimiento.NombreTipo; set => tiposMantenimiento.NombreTipo = value; }
    }
}
