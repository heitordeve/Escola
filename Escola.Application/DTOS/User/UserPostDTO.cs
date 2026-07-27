using System.ComponentModel.DataAnnotations;

namespace Escola.Application.DTOS.User;

public class UserPostDTO
{
    [Required(ErrorMessage = "O campo Nome é obrigatório.")]
    [MaxLength(50, ErrorMessage = "O campo Nome deve ter no máximo 50 caracteres.")]
    public string Name { get; set; }
    [Required(ErrorMessage = "O campo Email é obrigatório.")]
    [EmailAddress(ErrorMessage = "O campo Email deve ser um endereço de email válido.")]
    public string Email { get; set; }
    [Required(ErrorMessage = "O campo Perfil é obrigatório.")]
    [MaxLength(50, ErrorMessage = "O campo Perfil deve ter no máximo 50 caracteres.")]
    public string Perfil { get; set; }
}
