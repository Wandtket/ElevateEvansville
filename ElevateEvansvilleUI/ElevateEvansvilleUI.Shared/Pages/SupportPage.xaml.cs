using ElevateEvansvilleUI.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Composition;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Hosting;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Graphics.DirectX;
using System.ServiceModel.Channels;
using ElevateEvansvilleUI.Controls.Dialogs;
using Windows.UI.Xaml.Media.Imaging;
using Windows.System;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ElevateEvansvilleUI.Pages
{

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SupportPage : Page
    {
        public SupportPage()
        {
            this.InitializeComponent();          
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            await Disclaimer.ShowAsync();
        }

        string SupportType = "";
        private async void Calendar_Click(object sender, RoutedEventArgs args)
        {
            MenuFlyoutItem item = (MenuFlyoutItem)sender;

            if (item == CalendarGoogle)
            {
                await Launcher.LaunchUriAsync(new Uri("https://calendar.google.com/calendar/u/1?cid=MzRmNDlkOTI1NTMyMjc0Y2FlNGI1NzU5N2E3NjRmMDE4MzgzN2Q4MDcwMGY1OTA2MWM2ZTUyMWNhMmQwZjZhNkBncm91cC5jYWxlbmRhci5nb29nbGUuY29t"));
            }
            else if (item == CalendarYahoo)
            {
                await Launcher.LaunchUriAsync(new Uri("https://calendar.yahoo.com/sxem6vowrtxs3tgrx2z7erfv2ko5vhbvp6b2mfka"));
            }
            else if (item == CalendarOutlook)
            {
                await Launcher.LaunchUriAsync(new Uri("https://outlook.office365.com/owa/calendar/b8864392e5cd4188b02d20b42c7e987b@ElevateEvansville.com/35e799d4044f40daae5130677a234e608806982325643298840/calendar.html"));
            }
        }

        private async void Promote_Click(object sender, RoutedEventArgs args)
        {
            Button BT = (Button)sender;

            PromoteAmount.Text = "";
            SupportType = BT.Tag.ToString();

            if (BT.Tag.ToString() == "Facebook")
            {
                PromoteLogo.Source = new BitmapImage(new Uri("ms-appx:///Assets/Images/Logos/Facebook.png"));
            }
            else if (BT.Tag.ToString() == "Google")
            {
                PromoteLogo.Source = new BitmapImage(new Uri("ms-appx:///Assets/Images/Logos/YouTube.png"));
            }
            else if (BT.Tag.ToString() == "TikTok")
            {
                PromoteLogo.Source = new BitmapImage(new Uri("ms-appx:///Assets/Images/Logos/TikTok.png"));               
            }
            else if (BT.Tag.ToString() == "Billboards")
            {
                PromoteLogo.Source = new BitmapImage(new Uri("ms-appx:///Assets/Images/Logos/BillboardsIn.png"));
            }
            else if (BT.Tag.ToString() == "Distribute")
            {
                PromoteLogo.Source = new BitmapImage(new Uri("ms-appx:///Assets/Images/Logos/Logo.png"));
            }

            await PromoteDialog.ShowAsync();
        }

        private async void Paypal_Click(object sender, ContentDialogButtonClickEventArgs args)
        {
            await Launcher.LaunchUriAsync(new Uri($"https://www.paypal.com/cgi-bin/webscr?business=paypal@elevateevansville.com&cmd=_xclick&currency_code=&amount={PromoteAmount.SelectedValue}&item_name={SupportType}&return=&cancel_return="));
        }

        private async void Share_Click(object sender, RoutedEventArgs args)
        {
            Button BT = (Button)sender;

            if (BT.Tag.ToString() == "Facebook")
            {
                await Launcher.LaunchUriAsync(new Uri("https://www.facebook.com/sharer/sharer.php?u=https://www.elevateevansville.com"));
            }
            else if (BT.Tag.ToString() == "Google")
            {
                PromoteLogo.Source = new BitmapImage(new Uri("ms-appx:///Assets/Images/Logos/YouTube.png"));
            }
            else if (BT.Tag.ToString() == "TikTok")
            {
                PromoteLogo.Source = new BitmapImage(new Uri("ms-appx:///Assets/Images/Logos/TikTok.png"));
            }
            else if (BT.Tag.ToString() == "Twitter")
            {
                await Launcher.LaunchUriAsync(new Uri("https://twitter.com/intent/tweet?url=https://www.ElevateEvansville.com&text="));
            }
            else if (BT.Tag.ToString() == "Billboards")
            {
                PromoteLogo.Source = new BitmapImage(new Uri("ms-appx:///Assets/Images/Logos/BillboardsIn.png"));
            }
        }


        private void TextBox_OnBeforeTextChanging(TextBox sender, TextBoxBeforeTextChangingEventArgs args)
        {
            args.Cancel = args.NewText.Any(c => !char.IsDigit(c));
        }

        private void Support_Click(object sender, RoutedEventArgs e)
        {
            UI.Navigate(typeof(FinancePage));
        }
    }
}
