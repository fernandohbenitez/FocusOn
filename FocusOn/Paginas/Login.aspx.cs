using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FocusOn.Paginas
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public bool LoginAutenticador(string nm_nome, string senha)
        {
            bool acesso;
            acesso = false;
            try
            {
                
                var sql = new SqlCommand();
                sql.Connection = Conexao.connection;
                sql.CommandText = "SELECT nm_usuario,senha from Usuarios where nm_usuario = @usuario and senha = @senha";
                sql.Parameters.AddWithValue("@usuario", nm_nome);
                sql.Parameters.AddWithValue("@senha", senha);
                Conexao.conectar();

                var dados = sql.ExecuteReader();

                while (dados.Read())
                {
                    string login = dados["nm_usuario"].ToString();
                    string sn = dados["senha"].ToString();
                    if ((nm_nome == login) & (senha == sn)){
                        acesso = true;
                    }
                }
               

            }
            catch (Exception)
            {
    
            }
            finally
            {
                Conexao.desconectar();    
            }
            return acesso;
        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            string nmNome = txtEmail.Text;
            string senha = txtSenha.Text;
            bool acesso = LoginAutenticador(nmNome, senha);
            if (acesso)
            {
                Response.Redirect("Inicio.aspx", true);
            }
        }
    }
}