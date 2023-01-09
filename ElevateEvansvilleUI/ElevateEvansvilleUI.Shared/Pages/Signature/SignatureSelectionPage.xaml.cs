using ElevateEvansvilleUI.Controls;
using ElevateEvansvilleUI.Extensions;
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
#if __WASM__
using Uno.Web.Http;
#endif

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ElevateEvansvilleUI.Pages.Signature
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SignatureSelectionPage : Page
    {
        public SignatureSelectionPage()
        {
            this.InitializeComponent();
        }

        private void SignRequestButton_Click(object sender, RoutedEventArgs e)
        {
            UI.Navigate(typeof(SignatureRequestPage));
        }

        private void VolunteerButton_Click(object sender, RoutedEventArgs e)
        {

            //UI.Navigate(typeof(SignatureVolunteerPage));
        }

        private void DownloadButton_Click(object sender, RoutedEventArgs e)
        {
            UI.Navigate(typeof(SignatureToolsPage));
        }
    }
}
