using Escola.Domain.Entities;
using Escola.Domain.Interface;

namespace Escola.Infra.Data.Repositories;

public class UserRepository : IUserRepository
{
    Task<User> IUserRepository.AddAsync(User user)
    {
        throw new NotImplementedException();
    }

    Task<bool> IUserRepository.DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    Task<List<User>> IUserRepository.GetAllAsync()
    {
        throw new NotImplementedException();
    }

    Task<User> IUserRepository.GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    Task<User> IUserRepository.UpdateAsync(User user)
    {
        throw new NotImplementedException();
    }
}
