$(() => {
    //Nao $id pq ja esta sendo usado no apagar
    $idCategoria = -1;

    //obter todos
    $tabelaCategoria = $('#categoria-index').DataTable({
        ajax: "https://localhost:5001/categoria/obtertodos",
        serverSide: true,
        columns: [
            { data: 'id' },
            { data: 'nome' },
            {
                render: function (data, type, row) {
                return '<button class="btn btn-primary mr-2 botao-editar" data-id="' + row.id + '">Editar</button>\
                        <button class="btn btn-danger botao-apagar" data-id="' + row.id + '">Apagar</button>';
                }
            }
        ]
    });

    //botao salvar modal
    $('#categoria-botao-salvar').on('click', function () {
        $nome = $('#categoria-campo-nome').val();
        if ($idCategoria == -1) {
            salvar($nome);
        } else {
            editar($nome);
        }
    });

    //func cadastrar
    function salvar($nome) {
        $.ajax({
            url: 'https://localhost:5001/categoria/cadastrar',
            method: 'post',
            dataType: 'json',
            data: {
                'nome': $nome
            },
            success: function (data) {
                $('#modal-categoria').modal('hide');
                $tabelaCategoria.ajax.reload();
            },
            error: function (data) {
                alert('deu ruim');
            }
        })
    }

    //func editar 
    function editar($nome) {
        $.ajax({
            url: 'https://localhost:5001/categoria/alterar',
            method: 'post',
            dataType: 'json',
            data: {
                'id': $idCategoria,
                'nome': $nome
            },
            success: function (data) {
                $('#modal-categoria').modal('hide');
                $tabelaCategoria.ajax.reload();
                $idCategoria = -1;
            },
            error: function (data) {
                alert('deu ruim');
            }
        })
    }

    //botao apagar table
    $('.table').on('click', '.botao-apagar', function () {
        $id = $(this).data('id');

        $.ajax({
            url: 'https://localhost:5001/categoria/apagar?id=' + $id,
            method: 'get',
            success: function (data) {
                $tabelaCategoria.ajax.reload();
            },
            error: function (data) {
                alert("Não deu boa");
            }
        });
    });

    //botao editar table
    $('.table').on('click', '.botao-editar', function () {
        $idCategoria = $(this).data('id');

        $.ajax({
            url: 'https://localhost:5001/categoria/obterpeloid?id=' + $idCategoria,
            method: 'get',
            success: function (data) {
                $('#categoria-campo-nome').val(data.nome);
                $('#modal-categoria').modal('show');
            },
            error: function (data) {
                alert('Deu Ruim!')
            }
        });
    });
});