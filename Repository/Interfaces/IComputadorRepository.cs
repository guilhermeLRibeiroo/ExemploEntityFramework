using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{
    interface IComputadorRepository
    {
        int Inserir(Computador computador);

        bool Alterar(Computador computador);

        List<Computador> ObterTodos(int quantidade, int pagina, string busca, string colunaOrdem, string coluna);

        Computador ObterPeloId(int id);

        bool Apagar(int id);
    }
}