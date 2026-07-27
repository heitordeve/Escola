using System.ComponentModel.DataAnnotations;

namespace Escola.Application.DTOS.Matricula;

public  class MatriculaPostDTO
{
    [Required(ErrorMessage = "O ID da Matricula é obrigatório.")]
    public int UserId { get; set; }
    [Required(ErrorMessage = "O ID da Matricula é obrigatório.")]
    public int TurmaId { get; set; }
}
