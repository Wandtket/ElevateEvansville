using AutoMapper;
using ElevateEvansville_API.Models;
using ElevateEvansvilleUI.API.DTOs;

namespace ElevateEvansville_API.Mapping.Profiles
{
    public class CoreProfile
    {
        public static void Initialize(Profile profile)
        {
            profile.CreateMap<Accounts, AccountsDTO>();

            profile.CreateMap<Balances, BalanceDTO>()
                 .ForMember(dest => dest.BalanceID, opt => opt.MapFrom(s => s.Id))
                 .ReverseMap()
                 .ForMember(dest => dest.Id, opt => opt.MapFrom(s => s.BalanceID));

            profile.CreateMap<Signatures, SignaturesDTO>()
                .ForMember(dest => dest.SignaturesID, opt => opt.MapFrom(s => s.Id))
                 .ReverseMap()
                 .ForMember(dest => dest.Id, opt => opt.MapFrom(s => s.SignaturesID)); ;

            profile.CreateMap<Transactions, TransactionsDTO>();


        }
    }
}
