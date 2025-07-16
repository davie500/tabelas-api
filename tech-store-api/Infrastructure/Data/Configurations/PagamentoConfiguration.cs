using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using tech_store_api.Domain.Entities;

namespace tech_store_api.Infrastructure.Data.Configurations
{
    public class PagamentoConfiguration : IEntityTypeConfiguration<Pagamento>
    {
        public void Configure(EntityTypeBuilder<Pagamento> builder)
        {
            builder.ToTable("Forma de Pagamento");
            builder.HasKey(fp => fp.Id);
            builder.Property(fp => fp.Forma).IsRequired().HasMaxLength(100);
        }
    }
}