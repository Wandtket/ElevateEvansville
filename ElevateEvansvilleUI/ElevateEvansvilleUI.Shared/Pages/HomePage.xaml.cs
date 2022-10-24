using ElevateEvansvilleUI.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ElevateEvansvilleUI.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomePage : Page
    {
        public HomePage()
        {
            this.InitializeComponent();
        }

        private CurrentViewItem CurrentItem = CurrentViewItem.Featured;


        private bool ScrollInitialized = false;
        private void HomeGrid_PointerWheelChanged(object sender, PointerRoutedEventArgs e)
        {
            if (ScrollInitialized == false)
            {
                ScrollInitialized = true;

                var delta = e.GetCurrentPoint((UIElement)sender).Properties.MouseWheelDelta;
                if (delta < 0)
                {
                    if (CurrentItem == CurrentViewItem.Featured)
                    {
                        ScrollDown();
                    }
                }

                if (delta > 0)
                {
                    if (CurrentItem == CurrentViewItem.Mission)
                    {
                        ScrollUp();
                    }
                }
            }
        }


        private bool _isSwiped;
        private void HomeGrid_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            if (e.IsInertial && !_isSwiped)
            {
                var swipedDistance = e.Cumulative.Translation.Y;

                if (Math.Abs(swipedDistance) <= 2) return;

                if (swipedDistance > 0)
                {
                    if (CurrentItem == CurrentViewItem.Mission)
                    {
                        ScrollUp();
                    }
                }
                else
                {
                    if (CurrentItem == CurrentViewItem.Featured)
                    {
                        ScrollDown();
                    }
                }
                _isSwiped = true;
            }



        }
        private void HomeGrid_ManipulationCompleted(object sender, ManipulationCompletedRoutedEventArgs e)
        {
            _isSwiped = false;
        }



        private async void ScrollDown()
        {
            MissionControl.MissionGrid.Visibility = Visibility.Visible;

            DWBeginAnimation1.From = (double)0;
            DWBeginAnimation1.To = -(double)FeaturedControl.ActualHeight;

            DWBeginAnimation2.From = (double)FeaturedControl.ActualHeight;
            DWBeginAnimation2.To = (double)0;
            DWBeginStoryBoard.Begin();

            DWBeginStoryBoard.Completed += async delegate (object sender, object e)
            {
                ScrollInitialized = false;
                CurrentItem = CurrentViewItem.Mission;
            };
        }

        private async void ScrollUp()
        {
            UPBeginAnimation1.From = (double)0;
            UPBeginAnimation1.To = (double)MissionControl.ActualHeight;

            UPBeginAnimation2.From = -(double)MissionControl.ActualHeight;
            UPBeginAnimation2.To = (double)0;
            UPBeginStoryBoard.Begin();

            UPBeginStoryBoard.Completed += delegate (object sender, object e)
            {
                ScrollInitialized = false;
                CurrentItem = CurrentViewItem.Featured;
            };
        }

    }

    public enum CurrentViewItem
    {
        Featured,
        Mission,
    }
}
