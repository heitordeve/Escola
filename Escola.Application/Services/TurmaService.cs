using Escola.Application.DTOS.Nota;
using Escola.Application.DTOS.Turma;
using Escola.Application.Interdaces;
using Escola.Domain.Entities;
using Escola.Domain.Interface;
using Microsoft.VisualBasic;

namespace Escola.Application.Services;

public class TurmaService : ITurmaService
{
    private readonly ITurmaRepository _turmaRepository;
    public TurmaService(ITurmaRepository turmaRepository)
    {
        _turmaRepository = turmaRepository;
    }
    public async Task<TurmaGetDTO> AddAsync(TurmaPostDTO turmaPostDto)
    {
        var turma = new Turma
        {
            Name = turmaPostDto.Name,
            Description = turmaPostDto.Description,
            CursoId = turmaPostDto.CursoId
        };
        var result = await _turmaRepository.AddAsync(turma);
        return new TurmaGetDTO
        {
            Id = result.Id,
            Name = result.Name,
            Description = result.Description,
            CursoId = result.CursoId
        };
    }
       
    

    public async Task<TurmaGetDTO> DeleteAsync(int id)
    {
        var deletedTurma = await _turmaRepository.DeleteAsync(id);
        if (deletedTurma == null)
        {
            return null;
        }
        return new TurmaGetDTO
        {


            Id = deletedTurma.Id,
            Name = deletedTurma.Name,
            Description = deletedTurma.Description,
            CursoId = deletedTurma.CursoId
        };
    }

    public async Task<List<TurmaGetDTO>> GetAllAsync()
    {
        var turmas = await _turmaRepository.GetAllAsync();
        return turmas.Select(t => new TurmaGetDTO
        {
            Id = t.Id,
            Name = t.Name,
            Description = t.Description,
            CursoId = t.CursoId
        }).ToList();
    }

    public async Task<TurmaGetDTO> GetByIdAsync(int id)
    {
        var turma = await _turmaRepository.GetByIdAsync(id);
        if (turma == null)
        {
            return null;
        }
        return new TurmaGetDTO
        {
            Id = turma.Id,
            Name = turma.Name,
            Description = turma.Description,
            CursoId = turma.CursoId
        };
    }

    public async Task<TurmaGetDTO> UpdateAsync(TurmaPutDTO turmaPutDto)
    {
        var existingTurma = await _turmaRepository.GetByIdAsync(turmaPutDto.Id);
        if (existingTurma == null)
        {
            return null;
        }

        existingTurma.Name = turmaPutDto.Name;
        existingTurma.Description = turmaPutDto.Description;
        existingTurma.CursoId = turmaPutDto.CursoId;

        var updatedTurma = await _turmaRepository.UpdateAsync(existingTurma);
        return new TurmaGetDTO
        {
            Id = updatedTurma.Id,
            Name = updatedTurma.Name,
            Description = updatedTurma.Description,
            CursoId = updatedTurma.CursoId
        };
    }
}
        
