using Escola.Application.DTOS.Curso;
using Escola.Application.DTOS.Matricula;
using Escola.Application.Interdaces;
using Escola.Domain.Entities;
using Escola.Domain.Interface;

namespace Escola.Application.Services;

public class MatriculaService : IMatriculaService
{
    private readonly IMatriculaRepository _matriculaRepository;
    public MatriculaService(IMatriculaRepository matriculaRepository)
    {
        _matriculaRepository = matriculaRepository;
    }

    public async Task<MatriculaGetDTO> AddAsync(MatriculaPostDTO matriculPostDTO)       
    {
        var matricula = new Matricula
        {
            TurmaId = matriculPostDTO.TurmaId
        };
        var result = await _matriculaRepository.AddAsync(matricula);
        return new MatriculaGetDTO      
        {
            Id = result.Id,
            UserId = result.UserId,
            TurmaId = result.TurmaId
        };

    }

    public async Task<MatriculaGetDTO> DeleteAsync(int id)
    {
        var deletedMatricula = await _matriculaRepository.DeleteAsync(id);
        if (deletedMatricula == null)
        {
            return null;
        }
        return new MatriculaGetDTO
        {
            Id = deletedMatricula.Id,
            UserId = deletedMatricula.UserId,
            TurmaId = deletedMatricula.TurmaId
        };
    }

    public async Task<List<MatriculaGetDTO>> GetAllAsync()
    {
        var matriculas = await _matriculaRepository.GetAllAsync();
        return matriculas.Select(m => new MatriculaGetDTO
        {
            Id = m.Id,
            UserId = m.UserId,
            TurmaId = m.TurmaId
        }).ToList();
    }

    public async Task<MatriculaGetDTO> GetByIdAsync(int id)
    {
        var matricula = await _matriculaRepository.GetByIdAsync(id);
        if (matricula == null)
        {
            return null;
        }
        return new MatriculaGetDTO
        {
            Id = matricula.Id,
            UserId = matricula.UserId,
            TurmaId = matricula.TurmaId
        };
    }

    public async Task<MatriculaGetDTO> UpdateAsync(MatriculaPutDTO matricula)
    {
        var existingMatricula = await _matriculaRepository.GetByIdAsync(matricula.Id);
        if (existingMatricula == null)
        {
            return null;
        }

        existingMatricula.UserId = matricula.UserId;
        existingMatricula.TurmaId = matricula.TurmaId;

        var updatedMatricula = await _matriculaRepository.UpdateAsync(existingMatricula);
        return new MatriculaGetDTO
        {
            Id = updatedMatricula.Id,
            UserId = updatedMatricula.UserId,
            TurmaId = updatedMatricula.TurmaId
        };
    }
}
