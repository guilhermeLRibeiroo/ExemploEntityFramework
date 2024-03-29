using Microsoft.EntityFrameworkCore;
using Model;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories{
    public class ComputadorRepository : IComputadorRepository
    {
        public SystemContext context;

        public ComputadorRepository(SystemContext context)
        {
            this.context = context;
        }

        public bool Alterar(Computador computador)
        {
            computador.RegistroAtivo = true;
            context.Computadores.Update(computador);
            return context.SaveChanges() == 1;
        }

        public bool Apagar(int id)
        {
            var computador = context.Computadores.FirstOrDefault(x => x.Id == id);

            if (computador == null)
                return false;

            computador.RegistroAtivo = false;

            context.Computadores.Update(computador);

            return context.SaveChanges() == 1;
        }

        public int Inserir(Computador computador)
        {
            computador.RegistroAtivo = true;
            context.Computadores.Add(computador);
            context.SaveChanges();
            return computador.Id;
        }

        public Computador ObterPeloId(int id)
        {
            return context.Computadores
                .Include(x => x.Categoria)
                .FirstOrDefault(x => x.Id == id);
        }

        public List<Computador> ObterTodos()
        {
            return context.Computadores
                .Include(x => x.Categoria)
                .Where(x => x.RegistroAtivo)
                .ToList();
        }
    }
}
