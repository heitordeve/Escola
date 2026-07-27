using Escola.Application.DTOS.Matricula;
using Escola.Application.DTOS.Nota;
using Escola.Application.Interdaces;
using Escola.Domain.Entities;
using Escola.Domain.Interface;

namespace Escola.Application.Services;

public class NotaService : INotaService
{
    private readonly INotaRepository _notaRepository;
    public NotaService(INotaRepository notaRepository)
    {
        _notaRepository = notaRepository;
    }
    public async Task<NotaGetDTO> AddAsync(NotaPostDTO notaPostDto)
    {
        var nota = new Nota
        {
            MatriculaId = notaPostDto.MatriculaId,
            ValorNota = notaPostDto.ValorNota
        };
        var result = await _notaRepository.AddAsync(nota);
        return new NotaGetDTO
        {
            Id = result.Id,
            MatriculaId = result.MatriculaId,
            ValorNota = result.ValorNota
        };
    }

    public async Task<NotaGetDTO> DeleteAsync(int id)

    {
        var deletedNota = await _notaRepository.DeleteAsync(id);
        if (deletedNota == null)
        {
            return null;
        }
        return new NotaGetDTO
        {
            Id = deletedNota.Id,
            MatriculaId = deletedNota.MatriculaId,
            ValorNota = deletedNota.ValorNota
        };
    }

    public async Task<List<NotaGetDTO>> GetAllAsync()
    {
        var notas = await _notaRepository.GetAllAsync();
        return notas.Select(n => new NotaGetDTO
        {
            Id = n.Id,
            MatriculaId = n.MatriculaId,
            ValorNota = n.ValorNota
        }).ToList();
    }

    public async Task<NotaGetDTO> GetByIdAsync(int id)
    {
        var nota = await _notaRepository.GetByIdAsync(id);
        if (nota == null)
        {
            return null;
        }
        return new NotaGetDTO
        {
            Id = nota.Id,
            MatriculaId = nota.MatriculaId,
            ValorNota = nota.ValorNota
        };
    }

    public async Task<NotaGetDTO> UpdateAsync(NotaPutDTO notaPutDto)
    {
        var existingNota = await _notaRepository.GetByIdAsync(notaPutDto.Id);
        if (existingNota == null)
        {
            return null;
        }

        existingNota.MatriculaId = notaPutDto.MatriculaId;
        existingNota.ValorNota = notaPutDto.ValorNota;

        var updatedNota = await _notaRepository.UpdateAsync(existingNota);
        return new NotaGetDTO
        {
            Id = updatedNota.Id,
            MatriculaId = updatedNota.MatriculaId,
            ValorNota = updatedNota.ValorNota
        };
    }
}
