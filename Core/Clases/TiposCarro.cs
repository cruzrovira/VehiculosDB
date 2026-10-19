using System;
using System.Collections.Generic;
using System.Text;

namespace VehiculosDB.Core.Clases
{
    internal class TiposCarro
    {
        private int idTipoCarro;
        private string nombreTipo;

        public int IdTipoCarro { get => idTipoCarro; set => idTipoCarro = value; }
        public string NombreTipo { get => nombreTipo; set => nombreTipo = value; }
    }
}
