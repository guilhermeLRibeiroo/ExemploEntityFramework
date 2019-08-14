$(function () {
    $('#computador-campo-categoria').select2({
        ajax: {
            url: '/categoria/obtertodosselect2',
            dataType: 'json'
        }
    });
});