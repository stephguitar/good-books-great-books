using MySql.Data.MySqlClient;
using System;
using System.Data;

public class Database
{
    private static string connectionString = "Server=127.0.0.1;Database=LibraryDB;User=root;Password=;";

    public static MySqlConnection GetConnection()
    {
        return new MySqlConnection(connectionString);
    }

    public static DataTable ExecuteQuery(string query)
    {
        using (MySqlConnection con = GetConnection())
        {
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                con.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
        }
    }
}
