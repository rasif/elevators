using ElevatorsTheHouse.Helpers;
using ElevatorsTheHouse.Interface;

namespace ElevatorsTheHouse.Model
{
    public sealed class FloorModel : ViewModelBase, IFloor
    {
        #region Constructors

        public FloorModel(int number) 
        {
            Number = number;
        }

        #endregion

        #region Properties

        public bool IsPressed
        {
            get
            {
                return _isPressed;
            }

            set
            {
                UpdateValue(value, ref _isPressed);
            }
        }

        public int Number
        {
            get { return _number; }
            set { UpdateValue(value, ref _number);}
        }

        #endregion

        #region Fields

        private bool _isPressed;
        private int _number;

        #endregion
    }
}
