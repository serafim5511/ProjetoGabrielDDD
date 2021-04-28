using ProjetoGabrielDDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace RestApiModeloDDD.Infrastructure.EntityConfig
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            HasKey(c => c.Id);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Sobrenome)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Email)
                .IsRequired();

        }
    }
}
