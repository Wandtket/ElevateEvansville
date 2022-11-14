using ElevateEvansvilleUI.API;
using ElevateEvansvilleUI.API.Services;
using ElevateEvansvilleUI.Controls.Dialogs;
using ElevateEvansvilleUI.DTOs;
using ElevateEvansvilleUI.Extensions;
using ElevateEvansvilleUI.Pages;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;
using Windows.Storage;
using Windows.System;
using Windows.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ElevateEvansvilleUI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            UIGrid.Opacity = 0;

            //Set the static AppFrame so it can be accessed anywhere in the app.
            WebUI.AppFrame = this.AppFrame;
            WebUI.LoadingGrid = this.LoadingGrid;
            WebUI.LoadingFadeIn = this.LoadingFadeIn;
            WebUI.SupportButton = this.Support;

            this.AppFrame.Navigated += WebUI.AppFrame_Navigated;
            this.LoadingFadeIn.Completed += WebUI.LoadingFadeIn_Completed;
        }


        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            AppFrame.Navigate(typeof(HomePage));

            await Task.Delay(1500);
            UIFadeIn.Begin();
        }


        private void Home_Click(object sender, RoutedEventArgs e)
        {
            WebUI.Navigate(typeof(HomePage));
        }


        private void About_Click(object sender, RoutedEventArgs e)
        {
            WebUI.Navigate(typeof(AboutPage));
        }

        private void Platform_Click(object sender, RoutedEventArgs e)
        {
            WebUI.Navigate(typeof(PlatformPage));
        }

        private async void ContactQuestion_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("mailto:Tyler.wandtke@ElevateEvansville.com?Subject=Question"));
        }

        private async void ContactInterview_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("mailto:Tyler.wandtke@ElevateEvansville.com?Subject=Interview%20Request"));
        }

        private async void Facebook_Click(object sender, TappedRoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://www.facebook.com/profile.php?id=100085610254522"));
        }

        private async void Twitter_Click(object sender, TappedRoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://twitter.com/TylerWandtke"));
        }

        private async void TikTok_Click(object sender, TappedRoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://www.tiktok.com/@elevateevansville?is_from_webapp=1&sender_device=pc"));
        }

        private async void Github_Click(object sender, TappedRoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://github.com/Wandtket"));
        }

        private async void Terms_Click(object sender, RoutedEventArgs e)
        {

            await Launcher.LaunchUriAsync(new Uri("https://elevateevansville-my.sharepoint.com/:b:/p/tyler_wandtke/EUUTKo7pxXhKtHuCiSoIq0oBYcge_3imCopk-UzKoZaa_g?e=nGWfvL"));
        }

        private async void Privacy_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://elevateevansville-my.sharepoint.com/:b:/p/tyler_wandtke/EeYaD_3LFPlEilDDnmIrh4MBtblOT6qUUraVnyKVYCXxkw?e=noLRgu"));
        }


        private async void Support_Click(object sender, RoutedEventArgs e)
        {
            //var file = await Windows.Storage.StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///Assets/Election Day Calendar.ics"));
            //await Launcher.LaunchUriAsync(new Uri("ms-appx:///Assets/Election Day Calendar.ics"));

            //string Message = await APIClient.Get();
            //TransactionSearchApi client = new TransactionSearchApi();
            //TransactionListDTO list = await client.SearchTransactions();

            ////Support.Content = List.Count().ToString();

            ////var list = await APIClient.Get();

            //string Message = "";



            //await MessageBox.Show(list.Transactions.Count().ToString());

            //foreach (TransactionsDTO DTO in list.Transactions)
            //{
            //    Message = Message + DTO.Payer + Environment.NewLine;
            //}

            //await MessageBox.Show(Message);
            //await MessageBox.Show(list.Count().ToString());

            WebUI.Navigate(typeof(SupportPage));
            Support.Visibility = Visibility.Collapsed;

#if __WASM__
                    //this.ExecuteJavascript("requestPermission();");
#endif

#if __WASM__
                    //this.ExecuteJavascript("persistentNotification();");
#endif

        }


    }

}
