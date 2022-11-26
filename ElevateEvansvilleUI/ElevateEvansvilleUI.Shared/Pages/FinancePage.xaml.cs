using ElevateEvansvilleUI.API.Services;
using ElevateEvansvilleUI.Controls.Dialogs;
using ElevateEvansvilleUI.Controls.Messages;
using ElevateEvansvilleUI.DTOs;
using ElevateEvansvilleUI.Extensions;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Transactions;
using Uno.UI.Toolkit;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class FinancePage : Page
    {
        public FinancePage()
        {
            this.InitializeComponent();
        }

        PayPalService service = new PayPalService();


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            AdjustUI();
            FetchFinancialData();
        }

        private void AdjustUI()
        {
            //Desktop
            if (UI.IsDeviceMobile() == false)
            {
                FinanceGrid.Width = 555;
                FAQGrid.Width = 555;

                FAQButton.Visibility = Visibility.Collapsed;

                FinanceGrid.HorizontalAlignment = HorizontalAlignment.Right;
                FAQGrid.HorizontalAlignment = HorizontalAlignment.Left;
            }
            //Mobile
            else
            {
                FinanceGrid.MaxWidth = 555;
                FinanceGrid.MinWidth = 280;

                FAQButton.Visibility = Visibility.Visible;

                RootGrid.ColumnDefinitions[1].Width = new GridLength(0);
                FAQGrid.Visibility = Visibility.Collapsed;
            }
        }

        private async void FetchFinancialData()
        {
            PayPalAccountBalance.Text = "Loading...";

            var Transactions = await service.GetTransactions();
            BalanceDTO dto = await service.GetBalance();

            PayPalAccountBalance.Text = "$" + dto.Balance;

            var Received = Transactions.Transactions.Where(x => x.Class == "RECEIVED");
            var Sent = Transactions.Transactions.Where(x => x.Class == "SENT");

            TransactionsReceivedListView.ItemsSource = Received;
            TransactionsSentListView.ItemsSource = Sent;

            APIProgress.Visibility = Visibility.Collapsed;
        }

        private async void FAQButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new ContentDialog();
            dialog.Title = "FAQ";
            dialog.PrimaryButtonText = "Close";
            dialog.DefaultButton = ContentDialogButton.Primary;

            //Prepare Content
            ScrollViewer viewer = new ScrollViewer();

            viewer.Content = FAQContent;
            dialog.Content = viewer;

            //Show
            await dialog.ShowAsync();
        }


        private async void ReceivedItem_Tapped(object sender, TappedRoutedEventArgs e)
        {          
            ElevatedView view = (ElevatedView)sender;

            TransactionsDTO dto = (TransactionsDTO)view.DataContext;

            PayPalDetailMessage message = new PayPalDetailMessage();
            message.DataContext = view.DataContext;

            ContentDialog dialog = new ContentDialog();
            dialog.Title = "Item Details";
            dialog.SecondaryButtonText = "Dismiss";
            dialog.Content = message;
            await dialog.ShowAsync();

            TransactionsReceivedListView.SelectedIndex = -1;

        }

        private async void SentItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ElevatedView view = (ElevatedView)sender;
            TransactionsDTO dto = (TransactionsDTO)view.DataContext;

            PayPalDetailMessage message = new PayPalDetailMessage();
            message.DataContext = view.DataContext;

            ContentDialog dialog = new ContentDialog();
            dialog.Title = "Item Details";
            dialog.SecondaryButtonText = "Dismiss";
            dialog.Content = message;
            await dialog.ShowAsync();

            TransactionsSentListView.SelectedIndex = -1;
        }





        List<TransactionsDTO> transactions = new List<TransactionsDTO>();

        private void GenerateTestData()
        {
            TransactionsDTO dto = new TransactionsDTO();
            dto.Status = "Released";
            dto.Type = "Above amount released";
            dto.Name = "Facebook";
            dto.Memo = "Initial Test";
            dto.Payer = "wandtket@gmail.com";
            dto.PayerDisplayName = "Tyler Wandtke";
            dto.FeeAmount = "0.00";
            dto.GrossAmount = "0.10";
            dto.NetAmount = "0.10";
            dto.Timestamp = DateTime.Now;

            transactions.Add(dto);

            TransactionsReceivedListView.ItemsSource = transactions;
        }


    }


}
