using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Text;

namespace VehiculosDB.Core.Lib
{
    internal class Cnn
    {
        private readonly SqlConnection _connection;

        public Cnn()
        {
           string cadena = ConfigurationManager.ConnectionStrings["sqlConn"].ConnectionString;
            _connection = new SqlConnection(cadena);
        }

        public SqlConnection OpenDb()
        {
            try
            {


                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();

                }
                return _connection;
            }
            catch (SqlException ex) {
                MessageBox.Show("Error al abrir la base de datos " + ex.Message ,
                    "Error de base de datos",
                    MessageBoxButtons.OK , 
                    MessageBoxIcon.Error);
                throw;

            }
        }


        public SqlConnection CloseDb()
        {
            try
            {


                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();

                }
                return _connection;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al cerrar la base de datos " + ex.Message,
                    "Error de base de datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                throw;

            }
        }
    }
}
