using Escola.Application.DTOS.Nota;

namespace Escola.Application.Interdaces;

public interface INotaService
{
    Task<NotaGetDTO> GetByIdAsync(int id);
    Task<List<NotaGetDTO>> GetAllAsync();
    Task<NotaGetDTO> AddAsync(NotaPostDTO notaPostDto);
    Task<NotaGetDTO> UpdateAsync(NotaPutDTO notaPutDto);
    Task<NotaGetDTO> DeleteAsync(int id);
}
