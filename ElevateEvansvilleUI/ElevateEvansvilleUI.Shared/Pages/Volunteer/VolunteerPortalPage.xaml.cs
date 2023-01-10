using ElevateEvansvilleUI.API.DTOs;
using ElevateEvansvilleUI.Controls;
using ElevateEvansvilleUI.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ElevateEvansvilleUI.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class VolunteerPortalPage : Page
    {
        public VolunteerPortalPage()
        {
            this.InitializeComponent();
        }

        AccountsDTO CurrentUserAccount = new AccountsDTO();

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (Cookies.GetVolunteerInfo() != null)
            {
                CurrentUserAccount = Cookies.GetVolunteerInfo();
                WelcomeMessage.Text = "Welcome, " + CurrentUserAccount.FirstName;
            }
        }

        private async void PrintPetition_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://elevateevansville-my.sharepoint.com/:b:/p/tyler_wandtke/ERHQyfh6eaxBkRtocmJsAggBzYQm_KtmEyz7doeS8ICz_Q?e=evKzCS"));
        }

        private async void TurnInPetition_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("mailto:Tyler.wandtke@ElevateEvansville.com?Subject=Petition%20Turn-In%20Request"));
        }
    }
}
