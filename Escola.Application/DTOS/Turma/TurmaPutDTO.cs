using System.ComponentModel.DataAnnotations;

namespace Escola.Application.DTOS.Turma;

public class TurmaPutDTO
{
    [Required(ErrorMessage = "O campo Id da Turma é obrigatório.")]
    public int Id { get; set; }
    [Required(ErrorMessage = "O campo Nome da Turma é obrigatório.")]
    public string Name { get; set; }
    [Required(ErrorMessage = "O campo Descrição da Turma é obrigatório.")]
    public string Description { get; set; }
    [Required(ErrorMessage = "O campo 'CursoId' é obrigatório.")]
    public int CursoId { get; set; }
}
