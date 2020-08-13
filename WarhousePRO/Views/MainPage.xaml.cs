using System;

using WarhousePRO.ViewModels;

using Windows.UI.Xaml.Controls;

namespace WarhousePRO.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new GeorgiaViewModel();

        public MainPage()
        {
            InitializeComponent();
            ViewModel.Initialize();
        }
    }
}
