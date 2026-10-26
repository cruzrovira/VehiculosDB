using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using VehiculosDB.Core.Clases;
using VehiculosDB.Core.Lib;

namespace VehiculosDB.Core.Dao
{
    internal class MarcasDao : Cnn, IMarcas
    {
        SqlConnection Con = null;
        SqlCommand command = null;
        public bool delete(int idMarca)
        {
            try
            {
                Con = OpenDb();
                command = new SqlCommand(@"delete Marcas  where IdMarca = @id", Con);
                command.Parameters.Add("@id", SqlDbType.Int).Value = idMarca;
                return command.ExecuteNonQuery() == 1;
            }
            catch (SqlException ex) when (ex.Number == 547)
            {

                throw new ApplicationException("No se puede eliminar : La marca porque  esta asociada a un vehiculo", ex);

            }
            finally
            {
                command?.Dispose();
                CloseDb();
            }
        }

        public List<Marcas> getAll(string filtro = "")
        {
            var lista = new List<Marcas>();
            SqlDataReader rd = null;

            try
            {
                Con = OpenDb();
                string sql = @"select IdMarca, NombreMarca from Marcas 
                                    /**where**/ order by IdMarca";

                if (!string.IsNullOrWhiteSpace(filtro))
                {
                    sql = sql.Replace("/**where**/", "where NombreMarca like @f ");
                }
                else
                {
                    sql = sql.Replace("/**where**/", string.Empty);
                }

                command = new SqlCommand(sql, Con);

                if (!string.IsNullOrWhiteSpace(filtro))
                {
                    command.Parameters.Add("@f", SqlDbType.NVarChar, 100).Value = $"%{filtro.Trim()}%";
                }

                rd = command.ExecuteReader();

                while (rd.Read())
                {
                    lista.Add(Map(rd));
                }

            }
            catch (SqlException ex)
            {
                throw new ApplicationException("no pue posible consultar a los propietatios", ex);
            }
            finally
            {
                rd?.Close();
                command?.Dispose();
                CloseDb();
            }


            return lista;
        }

        private Marcas Map(SqlDataReader rd)
        {
            return new Marcas
            {
             IdMarca=  rd.GetInt32(0),
             NombreMarca=  rd.GetString(1)
            };
        }

        public Marcas? getById(int idMarca)
        {
            throw new NotImplementedException();
        }

        public int insert(Marcas paMarca)
        {
            throw new NotImplementedException();
        }

        public bool update(Marcas paMarca)
        {
            throw new NotImplementedException();
        }
    }
}
