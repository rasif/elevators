using System.Windows;
using ElevatorsTheHouse.Interface;

namespace ElevatorsTheHouse.Service
{
    public sealed class WindowService:IWindowService
    {
        public void Show<TWindow>(object viewModel) where TWindow : Window, new()
        {
            var window = new TWindow
            {
                DataContext = viewModel
            };

            window.Show();
        }
    }
}
