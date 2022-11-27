using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Windows.UI.Xaml.Controls;
using System.IO;
using System.Linq;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml;
using System.ServiceModel.Description;
using ElevateEvansvilleUI.Controls.Dialogs;
using System.Threading.Tasks;
using System.Security.AccessControl;
using ElevateEvansvilleUI.Pages;
using Windows.Web.AtomPub;
#if __WASM__
using Uno.Foundation;
#endif

namespace ElevateEvansvilleUI.Extensions
{
    public static class UI
    {
        /// <summary>
        /// Access the MainPage's AppFrame from anywhere.
        /// </summary>
        public static Frame AppFrame;

        public static Grid LoadingGrid;
        public static Storyboard LoadingFadeIn;

        public static XamlRoot MainRoot;

        public static Button SupportButton;

        private static Type SourceType;

        public static void Navigate(Type sourceType)
        {
            SourceType = sourceType;
            LoadingGrid.Visibility = Visibility.Visible;
            LoadingFadeIn.Begin();
        }

        public static async void LoadingFadeIn_Completed(object sender, object e)
        {
            Navigation.PushURI(SourceType.Name.Replace("Page", ""));
            AppFrame.Navigate(SourceType);

            //Hide Support Button if on SupportPage
            if (SourceType != typeof(SupportPage))
            {
                SupportButton.Visibility = Visibility.Visible;
            }
            else if (SourceType == typeof(SupportPage))
            {
                SupportButton.Visibility = Visibility.Collapsed;
            }
        }

        public static void AppFrame_Navigated(object sender, Windows.UI.Xaml.Navigation.NavigationEventArgs e)
        {
            LoadingGrid.Visibility = Visibility.Collapsed;
        }


        /// <summary>
        /// Detect the user agent of the browser in Web Assembly for mobile devices.
        /// </summary>
        /// <returns></returns>
        public static bool IsDeviceMobile()
        {
#if __WASM__
            return Convert.ToBoolean(WebAssemblyRuntime.InvokeJS("IsDeviceMobile();"));                 
#endif
            return false;
        }


        /// <summary>
        /// Detect the user agent of the browser in Web Assembly for mobile devices.
        /// </summary>
        /// <returns></returns>
        public static double GetDeviceWidth()
        {
#if __WASM__
            return Convert.ToDouble(WebAssemblyRuntime.InvokeJS("window.outerWidth"));                 
#endif
            return 400;
        }


    }



}
