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
            profile.CreateMap<Balance, BalanceDTO>();
        }
    }
}
