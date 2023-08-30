using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.EntityConfigurations;

public class CarConfiguration : IEntityTypeConfiguration<Car>
{
    public void Configure(EntityTypeBuilder<Car> builder)
    {
        builder.Property(x => x.ModelId).IsRequired();
        builder.Property(x => x.CreatedDate).IsRequired();
        builder.Property(x => x.Kilometer).IsRequired();

        builder.HasOne(x => x.Model);

        builder.HasQueryFilter(x => !x.DeletedDate.HasValue);

    }
}

