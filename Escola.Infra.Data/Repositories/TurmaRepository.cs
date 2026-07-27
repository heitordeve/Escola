using Escola.Domain.Entities;
using Escola.Domain.Interface;
using Escola.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
namespace Escola.Infra.Data.Repositories;

public class TurmaRepository : ITurmaRepository
{
    private readonly ApplicationDbContext _context;

    public TurmaRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Turma> AddAsync(Turma turma)
    {
        _context.Turma.Add(turma);
        await _context.SaveChangesAsync();
        return turma;
    }
    public async Task<bool> DeleteAsync(int id) 
    {
        var turma = await _context.Turma.Where(t => t.Id == id && t.IsDeleted == false).FirstOrDefaultAsync();
        if (turma == null)
            return false;

        turma.IsDeleted = true;
        _context.Turma.Update(turma);
        await _context.SaveChangesAsync();
        return true;
    }
    public async Task<List<Turma>> GetAllAsync()
    {
        return await _context.Turma
            .Where(t => !t.IsDeleted)
            .ToListAsync();
    }
    public async Task<Turma> GetByIdAsync(int id)
    {
        return await _context.Turma.Where(t => t.Id == id && t.IsDeleted == false).FirstOrDefaultAsync();
    }


    public async Task<Turma> UpdateAsync(Turma turma)
    {
        _context.Turma.Update(turma);
        await _context.SaveChangesAsync();
        return turma ;
    }
}
