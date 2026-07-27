using System.ComponentModel.DataAnnotations;

namespace Escola.Application.DTOS.Matricula;

public class MatriculaPutDTO
{
    [Required(ErrorMessage = "O ID da Matricula é obrigatório.")]
    public int Id { get; set; }
    [Required(ErrorMessage = "O ID da Matricula é obrigatório.")]
    public int UserId { get; set; }
    [Required(ErrorMessage = "O ID da Matricula é obrigatório.")]
    public int TurmaId { get; set; }
}
