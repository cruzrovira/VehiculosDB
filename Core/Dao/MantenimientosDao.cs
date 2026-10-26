using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using VehiculosDB.Core.Clases;
using VehiculosDB.Core.Lib;

namespace VehiculosDB.Core.Dao
{
    internal class MantenimientosDao : Cnn, IMantenimientos
    {
        SqlConnection Con = null;
        SqlCommand command = null;
        public bool delete(int idMantenimiento)
        {
            throw new NotImplementedException();
        }

        public List<Mantenimientos> getAll(string filtro = "")
        {
           var lista = new List<Mantenimientos>();
            SqlDataReader rd = null;

            try { 
                Con = OpenDb();
                string sql = @"SELECT Mantenimientos.IdMantenimiento, Vehiculos.IdVehiculo, Vehiculos.Placa,
                                   Mantenimientos.Fecha, Mantenimientos.Costo, Mantenimientos.Observaciones,
                                   TiposMantenimiento.IdTipoMantenimiento, TiposMantenimiento.NombreTipo
                            FROM Mantenimientos
                            INNER JOIN Vehiculos ON Vehiculos.IdVehiculo = Mantenimientos.IdVehiculo
                            INNER JOIN TiposMantenimiento ON TiposMantenimiento.IdTipoMantenimiento = Mantenimientos.IdTipoMantenimiento
                            /**where**/
                            ORDER BY Mantenimientos.IdMantenimiento DESC;";
                if (!string.IsNullOrEmpty(filtro))
                {
                    sql = sql.Replace("/**where**/", "WHERE Vehiculos.Placa LIKE @f OR TiposMantenimiento.NombreTipo LIKE @f ");
                }
                else { 
                    sql = sql.Replace("/**where**/", string.Empty);
                
                }

                command = new SqlCommand(sql, Con);
                if (!string.IsNullOrEmpty(filtro)) {

                    command.Parameters.Add("@f",SqlDbType.NVarChar,120).Value = $"%{filtro}%";
                }

                rd = command.ExecuteReader();

                while (rd.Read()) {

                    lista.Add(Map(rd));
                }


            }
            catch (Exception ex)
            {
                throw new ApplicationException("No fue posible consultar los mantenimientos: " + ex.Message);
            }
            finally {
                rd?.Close();
                command?.Dispose();
                CloseDb();

            }
            return lista;
        }

        private Mantenimientos Map(SqlDataReader rd)
        {
            return new Mantenimientos
            {
                IdMantenimiento = rd.GetInt32(0),
                IdVehiculo = rd.GetInt32(1),
                Placa = rd.GetString(2),
                Fecha = rd.GetDateTime(3),
                Costo = rd.GetDecimal(4),
                Observaciones = rd.GetString(5),
                IdTipoMantenimiento = rd.GetInt32(6),
                NombreTipo = rd.GetString(7)
            };

        }

        public Mantenimientos? getById(int idMantenimiento)
        {
            throw new NotImplementedException();
        }

        public int insert(Mantenimientos paMantenimiento)
        {
            try { 
                Con=OpenDb();
                command = new SqlCommand(@"insert into Mantenimientos(IdVehiculo, Fecha, Costo, Observaciones , IdTipoMantenimiento)
	                                    output inserted.IdMantenimiento
	                                     Values(@IdVehiculo,@Fecha,@Costo,@Observaciones,@IdTipoMantenimiento)", Con);
                command.Parameters.Add("@IdVehiculo",SqlDbType.Int).Value=paMantenimiento.IdVehiculo;
                command.Parameters.Add("@Fecha",SqlDbType.Date).Value=paMantenimiento.Fecha;
                command.Parameters.Add("@Costo",SqlDbType.Decimal).Value=paMantenimiento.Costo;
                command.Parameters.Add("@Observaciones",SqlDbType.NVarChar,200).Value=paMantenimiento.Observaciones ?? (object)DBNull.Value;
                command.Parameters.Add("@IdTipoMantenimiento",SqlDbType.Int).Value=paMantenimiento.IdTipoMantenimiento;

               var id =  command.ExecuteScalar();
               return Convert.ToInt32(id);
            }
            catch (SqlException ex) {
                throw new ApplicationException("No fue posible insertar el mantenimiento: " + ex.Message);

            }
            finally {
                command?.Dispose();
                CloseDb();

            }
        }

        public bool update(Mantenimientos paMantenimiento)
        {
            throw new NotImplementedException();
        }
    }
}
