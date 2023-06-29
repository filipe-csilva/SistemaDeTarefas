using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Data.Map
{
    public class TaskMap : IEntityTypeConfiguration<TaskMd>
    {
        public void Configure(EntityTypeBuilder<TaskMd> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(1000);
            builder.Property(x => x.Status).IsRequired();
        }
    }
}
