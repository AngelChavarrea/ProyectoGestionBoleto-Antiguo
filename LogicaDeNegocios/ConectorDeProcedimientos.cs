﻿
using Datos;
using MySqlConnector;
using System;

namespace LogicaDeNegocios
{
   
    class ConectorDeProcedimientos
    {
  
        public MySqlCommand ConectarProcedimiento(string Procedimientos, MySqlConnection mySqlConnection)
        {
            MySqlCommand mySqlCommand;
            mySqlCommand = new MySqlCommand(Procedimientos, mySqlConnection);
            mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            return mySqlCommand;
        }
    }
}
