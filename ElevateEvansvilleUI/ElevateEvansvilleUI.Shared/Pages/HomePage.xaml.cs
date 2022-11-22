using ElevateEvansvilleUI.Controls;
using ElevateEvansvilleUI.Controls.Dialogs;
using ElevateEvansvilleUI.Extensions;
using ElevateEvansvilleUI.Pages.Featured;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using System.Threading;
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
    public enum CurrentFeaturedlItem
    {
        Begin,
        F2,
        F3,
        Final,
    }


    public sealed partial class HomePage : Page
    {
        public CurrentFeaturedlItem CurrentItem = CurrentFeaturedlItem.Begin;


        public HomePage()
        {
            this.InitializeComponent();
        }


        private async void F1Before_Loaded(object sender, RoutedEventArgs e)
        {
            if (UI.IsDeviceMobile() == true) 
            { AdjustForMobile(); }


            F1Transition1.Begin();

            AutoScrollOver();

            await Task.Delay(1500);

            SetVisibility();
            ProfileSlideIn();
        }

        private void AdjustForMobile()
        {
            ProfileWidth.Width = new GridLength(1, GridUnitType.Star);
            ProfileHeight.Height = new GridLength(1, GridUnitType.Star);

            F1Before.Margin = new Thickness(-100, 0, 0, 0);
            F1After.Margin = new Thickness(-100, 0, 0, 0);

            F4Before.Margin = new Thickness(-100, 0, 0, 0);
            F4After.Margin = new Thickness(-100, 0, 0, 0);
        }


        CancellationTokenSource CancelToken = new CancellationTokenSource();
        private bool Interacted = false;

        private async void AutoScrollOver()
        {
            if (Interacted == false)
            {         
                //Cancel the auto scroll over if the user clicks the next button
                try 
                { 
                    await Task.Delay(10000, CancelToken.Token);

                    GoForward();
                    AutoScrollOver();

                } catch { }
               
            }
        }



        private void SetVisibility()
        {
            F1After.Visibility = Visibility.Visible;
            F2After.Visibility = Visibility.Visible;
            F3After.Visibility = Visibility.Visible;
            F4After.Visibility = Visibility.Visible;

            F1Before.Visibility = Visibility.Visible;
            F2Before.Visibility = Visibility.Visible;
            F3Before.Visibility = Visibility.Visible;
            F4Before.Visibility = Visibility.Visible;

            UIFadeIn.Begin();
        }



        private void Forward_Click(object sender, RoutedEventArgs e)
        {
            Interacted = true;
            CancelToken.Cancel();
            GoForward();
        }

        private void Backward_Click(object sender, RoutedEventArgs e)
        {
            Interacted = true;
            CancelToken.Cancel();
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
            else if (CurrentItem == CurrentFeaturedlItem.F3)
            {
                AnimateForwardF3();
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
            else if (CurrentItem == CurrentFeaturedlItem.F3)
            {
                AnimateBackwardF3();
            }
            else if (CurrentItem == CurrentFeaturedlItem.Final)
            {
                AnimateBackwardFinal();
            }
        }



        private void RailroadButton_Click(object sender, RoutedEventArgs e)
        {
            UI.Navigate(typeof(RailroadPage));
        }

        private void SolorCanopiesButton_Click(object sender, RoutedEventArgs e)
        {
            UI.Navigate(typeof(EnergyPage));
        }

        private void CostOfLivingButton_Click(object sender, RoutedEventArgs e)
        {
            UI.Navigate(typeof(HousingPage));
        }

        private void TransparencyButton_Click(object sender, RoutedEventArgs e)
        {
            UI.Navigate(typeof(FinancePage));
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
                F1TransitionStop();
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
                F2TransitionStop();
                F2.Visibility = Visibility.Collapsed;
                Forward.IsEnabled = true;
                Backward.IsEnabled = true;
            };

            F3Transition1.Begin();
            CurrentItem = CurrentFeaturedlItem.F3;
        }

        public void AnimateForwardF3()
        {
            F4.Visibility = Visibility.Visible;

            FWF3Animation1.From = (double)0;
            FWF3Animation1.To = -(double)F3.ActualWidth;

            FWF3Animation2.From = (double)F3.ActualWidth;
            FWF3Animation2.To = (double)0;

            FWF3StoryBoard.Begin();

            FWF3StoryBoard.Completed += delegate (object sender, object e)
            {
                F3TransitionStop();
                F3.Visibility = Visibility.Collapsed;
                Forward.IsEnabled = true;
                Backward.IsEnabled = true;
            };
            
            F4Transition1.Begin();
            CurrentItem = CurrentFeaturedlItem.Final;
        }

        public void AnimateForwardFinal()
        {
            F1.Visibility = Visibility.Visible;

            FWFinalAnimation1.From = (double)0;
            FWFinalAnimation1.To = -(double)F4.ActualWidth;

            FWFinalAnimation2.From = (double)F4.ActualWidth;
            FWFinalAnimation2.To = (double)0;

            FWFinalStoryBoard.Begin();

            FWFinalStoryBoard.Completed += delegate (object sender, object e)
            {
                F4TransitionStop();
                F4.Visibility = Visibility.Collapsed;
                Forward.IsEnabled = true;
                Backward.IsEnabled = true;
            };

            F1Transition1.Begin();
            CurrentItem = CurrentFeaturedlItem.Begin;
        }



        public void AnimateBackwardBegin()
        {
            F4.Visibility = Visibility.Visible;
            F2.Visibility = Visibility.Collapsed;
            F3.Visibility = Visibility.Collapsed;

            BWBeginAnimation1.From = (double)0;
            BWBeginAnimation1.To = (double)F1.ActualWidth;

            BWBeginAnimation2.From = -(double)F1.ActualWidth;
            BWBeginAnimation2.To = (double)0;

            BWBeginStoryBoard.Begin();

            BWBeginStoryBoard.Completed += delegate (object sender, object e)
            {
                F1TransitionStop();
                F1.Visibility = Visibility.Collapsed;
                Forward.IsEnabled = true;
                Backward.IsEnabled = true;
            };

            F4Transition1.Begin();
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
                F2TransitionStop();
                F2.Visibility = Visibility.Collapsed;
                Forward.IsEnabled = true;
                Backward.IsEnabled = true;
            };

            F1Transition1.Begin();
            CurrentItem = CurrentFeaturedlItem.Begin;
        }

        public void AnimateBackwardF3()
        {
            F2.Visibility = Visibility.Visible;

            BWF3Animation1.From = (double)0;
            BWF3Animation1.To = (double)F3.ActualWidth;

            BWF3Animation2.From = -(double)F3.ActualWidth;
            BWF3Animation2.To = (double)0;

            BWF3StoryBoard.Begin();

            BWF3StoryBoard.Completed += delegate (object sender, object e)
            {
                F3TransitionStop();
                F3.Visibility = Visibility.Collapsed;
                Forward.IsEnabled = true;
                Backward.IsEnabled = true;
            };

            F2Transition1.Begin();
            CurrentItem = CurrentFeaturedlItem.F2;
        }

        public void AnimateBackwardFinal()
        {
            F3.Visibility = Visibility.Visible;

            BWFinalAnimation1.From = (double)0;
            BWFinalAnimation1.To = (double)F3.ActualWidth;

            BWFinalAnimation2.From = -(double)F3.ActualWidth;
            BWFinalAnimation2.To = (double)0;

            BWFinalStoryBoard.Begin();

            BWFinalStoryBoard.Completed += delegate (object sender, object e)
            {
                F4TransitionStop();
                F4.Visibility = Visibility.Collapsed;
                Forward.IsEnabled = true;
                Backward.IsEnabled = true;
            };

            F3Transition1.Begin();
            CurrentItem = CurrentFeaturedlItem.F3;
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


        private void F1TransitionStop()
        {
            F1Transition1.Stop();
            F1Transition2.Stop();
            F1Transition3.Stop();
            F1Transition4.Stop();
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


        private void F2TransitionStop()
        {
            F2Transition1.Stop();
            F2Transition2.Stop();
            F2Transition3.Stop();
            F2Transition4.Stop();
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


        private void F3TransitionStop()
        {
            F3Transition1.Stop();
            F3Transition2.Stop();
            F3Transition3.Stop();
            F3Transition4.Stop();
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


        private void F4TransitionStop()
        {
            F4Transition1.Stop();
            F4Transition2.Stop();
            F4Transition3.Stop();
            F4Transition4.Stop();
        }

        private void F4Transition1_Completed(object sender, object e)
        {
            F4Transition2.Begin();
        }

        private void F4Transition2_Completed(object sender, object e)
        {
            F4Transition3.Begin();
        }

        private void F4Transition3_Completed(object sender, object e)
        {
            F4Transition4.Begin();
        }

        private void F4Transition4_Completed(object sender, object e)
        {
            F4Transition1.Begin();
        }






        #endregion
    }

}
