using Escola.Domain.Entities;
using Escola.Domain.Interface;
using Escola.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
namespace Escola.Infra.Data.Repositories;

public class NotaRepository : INotaRepository
{
    private readonly ApplicationDbContext _context;

    public NotaRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Nota> AddAsync(Nota nota)
    {
        _context.Nota.Add(nota);
        await _context.SaveChangesAsync();
        return nota;
    }
    public async Task<bool> DeleteAsync(int id)
    {
        var nota = await _context.Nota.Where(n => n.Id == id && !n.IsDeleted)
            .FirstOrDefaultAsync();
        if (nota == null)
            return false;

        nota.IsDeleted = true;
        _context.Nota.Update(nota);
        await _context.SaveChangesAsync();
        return true;
    }
    public async Task<List<Nota>> GetAllAsync()
    {
        return await _context.Nota
            .Where(n => !n.IsDeleted)
            .ToListAsync();
    }
    public async Task<Nota> GetByIdAsync(int id)
    {
        return await _context.Nota.Where(n => n.Id == id && n.IsDeleted == false).FirstOrDefaultAsync();
    }


    public async Task<Nota> UpdateAsync(Nota nota)
    {
        _context.Nota.Update(nota);
        await _context.SaveChangesAsync();
        return nota;
    }
}
