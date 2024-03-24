

using ConsoleApp1.Models.Extended;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Witaj, świecie!");
        
        GasContainer gasContainer1 = new GasContainer(350,  6.0, 50.0, 3.0, 2000.0, 2.5);
        Console.WriteLine(gasContainer1);
        gasContainer1.AddLoad(200);
        Console.WriteLine(gasContainer1);
        gasContainer1.Deload();
        Console.WriteLine(gasContainer1);
        
        LiquidContainer liquidContainer1 = new LiquidContainer(100.0, 2.0, 100.0, 1.8, 1000.0,LiquidContainer.CargoType.Regular);
        LiquidContainer liquidContainer2 = new LiquidContainer(100.0, 2.0, 100.0, 1.8, 1000.0,LiquidContainer.CargoType.Hazard);
        
        Console.WriteLine(liquidContainer1);
        Console.WriteLine(liquidContainer2);
    }
}
