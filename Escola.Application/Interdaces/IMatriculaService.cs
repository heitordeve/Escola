using Escola.Application.DTOS.Matricula;

namespace Escola.Application.Interdaces;

public interface IMatriculaService
{
    Task<MatriculaGetDTO> GetByIdAsync(int id);
    Task<List<MatriculaGetDTO>> GetAllAsync();
    Task<MatriculaGetDTO> AddAsync(MatriculaPostDTO matricula);
    Task<MatriculaGetDTO> UpdateAsync(MatriculaPutDTO matricula);
    Task<MatriculaGetDTO> DeleteAsync(int id);
}
