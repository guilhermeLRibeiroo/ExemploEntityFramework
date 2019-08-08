using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{
    public interface IComputadorPecaRepository
    {
       
        int Relacionar(ComputadorPeca computadorPeca);

        bool Apagar(int idComputador);

        List<ComputadorPeca> ObterTodosPeloIdComputador(int idComputador);

        ComputadorPeca ObterPeloId(int idComputador);
    }
}