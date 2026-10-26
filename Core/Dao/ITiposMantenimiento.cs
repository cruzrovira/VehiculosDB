using System;
using System.Collections.Generic;
using System.Text;
using VehiculosDB.Core.Clases;

namespace VehiculosDB.Core.Dao
{
    internal interface ITiposMantenimiento
    {
        int insert(TiposMantenimiento paTipoMantenimiento);
        bool update(TiposMantenimiento paTipoMantenimiento);
        bool delete(int idTipoMantenimiento);
        TiposMantenimiento? getById(int idTipoMantenimiento);
        List<TiposMantenimiento> getAll(string filtro = "");
    }
}
