using System;
using System.Collections.Generic;
using System.Text;
using VehiculosDB.Core.Clases;

namespace VehiculosDB.Core.Dao
{
    internal interface IMarcas
    {
        int insert(Marcas paMarca);
        bool update(Marcas paMarca);
        bool delete(int idMarca);
        Marcas? getById(int idMarca);
        List<Marcas> getAll(string filtro = "");
    }
}
