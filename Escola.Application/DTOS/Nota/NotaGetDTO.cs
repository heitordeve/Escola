namespace Escola.Application.DTOS.Nota;

public class NotaGetDTO
{
    public int Id { get; set; }
    public int MatriculaId { get; set; }
    public decimal ValorNota { get; set; }
    public DateTime DataRegistro { get; set; }
}
