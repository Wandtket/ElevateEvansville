using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace ElevateEvansvilleUI.Controls.Dialogs
{
    internal class InputBox
    {
        public static async Task Show(string Title = "", string PrimaryButtonText = "Ok", string SecondaryButtonText = "Ok")
        {
            //If more than one contentdialog is called it will throw an error.
            try
            {
                //Prepare Dialog
                var dialog = new ContentDialog();
                dialog.Title = Title;
                dialog.PrimaryButtonText = PrimaryButtonText;
                dialog.DefaultButton = ContentDialogButton.Primary;

                dialog.SecondaryButtonText = SecondaryButtonText;

                //Prepare Content
                TextBox box = new TextBox();
                dialog.Content = box;

                //Show
                await dialog.ShowAsync();
            }
            catch { }
        }
    }
}
