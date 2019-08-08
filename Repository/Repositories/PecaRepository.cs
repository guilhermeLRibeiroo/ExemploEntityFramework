using Model;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public class PecaRepository : IPecaRepository
    {
        public SystemContext context;

        public PecaRepository(SystemContext context)
        {
            this.context = context;
        }

        public bool Alterar(Peca peca)
        {
            peca.RegistroAtivo = true;
            context.Pecas.Update(peca);
            return context.SaveChanges() == 1;
        }

        public bool Apagar(int id)
        {
            var peca = context.Pecas.FirstOrDefault(x => x.Id == id);

            if (peca == null)
                return false;

            peca.RegistroAtivo = false;

            context.Pecas.Update(peca);

            return context.SaveChanges() == 1;
        }

        public int Inserir(Peca peca)
        {
            peca.RegistroAtivo = true;
            context.Pecas.Add(peca);
            context.SaveChanges();
            return peca.Id;
        }

        public Peca ObterPeloId(int id)
        {
            return context.Pecas.FirstOrDefault(x => x.Id == id);
        }

        public List<Peca> ObterTodos()
        {
            return context.Pecas.Where(x => x.RegistroAtivo).ToList();
        }
    }
}
