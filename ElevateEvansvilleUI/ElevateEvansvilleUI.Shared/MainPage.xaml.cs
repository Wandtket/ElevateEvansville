using ElevateEvansvilleUI.API;
using ElevateEvansvilleUI.Controls.Dialogs;
using ElevateEvansvilleUI.Extensions;
using ElevateEvansvilleUI.Pages;
using Microsoft.VisualBasic;
using System;
using System.Collections;
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
            
            //Set the static AppFrame so it can be accessed anywhere in the app.
            WebUI.AppFrame = this.AppFrame;
        }


        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            WebUI.AppFrame.Navigate(typeof(HomePage));

            await Task.Delay(1500);
            UIFadeIn.Begin();
        }



        private void Home_Click(object sender, RoutedEventArgs e)
        {
            WebUI.AppFrame.Navigate(typeof(HomePage));
        }


        private void About_Click(object sender, RoutedEventArgs e)
        {
            WebUI.AppFrame.Navigate(typeof(AboutPage));
        }

        private async void Platform_Click(object sender, RoutedEventArgs e)
        {
            WebUI.AppFrame.Navigate(typeof(PlatformPage));
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
            await Launcher.LaunchUriAsync(new Uri("mailto:Tyler.wandtke@ElevateEvansville.com?Subject=Interview%20Request"));
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
            WebUI.AppFrame.Navigate(typeof(SupportPage));
            Support.Visibility = Visibility.Collapsed;

            #if __WASM__
                    //this.ExecuteJavascript("requestPermission();");
            #endif

            #if __WASM__
                    //this.ExecuteJavascript("persistentNotification();");
            #endif

        }


        private void AppFrame_Navigated(object sender, NavigationEventArgs e)
        {
            Support.Visibility = Visibility.Visible;
        }

    }

}
