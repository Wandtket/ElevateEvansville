using ElevateEvansvilleUI.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace ElevateEvansvilleUI.Controls.Dialogs
{
    /// <summary>
    /// Confirm box will ask a user to confirm a message.
    /// </summary>
    internal class ConfirmBox
    {
        public static async Task<ContentDialogResult> Show(string Contents, string Title = "", string primaryText = "Yes", string secondaryText = "Cancel")
        {
            try
            {
                //Prepare Dialog
                var dialog = new ContentDialog();
                dialog.XamlRoot = UI.MainRoot;
                dialog.Title = Title;
                dialog.PrimaryButtonText = primaryText;
                dialog.SecondaryButtonText = secondaryText;
                dialog.DefaultButton = ContentDialogButton.Secondary;

                //Prepare Content
                ScrollViewer viewer = new ScrollViewer();
                TextBlock block = new TextBlock();

                block.Text = Contents;
                viewer.Content = block;
                dialog.Content = viewer;


                //Show
                ContentDialogResult result = await dialog.ShowAsync();
                return result;
            }
            catch
            {
                return ContentDialogResult.None;
            }
        }
    }
}
