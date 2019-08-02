using Model;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories{
    public class ClienteRepository : IClienteRepository
    {
        public bool Alterar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public bool Apagar(int id)
        {
            throw new NotImplementedException();
        }

        public int Inserir(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Cliente ObterPeloId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ObterTodos(int quantidade, int pagina, string busca, string colunaOrdem, string ordem)
        {
            throw new NotImplementedException();
        }
    }
}
