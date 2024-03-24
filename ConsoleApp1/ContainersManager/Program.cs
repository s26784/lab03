

using ConsoleApp1.Models.Extended;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\n");
        
        LiquidContainer liquidContainer1 = new LiquidContainer(100.0, 2.0, 100.0, 1.8, 1000.0,LiquidContainer.CargoType.Regular);
        liquidContainer1.AddLoad(1290);
        Console.WriteLine(liquidContainer1);
        liquidContainer1.Deload();
        Console.WriteLine(liquidContainer1);
        
        LiquidContainer liquidContainer2 = new LiquidContainer(100.0, 2.0, 100.0,1.8, 1000.0,LiquidContainer.CargoType.Hazard);
        liquidContainer2.AddLoad(700);
        Console.WriteLine(liquidContainer2);

        GasContainer gasContainer = new GasContainer(500.0, 6.0, 300.0, 5.9, 2000.0, 1.2);
        Console.WriteLine(gasContainer);
        gasContainer.Deload();
        Console.WriteLine(gasContainer);
        gasContainer.AddLoad(2001);
        Console.WriteLine(gasContainer);

        CoolingContainer coolingContainer = new CoolingContainer(1000.0, 6.0, 100.0, 5.5, 2000.0, 4.0, "milk");
        coolingContainer.AddCargoToContainer(600,"milk",3.0);
        Console.WriteLine(coolingContainer);






    }
}
