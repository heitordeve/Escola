using System;
using System.Collections.Generic;
using System.Text;

namespace Escola.Domain.Entities;

public class User
{
    public int UserId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public byte[] PasswordHash { get; set; }
    public byte[] PasswordSalt { get; set; }
    public string Perfil { get; set; }
    public ICollection<Matricula> Matricula { get; set; }
    public bool IsDeleted { get; set; }
}
