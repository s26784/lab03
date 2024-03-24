using ConsoleApp1.Interfaces;
using ConsoleApp1.Models.Base;

namespace ConsoleApp1.Models.Extended;

public class GasContainer : Container, IHazardNotifier
{

    protected double Pressure  { get; set; }

    public GasContainer(double loadWeight, double height, double curbWeight, double depth,
        double loadCapacity, double pressure)
    {
        LoadWeight = loadWeight;
        Height = height;
        CurbWeight = curbWeight;
        Depth = depth;
        SerialNumber = "KON-L-" + ContainerCounter;
        LoadCapacity = loadCapacity;
        ContainerCounter++;
    }
    
    
    public override void Deload()
    {
        throw new NotImplementedException();
    }

    public override void AddLoad(double loadToAdd)
    {
        throw new NotImplementedException();
    }

    public void notify()
    {
        throw new NotImplementedException();
    }
}