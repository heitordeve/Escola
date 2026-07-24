using Escola.Domain.Entities;

namespace Escola.Domain.Interface;

public interface IMatriculaRepository
{
    Task<Matricula> GetByIdAsync(int id);
    Task<List<Matricula>> GetAllAsync();
    Task<Matricula> AddAsync(Matricula matricula);
    Task<Matricula> UpdateAsync(Matricula matricula);
    Task<bool> DeleteAsync(int id);
}
