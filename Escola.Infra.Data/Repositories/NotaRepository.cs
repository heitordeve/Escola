using Escola.Domain.Entities;
using Escola.Domain.Interface;

namespace Escola.Infra.Data.Repositories;

public class NotaRepository : INotaRepository
{
    Task<Nota> INotaRepository.AddAsync(Nota nota)
    {
        throw new NotImplementedException();
    }

    Task<bool> INotaRepository.DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    Task<List<Nota>> INotaRepository.GetAllAsync()
    {
        throw new NotImplementedException();
    }

    Task<Nota> INotaRepository.GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    Task<Nota> INotaRepository.UpdateAsync(Nota nota)
    {
        throw new NotImplementedException();
    }
}
