using System.Diagnostics;
using System.Windows.Input;
using WarhousePRO.Helpers;

namespace WarhousePRO.ViewModels
{
    public abstract class MainViewModel : Observable
    {
        private string _menuBarItem = "Default";
        internal string MenuBarItem
        {
            get => _menuBarItem;
            set { Set(ref _menuBarItem, value); }
        }

        private ICommand buttonClickCommand;

        public ICommand ButtonClickCommand => buttonClickCommand ?? (buttonClickCommand = new RelayCommand(ButtonClick));

        public MainViewModel() { }

        internal virtual void Initialize() { }

        internal virtual void ButtonClick()
        {
            Debug.WriteLine("MainViewModel.ButtonClick");
        }
    }
}
