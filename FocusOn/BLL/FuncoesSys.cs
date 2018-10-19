using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace FocusOn
{
    public class FuncoesSys
    {
        public ViaCep buscaCep(String cep)
        {
            ViaCep v = new ViaCep();
            //URL DE CONSULTA
            string url = "https://viacep.com.br/ws/" + cep + "/xml/";

            DataSet dsRetornaEndereco = new DataSet();
            dsRetornaEndereco.ReadXml(url);

            v.cep = dsRetornaEndereco.Tables[0].Rows[0]["cep"].ToString();
            v.uf = dsRetornaEndereco.Tables[0].Rows[0]["uf"].ToString();
            v.logradouro = dsRetornaEndereco.Tables[0].Rows[0]["logradouro"].ToString();
            v.localidade = dsRetornaEndereco.Tables[0].Rows[0]["localidade"].ToString();
            v.bairro= dsRetornaEndereco.Tables[0].Rows[0]["bairro"].ToString(); 
            return v;
        }

    }
}