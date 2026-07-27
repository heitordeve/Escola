using Escola.Application.DTOS.Nota;
using Escola.Application.DTOS.Turma;

namespace Escola.Application.Interdaces;

public interface ITurmaService
{
    Task<TurmaGetDTO> GetByIdAsync(int id);
    Task<List<TurmaGetDTO>> GetAllAsync();
    Task<TurmaGetDTO> AddAsync(TurmaPostDTO turmaPostDto);
    Task<TurmaGetDTO> UpdateAsync(TurmaPutDTO turmaPutDto);
    Task<TurmaGetDTO> DeleteAsync(int id);
}
