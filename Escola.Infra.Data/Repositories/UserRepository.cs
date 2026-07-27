using Escola.Domain.Entities;
using Escola.Domain.Interface;
using Escola.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
namespace Escola.Infra.Data.Repositories;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _context;

    public UserRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<User> AddAsync(User user)
    {
        _context.User.Add(user);
        await _context.SaveChangesAsync();
        return user;
    }
    public async Task<User> DeleteAsync(int id)
    {
        var user = await _context.User.Where(u => u.UserId == id && u.IsDeleted == false).FirstOrDefaultAsync();
        if (user == null)
            return null;

        user.IsDeleted = true;
        _context.User.Update(user);
        await _context.SaveChangesAsync();
        return user;
    }
    public async Task<List<User>> GetAllAsync()
    {
        return await _context.User
            .Where(u => !u.IsDeleted)
            .ToListAsync();
    }
    public async Task<User> GetByIdAsync(int id)
    {
        return await _context.User.Where(u => u.UserId == id && u.IsDeleted == false).FirstOrDefaultAsync();
    }


    public async Task<User> UpdateAsync(User user)
    {
        _context.User.Update(user);
        await _context.SaveChangesAsync();
        return user;
    }
}
