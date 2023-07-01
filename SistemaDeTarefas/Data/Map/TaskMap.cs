using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ApiDeTarefas.Models;

namespace ApiDeTarefas.Data.Map
{
    public class TaskMap : IEntityTypeConfiguration<TaskMd>
    {
        public void Configure(EntityTypeBuilder<TaskMd> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(1000);
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.UserId);

            // builder.HasOne(x => x.User);
            builder.HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId);
        }
    }
}
