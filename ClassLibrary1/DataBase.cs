using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ClassLibrary1
{
    public class DataBase
    {
        List<User> _user;
        List<Account> _account;
        List<Role> _role;
        List<AccountRole> _accountRole;
        public static MySqlConnection DataBaseConnect(string host, int port, string database, string username, string password)
        {
            String connString = "Server=" + host + ";Database=" + database + ";port=" + port + ";User Id=" + username + ";password=" + password;
            MySqlConnection conn = new MySqlConnection(connString);
            return conn;
        }

        public static void DataBaseExport(MySqlConnection connect, string table)
        {
            string queryString =
                $"SELECT * FROM " + table;  
            //MySqlDataAdapter adapter = new MySqlDataAdapter(queryString, connect);
        }

        public static List<string> DataBaseImport(MySqlConnection connect, string table)
        {
            var  command = connect.CreateCommand();
            command.CommandText = $"SELECT * FROM " + table;
            connect.Open();
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            var dataList = new List<string>();
            /*
             ...
             */
            return dataList;
        }
    }
}
