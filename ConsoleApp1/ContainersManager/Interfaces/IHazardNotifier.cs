namespace ConsoleApp1.Interfaces;

public interface IHazardNotifier
{
    public void nofify(double serialNumber)
    {
        Console.WriteLine("Dangerous situation! ", serialNumber);
    }
}