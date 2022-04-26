using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Linq;
using Windows.ApplicationModel.DataTransfer;

namespace PasswordGenerator
{
    public sealed partial class MainWindow
    {
        private string _password;
        private int _length;
        private const int MaxLength = 100;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Generate_click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(length.Text) != true)
            {
                _length = Convert.ToInt32(length.Text);
            }

            if (_length is <= MaxLength and > 0)
            {
                _password = GeneratePasswordClass.GeneratePassword(_length);
                pass.Text = _password;
            }
        }

        private void ClipSet_click(object sender, RoutedEventArgs e)
        {
            var dataPackage = new DataPackage();
            dataPackage.SetText(_password); 
            Clipboard.SetContent(dataPackage);
        }

        private void Length_OnBeforeTextChanging(TextBox sender, TextBoxBeforeTextChangingEventArgs args)
        {
            args.Cancel = args.NewText.Any(c => !char.IsDigit(c));
        }
    }
}