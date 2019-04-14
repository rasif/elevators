using System.Windows;
using ElevatorsTheHouse.Helpers;
using ElevatorsTheHouse.Service;
using ElevatorsTheHouse.View;
using ElevatorsTheHouse.ViewModel;

namespace ElevatorsTheHouse
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var _mainWindow = new StartView();

            _mainWindow.DataContext = new MainViewModel(new RelayCommandFactory(), new WindowService());

            _mainWindow.Show();

            base.OnStartup(e);
        }
    }
}
