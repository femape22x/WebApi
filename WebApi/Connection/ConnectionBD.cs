using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace WebApi.Connection
{
    public class ConnectionBD
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("serve=127.0.0.1; database=formularios; Uid=root; pwd=;");

            conectar.Open();
            return conectar;
        }
    }
}