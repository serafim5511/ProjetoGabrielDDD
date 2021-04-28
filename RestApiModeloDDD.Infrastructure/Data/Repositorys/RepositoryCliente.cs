using ProjetoGabrielDDD.Domain.Entitys;
using RestApiModeloDDD.Domain.Core.Interfaces.Repositorys;

namespace RestApiModeloDDD.Infrastructure.Data.Repositorys
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        private readonly SqlContext sqlContext;

        public RepositoryCliente(SqlContext sqlContext)
            : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}