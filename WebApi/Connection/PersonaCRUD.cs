using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Models;
using MySql.Data.MySqlClient;

namespace WebApi.Connection
{
    public class PersonaCRUD
    {
        public static int Agregar(Persona persona)
        {
            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(String.Format("Insert into personas(nombre, apellido, identificacion, direccion, correo, celular) values ('{0}','{1}','{2}','{3}','{4}','{5}')",
                persona.Nombre, persona.Apellido, persona.Identificacion, persona.Direccion, persona.Correo, persona.Celular), ConnectionBD.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }
    }
}