using System.Windows;

namespace ElevatorsTheHouse.Interface
{
    public interface IWindowService
    {
        void Show<TWindow>(object viewModel) where TWindow :  Window, new();
    }
}
