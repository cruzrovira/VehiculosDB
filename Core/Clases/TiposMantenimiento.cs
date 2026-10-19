using System;
using System.Collections.Generic;
using System.Text;

namespace VehiculosDB.Core.Clases
{
    internal class TiposMantenimiento
    {
        private int idTipoMantenimiento;
        private string nombreTipo;

        public int IdTipoMantenimiento { get => idTipoMantenimiento; set => idTipoMantenimiento = value; }
        public string NombreTipo { get => nombreTipo; set => nombreTipo = value; }
    }
}
