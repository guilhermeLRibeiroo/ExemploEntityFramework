using Model;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories{
    public class PecaRepository : IPecaRepository
    {
        public bool Alterar(Peca peca)
        {
            throw new NotImplementedException();
        }

        public bool Apagar(int id)
        {
            throw new NotImplementedException();
        }

        public int Inserir(Peca peca)
        {
            throw new NotImplementedException();
        }

        public Peca ObterPeloId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Peca> ObterTodos(int quantidade, int pagina, string busca, string colunaOrdem, string ordem)
        {
            throw new NotImplementedException();
        }
    }
}
