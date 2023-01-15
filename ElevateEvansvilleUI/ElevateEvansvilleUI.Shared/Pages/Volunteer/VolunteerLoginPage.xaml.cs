using ElevateEvansvilleUI.API.DTOs;
using ElevateEvansvilleUI.API.Services;
using ElevateEvansvilleUI.Controls;
using ElevateEvansvilleUI.Controls.Dialogs;
using ElevateEvansvilleUI.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.ServiceModel.Channels;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI;
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
    public sealed partial class VolunteerLoginPage : Page
    {
        AccountService service = new AccountService();

        public VolunteerLoginPage()
        {
            this.InitializeComponent();
        }

        private async void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            string HashedPassword = Security.HashPassword(PasswordLogin.Password);

            AccountsDTO dto = new AccountsDTO();
            dto.Email = EmailLogin.Text;
            dto.LastName = "";
            dto.FirstName = "";
            dto.Phone = "";
            dto.MachineId = "";
            dto.Password = HashedPassword;

            var Account = await service.Validate(dto);

            if (Account != null) 
            {
                Cookies.SaveVolunteerInfo(Account);
                UI.Navigate(typeof(VolunteerPortalPage));
            }
            if (Account == null)
            {
                await MessageBox.Show("Please try again.", "Password Incorrect");
            }
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            SignInGrid.Visibility = Visibility.Collapsed;  
            NoticeGrid.Visibility = Visibility.Visible;
            SignUpGrid.Visibility = Visibility.Collapsed;
        }

        private async void SignUpSubmittButton_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateForm() == true)
            {
                Button BT = (Button)sender;
                BT.IsEnabled = false;

                AccountsDTO dto = new AccountsDTO();
                dto.LastName = LastName.Text;
                dto.FirstName = FirstName.Text;
                dto.Phone = Phone.Text;
                dto.Email = EmailSignUp.Text;
                
                if (UI.IsDeviceMobile() == true)
                {
                    dto.MachineId = UI.GetMachineId();                    
                }
                else { dto.MachineId = ""; }

                dto.Password = Security.HashPassword(ConfirmPasswordSignUp.Password);

                string AccountStatus = await service.Create(dto);

                if (AccountStatus.Contains("Success"))
                {
                    await MessageBox.Show("Please continue to login.", AccountStatus);                  
                    ClearForm();
                    DismissSignUp();
                }
                else if (AccountStatus.Contains("Email"))
                {
                    await MessageBox.Show("Please try logging in or request a password reset.", AccountStatus);
                }
                else if (AccountStatus.Contains("Error"))
                {
                    await MessageBox.Show("Please try again later.", AccountStatus);
                }

                BT.IsEnabled = true;
            }
        }

        

        private bool ValidateForm()
        {
            bool Validated = true;

            if (LastName.Text == "") { LastName.BorderBrush = new SolidColorBrush(Colors.Red); Validated = false; }
            if (FirstName.Text == "") { FirstName.BorderBrush = new SolidColorBrush(Colors.Red); Validated = false; }
            if (EmailSignUp.Text == "") { EmailSignUp.BorderBrush = new SolidColorBrush(Colors.Red); Validated = false; }
            if (Phone.Text == "") { Phone.BorderBrush = new SolidColorBrush(Colors.Red); Validated = false; }
            if (PasswordSignUp.Password == "") { PasswordSignUp.BorderBrush = new SolidColorBrush(Colors.Red); Validated = false; }
            if (ConfirmPasswordSignUp.Password == "") { ConfirmPasswordSignUp.BorderBrush = new SolidColorBrush(Colors.Red); Validated = false; }

            if (PasswordSignUp.Password != ConfirmPasswordSignUp.Password) 
            {
                PasswordSignUp.BorderBrush = new SolidColorBrush(Colors.Red);
                ConfirmPasswordSignUp.BorderBrush = new SolidColorBrush(Colors.Red);           
                Validated = false;            
            }

            return Validated;
        }

        private void ClearForm()
        {
            LastName.Text = "";
            FirstName.Text = "";
            EmailSignUp.Text = "";
            Phone.Text = "";
            PasswordSignUp.Password = "";
            ConfirmPasswordSignUp.Password = "";
        }

        private void DismissSignUp()
        {
            SignInGrid.Visibility = Visibility.Visible;
            NoticeGrid.Visibility = Visibility.Collapsed;
            SignUpGrid.Visibility = Visibility.Collapsed;
        }

        private async void ForgotPasswordButton_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("mailto:Tyler.wandtke@ElevateEvansville.com?Subject=Forgot%20Password"));
        }

        private void SignUpContinueButton_Click(object sender, RoutedEventArgs e)
        {
            SignInGrid.Visibility = Visibility.Collapsed;
            NoticeGrid.Visibility = Visibility.Collapsed;
            SignUpGrid.Visibility = Visibility.Visible;
        }

        private void SignUpDismissButton_Click(object sender, RoutedEventArgs e)
        {
            DismissSignUp();
        }
    }
}
