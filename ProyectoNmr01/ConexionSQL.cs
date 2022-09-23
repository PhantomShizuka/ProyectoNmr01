using System;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoNmr01
{
    internal class ConexionSQL
    {
        private static readonly string connectionString = "Data Source=.;Initial Catalog=Base;Integrated Security=True";

        public static DataTable FillData(string comandoSql, string catalog)
        {
            var dataTable = new DataTable();

            try
            {
                var sqlDataAdapter = new SqlDataAdapter(comandoSql, connectionString.Replace("Base", catalog));
                sqlDataAdapter.Fill(dataTable);
            }
            catch (Exception)
            {
                return null;
            }

            return dataTable;
        }
    }
}
