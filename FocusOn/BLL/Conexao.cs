using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FocusOn
{
    public class Conexao
    {

        //Estou pegando a String de conexão de Web.Config. [ConexaoSqlServer] --> é o nome da conexão que eu dei em web.config
        public static String connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConexaoSqlServer"].ConnectionString;

        public static SqlConnection connection = new SqlConnection(connectionString);


        public static void conectar()
        {
            //Se a Conexão estiver fechada
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();  //Tentando abrir conexão com o banco.
            }
        }

        public static void desconectar()
        {
            //Se a Conexão estiver aberta
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();  //fechando a conexão com o banco.
            }
        }
    }
}