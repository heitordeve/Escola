using System.Linq;
using Escola.Application.DTOS.Curso;
using Escola.Application.Interdaces;
using Escola.Domain.Entities;
using Escola.Domain.Interface;

namespace Escola.Application.Services;

public class CursoService : ICursoService
{
    private readonly ICursoRepository _cursoRepository;

    public CursoService(ICursoRepository cursoRepository)
    {
        _cursoRepository = cursoRepository;
    }

    public async Task<CursoGetDTO> AddAsync(CursoPostDTO cursoPostDTO)
    {
        var curso = new Curso
        {
            Name = cursoPostDTO.Name,
            Description = cursoPostDTO.Description
        };
        var result = await _cursoRepository.AddAsync(curso);
        return new CursoGetDTO
        {
            Id = result.Id,
            Name = result.Name,
            Description = result.Description
        };
    }

    public async Task<CursoGetDTO> DeleteAsync(int id)
    {
        var deletedCurso = await _cursoRepository.DeleteAsync(id);
        if (deletedCurso == null)
        {
            return null;
        }
        return new CursoGetDTO
        {
            Id = deletedCurso.Id,
            Name = deletedCurso.Name,
            Description = deletedCurso.Description
        };
    }

    public async Task<List<CursoGetDTO>> GetAllAsync()
    {
        var cursos = await _cursoRepository.GetAllAsync();
        var cursoGetDTOs = cursos.Select(curso => new CursoGetDTO
        {
            Id = curso.Id,
            Name = curso.Name,
            Description = curso.Description
        }).ToList();
        return cursoGetDTOs;
    }

    public async Task<CursoGetDTO> GetByIdAsync(int id)
    {
        var curso = await _cursoRepository.GetByIdAsync(id);
        if (curso == null)
        {
            return null;
        }
        return new CursoGetDTO
        {
            Id = curso.Id,
            Name = curso.Name,
            Description = curso.Description
        };
    }

    public async Task<CursoGetDTO> UpdateAsync(CursoPutDTO cursoPutDTO)
    {
        var curso = new Curso
        {
            Id = cursoPutDTO.Id,
            Name = cursoPutDTO.Name,
            Description = cursoPutDTO.Description
        };

        var updatedCurso = await _cursoRepository.UpdateAsync(curso);
        if (updatedCurso == null)
        {
            return null;
        }
        return new CursoGetDTO
        {
            Id = updatedCurso.Id,
            Name = updatedCurso.Name,
            Description = updatedCurso.Description
        };
    }
}
