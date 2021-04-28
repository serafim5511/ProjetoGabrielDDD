using ProjetoGabrielDDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace RestApiModeloDDD.Infrastructure.EntityConfig
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            HasKey(p => p.Id);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(250);

            Property(p => p.Valor)
                .IsRequired();

        }
    }
}
