// JavaScript Document
// Variáveis
// Aguardando página ser carregada

$(document).ready(function () {

	//Quando clicar em um botão, disparar um evento para esconder uma div
	$("#bt_Carregar").click(function () {

		$("#conteudo").fadeOut(500, function () {

			$(".carregar").fadeIn(500, function () {
				$.ajax({
					method: "POST",
					url: "servico.php",
					data: { codigo: 1 }
				}).done(function (retorno) {

					$("#conteudo").html(retorno);

					$(".carregar").fadeOut(500, function () {

						$("#conteudo").fadeIn(500);

					});
				})
			});
		});
	});
});
