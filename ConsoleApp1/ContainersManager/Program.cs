

using ConsoleApp1.Models.Extended;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Witaj, świecie!");
        HazardLiquidContainer hazardLiquidContainer1 = new HazardLiquidContainer(100.0, 2.0, 100.0, 1.8, 1000.0);
        HazardLiquidContainer hazardLiquidContainer2 = new HazardLiquidContainer(100.0, 2.0, 100.0, 1.8, 1000.0);
        Console.WriteLine(hazardLiquidContainer1);
        Console.WriteLine(hazardLiquidContainer2);
    }
}
