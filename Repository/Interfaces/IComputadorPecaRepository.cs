using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{
    public interface IComputadorPecaRepository
    {
        int Inserir(ComputadorPeca computadorPeca);

        bool Alterar(ComputadorPeca computadorPeca);

        List<ComputadorPeca> ObterTodos(int quantidade, int pagina, string busca, string colunaOrdem, string coluna);

        ComputadorPeca ObterPeloId(int id);

        bool Apagar(int id);
    }
}