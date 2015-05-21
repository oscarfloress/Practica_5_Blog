using System;
using MySql.Data.MySqlClient;

namespace Practica_5
{
    public class Entradas : MySql
    {
        public Entradas()
        {
        }

        public void insertarRegistroNuevo(string fecha, string autor, string titulo, string cuerpo)
        {
            this.abrirConexion();
            string sql = "INSERT INTO `entradas` (`fecha`, `autor`, `titulo`, `cuerpo`) VALUES ('" + fecha + "', '" + autor + "', '" + titulo + "', '" + cuerpo + "')";
            this.ejecutarComando(sql);
            this.cerrarConexion();
        }
        
        private int ejecutarComando(string sql)
        {
            MySqlCommand myCommand = new MySqlCommand(sql, this.myConnection);
            int afectadas = myCommand.ExecuteNonQuery();
            myCommand.Dispose();
            myCommand = null;
            return afectadas;
        }

    }
}