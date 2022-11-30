using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Data;
using Dapper;
using System.Data.SqlClient;

namespace DataAccessLibrary
{
    // This class provides the basic methods for connecting to the SQL Server asyncronously with the given connection string, query, and model
    // All services use this class to to query or execute SQL commands
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _config;

        // Set the default name of the database connection string 
        public string ConnectionStringName { get; set; } = "Default";

        // Constructor, initializes configuration field
        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
        }

        
        
        // Handles Read Operations
        public async Task<List<T>> LoadData<T, U>(string sql, U parameters)
        {
            // Gets the connection string for the database
            string? connectionString = _config.GetConnectionString(ConnectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                // Calls Dapper's asyncronous query method and passes it the SQL string created by the get method, and the model for any given object.
                var data = await connection.QueryAsync<T>(sql, parameters);

                // Return queried data as a list of its type
                return data.ToList();
            }
        }

        
        // Handles Create, Update, and Delete operations, see LoadData for details
        public async Task SaveData<T>(string sql, T parameters)
        {
            string? connectionString = _config.GetConnectionString(ConnectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                await connection.ExecuteAsync(sql, parameters);
            }
        }
    }
}
