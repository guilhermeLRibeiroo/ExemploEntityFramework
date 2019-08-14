$(function () {
    $idComputador = $('#computador-id').val();

    $('#computador-editar-categoria').select2({
        ajax: {
            url: '/categoria/obtertodosselect2',
            dataType: 'json'
        }
    });

    $("#computador-editar-salvar").on('click', function () {
        $nome = $("#computador-editar-nome").val();
        $preco = $("#computador-editar-preco").val();
        $idCategoria = $('#computador-editar-categoria').val(); 
        $.ajax({
            url: '/computador/alterar',
            method: 'post',
            data: {
                id: $idComputador,
                nome: $nome,
                preco: $preco,
                IdCategoria: $idCategoria
            },
            success: function (data) {
                console.log('alterado')
            },
            error: function (data) {
                alert('não foi possivel alterar');
            }
        });
    });
});