namespace ElevatorsTheHouse.Interface
{
    public interface IFloor
    {
        bool IsPressed { get; set; }      
        int Number { get; set; }
    }
}
