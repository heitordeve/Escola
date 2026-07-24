using Escola.Domain.Entities;
using Escola.Domain.Interface;

namespace Escola.Infra.Data.Repositories;

public class MatriculaRepository : IMatriculaRepository
{
    Task<Matricula> IMatriculaRepository.AddAsync(Matricula matricula)
    {
        throw new NotImplementedException();
    }

    Task<bool> IMatriculaRepository.DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    Task<List<Matricula>> IMatriculaRepository.GetAllAsync()
    {
        throw new NotImplementedException();
    }

    Task<Matricula> IMatriculaRepository.GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    Task<Matricula> IMatriculaRepository.UpdateAsync(Matricula matricula)
    {
        throw new NotImplementedException();
    }
}
