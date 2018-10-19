<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FocusOn.Paginas.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../Estilos/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../Estilos/css/bootstrap.css" rel="stylesheet" />
    <link href="../Estilos/css/bootstrap-login.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div>
                    <div class="form-login">
                        <h4>Bem Vindo !</h4>
                        <table>
                            <tr>
                                <td>
                                    <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server" Width="200px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox ID="txtSenha" CssClass="form-control" runat="server" Width="200px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button ID="btnEntrar" Text="Entrar" CssClass="btn btn-lg btn-primary btn-block btn-signin" runat="server" OnClick="btnEntrar_Click"></asp:Button>
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
