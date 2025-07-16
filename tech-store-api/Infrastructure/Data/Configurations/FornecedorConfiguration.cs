using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using tech_store_api.Domain.Entities;

namespace tech_store_api.Infrastructure.Data.Configurations
{
    public class FornecedorConfiguration : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.ToTable("Fornecedor");
            builder.HasKey(f => f.Id);
            builder.Property(f => f.Nome).IsRequired().HasMaxLength(100);
        }
    }
}
