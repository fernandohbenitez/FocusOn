<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultarAluno.aspx.cs" Inherits="FocusOn.ConsultarAluno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>FocusOn - Consultar Aluno</title>
    <link rel="stylesheet" type="text/css" href="../Estilos/css/style_consultaAluno.css" />

    <style type="text/css">
        .auto-style2 {
            width: 375px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">

        <table class="filtro" style="width:829px">
            <tr>
                <td class="auto-style2" >
                    <asp:Label CssClass="letras" runat="server">Nome: </asp:Label>
                    <asp:TextBox placeholder="Nome" ID="txtNome" runat="server" Width="250px"></asp:TextBox>
                </td>
                <td>
                    <asp:Label CssClass="letras" runat="server">Apelido: </asp:Label>
                    <asp:TextBox placeholder="Apelido" ID="txtSobrenome" runat="server" Width="230px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label CssClass="letras" runat="server">RG: </asp:Label>
                    <asp:TextBox placeholder="RG" ID="txtRG" runat="server" Width="200px"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label CssClass="letras" runat="server">Curso de Interesse: </asp:Label>
                    <asp:DropDownList CssClass="combo" runat="server" ID="ddlCurso" Width="150px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="margin-left:auto;margin-right:auto" class="auto-style2" dir="ltr">
                    
                    <asp:Button CssClass="botao" Text="Filtrar" runat="server" OnClick="Unnamed5_Click"/>
                </td>
            </tr>

        </table>
        <table>
                        <asp:GridView runat="server" AutoGenerateColumns="false" Width="100%" colum>
                <Columns>

                    <asp:TemplateField HeaderText="Id">
                        <ItemTemplate>
                            <label id="id_aluno">Teste</label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:BoundField HeaderText="Nome"/>
                    <asp:BoundField HeaderText="Apelido"/>
                    <asp:BoundField HeaderText="RG"/>
                    <asp:BoundField HeaderText="CPF"/>
                    <asp:BoundField HeaderText="DDD"/>
                    <asp:BoundField HeaderText="Telefone"/>
                    <asp:BoundField HeaderText="DDD"/>
                    <asp:BoundField HeaderText="Celular"/>
                    <asp:BoundField HeaderText="Email"/>
                </Columns>
            </asp:GridView>
        </table>
    </form>
</body>

</html>
