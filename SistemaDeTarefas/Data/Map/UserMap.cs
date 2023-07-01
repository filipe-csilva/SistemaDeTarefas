using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ApiDeTarefas.Models;

namespace ApiDeTarefas.Data.Map
{
    public class UserMap : IEntityTypeConfiguration<UserMd>
    {
        public void Configure(EntityTypeBuilder<UserMd> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(150);
        }
    }
}
