using CE.ApiDotnet7.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace CE.ApiDotnet7.Infra.Data.Maps
{
    public class CarMap : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("carro");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .HasColumnName("idcarro")
                .UseIdentityColumn();

            builder.Property(c => c.Name)
             .HasColumnName("nome");

            builder.Property(c => c.Model)
                .HasColumnName("modelo");

            builder.Property(c => c.Brand)
                .HasColumnName("marca");

            builder.Property(c => c.Price)
                .HasColumnName("valor");

            builder.Property(c => c.Year)
                .HasColumnName("ano");

            builder.Property(c => c.Km)
                .HasColumnName("km");

            builder.Property(c => c.Color)
                .HasColumnName("cor");

            builder.Property(c => c.Picture)
                .HasColumnName("picture");

            builder.HasMany(c => c.Purchases)
                .WithOne(p => p.Car)
                .HasForeignKey(c => c.CarId);
        }
    }
}
