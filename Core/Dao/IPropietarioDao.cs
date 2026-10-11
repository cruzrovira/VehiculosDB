using System;
using System.Collections.Generic;
using System.Text;
using VehiculosDB.Core.Clases;

namespace VehiculosDB.Core.Dao
{
    internal interface IPropietarioDao
    {
        int insert(Propietario paPropitario);
        bool update(Propietario paPropitario);
        bool delete(int idPropietario);
        Propietario getById(int idPropietario);
        List<Propietario> getAll( string filtro ="");

    }
}
