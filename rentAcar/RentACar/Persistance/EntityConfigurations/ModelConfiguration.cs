using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.EntityConfigurations;

public partial class ModelConfiguration : IEntityTypeConfiguration<Model>
{
    public void Configure(EntityTypeBuilder<Model> builder)
    {
        builder.Property(x => x.Name).IsRequired();
        builder.Property(x => x.CreatedDate).IsRequired();
        builder.Property(x => x.BrandId).IsRequired();
        builder.Property(x => x.FuelId).IsRequired();
        builder.Property(x => x.TransmissionId).IsRequired();
        builder.Property(x => x.DailyPrice).HasPrecision(18,2);

        builder.HasIndex(indexExpression: x => x.Name, name: "UK_Models_Name").IsUnique();
        builder.HasOne(x => x.Brand);
        builder.HasOne(x => x.Transmission);
        builder.HasOne(x => x.Fuel);
        builder.HasMany(x => x.Cars);

        builder.HasQueryFilter(x => !x.DeletedDate.HasValue);

    }

}
