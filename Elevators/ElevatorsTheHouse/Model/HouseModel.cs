using System.Collections;
using System.Collections.ObjectModel;
using ElevatorsTheHouse.Helpers;
using ElevatorsTheHouse.Interface;

namespace ElevatorsTheHouse.Model
{
    public sealed class HouseModel : ViewModelBase, IHouse, IShape, IEnumerable, IEnumerator
    {
        #region Constructors

        public HouseModel(int countFloor, int countLift)
        {
            CountFloor = countFloor;
            CountLift = countLift;

            Blocks = new ObservableCollection<BlockModel>();

            var x = 30;

            Height = countFloor*160;
            Width = countLift*200;

            for (var i = 0; i < countLift; i++)
            {
                var block = new BlockModel(countFloor, x, Height-160);
                Blocks.Add(block);
                x += 200;
            }
        }

        #endregion

        #region IEnumerable

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (index == CountLift-1)
            {
                Reset();
                return false;
            }

            index++;
            return true;
        }

        public void Reset()
        {
            index = -1;
        }

        public object Current => Blocks[index].Lift;

        private int index = -1;

        #endregion

        #region Properties

        public ObservableCollection<BlockModel> Blocks { get; set; } 

        public int CountFloor 
        {
            get
            {
                return _countFloor;
            }

            set
            {
                UpdateValue(value, ref _countFloor);
            }
        }

        public int CountLift 
        {
            get
            {
                return _countLift;
            }

            set
            {
                UpdateValue(value, ref _countLift);
            }
        }

        public int Height
        {
            get { return _height; }
            set { UpdateValue(value, ref _height);}
        }

        public int Width
        {
            get { return _width; }
            set { UpdateValue(value, ref _width);}
        }

        #endregion

        #region Fields

        private int _countFloor;
        private int _countLift;
        private int _width;
        private int _height;

        #endregion
  
    }
}
