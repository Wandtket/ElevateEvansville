using ElevateEvansvilleUI.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace ElevateEvansvilleUI.Controls.Dialogs
{
    internal class MessageBox
    {
        public static async Task Show(string Contents, string Title = "", string buttonText = "Ok")
        {
            //If more than one contentdialog is called it will throw an error.
            try
            {
                //Prepare Dialog
                var dialog = new ContentDialog();
                dialog.Title = Title;
                dialog.PrimaryButtonText = buttonText;
                dialog.DefaultButton = ContentDialogButton.Primary;

                //Prepare Content
                ScrollViewer viewer = new ScrollViewer();
                TextBlock block = new TextBlock();

                block.Text = Contents;
                viewer.Content = block;
                dialog.Content = viewer;

                //Show
                await dialog.ShowAsync();
            }
            catch { }
        }
    }

}
