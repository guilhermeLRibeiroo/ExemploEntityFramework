using Model;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories{
    public class ComputadorRepository : IComputadorRepository
    {
        public bool Alterar(Computador computador)
        {
            throw new NotImplementedException();
        }

        public bool Apagar(int id)
        {
            throw new NotImplementedException();
        }

        public int Inserir(Computador computador)
        {
            throw new NotImplementedException();
        }

        public Computador ObterPeloId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Computador> ObterTodos(int quantidade, int pagina, string busca, string colunaOrdem, string coluna)
        {
            throw new NotImplementedException();
        }
    }
}
