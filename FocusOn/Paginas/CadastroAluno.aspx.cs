using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FocusOn;

namespace FocusOn
{
    public partial class CadastroAluno : System.Web.UI.Page
    {
        FuncoesSys fs = new FuncoesSys();

        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)        
            {
                CarregaCombo();

                if (Request.QueryString["id_aluno"] != null)
                {
                    CarregaAluno();
                    btnCadastrar.Text = "Alterar";
                }
            }
            else
            {
                CarregaDados_Cep();
            }
        }

        public void CarregaAluno()
        {
            int id = Convert.ToInt32(Request.QueryString["id_aluno"].ToString());
            AlunoDAO ad = new AlunoDAO();
            AlunoMDL a = new AlunoMDL();
            a=ad.RetornaAluno(id);

            txtNome.Text = a.nome;
            txtSobrenome.Text = a.apelido;
            txtRG.Text = a.rg;
            txtCPF.Text = a.rg;
            txtCep.Text = a.cep;
            txtLogradouro.Text = a.logradouro;
            txtNum.Text = a.numEndereco;
            txtComp.Text = a.complemento;
            txtCidade.Text = a.cidade;
            txtBairro.Text = a.bairro;
            txtEmail.Text = a.email;
            chkRecebeEmail.Checked = a.flRecebeEmail;

        }
        public void CarregaCombo()
        {

            //Carrega combo Cursos
            CursoDAO cd = new CursoDAO();
            ddlCurso.DataSource = cd.RetornaCursos();
            ddlCurso.DataTextField= "desc_curso";
            ddlCurso.DataValueField = "id_curso";
            ddlCurso.DataBind();

            //Carrega combo Escolaridade
            AlunoDAO ad = new AlunoDAO();
            ddlEscolaridade.DataSource = ad.RetornaEscolaridades();
            ddlEscolaridade.DataTextField = "desc_escolaridade";
            ddlEscolaridade.DataValueField = "id_escolaridade";
            ddlEscolaridade.DataBind();




        }
        public void CarregaDados_Cep()
        {
            String cep = "09812600";
            ViaCep v = new ViaCep();
            v = fs.buscaCep(cep);
            txtBairro.Text = v.bairro;
            txtCidade.Text = v.localidade;
            txtLogradouro.Text = v.logradouro;
        }


        public void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {

            AlunoDAO ad = new AlunoDAO();
            AlunoMDL a = new AlunoMDL();

            //Dados Básicos
            a.nome = txtNome.Text;
            a.apelido = txtSobrenome.Text;
            a.rg = txtRG.Text;
            a.cpf = txtCPF.Text;
            a.dddTel = txtDDD.Text;
            a.tel = txtTel.Text;
            a.dddCel = txtDDD2.Text;
            a.cel = txtCel.Text;
            a.flRecebeEmail = chkRecebeEmail.Checked;
            a.email = txtEmail.Text;
            //Endereço
            a.logradouro = txtLogradouro.Text;
            a.cidade = txtCidade.Text;
            a.bairro = txtBairro.Text;
            a.cep = txtCep.Text;
            a.complemento = txtComp.Text;
            a.numEndereco = txtNum.Text;

            //Gravar aluno
            if (btnCadastrar.Text == "Alterar")
            {

            }
            else
            {
                int id_aluno=ad.CadastrarAluno(a);
                if (id_aluno > 0)
                {
                    Response.Write("<script>alert('Aluno Cadastrado com Sucesso !!')</script>");
                    btnCadastrar.Text = "Alterar";
                }

            }
            

            
        }
    }
}