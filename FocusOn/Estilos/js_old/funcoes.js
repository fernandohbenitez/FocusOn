function Redimensiona() {
    var height = window.innerHeight;
    var width = window.innerWidth;
    document.getElementById('menu1').style.height = height + "px";
    document.getElementById('teste1').style.height = document.getElementById('menu1').style.height;
}

function pesquisacep(valor) {

    //Nova variável "cep" somente com dígitos.
    var cep = valor.replace(/\D/g, '');
    //Verifica se campo cep possui valor informado.
    if (cep != "") {

        //Expressão regular para validar o CEP.
        var validacep = /^[0-9]{8}$/;

        //Valida o formato do CEP.
        if (validacep.test(cep)) {
            
            //Preenche os campos com "..." enquanto consulta webservice.
            document.getElementById('txtLogradouro').value = "...";
           // document.getElementById('bairro').value = "...";
           // document.getElementById('cidade').value = "...";
            //document.getElementById('uf').value = "...";
            //document.getElementById('ibge').value = "...";

            //Cria um elemento javascript.
            var script = document.createElement('script');

            //Sincroniza com o callback.
            script.src = 'https://viacep.com.br/ws/' + cep + '/json/?callback=meu_callback';

            //Insere script no documento e carrega o conteúdo.
            document.body.appendChild(script);

        } //end if.
        else {
            //cep é inválido.
            limpa_formulário_cep();
            alert("Formato de CEP inválido.");
        }
    } //end if.
    else {
        //cep sem valor, limpa formulário.
        limpa_formulário_cep();
    }
}

