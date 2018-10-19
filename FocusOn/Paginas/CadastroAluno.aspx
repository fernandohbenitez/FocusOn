<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroAluno.aspx.cs" Inherits="FocusOn.CadastroAluno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>FocusOn - Cadastro de Aluno</title>
    <link rel="stylesheet" type="text/css" href="../Estilos/css/style_cadAluno.css" />
      
    <script type="text/javascript"> 
      
     
    </script>



</head>
<body>
    <form id="form1" runat="server">
        <div class="Principal">

            <div>
                <div>
                    <asp:Label CssClass="letras" runat="server">Nome</asp:Label>
                    <br />
                    <asp:TextBox placeholder="Nome" ID="txtNome" runat="server" Width="250px"></asp:TextBox>
                </div>

                <div>
                    <asp:Label CssClass="letras" runat="server"> Apelido</asp:Label>
                    <br />
                    <asp:TextBox placeholder="Como deseja ser chamado?" ID="txtSobrenome" runat="server" Width="230px"></asp:TextBox>
                </div>

                <div>
                    <asp:Label CssClass="letras" runat="server"> RG</asp:Label>
                    <br />
                    <asp:TextBox placeholder="Digite seu RG" ID="txtRG" runat="server" Width="200px"></asp:TextBox>
                </div>

                <div>
                    <asp:Label CssClass="letras" runat="server"> CPF</asp:Label>
                    <br />
                    <asp:TextBox placeholder="Digite seu CPF" ID="txtCPF" runat="server" Width="200px"></asp:TextBox>
                </div>

                <br />

                <div>
                    <asp:Label CssClass="letras" runat="server"> Telefone</asp:Label>
                    <br />
                    <asp:TextBox placeholder="(xx)" ID="txtDDD" runat="server" Width="25px"></asp:TextBox>
                    <asp:TextBox placeholder="9999-9999" ID="txtTel" runat="server" Width="130px"></asp:TextBox>
                </div>

                <div>
                    <asp:Label CssClass="letras" runat="server"> Celular</asp:Label>
                    <br />
                    <asp:TextBox placeholder="(xx)" ID="txtDDD2" runat="server" Width="25px"></asp:TextBox>
                    <asp:TextBox placeholder="99999-9999" ID="txtCel" runat="server" Width="130px"></asp:TextBox>
                </div>

                <div>
                    <asp:Label CssClass="letras" runat="server"> E-mail</asp:Label>
                    <br />
                    <asp:TextBox placeholder="" ID="txtEmail" runat="server" Width="200px"></asp:TextBox>
                    <asp:CheckBox CssClass="checkbox" ID="chkRecebeEmail" runat="server" Text="Deseja receber e-mail" />
                </div>


            </div>

            <asp:Label CssClass="is" runat="server">________________________________________________________________________________________________________________________</asp:Label>



            <div>
                <p />
                <div>
                    <asp:Label CssClass="letras" runat="server"> CEP</asp:Label>
                    <br />
                    <asp:TextBox placeholder="ex: 00000-000" ID="txtCep" runat="server" Width="120px" AutoPostBack="true"></asp:TextBox>
                </div>
                <div>
                    <asp:Label CssClass="letras" runat="server">Logradouro</asp:Label>
                    <br />
                    <asp:TextBox name="rua" placeholder="Endereço" ID="txtLogradouro" runat="server" Width="400px" Enabled="false"></asp:TextBox>
                </div>

                <div>
                    <asp:Label CssClass="letras" runat="server"> Nº</asp:Label>
                    <br />
                    <asp:TextBox ID="txtNum" runat="server" Width="80px"></asp:TextBox>
                </div>
                <div>
                    <asp:Label CssClass="letras" runat="server"> Complemento</asp:Label>
                    <br />
                    <asp:TextBox ID="txtComp" runat="server" Width="120px"></asp:TextBox>
                </div>
                <p />
                <div>
                    <asp:Label CssClass="letras" runat="server" Enabled="false">Cidade</asp:Label>
                    <br />
                    <asp:TextBox ID="txtCidade" runat="server" Width="200px" Enabled="false"></asp:TextBox>
                </div>

                <div>
                    <asp:Label CssClass="letras" runat="server">Bairro</asp:Label>
                    <br />
                    <asp:TextBox ID="txtBairro" runat="server" Width="200px" Enabled="false"></asp:TextBox>

                </div>

            </div>
            <asp:Label CssClass="is" runat="server">________________________________________________________________________________________________________________________</asp:Label>

            <div>
                <p />
                <div>

                    <asp:Label CssClass="letras" runat="server">Escolaridade</asp:Label>
                    <br />
                    <asp:DropDownList id="ddlEscolaridade" CssClass="combo" runat="server">
                        <asp:ListItem Text="Selecione.." Value="" />
                    </asp:DropDownList>
                </div>
                <div>
                    <asp:Label CssClass="letras" runat="server">Curso de Interesse</asp:Label>
                    <br />
                    <asp:DropDownList CssClass="combo" runat="server" ID="ddlCurso">
                    </asp:DropDownList>
                </div>
                <br />

                <div>
                    <br />
                    <asp:Label CssClass="letras" runat="server">Observações</asp:Label>
                    <br />
                    <textarea id="txtAreaObs" class="CampoTextoObs" cols="20" rows="2"></textarea>
                    <br />
            <asp:Button  CssClass="botao" ID="btnCadastrar" runat="server" Text="Salvar" OnClick="btnCadastrar_Click" />
    <asp:Button CssClass="botao" ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
    <asp:Button CssClass="botao" ID="btnExcluir" runat="server" Text="Excluir" />
                </div>
            </div>
        
        </div>

    </form>
</body>
</html>
