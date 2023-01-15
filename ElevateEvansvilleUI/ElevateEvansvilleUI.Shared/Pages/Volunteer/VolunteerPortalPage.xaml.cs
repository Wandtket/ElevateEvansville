using ElevateEvansvilleUI.API.DTOs;
using ElevateEvansvilleUI.API.Requests;
using ElevateEvansvilleUI.API.Services;
using ElevateEvansvilleUI.Controls;
using ElevateEvansvilleUI.Controls.Dialogs;
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

        AccountService service = new AccountService();
        AccountsDTO CurrentUserAccount = new AccountsDTO();

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (Cookies.GetVolunteerInfo() != null)
            {
                CurrentUserAccount = Cookies.GetVolunteerInfo();
                WelcomeMessage.Text = "Welcome, " + CurrentUserAccount.FirstName;
            }

            ConfigureUI();
        }

        private void ConfigureUI()
        {
            if (UI.IsDeviceMobile() == false)
            {
                SignatureBlock.Width = 555;
                SecurityBlock.Width = 555;
            }
        }

        private async void LogOut_Click(object sender, RoutedEventArgs e)
        {
            var result = await ConfirmBox.Show("", "Log Out?");
            if (result == ContentDialogResult.Primary)
            {
                Cookies.ClearCookies();
                UI.Navigate(typeof(HomePage));
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

        private async void ChangeEmail_Click(object sender, RoutedEventArgs e)
        {
            var result = await ChangeEmailDialog.ShowAsync();
            if (result == ContentDialogResult.Primary)
            {
                AccountUpdateRequest request = new AccountUpdateRequest();
                request.CurrentEmail = "";
                request.NewEmail = "";
                request.CurrentPassword = "";
                request.NewPassword = "";
                request.NewPhone = "";

                request.CurrentPassword = Security.HashPassword(ChangeEmailPassword.Password);
                request.CurrentEmail = CurrentUserAccount.Email;
                request.NewEmail = ChangeEmailEmail.Text;

                var ReturnDto = await service.Update(request);

                if (ReturnDto != null)
                {
                    CurrentUserAccount = ReturnDto;
                    Cookies.SaveVolunteerInfo(CurrentUserAccount);
                    await MessageBox.Show("The requested changes have been made.", "Success");
                }
                else
                {
                    await MessageBox.Show("Please try again.", "Password Incorrect");
                }
            }
        }

        private async void ChangePassword_Click(object sender, RoutedEventArgs e)
        {
            var result = await ChangePasswordDialog.ShowAsync();
        }

        private async void ChangePhone_Click(object sender, RoutedEventArgs e)
        {
            var result = await ChangePhoneDialog.ShowAsync();

        }
    }
}
