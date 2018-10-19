using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FocusOn
{
    public class CursoDAO
    {

        public List<CursoMDL> RetornaCursos()
        {
            var lista = new List<CursoMDL>();
            try
            {
                var sql = new SqlCommand();
                sql.Connection = Conexao.connection;
                sql.CommandText = "SELECT id_curso,desc_curso FROM curso";
                Conexao.conectar();

                var cursos = sql.ExecuteReader();

                


                while (cursos.Read())
                {
                    var c = new CursoMDL();
                    c.idCurso=Convert.ToInt32(cursos["id_curso"].ToString());
                    c.descCurso = cursos["desc_curso"].ToString();
                    lista.Add(c);
                   


                }
                return lista;



            }            

            catch (Exception)
            {
                return lista;
            }
            finally
            {
                Conexao.desconectar();
            }

        }


    }
    }
