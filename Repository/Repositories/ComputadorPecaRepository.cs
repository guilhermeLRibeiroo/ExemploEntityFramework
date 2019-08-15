using Microsoft.EntityFrameworkCore;
using Model;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories{
    public class ComputadorPecaRepository : IComputadorPecaRepository
    {
        SystemContext context;

        public ComputadorPecaRepository(SystemContext context)
        {
            this.context = context;
        }

        public bool Apagar(int idComputador)
        {
            var computadorPeca = context.ComputadoresPecas.FirstOrDefault(x => x.Id == idComputador);

            if (computadorPeca == null)
                return false;

            computadorPeca.RegistroAtivo = false;
            context.ComputadoresPecas.Update(computadorPeca);
            return context.SaveChanges() == 1;
        }

        public ComputadorPeca ObterPeloId(int idComputador)
        {
            return context.ComputadoresPecas.FirstOrDefault(x => x.Id == idComputador);
        }

        public List<ComputadorPeca> ObterTodosPeloIdComputador(int idComputador)
        {
            return context.ComputadoresPecas
                .Include(x => x.Peca)
                .Where(x => x.IdComputador == idComputador).ToList();
        }

        public int Relacionar(ComputadorPeca computadorPeca)
        {
            context.ComputadoresPecas.Add(computadorPeca);
            context.SaveChanges();
            return computadorPeca.Id;
        }
    }
}
