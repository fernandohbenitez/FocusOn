<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="FocusOn.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <title>FocusOn - Home</title>
    <link rel="stylesheet" type="text/css" href="../Estilos/css/style_home.css"/>
    
    <script type="text/javascript" src="../estilo/js/funcoes.js"></script>

    <script type="text/javascript">

        function AbreTelaCadAluno() {

            document.getElementById('teste1').src = "CadastroAluno.aspx";
        }
        
    </script>



</head>

<body onload="Redimensiona()">
	
	    <div id="principal" >
		    <div class="menu" id="menu1">
			
			    <div class="logo">
				    <img src="/images/logo.png"/>
			    </div>
            
			    <div class="menuint">
				    <ul>

					    <img src="/images/aluno.png"/>
					
					    <li>
						    <a href="" class="alunos">Alunos</a>
						    <div class="submenu">

                                <a href="#" onclick='AbreTelaCadAluno()' target=""><div class="submenuitem"><img src="/images/listaralunos.png"/> Cadastrar Aluno</div></a>

							    <a href=""><div class="submenuitem"><img src="/images/consultaraluno.png"/>Consultar Aluno</div></a>

							    <a href=""><div class="submenuitem"><img src="/images/listaralunos.png"/>Listar Alunos</div></a>
						    </div>
					    </li>
                    
					    <img src="/images/financeiro.png"/>
					    <li>
						    <a href="" class="financeiro">Financeiro</a>
						    <div class="submenu">
							
						    </div>
					    </li>
					    <img src="/images/pendencia.png"/><li><a href="" class="pendencias">Pendências</a></li>
					    <img src="/images/relatorios.png"/><li><a href="" class="relatorios">Relatórios</a></li>
					    <img src="/images/configuracao.png"/><li><a href="" class="configuracao">Configurações</a></li>
					    <img src="/images/interrogacao.png"/><li><a href="" class="duvidas">Dúvidas</a></li>
				    </ul>
			    </div>
                </div>
                            <iframe id="teste1" class="teste"  ></iframe>
            </div>
    
              

	</body>
</html>
