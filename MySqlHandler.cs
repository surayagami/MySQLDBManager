using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
    
namespace MySqlHandler
{
    public class MySqlHandler
    {
        MySqlConnection connection;
        string Server;
        string Port;
        string Database;
        string UserID;
        string Password;

        public MySqlHandler(string server, string port, string database, string userid, string password)
        {
            Server = server;
            Port = port;
            Database = database;
            UserID = userid;
            Password = password;


        }

    }
}