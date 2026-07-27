using Escola.Application.DTOS.Curso;
using Escola.Domain.Entities;

namespace Escola.Application.Interdaces;

public interface ICursoService
{
    Task<CursoGetDTO> GetByIdAsync(int id);
    Task<List<CursoGetDTO>> GetAllAsync();
    Task<CursoGetDTO> AddAsync(CursoGetDTO cursoGetDTO);
    Task<CursoGetDTO> UpdateAsync(CursoGetDTO cursoGetDTO);
    Task<CursoGetDTO> DeleteAsync(int id);
}
