namespace ElevatorsTheHouse.Interface
{
    public interface ILift
    {
        bool IsMoving { get; set; }
        bool IsOpened { get; set; }
        int NumberFloor { get; set; }
        int Weight { get; set; }
    }
}
