using System;
using System.Collections.Generic;
using System.Text;
using VehiculosDB.Core.Clases;

namespace VehiculosDB.Core.Dao
{
    internal interface IMantenimientos
    {
        int insert(Mantenimientos paMantenimiento);
        bool update(Mantenimientos paMantenimiento);
        bool delete(int idMantenimiento);
        Mantenimientos? getById(int idMantenimiento);
        List<Mantenimientos> getAll(string filtro = "");
    }
}
