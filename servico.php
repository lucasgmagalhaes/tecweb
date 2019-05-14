<?php

if(empty($_POST['codigo'])){

    echo "Informe um código do funcionário";

} else {

    $codigo = $_POST['codigo'];


$url_funcionario = [
    'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTfpHyaoQyXOGqR51YTP
    a0-rokaDh9GgmTpHo8zOwaAPgXz-1EZ'
];

$url_empresa = [
  'http://www.osul.com.br/wp-content/uploads/2018/10/portalmixcrosss.jpg'
];

$cargos = ['Financeiro', 'Marketing', 'Comercial', 'Diretoria'];

    echo "<img src='".$url_funcionario[$codigo - 1 ]. "' width='200'>";
    echo "<img src='".$url_empresa[$codigo - 1 ]. "' width='200'>";
    echo "<br> Setor: ".$cargos[$codigo - 1 ];
}

?>

<html>
    <head>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.0/jquery.min.js"></script>
</head>
    </head>
    <body>

    </body>
</html>


<script>

</script>