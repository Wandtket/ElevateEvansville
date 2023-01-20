using ElevateEvansvilleUI.Controls.Dialogs;
using ElevateEvansvilleUI.Pages;
using ElevateEvansvilleUI.Pages.Featured;
using System;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace ElevateEvansvilleUI.Extensions
{
    public class Navigation
    {

        public static string CurrentURI;


        public static async Task<string> GetURI()
        {
#if __WASM__
            if (System.Uri.TryCreate(Uno.Foundation.WebAssemblyRuntime.InvokeJS("document.location.href"),
                UriKind.RelativeOrAbsolute, out var browserUrl))
            {
                await Task.Delay(100);
                return browserUrl.GetComponents(System.UriComponents.Path, UriFormat.Unescaped);
            }
#endif
            return "";
        }


        public static async void HandleURI()
        {
#if __WASM__
            string CurrentURI = await GetURI();

            UI.SupportButton.Visibility = Windows.UI.Xaml.Visibility.Visible;

            if (CurrentURI.Contains("Platform")) { UI.Navigate(typeof(PlatformPage)); }
            else if (CurrentURI.Contains("About")) { UI.Navigate(typeof(AboutPage)); }
            else if (CurrentURI.Contains("Finance")) { UI.Navigate(typeof(FinancePage)); }
            else if (CurrentURI.Contains("Support")) 
            {
                UI.SupportButton.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                UI.Navigate(typeof(SupportPage)); 
            }

            else if (CurrentURI.Contains("Railroad")) { UI.Navigate(typeof(RailroadPage)); }
            else if (CurrentURI.Contains("Housing")) { UI.Navigate(typeof(HousingPage)); }
            else if (CurrentURI.Contains("Energy")) { UI.Navigate(typeof(EnergyPage)); }

            else if (CurrentURI.Contains("SignatureRequest")) { UI.Navigate(typeof(PetitionPage)); }
            else if (CurrentURI.Contains("Petition")) { UI.Navigate(typeof(PetitionPage)); }

            else if (CurrentURI.Contains("SignatureTools")) { UI.Navigate(typeof(VolunteerLoginPage)); }
            else if (CurrentURI.Contains("SignatureVolunteer")) { UI.Navigate(typeof(VolunteerLoginPage)); }
            else if (CurrentURI.Contains("Volunteer")) { UI.Navigate(typeof(VolunteerLoginPage)); }
            else if (CurrentURI.Contains("VolunteerLogin")) { UI.Navigate(typeof(VolunteerLoginPage)); }

            else
            {
                if (Cookies.GetVolunteerInfo() != null)
                {
                    UI.Navigate(typeof(VolunteerPortalPage)); 
                }
                else 
                {
                    UI.Navigate(typeof(HomePage));
                    Navigation.ReplaceURI("Home");
                }
            }           
#endif
        }

        public static async void HandleBackward()
        {

        }



        public static void PushURI(string Route)
        {
#if __WASM__
            Uno.Foundation.WebAssemblyRuntime.InvokeJS($"PushURL('{Route}')");
#endif
        }

        public static void ReplaceURI(string Route)
        {
#if __WASM__
            Uno.Foundation.WebAssemblyRuntime.InvokeJS($"ReplaceURL('{Route}')");
#endif
        }



    }
}