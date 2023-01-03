using ElevateEvansvilleUI.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace ElevateEvansvilleUI.Controls.Dialogs
{
    internal class InputBox
    {
        public static async Task<string> Show(string Title, string Description = "", string PlaceHolder = "", string DefaultValue = "", int MaxLength = -1)
        {
            try
            {
                var dialog = new ContentDialog();
                dialog.XamlRoot = UI.MainRoot;
                dialog.Title = Title;

                Button btn = new Button();
                TextBox Box = new TextBox();

                Box.Header = Description;
                Box.Text = DefaultValue;
                if (MaxLength > 0)
                {
                    Box.MaxLength = MaxLength;
                }
                Box.PlaceholderText = PlaceHolder;

                if (!string.IsNullOrEmpty(DefaultValue))
                {
                    Box.SelectAll();
                }

                dialog.Content = Box;

                Box.KeyUp += delegate (object sender, KeyRoutedEventArgs e)
                {
                    if (e.Key == Windows.System.VirtualKey.Enter)
                    {
                        btn.Content = "Result: OK";
                        dialog.Hide();
                    }
                };

                //Add Buttons
                dialog.PrimaryButtonText = "Submit";
                dialog.SecondaryButtonText = "Cancel";

                dialog.IsPrimaryButtonEnabled = true;
                dialog.IsSecondaryButtonEnabled = true;
                dialog.PrimaryButtonClick += delegate
                {
                    btn.Content = "Result: OK";
                };
                dialog.SecondaryButtonClick += delegate
                {
                    Box.Text = "";
                    btn.Content = "Result: Cancel";
                };

                await dialog.ShowAsync();

                return Box.Text;
            }
            catch { return ""; }
        }
    }
}
