using ProjetoGabrielDDD.Domain.Entitys;
using RestApiModeloDDD.Domain.Core.Interfaces.Repositorys;

namespace RestApiModeloDDD.Infrastructure.Data.Repositorys
{
    public class RepositoryProduto : RepositoryBase<Produto>, IRepositoryProduto
    {
        private readonly SqlContext sqlContext;

        public RepositoryProduto(SqlContext sqlContext)
            : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}