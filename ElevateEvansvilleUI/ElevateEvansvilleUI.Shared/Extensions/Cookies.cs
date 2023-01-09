using ElevateEvansvilleUI.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.Text;

#if __WASM__
using Uno.Web.Http;
#endif

namespace ElevateEvansvilleUI.Extensions
{

    public class Cookies
    {

        public string VolunteerString = "IsEEVolunteer";
        public string VolunteerValue = "True";


        public void SetDeviceAsVolunteer()
        {
#if __WASM__
            var cookie = new Cookie(VolunteerString, VolunteerValue);
            var request = new SetCookieRequest(cookie)
            {
                Path = "/",
                Expires = DateTimeOffset.UtcNow.AddDays(999),
                Secure = true,
            };

            CookieManager.GetDefault().SetCookie(request);
#endif
        }


        public bool isDeviceVolunteer()
        {

#if __WASM__
            var cookies = CookieManager.GetDefault().GetCookies();
            foreach (var cookie in cookies)
            {
                if (cookie.Name == VolunteerString & cookie.Value == VolunteerValue)
                {
                    if (UI.IsDeviceMobile() == true)
                    {
                        return true;
                    }
                }
            }

            return false;
#endif

            return false;
        }
    }


}
