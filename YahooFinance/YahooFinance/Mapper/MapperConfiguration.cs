using AutoMapper;
using YahooFinance.Domain.Dtos;
using YahooFinance.Domain.Entities;

namespace YahooFinance.Aplication.Mapper
{
    public class MapperConfiguration : Profile
    {
        public MapperConfiguration()
        {
            CreateMap<Ativo, AtivoDto>().ReverseMap();
            //CreateMap<Security, ApiYahooReturnDto>().ReverseMap();

            CreateMap<AssetVariation, AssetVariationDto>()
                .ForMember(dest => dest.Valor, act => act.MapFrom(src => Math.Round(src.Valor, 2))).ReverseMap();





        }

    }
}
