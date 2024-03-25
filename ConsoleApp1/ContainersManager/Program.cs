

using ConsoleApp1.Models.Base;
using ConsoleApp1.Models.Extended;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\n");
        
        LiquidContainer liquidContainer1 = new LiquidContainer(10.0, 2.0, 100.0, 1.8, 100.0,LiquidContainer.CargoType.Regular);
        liquidContainer1.AddLoad(120);
        Console.WriteLine(liquidContainer1);
        liquidContainer1.Deload();
        Console.WriteLine(liquidContainer1);
        
        LiquidContainer liquidContainer2 = new LiquidContainer(10.0, 2.0, 10.0,1.8, 100.0,LiquidContainer.CargoType.Hazard);
        liquidContainer2.AddLoad(70);
        Console.WriteLine(liquidContainer2);

        GasContainer gasContainer = new GasContainer(50.0, 6.0, 30.0, 5.9, 200.0, 1.2);
        Console.WriteLine(gasContainer);
        gasContainer.Deload();
        Console.WriteLine(gasContainer);
        gasContainer.AddLoad(200);
        Console.WriteLine(gasContainer);

        CoolingContainer coolingContainer = new CoolingContainer(100.0, 6.0, 10.0, 5.5, 200.0, 4.0, "milk");
        CoolingContainer coolingContainer2 = new CoolingContainer(100.0, 6.0, 10.0, 5.5, 200.0, 4.0, "wine");
        coolingContainer.AddCargoToContainer(10.0,"milk",3.0);
        Console.WriteLine(coolingContainer);

        ContainerShip containerShip = new ContainerShip(2.6, 20, 500, "WhiteSeagull");

        List<Container> list = new List<Container>()
            { liquidContainer1, liquidContainer2, gasContainer, coolingContainer };
        
        containerShip.AddListOfContainers(list);
        containerShip.AddContainer(new LiquidContainer(3.0,7.9,1.0,7.8,200.0,LiquidContainer.CargoType.Regular));
        containerShip.DeloadContainer("KON-L-0");
        containerShip.ReplaceContainer("KON-L-3",coolingContainer2);
        containerShip.RemoveContainer("KON-L-1");

        ContainerShip containerShip2 = new ContainerShip(3.6, 20, 500, "BlackSeagull");
        containerShip.ReplaceContainersBetweenShips(containerShip2,gasContainer);
        
        Console.WriteLine(containerShip);
        Console.WriteLine(containerShip2);
        
        






    }
}
