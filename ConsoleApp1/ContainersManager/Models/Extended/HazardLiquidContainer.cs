using ConsoleApp1.Interfaces;
using ConsoleApp1.Models.Base;

namespace ConsoleApp1.Models.Extended;

public class HazardLiquidContainer : Container, IHazardNotifier
{

    public HazardLiquidContainer(double loadWeight, double height, double curbWeight, double depth,
        double loadCapacity)
    {
        LoadWeight = loadWeight;
        Height = height;
        CurbWeight = curbWeight;
        Depth = depth;
        SerialNumber = "KON-L-" + ContainerCounter;
        LoadCapacity = loadCapacity;
        ContainerCounter++;
        notify();
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
               "load weight = " + LoadWeight + "kg\n" +
               "load capacity = " + LoadCapacity + "kg\n" + 
               "curb weight = " + CurbWeight + "kg\n" +
               "height = " + Height + "m\n" +
               "depth = " + Depth + "m\n";
    }

    public void notify()
    {
        Console.WriteLine("Container " + SerialNumber + ": Dangerous action detected!");
    }
}