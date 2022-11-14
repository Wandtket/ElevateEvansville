using AutoMapper;
using ElevateEvansville_API.Models;
using ElevateEvansvilleUI.DTOs;
using System.Security;

namespace ElevateEvansville_API.Mapping.Profiles
{
    public class CoreProfile
    {
        public static void Initialize(Profile profile)
        {
            profile.CreateMap<Balances, BalanceDTO>()
                 .ForMember(dest => dest.BalanceID, opt => opt.MapFrom(s => s.Id))
                 .ReverseMap()
                 .ForMember(dest => dest.Id, opt => opt.MapFrom(s => s.BalanceID));

            profile.CreateMap<Transactions, TransactionsDTO>();

        }
    }
}
