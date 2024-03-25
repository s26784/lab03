using ConsoleApp1.Interfaces;
using ConsoleApp1.Models.Base;
using ConsoleApp1.SpecialExceptions;

namespace ConsoleApp1.Models.Extended;

public class LiquidContainer : Container, IHazardNotifier
{
    public enum CargoType
    {
        Hazard,
        Regular
    }

    private CargoType Cargo { get; set; }

    public LiquidContainer(double loadWeight, double height, double curbWeight, double depth,
        double loadCapacity, CargoType cargo)
    {
        LoadWeight = loadWeight;
        Height = height;
        CurbWeight = curbWeight;
        Depth = depth;
        SerialNumber = "KON-L-" + ContainerCounter;
        LoadCapacity = loadCapacity;
        ContainerCounter++;
        Cargo = cargo;
    }

    public override void Deload()
    {
        LoadWeight = 0;
        Console.WriteLine("Container is now empty");
    }

    public override void AddLoad(double loadToAdd)
    {
        
        if (Cargo == CargoType.Hazard && (LoadWeight + loadToAdd > 0.5 * LoadCapacity))
        {
            Notify();
            LoadWeight = 0.5 * LoadCapacity;
            Console.WriteLine("We have filled container to 50% of its max capacity");
        }
        else if (Cargo == CargoType.Hazard && (LoadWeight + loadToAdd < 0.5 * LoadCapacity))
        {
            LoadWeight += loadToAdd;
        }
        else if (Cargo == CargoType.Regular && (LoadWeight + loadToAdd > 0.9 * LoadCapacity))
        {
            Notify();
            LoadWeight = 0.9 * LoadCapacity;
            Console.WriteLine("We have filled container to 90% of its max capacity");
        }
    }

    public override string ToString()
    {
        return "Container " + SerialNumber + "\n" +
               "Load weight = " + LoadWeight + "kg\n" +
               "Load capacity = " + LoadCapacity + "kg\n" + 
               "Curb weight = " + CurbWeight + "kg\n" +
               "Height = " + Height + "m\n" +
               "Depth = " + Depth + "m\n" +
               "Cargo = " + Cargo + "\n";
    }

    public void Notify()
    {
        Console.WriteLine("Container " + SerialNumber + ": Dangerous action detected!");
    }

    public override double GetLoadWeight()
    {
        return LoadWeight;
    }

    public override string GetSerialNumber()
    {
        return SerialNumber;
    }
}