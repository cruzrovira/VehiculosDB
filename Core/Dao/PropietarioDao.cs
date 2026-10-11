using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using VehiculosDB.Core.Clases;
using VehiculosDB.Core.Lib;

namespace VehiculosDB.Core.Dao
{
    internal class PropietarioDao : Cnn, IPropietarioDao
    {
        SqlConnection Con = null;
        SqlCommand command = null;

        public bool delete(int idPropietario)
        {
            throw new NotImplementedException();
        }

        public List<Propietario> getAll(string filtro = "")
        {
           var lista = new List<Propietario>();
             SqlDataReader rd = null;

            try {
                Con = OpenDb();
                string sql = @"select IdPropietario ,Nombre, Apellido, DUI, Telefono, Direccion
                            from Propietarios /**where**/ order by IdPropietario desc";

                if (!string.IsNullOrWhiteSpace(filtro)) {
                    sql = sql.Replace("/**where**/", "where Nombre like @f or Apellido like @f or DUI like @f");
                }
                else {
                    sql = sql.Replace("/**where**/", string.Empty);
                }

                command = new SqlCommand(sql, Con);

                if (!string.IsNullOrWhiteSpace(filtro))
                {
                    command.Parameters.Add("@f", SqlDbType.NVarChar, 120).Value = $"%{filtro.Trim()}%";
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

         public static Propietario Map(SqlDataReader rd)
        {
            return new Propietario
            (
               rd.GetInt32(0),
               rd.GetString(1),
               rd.GetString(2),
               rd.GetString(3),
               rd.IsDBNull(4) ? null : rd.GetString(4),
               rd.IsDBNull(5) ? null : rd.GetString(5)
            );
        }

        public Propietario getById(int idPropietario)
        {
            throw new NotImplementedException();
        }

        public int insert(Propietario paPropitario)
        {

            try
            {

                Con = OpenDb();
                command = new SqlCommand(@"insert into Propietarios (Nombre , Apellido, DUI, Telefono , Direccion) 
                                output inserted.IdPropietario values (@Nombre,@Apellido,@DUI,@Telefono,@Direccion);", Con);
                command.Parameters.Add("@Nombre", SqlDbType.NVarChar, 100).Value = paPropitario.Nombre;
                command.Parameters.Add("@Apellido", SqlDbType.NVarChar, 100).Value = paPropitario.Apellido;
                command.Parameters.Add("@DUI", SqlDbType.VarChar, 10).Value = paPropitario.Dui;
                command.Parameters.Add("@Telefono", SqlDbType.VarChar, 15).Value = (object?)paPropitario.Telefono ?? DBNull.Value;
                command.Parameters.Add("@Direccion", SqlDbType.NVarChar, 200).Value = (object?)paPropitario.Direccion ?? DBNull.Value;

                var id = command.ExecuteScalar();
                return Convert.ToInt32(id);
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {

                throw new ApplicationException("El DUI ya existe en la base de datos", ex);
            }
            catch (SqlException ex)
            {

                throw new ApplicationException("No se puede ingresar el propietario", ex);
            }
            finally
            {
                command?.Dispose();
                CloseDb();
            }
        }

        public bool update(Propietario paPropitario)
        {
            throw new NotImplementedException();
        }
    }
}
