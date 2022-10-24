using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Windows.UI.Xaml.Controls;
#if __WASM__
using Uno.Foundation;
#endif

namespace ElevateEvansvilleUI.Extensions
{
    public static class WebUI
    {
        /// <summary>
        /// Access the MainPage's AppFrame from anywhere.
        /// </summary>
        public static Frame AppFrame;

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



    }



}
