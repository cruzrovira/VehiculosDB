using System;
using System.Collections.Generic;
using System.Text;
using VehiculosDB.Core.Clases;

namespace VehiculosDB.Core.Dao
{
    internal interface IVehiculo
    {

        int insert(Vehiculos paVehiculo);
        bool update(Vehiculos paVehiculo);
        bool delete(int idVehiculo);
        Vehiculos? getById(int idVehiculo);
        List<Vehiculos> getAll(string filtro = "");
    }
}
