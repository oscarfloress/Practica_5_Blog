using System;
using MySql.Data.MySqlClient;

namespace Practica_5
{
    public class MySql
    {
        protected MySqlConnection myConnection;

        public MySql()
        {
        }

        protected void abrirConexion()
        {
            string connectionString =
            "Server=localhost;" +
            "Database=blog;" +
            "User ID=root;" +
            "Password=root;" +
            "Pooling=false;";
            this.myConnection = new MySqlConnection(connectionString);
            this.myConnection.Open();
        }
        protected void cerrarConexion()
        {
            this.myConnection.Close();
            this.myConnection = null;
        }
    }
}
