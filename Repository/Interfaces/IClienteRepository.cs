using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{
    interface IClienteRepository
    {
        int Inserir(Cliente cliente);

        bool Alterar(Cliente cliente);

        List<Cliente> ObterTodos(int quantidade, int pagina, string busca, string colunaOrdem, string coluna);

        Cliente ObterPeloId(int id);

        bool Apagar(int id);
    }
}