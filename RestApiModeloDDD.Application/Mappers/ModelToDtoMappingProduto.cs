using AutoMapper;
using ProjetoGabrielDDD.Domain.Entitys;
using RestApiModeloDDD.Application.Dtos;

namespace RestApiModeloDDD.Application.Mappers
{
    public class ModelToDtoMappingProduto : Profile
    {
        public ModelToDtoMappingProduto()
        {
            ProdutoDtoMap();
        }
        private void ProdutoDtoMap()
        {
            CreateMap<Produto, ProdutoDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(x => x.Nome))
                .ForMember(dest => dest.Valor, opt => opt.MapFrom(x => x.Valor));
        }
    }
}
