using ElevateEvansvilleUI.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
    public sealed partial class AboutPage : Page
    {
        public AboutPage()
        {
            this.InitializeComponent();


#if __WASM__
            //WebAssemblyHtmlControl control = new WebAssemblyHtmlControl();
            //control.SetHtmlContent("<button type=\"button\" onclick=\"alert('hello!')\" name=\"myButton\">Button</button>");
            //control.VerticalAlignment = VerticalAlignment.Center;

            //TestGrid.Children.Add(control); 
#endif

        }

        private async void BirthCert_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://i.imgur.com/eXS2MI6.png"));
        }

        private async void CCAF_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://i.imgur.com/cAwHNiP.png"));
        }

        private async void Discharge_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://i.imgur.com/dnFdKh9.png"));
        }

        private async void Candidacy_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri(""));
        }

        private async void TaxReturns_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri(""));
        }


    }
}
