using System.Collections.ObjectModel;
using ElevatorsTheHouse.Model;

namespace ElevatorsTheHouse.Interface
{
    public interface IBlock
    {
        LiftModel Lift { get; set; }
        ObservableCollection<FloorModel> Floors { get; set; }
    }
}
