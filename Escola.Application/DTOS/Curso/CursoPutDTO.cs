using System.ComponentModel.DataAnnotations;

namespace Escola.Application.DTOS.Curso;

public class CursoPutDTO
{
    [Required(ErrorMessage = "O campo Id do Curso é obrigatório.")]
    public int Id { get; set; }
    [Required(ErrorMessage = "O campo Nome' é obrigatório.")]
    [MaxLength(50, ErrorMessage = "O campo Nome deve ter no máximo 50 caracteres.")]
    public string Name { get; set; }
    [Required(ErrorMessage = "O campo Descrição é obrigatório.")]
    [MaxLength(150, ErrorMessage = "O campo Descrição deve ter no máximo 150 caracteres.")]
    public string Description { get; set; }
}
