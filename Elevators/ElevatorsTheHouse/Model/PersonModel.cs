using ElevatorsTheHouse.Helpers;
using ElevatorsTheHouse.Interface;

namespace ElevatorsTheHouse.Model
{
    public sealed class PersonModel : ViewModelBase, IPerson
    {
        #region Constructors

        public PersonModel(uint weight)
        {
            Weight = weight;
        }

        #endregion

        #region Properties

        public uint Weight
        {
            get { return _weight; }

            set
            {
                UpdateValue(value, ref _weight);
            }
        }

        #endregion

        #region Fields

        private uint _weight;

        #endregion
    }
}
