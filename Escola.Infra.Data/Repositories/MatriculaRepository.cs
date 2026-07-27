using Escola.Domain.Entities;
using Escola.Domain.Interface;
using Escola.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
namespace Escola.Infra.Data.Repositories;

public class MatriculaRepository : IMatriculaRepository
{
    private readonly ApplicationDbContext _context;

    public async Task<Matricula> AddAsync(Matricula matricula)
    {
        _context.Matricula.Add(matricula);
        await _context.SaveChangesAsync();
        return matricula;
    }
    public async Task<bool> DeleteAsync(int id)
    {
        var matricula = await _context.Matricula.Where(m => m.Id == id && m.IsDeleted == false).FirstOrDefaultAsync();
        if (matricula == null)
            return false;

        matricula.IsDeleted = true;
        _context.Matricula.Update(matricula);
        await _context.SaveChangesAsync();
        return true;
    }
    public async Task<List<Matricula>> GetAllAsync()
    {
        return await _context.Matricula
            .Where(m => !m.IsDeleted)
            .ToListAsync();
    }
    public async Task<Matricula> GetByIdAsync(int id)
    {
        return await _context.Matricula.Where(m => m.Id == id && m.IsDeleted == false).FirstOrDefaultAsync();
    }


    public async Task<Matricula> UpdateAsync(Matricula matricula)
    {
        _context.Matricula.Update(matricula);
        await _context.SaveChangesAsync();
        return matricula;
    }
}
