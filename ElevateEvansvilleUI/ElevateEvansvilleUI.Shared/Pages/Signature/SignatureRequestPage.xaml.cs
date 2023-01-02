using ElevateEvansvilleUI.API.DTOs;
using ElevateEvansvilleUI.API.Services;
using ElevateEvansvilleUI.Controls;
using ElevateEvansvilleUI.Controls.Dialogs;
using ElevateEvansvilleUI.Extensions;
using PhoneNumbers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.Json;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Networking;
using Windows.System;
using Windows.UI;
using Windows.UI.WebUI;
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
    public sealed partial class SignatureRequestPage : Page
    {

        public SignatureRequestPage()
        {
            this.InitializeComponent();

            PopulateTimes();

            OriginalBrush = LastName.BorderBrush;
            OriginalForeground = CheckboxMonday.Foreground;
        }

        SignatureService service = new SignatureService();

        Brush OriginalBrush = null;
        Brush OriginalForeground = null;

        private void PopulateTimes()
        {
            for (int i = 1; i <= 12; i++)
            {
                TimeStartHour.Items.Add(i.ToString());
                TimeEndHour.Items.Add(i.ToString());
            }

            for (int i = 0; i <= 60; i++)
            {
                if (i.ToString().Length == 1)
                {
                    TimeStartMinute.Items.Add("0" + i.ToString());
                    TimeEndMinute.Items.Add("0" + i.ToString());
                }
                else
                {
                    TimeStartMinute.Items.Add(i.ToString());
                    TimeEndMinute.Items.Add(i.ToString());
                }
            }

            TimeStartAM.Items.Add("AM");
            TimeStartAM.Items.Add("PM");
            TimeStartAM.SelectedIndex = 1;

            TimeEndAM.Items.Add("AM");
            TimeEndAM.Items.Add("PM");
            TimeEndAM.SelectedIndex = 1;
        }

        private async void SubmitButton_Click(object sender, RoutedEventArgs e)
        {     
            bool Validated = ValidateForm();

            if (Validated == true)
            {
                var result = await ConfirmBox.Show("You will receive a text message 15-30 minutes before a volunteer will arrive at the address you specify." + 
                    Environment.NewLine + Environment.NewLine +
                    "To cancel the request at a later date click the 'Cancel Existing Request' button at the bottom of this form.",                 
                    "Confirm Submission?");

                if (result == ContentDialogResult.Primary)
                {
                    SignaturesDTO dto = new SignaturesDTO();
                    dto.SignaturesID = 0;

                    dto.LastName = LastName.Text;
                    dto.FirstName = FirstName.Text;
                    dto.Address = Address.Text;
                    dto.Zip = Zip.Text;
                    dto.Phone = Phone.Text;
                    dto.Email = Email.Text;

                    dto.PreferredTimeStart = DateTime.Now;
                    dto.PreferredTimeEnd = DateTime.Now;

                    dto.PrefersMonday = (bool)CheckboxMonday.IsChecked;
                    dto.PrefersTuesday = (bool)CheckboxTuesday.IsChecked;
                    dto.PrefersWednesday = (bool)CheckboxWednesday.IsChecked;
                    dto.PrefersThursday = (bool)CheckboxThursday.IsChecked;
                    dto.PrefersFriday = (bool)CheckboxFriday.IsChecked;
                    dto.PrefersSaturday = (bool)CheckboxSaturday.IsChecked;
                    dto.PrefersSunday = (bool)CheckboxSunday.IsChecked;

                    dto.MaskRequested = (bool)CheckboxMask.IsChecked;
                    dto.NotHome = false;
                    dto.SignatureCollected = false;
                    dto.SignatureCount = 0;
                    dto.SignatureCollectedDateTime = DateTime.Now;
                    dto.SignatureCollectedUserId = 0;

                    await MessageBox.Show(JsonSerializer.Serialize<SignaturesDTO>(dto));

                    var message = await service.SubmitRequest(dto);

                    await MessageBox.Show(message);
                }
            }
        }


        private bool ValidateForm()
        {
            bool Validated = true;           

            if (LastName.Text == "") { LastName.BorderBrush = new SolidColorBrush(Colors.Red); Validated = false; }
            if (FirstName.Text == "") { FirstName.BorderBrush = new SolidColorBrush(Colors.Red); Validated = false; }
            if (Address.Text == "") { Address.BorderBrush = new SolidColorBrush(Colors.Red); Validated = false; }
            if (Zip.Text == "") { Zip.BorderBrush = new SolidColorBrush(Colors.Red); Validated = false; }

            if (!Zip.Text.Contains("47708") &&
                !Zip.Text.Contains("47710") &&
                !Zip.Text.Contains("47711") &&
                !Zip.Text.Contains("47712") &&
                !Zip.Text.Contains("47713") &&
                !Zip.Text.Contains("47714") &&
                !Zip.Text.Contains("47715") &&
                !Zip.Text.Contains("47720") &&
                !Zip.Text.Contains("47725"))
            {
                Zip.BorderBrush = new SolidColorBrush(Colors.Red); Validated = false;
            }

            if (Email.Text == "") { Email.BorderBrush = new SolidColorBrush(Colors.Red); Validated = false; }
            if (new EmailAddressAttribute().IsValid(Email.Text) == false) { Email.BorderBrush = new SolidColorBrush(Colors.Red); Validated = false; }

            if (Phone.Text == "") { Phone.BorderBrush = new SolidColorBrush(Colors.Red); Validated = false; }
            if (PhoneNumberUtil.IsViablePhoneNumber(Phone.Text) == false) { Phone.BorderBrush = new SolidColorBrush(Colors.Red); Validated = false; }

            if (CheckboxAnytime.IsChecked == false)
            {
                if (TimeStartHour.SelectedIndex == -1) { TimeStartHour.BorderBrush = new SolidColorBrush(Colors.Red); Validated = false; }
                if (TimeStartMinute.SelectedIndex == -1) { TimeStartMinute.BorderBrush = new SolidColorBrush(Colors.Red); Validated = false; }
                if (TimeStartAM.SelectedIndex == -1) { TimeStartAM.BorderBrush = new SolidColorBrush(Colors.Red); Validated = false; }

                if (TimeEndHour.SelectedIndex == -1) { TimeEndHour.BorderBrush = new SolidColorBrush(Colors.Red); Validated = false; }
                if (TimeEndMinute.SelectedIndex == -1) { TimeEndMinute.BorderBrush = new SolidColorBrush(Colors.Red); Validated = false; }
                if (TimeEndAM.SelectedIndex == -1) { TimeEndAM.BorderBrush = new SolidColorBrush(Colors.Red); Validated = false; }
            }

            if (CheckboxMonday.IsChecked == false &&
                CheckboxTuesday.IsChecked == false &&
                CheckboxWednesday.IsChecked == false &&
                CheckboxThursday.IsChecked == false &&
                CheckboxFriday.IsChecked == false &&
                CheckboxSaturday.IsChecked == false &&
                CheckboxSunday.IsChecked == false)
            {
                CheckboxMonday.Foreground = new SolidColorBrush(Colors.Red);
                CheckboxTuesday.Foreground = new SolidColorBrush(Colors.Red);
                CheckboxWednesday.Foreground = new SolidColorBrush(Colors.Red);
                CheckboxThursday.Foreground = new SolidColorBrush(Colors.Red);
                CheckboxFriday.Foreground = new SolidColorBrush(Colors.Red);
                CheckboxSaturday.Foreground = new SolidColorBrush(Colors.Red);
                CheckboxSunday.Foreground = new SolidColorBrush(Colors.Red);
                Validated = false; 
            }

            return Validated;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox Box = (TextBox)sender;
            Box.BorderBrush = OriginalBrush;
        }

        private void TimePicker_SelectedItemChanged(TimePicker sender, TimePickerSelectedValueChangedEventArgs args)
        {
            TimePicker Picker = (TimePicker)sender;
            Picker.BorderBrush = OriginalBrush;
        }

        private void Checkbox_Click(object sender, RoutedEventArgs e)
        {
            CheckboxMonday.Foreground = OriginalForeground;
            CheckboxTuesday.Foreground = OriginalForeground;
            CheckboxWednesday.Foreground = OriginalForeground;
            CheckboxThursday.Foreground = OriginalForeground;
            CheckboxFriday.Foreground = OriginalForeground;
            CheckboxSaturday.Foreground = OriginalForeground;
            CheckboxSunday.Foreground = OriginalForeground;
        }

        private void CheckboxAnyTime_Click(object sender, RoutedEventArgs e)
        {
            TimeStartHour.IsEnabled = !TimeStartHour.IsEnabled;
            TimeStartMinute.IsEnabled = !TimeStartMinute.IsEnabled;
            TimeStartAM.IsEnabled = !TimeStartAM.IsEnabled;

            TimeEndHour.IsEnabled = !TimeEndHour.IsEnabled;
            TimeEndMinute.IsEnabled = !TimeEndMinute.IsEnabled;
            TimeEndAM.IsEnabled = !TimeEndAM.IsEnabled;
        }
    }
}
