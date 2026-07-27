using System.ComponentModel.DataAnnotations;

namespace Escola.Application.DTOS.Nota;

public class NotaPutDTO
{
    [Required(ErrorMessage = "O ID da Nota é obrigatório.")]
    public int Id { get; set; }
    [Required(ErrorMessage = "O ID da Matricula é obrigatório.")]
    public int MatriculaId { get; set; }
    [Required(ErrorMessage = "O valor da nota é obrigatório.")]
    public decimal ValorNota { get; set; }
    [Required(ErrorMessage = "A data de registro é obrigatória.")]
    public DateTime DataRegistro { get; set; }
}
