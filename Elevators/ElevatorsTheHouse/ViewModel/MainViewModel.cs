using System.Threading;
using System.Windows;
using System.Windows.Input;
using ElevatorsTheHouse.Helpers;
using ElevatorsTheHouse.Interface;
using ElevatorsTheHouse.Model;
using ElevatorsTheHouse.View;

namespace ElevatorsTheHouse.ViewModel
{
    public sealed class MainViewModel:ViewModelBase
    {
        #region Constructors

        public MainViewModel(ICommandFactory commandFactory, IWindowService windowService)
        {
            if (commandFactory == null)
                return;

            if (windowService == null)
                return;

            _commandFactory = commandFactory;

            _windowService = windowService;

            ConfigureCommand();
        }

        #endregion

        #region Command

        private void ConfigureCommand()
        {
            CallElevatorCommand = _commandFactory.CreateCommand<FloorModel>(OnCallElevatorCommand);
            DragWindowCommand = _commandFactory.CreateCommand<Window>(OnDragWindowCommand);
            CloseWindowCommand = _commandFactory.CreateCommand<Window>(OnCloseWindowCommand);
            CollapseWindowCommand = _commandFactory.CreateCommand<Window>(OnCollapseWindowCommand);
            CreateMainViewCommand = _commandFactory.CreateCommand<Window>(OnCreateMainViewCommand);
            StopSystemCommand = _commandFactory.CreateCommand(OnStopSystemCommand);
        }

        public ICommand CallElevatorCommand { get; private set; }
        public ICommand DragWindowCommand { get; private set; }
        public ICommand CloseWindowCommand { get; private set; }
        public ICommand CollapseWindowCommand { get; set; }
        public ICommand CreateMainViewCommand { get; set; }
        public ICommand StopSystemCommand { get; set; }

        #endregion

        #region Methods Command

        private void OnCallElevatorCommand(FloorModel floor)
        {
            if (IsStoppedSystem)
            {
                floor.IsPressed = false;
                return;
            }

            ThreadPool.QueueUserWorkItem(new WaitCallback(s =>
            {
                WaitFreeLift();

                if (IsLiftClose(floor) == false)
                {
                    CallLift(floor);
                }
            }));
        }

        private void OnDragWindowCommand(Window window)
        {
            window.DragMove();
        }

        private void OnCloseWindowCommand(Window window)
        {
            window.Close();
        }

        private void OnCollapseWindowCommand(Window window)
        {
            window.WindowState = WindowState.Minimized;
        }

        private void OnCreateMainViewCommand(Window window)
        {
            House = new HouseModel(_countOfFloor, _countOfLift);

            _windowService.Show<MainView>(this);

            window.Close();
        }

        private void OnStopSystemCommand() => IsStoppedSystem = !IsStoppedSystem;

        #endregion

        #region Methods

        private bool IsLiftClose(FloorModel floor)
        {
            for (var i = 0; i < House.CountLift; i++)
            {
                var lift = House.Blocks[i].Lift;

                if (lift.NumberFloor == floor.Number)
                {
                    lift.IsMoving = true;

                    OpenAndCloseDoorLift(lift);

                    lift.IsMoving = false;

                    lift.Weight += 10;

                    floor.IsPressed = false;

                    return true;
                }
            }
 
            return false;
        }

        private void CallLift(FloorModel floor)
        {
            for (var i = 0; i < House.CountLift; i++)
            {
                var lift = House.Blocks[i].Lift;

                if (!lift.IsMoving)
                {
                    MoveLift(lift, floor.Number);
                    floor.IsPressed = false;
                    break;
                }
            }
        }

        private void MoveLift(LiftModel lift, int numberFloor)
        {
            var currentY = House.Height - numberFloor*160;

            lift.IsMoving = true;

            if (lift.Y > currentY)
                MoveUpLift(lift, currentY);
            else if (lift.Y < currentY)
                MoveDownLift(lift, currentY);

            lift.Weight += 10;

            OpenAndCloseDoorLift(lift);

            lift.NumberFloor = numberFloor;

            lift.IsMoving = false;
        }

        private void MoveUpLift(LiftModel lift, int needToMove)
        {
            while (lift.Y > needToMove)
            {
                lift.Y--;
                Thread.Sleep(3);
            }
        }

        private void MoveDownLift(LiftModel lift, int needToMove)
        {
            while (lift.Y < needToMove)
            {
                lift.Y++;
                Thread.Sleep(3);
            }
        }

        private void OpenAndCloseDoorLift(LiftModel lift)
        {
            lift.IsOpened = true;
            Thread.Sleep(2000);
            lift.IsOpened = false;
            Thread.Sleep(2000);
        }

        private bool IsFreeLift()
        {
            for (var i = 0; i < House.CountLift; i++)
            {
                var lift = House.Blocks[i].Lift;

                if (lift.IsMoving == false)
                    return true;
            }

            return false;
        }

        private void WaitFreeLift()
        {
            if (!IsFreeLift())
            {
                Thread.Sleep(2000);
                WaitFreeLift();
            }
        }

        #endregion

        #region Properties

        public HouseModel House { get; set; }

        public int CountOfFloor
        {
            get { return _countOfFloor;}
            set { UpdateValue(value, ref _countOfFloor);}
        }

        public int CountOfLift
        {
            get { return _countOfLift; }
            set { UpdateValue(value, ref _countOfLift);}
        }

        public bool IsStoppedSystem
        {
            get { return _isStoppedSystem; }
            set { UpdateValue(value, ref _isStoppedSystem);}
        }

        #endregion

        #region Fields

        private readonly ICommandFactory _commandFactory;
        private readonly IWindowService _windowService;

        private bool _isStoppedSystem;
        private int _countOfFloor;
        private int _countOfLift;

        #endregion
    }
}
