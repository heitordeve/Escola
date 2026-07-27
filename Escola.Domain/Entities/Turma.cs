using System;
using System.Collections.Generic;
using System.Text;

namespace Escola.Domain.Entities;

public class Turma
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int CursoId { get; set; }
    public ICollection<Matricula> Matriculas { get; set; }
    public Curso Curso { get; set; }
    public bool IsDeleted { get; set; } = false;
}
