using Model;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories{
    public class ComputadorPecaRepository : IComputadorPecaRepository
    {
        public bool Alterar(ComputadorPeca computadorPeca)
        {
            throw new NotImplementedException();
        }

        public bool Apagar(int id)
        {
            throw new NotImplementedException();
        }

        public int Inserir(ComputadorPeca computadorPeca)
        {
            throw new NotImplementedException();
        }

        public ComputadorPeca ObterPeloId(int id)
        {
            throw new NotImplementedException();
        }

        public List<ComputadorPeca> ObterTodos(int quantidade, int pagina, string busca, string colunaOrdem, string ordem)
        {
            throw new NotImplementedException();
        }
    }
}
