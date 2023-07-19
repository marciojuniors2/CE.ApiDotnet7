using CE.ApiDotnet7.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CE.ApiDotnet7.Infra.Data.Maps
{
    public class PurchaseMap : IEntityTypeConfiguration<Purchase>
    {
        public void Configure(EntityTypeBuilder<Purchase> builder)
        {
            builder.ToTable("compra");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .HasColumnName("idcompra")
                .UseIdentityColumn();

            builder.Property(p => p.UserId)
                .HasColumnName("idusuario");

            builder.Property(p => p.CarId)
                .HasColumnName("idcarro");

            builder.Property(p => p.Date)
                .HasColumnName("datacompra");

            builder.HasOne(p => p.User)
                .WithMany(p => p.Purchases);


            builder.HasOne(p => p.Car)
                .WithMany(p => p.Purchases);
        }
    }
}
