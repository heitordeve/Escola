using Escola.Application.DTOS.Turma;
using Escola.Application.DTOS.User;

namespace Escola.Application.Interdaces;

public interface IUserService
{
    Task<UserGetDTO> GetByIdAsync(int id);
    Task<List<UserGetDTO>> GetAllAsync();
    Task<UserGetDTO> AddAsync(UserPostDTO userPostDto);
    Task<UserGetDTO> UpdateAsync(UserPutDTO userPutDto);
    Task<UserGetDTO> DeleteAsync(int id);
}
