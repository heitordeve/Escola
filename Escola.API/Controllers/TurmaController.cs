using Escola.Application.DTOS.Turma;
using Escola.Application.Interdaces;
using Microsoft.AspNetCore.Mvc;

namespace Escola.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TurmaController : Controller
{
    private readonly ITurmaService _turmaService;
    public TurmaController(ITurmaService turmaService)
    {
        _turmaService = turmaService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateTurma(TurmaPostDTO turmaPostDto)
    {
        var createdTurma = await _turmaService.AddAsync(turmaPostDto);
        if (createdTurma == null)
        {
            return BadRequest("Não foi possível criar a turma.");
        }
        return Ok(createdTurma);
    }
    [HttpPut]
    public async Task<IActionResult> UpdateTurma(TurmaPutDTO turmaPutDto)
    {
        var updatedTurma = await _turmaService.UpdateAsync(turmaPutDto);
        if (updatedTurma == null)
        {
            return BadRequest("Não foi possível atualizar a turma.");
        }
        return Ok(updatedTurma);
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTurma(int id)
    {
        var deletedTurma = await _turmaService.DeleteAsync(id);
        if (deletedTurma == null)
        {
            return BadRequest("Não foi possível excluir a turma.");
        }
        return Ok();
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetTurmaById(int id)
    {
        var turma = await _turmaService.GetByIdAsync(id);
        if (turma == null)
        {
            return NotFound("Turma não encontrada.");
        }
        return Ok(turma);
    }

    [HttpGet]
    public async Task<ActionResult> GetAllAsync()
    {
        var turmas = await _turmaService.GetAllAsync();
        return Ok(turmas);
    }
}
