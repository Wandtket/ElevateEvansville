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
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace ElevateEvansvilleUI.Controls.Messages
{
    public sealed partial class PreviewMessage : UserControl
    {
        public PreviewMessage()
        {
            this.InitializeComponent();
            PopulateChangelog();
        }


        private void PopulateChangelog()
        {
            ChangeItemsListView.Items.Add("Added 4th feature item.");
            ChangeItemsListView.Items.Add("Home screen bug fixes.");
            ChangeItemsListView.Items.Add("Event Calendars now operational for Outlook, Google and Yahoo");
            ChangeItemsListView.Items.Add("Paypal API operational (UI coming later)");
            ChangeItemsListView.Items.Add("Added 'Distribute All' support item.");
            ChangeItemsListView.Items.Add("Fixed application theme on iOS.");
            ChangeItemsListView.Items.Add("Made support page items more readable on smaller displays.");
            ChangeItemsListView.Items.Add("Moved mission statement to Platform page.");
        }

    }
}
