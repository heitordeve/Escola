using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Escola.Application.DTOS.Nota;

public class NotaPostDTO
{
    [Required(ErrorMessage = "O ID da Matricula é obrigatório.")]
    public int MatriculaId { get; set; }
    [Required(ErrorMessage = "O valor da nota é obrigatório.")]
    public decimal ValorNota { get; set; }
    [Required(ErrorMessage = "A data de registro é obrigatória.")]
    public DateTime DataRegistro { get; set; }
}
