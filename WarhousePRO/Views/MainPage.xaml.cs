using System;

using WarhousePRO.ViewModels;

using Windows.UI.Xaml.Controls;

namespace WarhousePRO.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; set; }

        public MainPage()
        {
            InitializeComponent();
            ViewModel = new BulgariaViewModel();
            DataContext = ViewModel;
        }

        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            ViewModel = new GeorgiaViewModel();
            Bindings.Update();
        }
    }
}
