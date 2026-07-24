using Escola.Domain.Entities;
using Escola.Domain.Interface;

namespace Escola.Infra.Data.Repositories;

public class TurmaRepository : ITurmaRepository
{
    Task<Turma> ITurmaRepository.AddAsync(Turma turma)
    {
        throw new NotImplementedException();
    }

    Task ITurmaRepository.DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    Task<List<Turma>> ITurmaRepository.GetAllAsync()
    {
        throw new NotImplementedException();
    }

    Task<Turma> ITurmaRepository.GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}
