var ObjVenda = new Object();

ObjVenda.CarregarQtdCarrinho = function () {
    $.ajax({
        type: "POST",
        url: "/api/GetAllCompraUsuario",
        dataType: "JSON",
        cache: false,
        async: true,
        success: function (data) {

            if (data) {
                $("#qtdCarrinho").html(data.length);
            } else {
                ObjetoAlerta.AlertarTela(3, "Não foi possível adicionar produto ao carrinho")
            }
        }
    });
}

ObjVenda.AddProdutoCarrinho = function (idProduto) {

    var nome = $("#nome_" + idProduto).val();
    var qtd = $("#qtd_" + idProduto).val();

    $.ajax({
        type: "POST",
        url: "/api/AdicionarProdutoCarrinho",
        dataType: "JSON",
        cache: false,
        async: true,
        data: {
            "id": idProduto, "nome": nome, "qtd": qtd
        },
        success: function (data) {

            if (data.sucesso) {
                ObjetoAlerta.AlertarTela(1, "Produto adicionado no carrinho")
                ObjVenda.CarregarQtdCarrinho();
            } else {
                ObjetoAlerta.AlertarTela(2, "Fazer Login")
            }
        }
    });
}

ObjVenda.CarregaProdutos = function (descricao) {
    $.ajax({
        type: 'GET',
        url: "/api/ListarProdutosComEstoque",
        dataType: "JSON",
        cache: false,
        async: true,
        data: { descricao: descricao },
        success: function (data) {

            ObjVenda.CarregarQtdCarrinho();
            var htmlConteudo = "";

            data.forEach(function (Entitie) {

                htmlConteudo += " <div class='col-xs-12 col-sm-4 col-md-4 col-lg-4'>";

                var idNome = "nome_" + Entitie.id;
                var idQtd = "qtd_" + Entitie.id;

                htmlConteudo += " </br> <label id='" + idNome + "' > Produto: " + Entitie.nome + "</label></br>";
               

                if (Entitie.url != null && Entitie.url != "" && Entitie.url != undefined) {
                    htmlConteudo += "<img width='200' heigth='100' src='" + Entitie.url + "'/><br/>" 
                }

                htmlConteudo += "<label>  Valor: " + Entitie.valor + "</label></br>";

                htmlConteudo += "Quantidade : <input type'number' value='1' id='" + idQtd + "'>";

                htmlConteudo += "<input type='button' onclick='ObjVenda.AddProdutoCarrinho(" + Entitie.id + ")' value ='Comprar'> </br> ";

                htmlConteudo += " </div>";

            });

            $("#DivVenda").html(htmlConteudo);
        }
    });

}

$(function () {
    ObjVenda.CarregaProdutos();
    $("#buscar").click(() => {
        var descricao = $("#descricao").val();
        ObjVenda.CarregaProdutos(descricao);
    })
})
