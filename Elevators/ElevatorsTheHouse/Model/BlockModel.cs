using System.Collections.ObjectModel;
using ElevatorsTheHouse.Helpers;
using ElevatorsTheHouse.Interface;

namespace ElevatorsTheHouse.Model
{
    public sealed class BlockModel : ViewModelBase, IBlock, IPosition
    {
        #region Constructors

        public BlockModel(int countFloors, int x, int y)
        {
            Lift = new LiftModel(x,y);

            Floors = new ObservableCollection<FloorModel>();

            X = x;
 
            for (var i = countFloors; i > 0; i--)
                Floors.Add(new FloorModel(i));
        }

        #endregion

        #region Properties

        public ObservableCollection<FloorModel> Floors { get; set; }

        public LiftModel Lift 
        {
            get { return _lift; }

            set
            {
                UpdateValue(value, ref _lift);
            }
        }

        public int X
        {
            get { return _x; }
            set {UpdateValue(value, ref _x);} 
        }

        public int Y
        {
            get { return _y; }
            set {UpdateValue(value,  ref _y);}
        }

        #endregion

        #region Fields

        private LiftModel _lift;
        private int _x;
        private int _y;

        #endregion
    }
}
