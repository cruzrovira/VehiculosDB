using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using VehiculosDB.Core.Clases;
using VehiculosDB.Core.Lib;

namespace VehiculosDB.Core.Dao
{
    internal class TiposMantenimientoDao : Cnn, ITiposMantenimiento
    {

        SqlConnection Con = null;
         SqlCommand command =null;
        public bool delete(int idTipoMantenimiento)
        { 
            throw new NotImplementedException();
        }

        public List<TiposMantenimiento> getAll(string filtro = "")
        {
            var lista = new List<TiposMantenimiento>();
            SqlDataReader rd = null;

            try
            {
                Con = OpenDb();
                string sql = @"select IdTipoMantenimiento, NombreTipo  from TiposMantenimiento
                                /**where**/
                                order by IdTipoMantenimiento DESC;";

                if (!string.IsNullOrWhiteSpace(filtro) ){
                    sql = sql.Replace("/**where**/", " where NombreTipo like @f");

                }
                else { 
                    sql = sql.Replace("/**where**/", string.Empty);

                }

                command = new SqlCommand(sql, Con);
                if (!string.IsNullOrWhiteSpace(filtro)) {
                    command.Parameters.Add("@f", SqlDbType.NVarChar, 120).Value = $"%{filtro}%";
                }

                rd= command.ExecuteReader();

                while (rd.Read()) {
                    lista.Add(Map(rd));
                }

            }
            catch (SqlException ex) {
                throw new ApplicationException("No due posible consultar los datos "+ex.Message);
            }
            finally { 
                rd?.Close();
                command?.Dispose();
                CloseDb();
            }

            return lista;
        }

        private TiposMantenimiento Map(SqlDataReader rd)
        {
           return new TiposMantenimiento()
           {
               IdTipoMantenimiento = rd.GetInt32(0),
               NombreTipo = rd.GetString(1)
           };   
        }

        public TiposMantenimiento? getById(int idTipoMantenimiento)
        {
            throw new NotImplementedException();
        }

        public int insert(TiposMantenimiento paTipoMantenimiento)
        {
            throw new NotImplementedException();
        }

        public bool update(TiposMantenimiento paTipoMantenimiento)
        {
            throw new NotImplementedException();
        }
    }
}
