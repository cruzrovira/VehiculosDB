using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using VehiculosDB.Core.Clases;
using VehiculosDB.Core.Lib;

namespace VehiculosDB.Core.Dao
{
    internal class VehiculoDao : Cnn, IVehiculo
    {

        SqlConnection Con = null;
        SqlCommand command = null;
        public bool delete(int idVehiculo)
        {
            throw new NotImplementedException();
        }

        public List<Vehiculos> getAll(string filtro = "")
        {

            var lista = new List<Vehiculos>();
            SqlDataReader rd = null;

            try {
                Con =OpenDb();
                string sql = @" SELECT Vehiculos.IdVehiculo, Vehiculos.Placa, Vehiculos.Modelo, Vehiculos.Anio, Vehiculos.Color,
                                   Marcas.IdMarca, Marcas.NombreMarca,
                                   Propietarios.IdPropietario, Propietarios.DUI,
                                   TiposCarro.IdTipoCarro, TiposCarro.NombreTipo
                            FROM Vehiculos
                            INNER JOIN Marcas ON Vehiculos.IdMarca = Marcas.IdMarca
                            INNER JOIN Propietarios ON Vehiculos.IdPropietario = Propietarios.IdPropietario
                            INNER JOIN TiposCarro ON Vehiculos.IdTipoCarro = TiposCarro.IdTipoCarro
                            /**where**/
                            order by Vehiculos.IdVehiculo DESC;";
                if (!string.IsNullOrWhiteSpace(filtro))
                {

                    sql = sql.Replace("/**where**/", "WHERE Vehiculos.Placa like @f OR Marcas.NombreMarca like @f OR  Propietarios.DUI LIKE @f OR  TiposCarro.NombreTipo LIKE @f ");
                }
                else {
                    sql = sql.Replace("/**where**/", string.Empty);
                }

                command = new SqlCommand(sql, Con);

                if (!string.IsNullOrWhiteSpace(filtro))
                { 
                    command.Parameters.Add("@f", SqlDbType.NVarChar,120 ).Value = $"%{filtro}%";
                
                }

                rd = command.ExecuteReader();

                while (rd.Read()) {
                    lista.Add(Map(rd));
                
                }

            }
            catch ( SqlException ex) { 
            
                throw new ApplicationException("No fue posible consultar los vehículos", ex);
            }
            finally { 
                rd?.Close();
                command?.Dispose();
                CloseDb();
            }

            return lista;


        }

        private Vehiculos Map(SqlDataReader rd)
        {
            return new Vehiculos
            {

                IdVehiculo = rd.GetInt32(0),
                Placa = rd.GetString(1),
                Modelo = rd.GetString(2),
                Anio = rd.GetInt32(3),
                Color = rd.GetString(4),
                IdMarca = rd.GetInt32(5),
                NombreMarca = rd.GetString(6),
                IdPropietario = rd.GetInt32(7),
                DUI = rd.GetString(8),
                IdTipoCarro = rd.GetInt32(9),
                NombreTipo = rd.GetString(10)

            };
        }

        public Vehiculos? getById(int idVehiculo)
        {
            throw new NotImplementedException();
        }

        public int insert(Vehiculos paVehiculo)
        {
            throw new NotImplementedException();
        }

        public bool update(Vehiculos paVehiculo)
        {
            throw new NotImplementedException();
        }
    }
}
