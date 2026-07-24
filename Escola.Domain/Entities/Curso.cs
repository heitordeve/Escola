using System;
using System.Collections.Generic;
using System.Text;

namespace Escola.Domain.Entities;

public class Curso
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public ICollection<Turma> Turmas { get; set; }
}
