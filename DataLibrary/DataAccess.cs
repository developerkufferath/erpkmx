using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;

namespace DataLibrary
{
    public class DataAccess : IDataAccess
    {

        public async Task<List<T>> LoadData<T, U>(string sql, U parametres, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                var rows = await connection.QueryAsync<T>(sql, parametres);
                return rows.ToList();
            }

        }


        public Task SaveData<T>(string sql, T parametres, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                return connection.ExecuteAsync(sql, parametres);
            }
        }
    }
}
