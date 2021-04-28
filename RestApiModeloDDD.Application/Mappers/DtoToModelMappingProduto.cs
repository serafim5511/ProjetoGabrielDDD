using AutoMapper;
using ProjetoGabrielDDD.Domain.Entitys;
using RestApiModeloDDD.Application.Dtos;

namespace RestApiModeloDDD.Application.Mappers
{
    public class DtoToModelMappingProduto : Profile
    {
        public DtoToModelMappingProduto()
        {
            ProdutoMap();
        }

        private void ProdutoMap()
        {
            CreateMap<ProdutoDto, Produto>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(x => x.Nome))
                .ForMember(dest => dest.Valor, opt => opt.MapFrom(x => x.Valor))
                .ForMember(dest => dest.IsDisponivel, opt => opt.Ignore());
        }
    }
}
