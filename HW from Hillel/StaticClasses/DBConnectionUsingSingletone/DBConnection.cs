using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBConnectionUsingSingletone
{
    class DBConnection
    {
        private static DBConnection dbConnection;
        string datasource;
        string port;
        string username;
        string password;
        string query;

        private DBConnection(string datasource, string port, string username, string password, string query)
        {
            this.datasource = datasource;
            this.port = port;
            this.username = username;
            this.password = password;
            this.query = query;
        }

        public static DBConnection GetConnection(string datasource, string port, string username, string password, string query)
        {
            if(dbConnection==null)
            {
                dbConnection = new DBConnection(datasource, port, username, password, query);
                try
                {
                    MySqlConnection connection;
                    MySqlDataAdapter dataAdapter;
                    
                    string connectionString = String.Format($"datasource={datasource};port={port};username={username};password={password};");

                    connection = new MySqlConnection(connectionString);

                    dataAdapter = new MySqlDataAdapter(query, connection);

                    connection.Open();
                }
                catch (Exception ex)
                {
                }
            }
            return dbConnection;
        }
    }
}
