using ConsoleApp1.Interfaces;
using ConsoleApp1.Models.Base;

namespace ConsoleApp1.Models.Extended;

public class LiquidContainer : Container, IHazardNotifier
{
    public enum CargoType
    {
        Hazard,
        Regular
    }

    protected CargoType Cargo;

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
        throw new NotImplementedException();
    }

    public override void AddLoad(double loadToAdd)
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return "Container " + SerialNumber + "\n" +
               "Load weight = " + LoadWeight + "kg\n" +
               "Load capacity = " + LoadCapacity + "kg\n" + 
               "Curb weight = " + CurbWeight + "kg\n" +
               "Height = " + Height + "m\n" +
               "Depth = " + Depth + "m\n" +
               "Cargo = " + Cargo;
    }

    public void Notify()
    {
        Console.WriteLine("Container " + SerialNumber + ": Dangerous action detected!");
    }
}