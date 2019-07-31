using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{
    interface IContatoRepository
    {
        int Inserir(Contato contato);

        bool Alterar(Contato contato);

        List<Contato> ObterTodos(int quantidade, int pagina, string busca, string colunaOrdem, string coluna);

        Contato ObterPeloId(int id);

        bool Apagar(int id);
    }
}