using CE.ApiDotnet7.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CE.ApiDotnet7.Infra.Data.Maps
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("usuario");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .HasColumnName("idusuario")
                .UseIdentityColumn();

            builder.Property(c => c.Name)
                .HasColumnName("nome");

            builder.Property(c => c.Email)
                .HasColumnName("email");

            builder.Property(c => c.Password)
                .HasColumnName("senha");

            builder.HasMany(c => c.Purchases)
                .WithOne(p => p.User)
                .HasForeignKey(c => c.UserId);
        }
    }
}
