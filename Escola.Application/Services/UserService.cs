using Escola.Application.DTOS.Turma;
using Escola.Application.DTOS.User;
using Escola.Application.Interdaces;
using Escola.Domain.Entities;
using Escola.Domain.Interface;

namespace Escola.Application.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<UserGetDTO> AddAsync(UserPostDTO userPostDto)
    {
        var user = new User
        {
            Name = userPostDto.Name,
            Email = userPostDto.Email,
            Perfil = userPostDto.Perfil
        };
        var result = await _userRepository.AddAsync(user);
        return new UserGetDTO
        {
            UserId = result.UserId,
            Name = result.Name,
            Email = result.Email,
            Perfil = result.Perfil
        };
    }

    public async Task<UserGetDTO> DeleteAsync(int id)
    {
        var deletedUser = await _userRepository.DeleteAsync(id);
        if (deletedUser == null)
        {
            return null;
        }
        return new UserGetDTO
        {
            UserId = deletedUser.UserId,
            Name = deletedUser.Name,
            Email = deletedUser.Email
        };
    }

    public async Task<List<UserGetDTO>> GetAllAsync()
    {
        var users = await _userRepository.GetAllAsync();
        return users.Select(u => new UserGetDTO
        {
            UserId = u.UserId,
            Name = u.Name,
            Email = u.Email
        }).ToList();
    }

    public async Task<UserGetDTO> GetByIdAsync(int id)
    {
        var user = await _userRepository.GetByIdAsync(id);
        if (user == null)
        {
            return null;
        }
        return new UserGetDTO
        {
            UserId = user.UserId,
            Name = user.Name,
            Email = user.Email
        };
    }
    

    public async Task<UserGetDTO> UpdateAsync(UserPutDTO userPutDto)
    {
        var user = await _userRepository.GetByIdAsync(userPutDto.UserId);
        if (user == null)
        {
            return null;
        }

        user.Name = userPutDto.Name;
        user.Email = userPutDto.Email;

        var updatedUser = await _userRepository.UpdateAsync(user);
        return new UserGetDTO
        {
            UserId = updatedUser.UserId,
            Name = updatedUser.Name,
            Email = updatedUser.Email
        };
    }
}
