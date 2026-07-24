using Escola.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Escola.Infra.Data.EntitiesConfiguration;

public class MatriculaConfiguration : IEntityTypeConfiguration<Matricula>
{
    public void Configure(EntityTypeBuilder<Matricula> builder)
    {
        builder.HasKey(m => m.Id);
        builder.Property(m => m.DataMatricula).IsRequired();
        builder.Property(m => m.UserId).IsRequired();
        builder.Property(m => m.TurmaId).IsRequired();

        builder.HasOne(m => m.User)
               .WithMany(u => u.Matricula) // usa o nome definido em User.cs
               .HasForeignKey(m => m.UserId)
               .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(m => m.Turma)
               .WithMany(t => t.Matriculas)
               .HasForeignKey(m => m.TurmaId)
               .OnDelete(DeleteBehavior.NoAction);
    }
}
