using Escola.Domain.Entities;

namespace Escola.Domain.Interface;

public interface ITurmaRepository
{
    Task<Turma> GetByIdAsync(int id);
    Task<List<Turma>> GetAllAsync();
    Task<Turma> AddAsync(Turma turma);
    Task<Turma> DeleteAsync(int id);
    Task<Turma> UpdateAsync(Turma turma);

}
