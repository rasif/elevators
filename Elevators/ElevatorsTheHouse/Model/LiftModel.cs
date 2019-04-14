using ElevatorsTheHouse.Helpers;
using ElevatorsTheHouse.Interface;

namespace ElevatorsTheHouse.Model
{
    public sealed class LiftModel : ViewModelBase, ILift, IPosition
    {
        #region Constructors

        public LiftModel(int x, int y)
        {
            X = x;
            Y = y;
            NumberFloor = 1;
            Weight = 0;
        }

        #endregion

        #region Properties

        public bool IsMoving
        {
            get
            {
                return _isMoving;
            }

            set
            {
                UpdateValue(value, ref _isMoving);
            }
        }

        public int X
        {
            get { return _x; }

            set
            {
                UpdateValue(value, ref _x);
            }
        }

        public int Y
        {
            get { return _y; }
            set
            {
                UpdateValue(value, ref _y);
            }
        }

        public bool IsOpened
        {
            get { return _isOpened; }
            set { UpdateValue(value, ref _isOpened);}
        }

        public int NumberFloor
        {
            get { return _numberFloor; }
            set { UpdateValue(value, ref _numberFloor);}
        }

        public int Weight
        {
            get { return _weight; }
            set { UpdateValue(value, ref _weight);}
        }

        #endregion

        #region Fields

        private bool _isMoving;
        private bool _isOpened;
        private int _numberFloor;
        private int _x;
        private int _y;
        private int _weight;
        private const int _maxWeight = 140;

        #endregion
    }
}
