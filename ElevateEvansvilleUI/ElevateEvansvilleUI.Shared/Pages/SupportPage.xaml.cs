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
            await Launcher.LaunchUriAsync(new Uri($"https://www.paypal.com/cgi-bin/webscr?business=tyler.wandtke@elevateevansville.com&cmd=_xclick&currency_code=USD&amount={PromoteAmount.Text}&item_name={SupportType}"));
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




    }
}
