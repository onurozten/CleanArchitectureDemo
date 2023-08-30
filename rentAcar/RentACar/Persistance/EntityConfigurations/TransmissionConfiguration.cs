using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.EntityConfigurations;

public class TransmissionConfiguration : IEntityTypeConfiguration<Transmission>
{
    public void Configure(EntityTypeBuilder<Transmission> builder)
    {
        builder.Property(x => x.Name).IsRequired();
        builder.Property(x => x.CreatedDate).IsRequired();

        builder.HasIndex(indexExpression: x => x.Name, name: "UK_Transmissions_Name").IsUnique();
        builder.HasMany(x => x.Models);

        builder.HasQueryFilter(x => !x.DeletedDate.HasValue);

    }
}
