using ElevateEvansvilleUI.API.DTOs;
using ElevateEvansvilleUI.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

#if __WASM__
using Uno.Web.Http;
#endif

namespace ElevateEvansvilleUI.Extensions
{

    public class Cookies
    {

        public static string VolunteerCookie = "ElevateEvansvilleVolunteer";


        public static void SaveVolunteerInfo(AccountsDTO Dto)
        {
#if __WASM__
            string Value = JsonSerializer.Serialize(Dto);
            
            var cookie = new Cookie(VolunteerCookie, Value);
            var request = new SetCookieRequest(cookie)
            {
                Path = "/",
                Expires = DateTimeOffset.UtcNow.AddDays(999),
                Secure = true,
            };

            CookieManager.GetDefault().SetCookie(request);
#endif
        }

        public static AccountsDTO GetVolunteerInfo()
        {

#if __WASM__
            var cookies = CookieManager.GetDefault().GetCookies();
            foreach (var cookie in cookies)
            {
                if (cookie.Name == VolunteerCookie)
                {
                    AccountsDTO dto = JsonSerializer.Deserialize<AccountsDTO>(cookie.Value);
                    return dto;
                }
            }

            return null;
#endif
            return null;
        }

        public static void ClearCookies()
        {
#if __WASM__
            CookieManager.GetDefault().DeleteCookie(VolunteerCookie, path: "/");
#endif
        }



    }


}
