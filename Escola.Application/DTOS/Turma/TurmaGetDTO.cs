namespace Escola.Application.DTOS.Turma;

public class TurmaGetDTO
{
    public int Id { get; set; }
    public int MatriculaId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int CursoId { get; set; }
}
