$(function () {
    $tabelaPecas = $('#computador-pecas-index').DataTable({
        ajax: '/computadorpeca/obtertodos?idComputador=' + $idComputador,
        serverSide: true,
        columns: [
            { data: 'peca.nome' },
            { data: 'peca.preco' },
            {
                render: function (data, type, row) {
                    return "\
                        <button class='btn btn-danger botao-apagar'\
                                data-id='"+ row.id +"'>Apagar</button > ";
                }
            }
        ]
    });

    $('#modal-peca-relacionamento-peca').select2({
        ajax: {
            url: '/peca/obtertodosselect2',
            dataType: 'json'
        }
    });

    $('#modal-peca-relacionamento-salvar').on('click', function () {
        $idPeca = $('#modal-peca-relacionamento-peca').val();
        $.ajax({
            url: '/computadorpeca/relacionar',
            method: 'post',
            data: {
                idPeca: $idPeca,
                idComputador: $idComputador
            },
            success: function (data) {
                $tabelaPecas.ajax.reload();
                $('#modal-peca-relacionamento').modal('hide');
            },
            error: function (data, type, row) {
                alert('Não foi possivel relacionar');
            }
        });
    });
});