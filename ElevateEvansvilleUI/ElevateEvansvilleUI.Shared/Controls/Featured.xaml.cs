using ElevateEvansvilleUI.Controls.Dialogs;
using ElevateEvansvilleUI.Extensions;
using ElevateEvansvilleUI.Pages;
using ElevateEvansvilleUI.Pages.Featured;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.ServiceModel.Channels;
using System.Threading;
using System.Threading.Tasks;
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
using DateTime = System.DateTime;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace ElevateEvansvilleUI.Controls
{
    public enum CurrentFeaturedlItem
    {
        Begin,
        F2,
        Final,
    }

    public sealed partial class Featured : UserControl
    {
        public CurrentFeaturedlItem CurrentItem = CurrentFeaturedlItem.Begin;


        public Featured()
        {
            this.InitializeComponent();
        }

        private async void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            F1Transition1.Begin();
            AutoScrollOver();

            await Task.Delay(1500);

            SetVisibility();
            ProfileSlideIn();
        }



        public static CancellationToken CancelToken = new CancellationToken();

        private bool Interacted = false;
        private async void AutoScrollOver()
        {        
            if (Interacted == false)
            {
                await Task.Delay(10000, CancelToken);
                GoForward();

                AutoScrollOver();
            }
        }



        private void SetVisibility()
        {
            F1After.Visibility = Visibility.Visible;
            F2After.Visibility = Visibility.Visible;
            F3After.Visibility = Visibility.Visible;

            F1Before.Visibility = Visibility.Visible;
            F2Before.Visibility = Visibility.Visible;
            F3Before.Visibility = Visibility.Visible;

            UIFadeIn.Begin();
        }



        private void Forward_Click(object sender, RoutedEventArgs e)
        {
            Interacted = true;
            GoForward();
        }

        private void Backward_Click(object sender, RoutedEventArgs e)
        {
            Interacted = true;
            GoBackward();
        }


        private void GoForward()
        {
            Forward.IsEnabled = false;
            Backward.IsEnabled = false;

            if (CurrentItem == CurrentFeaturedlItem.Begin)
            {
                AnimateForwardBegin();
            }
            else if (CurrentItem == CurrentFeaturedlItem.F2)
            {
                AnimateForwardF2();
            }
            else if (CurrentItem == CurrentFeaturedlItem.Final)
            {
                AnimateForwardFinal();
            }
        }

        private void GoBackward()
        {
            Forward.IsEnabled = false;
            Backward.IsEnabled = false;

            if (CurrentItem == CurrentFeaturedlItem.Begin)
            {
                AnimateBackwardBegin();
            }
            else if (CurrentItem == CurrentFeaturedlItem.F2)
            {
                AnimateBackwardF2();
            }
            else if (CurrentItem == CurrentFeaturedlItem.Final)
            {
                AnimateBackwardFinal();
            }
        }



        private void RailroadButton_Click(object sender, RoutedEventArgs e)
        {
            UI.AppFrame.Navigate(typeof(RailroadPage));
        }

        private void SolorCanopiesButton_Click(object sender, RoutedEventArgs e)
        {
            UI.AppFrame.Navigate(typeof(SolarCanopiesPage));
        }

        private void CostOfLivingButton_Click(object sender, RoutedEventArgs e)
        {
            UI.AppFrame.Navigate(typeof(CostOfLivingPage));
        }


        #region Animations
        public void AnimateForwardBegin()
        {
            F2.Visibility = Visibility.Visible;

            FWBeginAnimation1.From = (double)0;
            FWBeginAnimation1.To = -(double)F1.ActualWidth;

            FWBeginAnimation2.From = (double)F1.ActualWidth;
            FWBeginAnimation2.To = (double)0;

            FWBeginStoryBoard.Begin();

            FWBeginStoryBoard.Completed += delegate (object sender, object e)
            {
                F1.Visibility = Visibility.Collapsed;
                Forward.IsEnabled = true;
                Backward.IsEnabled = true;
            };


            F2Transition1.Begin();
            CurrentItem = CurrentFeaturedlItem.F2;
        }

        public void AnimateForwardF2()
        {
            F3.Visibility = Visibility.Visible;

            FWF2Animation1.From = (double)0;
            FWF2Animation1.To = -(double)F2.ActualWidth;

            FWF2Animation2.From = (double)F2.ActualWidth;
            FWF2Animation2.To = (double)0;

            FWF2StoryBoard.Begin();

            FWF2StoryBoard.Completed += delegate (object sender, object e)
            {
                F2.Visibility = Visibility.Collapsed;
                Forward.IsEnabled = true;
                Backward.IsEnabled = true;
            };

            F3Transition1.Begin();
            CurrentItem = CurrentFeaturedlItem.Final;
        }

        public void AnimateForwardFinal()
        {
            F1.Visibility = Visibility.Visible;

            FWFinalAnimation1.From = (double)0;
            FWFinalAnimation1.To = -(double)F3.ActualWidth;

            FWFinalAnimation2.From = (double)F3.ActualWidth;
            FWFinalAnimation2.To = (double)0;

            FWFinalStoryBoard.Begin();

            FWFinalStoryBoard.Completed += delegate (object sender, object e)
            {
                F3.Visibility = Visibility.Collapsed;
                Forward.IsEnabled = true;
                Backward.IsEnabled = true;
            };

            CurrentItem = CurrentFeaturedlItem.Begin;
        }


        public void AnimateBackwardBegin()
        {
            F3.Visibility = Visibility.Visible;
            F2.Visibility = Visibility.Collapsed;

            BWBeginAnimation1.From = (double)0;
            BWBeginAnimation1.To = (double)F1.ActualWidth;

            BWBeginAnimation2.From = -(double)F1.ActualWidth;
            BWBeginAnimation2.To = (double)0;

            BWBeginStoryBoard.Begin();

            BWBeginStoryBoard.Completed += delegate (object sender, object e)
            {
                F1.Visibility = Visibility.Collapsed;
                Forward.IsEnabled = true;
                Backward.IsEnabled = true;
            };

            CurrentItem = CurrentFeaturedlItem.Final;
        }

        public void AnimateBackwardF2()
        {
            F1.Visibility = Visibility.Visible;

            BWF2Animation1.From = (double)0;
            BWF2Animation1.To = (double)F2.ActualWidth;

            BWF2Animation2.From = -(double)F2.ActualWidth;
            BWF2Animation2.To = (double)0;

            BWF2StoryBoard.Begin();

            BWF2StoryBoard.Completed += delegate (object sender, object e)
            {
                F2.Visibility = Visibility.Collapsed;
                Forward.IsEnabled = true;
                Backward.IsEnabled = true;
            };

            CurrentItem = CurrentFeaturedlItem.Begin;
        }

        public void AnimateBackwardFinal()
        {
            F2.Visibility = Visibility.Visible;

            BWFinalAnimation1.From = (double)0;
            BWFinalAnimation1.To = (double)F3.ActualWidth;

            BWFinalAnimation2.From = -(double)F3.ActualWidth;
            BWFinalAnimation2.To = (double)0;

            BWFinalStoryBoard.Begin();

            BWFinalStoryBoard.Completed += delegate (object sender, object e)
            {
                F3.Visibility = Visibility.Collapsed;
                Forward.IsEnabled = true;
                Backward.IsEnabled = true;
            };

            CurrentItem = CurrentFeaturedlItem.F2;
        }



        private bool ProfileShown = false;
        private void ProfileSlideIn()
        {
            ProfileShown = true;

            //ProfileStoryBoardFadeIn.Begin();


            ProfileSlideInAnimation.From = (double)50;
            ProfileSlideInAnimation.To = (double)0;


            ProfileStoryBoardSlideIn.Begin();
            Profile.Visibility = Visibility.Visible;
            ProfileStoryBoardFadeIn.Begin();
        }


        private void F1Transition1_Completed(object sender, object e)
        {
            F1Transition2.Begin();
        }

        private void F1Transition2_Completed(object sender, object e)
        {
            F1Transition3.Begin();
        }

        private void F1Transition3_Completed(object sender, object e)
        {
            F1Transition4.Begin();
        }

        private void F1Transition4_Completed(object sender, object e)
        {
            F1Transition1.Begin();
        }



        private void F2Transition1_Completed(object sender, object e)
        {
            F2Transition2.Begin();
        }

        private void F2Transition2_Completed(object sender, object e)
        {
            F2Transition3.Begin();
        }

        private void F2Transition3_Completed(object sender, object e)
        {
            F2Transition4.Begin();
        }

        private void F2Transition4_Completed(object sender, object e)
        {
            F2Transition1.Begin();
        }



        private void F3Transition1_Completed(object sender, object e)
        {
            F3Transition2.Begin();
        }

        private void F3Transition2_Completed(object sender, object e)
        {
            F3Transition3.Begin();
        }

        private void F3Transition3_Completed(object sender, object e)
        {
            F3Transition4.Begin();
        }

        private void F3Transition4_Completed(object sender, object e)
        {
            F3Transition1.Begin();
        }

        #endregion

    }


}
