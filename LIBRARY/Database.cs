using MySql.Data.MySqlClient;
using System;
using System.Data;

public class Database
{
    private static string connectionString = "Server=192.168.1.18;Database=LibraryDB;User=lmsummer;Password=lmsummer;";

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
