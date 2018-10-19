using FocusOn;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FocusOn
{
    public class AlunoDAO
    {

        public int CadastrarAluno(AlunoMDL aluno)
        {
            try
            {
                var cmd = new SqlCommand();
                cmd.Connection = Conexao.connection;
                cmd.CommandText = @"INSERT INTO Aluno(nome,apelido,rg,cpf,ddd_tel,tel,ddd_cel,cel,email,fl_recebe_email,cep,logradouro,num_endereco,complemento,cidade,bairro,user_cadastrou,dt_cadastrou)
                                            VALUES(@nome,@apelido,@rg,@cpf,@ddd_tel,@tel,@ddd_cel,@cel,@email,@fl_recebe_email,@cep,@logradouro,@num_endereco,@complemento,@cidade,@bairro,@user_cadastrou,@dt_cadastrou)";
                cmd.Parameters.AddWithValue("@nome", aluno.nome);
                cmd.Parameters.AddWithValue("@apelido", aluno.apelido);
                cmd.Parameters.AddWithValue("@rg", aluno.rg);
                cmd.Parameters.AddWithValue("@cpf", aluno.cpf);
                cmd.Parameters.AddWithValue("@ddd_tel", aluno.dddTel);
                cmd.Parameters.AddWithValue("@tel", aluno.tel);
                cmd.Parameters.AddWithValue("@ddd_cel", aluno.dddCel);
                cmd.Parameters.AddWithValue("@CEL", aluno.cel);
                cmd.Parameters.AddWithValue("@email", aluno.email);
                cmd.Parameters.AddWithValue("@fl_recebe_email", aluno.flRecebeEmail);
                cmd.Parameters.AddWithValue("@cep", aluno.cep);
                cmd.Parameters.AddWithValue("@logradouro", aluno.logradouro);
                cmd.Parameters.AddWithValue("@num_endereco", aluno.numEndereco);
                cmd.Parameters.AddWithValue("@complemento", aluno.complemento);
                cmd.Parameters.AddWithValue("@cidade", aluno.cidade);
                cmd.Parameters.AddWithValue("@bairro", aluno.bairro);
                cmd.Parameters.AddWithValue("@dt_cadastrou", DateTime.Now);
                cmd.Parameters.AddWithValue("@user_cadastrou", "ISEBEK");

                Conexao.conectar();
                //cmd.ExecuteReader();

                cmd.CommandText += @" SELECT Top 1 id_aluno from Aluno order by id_aluno DESC";
                int i =(int) cmd.ExecuteScalar();
                return i;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                
                Conexao.desconectar();
            }

        }

        public void AlterarAluno(AlunoMDL aluno)
        {
            try
            {
                var cmd = new SqlCommand();
                cmd.Connection = Conexao.connection;
                cmd.CommandText = @"INSERT INTO Aluno(nome,apelido,rg,cpf,ddd_tel,tel,ddd_cel,cel,email,fl_recebe_email,cep,logradouro,num_endereco,complemento,cidade,bairro,user_cadastrou,dt_cadastrou)
                                            VALUES(@nome,@apelido,@rg,@cpf,@ddd_tel,@tel,@ddd_cel,@cel,@email,@fl_recebe_email,@cep,@logradouro,@num_endereco,@complemento,@cidade,@bairro,@user_cadastrou,@dt_cadastrou)";
                cmd.Parameters.AddWithValue("@nome", aluno.nome);
                cmd.Parameters.AddWithValue("@apelido", aluno.apelido);
                cmd.Parameters.AddWithValue("@rg", aluno.rg);
                cmd.Parameters.AddWithValue("@cpf", aluno.cpf);
                cmd.Parameters.AddWithValue("@ddd_tel", aluno.dddTel);
                cmd.Parameters.AddWithValue("@tel", aluno.tel);
                cmd.Parameters.AddWithValue("@ddd_cel", aluno.dddCel);
                cmd.Parameters.AddWithValue("@CEL", aluno.cel);
                cmd.Parameters.AddWithValue("@email", aluno.email);
                cmd.Parameters.AddWithValue("@fl_recebe_email", aluno.flRecebeEmail);
                cmd.Parameters.AddWithValue("@cep", aluno.cep);
                cmd.Parameters.AddWithValue("@logradouro", aluno.logradouro);
                cmd.Parameters.AddWithValue("@num_endereco", aluno.numEndereco);
                cmd.Parameters.AddWithValue("@complemento", aluno.complemento);
                cmd.Parameters.AddWithValue("@cidade", aluno.cidade);
                cmd.Parameters.AddWithValue("@bairro", aluno.bairro);
                cmd.Parameters.AddWithValue("@dt_cadastrou", DateTime.Now);
                cmd.Parameters.AddWithValue("@user_cadastrou", "ISEBEK");

                Conexao.conectar();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

                Conexao.desconectar();
            }

        }


        public AlunoMDL RetornaAluno(int id)
        {
            AlunoMDL a = new AlunoMDL();
            try
            {
                var cmd = new SqlCommand();
                cmd.Connection = Conexao.connection;
                cmd.CommandText = @"SELECT * from Aluno WHERE id_aluno=@id";
                cmd.Parameters.AddWithValue("@id",id);

                Conexao.conectar();

                var dados = cmd.ExecuteReader();


                while (dados.Read())
                {
                    a.nome=dados["nome"].ToString();
                    a.apelido= dados["apelido"].ToString();
                    a.rg= dados["rg"].ToString();
                    a.cpf= dados["cpf"].ToString();
                    a.dddTel= dados["ddd_tel"].ToString();
                    a.tel= dados["tel"].ToString();
                    a.dddCel= dados["ddd_cel"].ToString();
                    a.cel= dados["cel"].ToString();
                    a.email= dados["email"].ToString();
                    a.flRecebeEmail=Convert.ToBoolean(dados["fl_recebe_email"].ToString());

                    a.cep= dados["cep"].ToString();
                    a.logradouro= dados["logradouro"].ToString();
                    a.numEndereco= dados["num_endereco"].ToString();
                    a.complemento= dados["complemento"].ToString();
                    a.cidade= dados["cidade"].ToString();
                    a.bairro= dados["bairro"].ToString();


                }
                return a;



            }

            catch (Exception)
            {
                throw;
            }
            finally
            {
                Conexao.desconectar();
            }

        }


        
        public List<EscolaridadeMDL> RetornaEscolaridades()
        {
            var lista = new List<EscolaridadeMDL>();
            try
            {
                var sql = new SqlCommand();
                sql.Connection = Conexao.connection;
                sql.CommandText = "SELECT id_escolaridade,desc_escolaridade FROM Escolaridade";
                Conexao.conectar();

                var escolaridade = sql.ExecuteReader();


                while (escolaridade.Read())
                {
                    var esc = new EscolaridadeMDL();
                    esc.descEscolaridade = escolaridade["desc_escolaridade"].ToString();
                    esc.idEscolaridade = Convert.ToInt32(escolaridade["id_escolaridade"].ToString());
                    lista.Add(esc);



                }
                return lista;



            }

            catch (Exception)
            {
                throw;
            }
            finally
            {
                Conexao.desconectar();
            }

        }

    }
}