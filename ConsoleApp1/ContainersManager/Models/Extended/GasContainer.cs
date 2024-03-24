using ConsoleApp1.Interfaces;
using ConsoleApp1.Models.Base;
using ConsoleApp1.SpecialExceptions;

namespace ConsoleApp1.Models.Extended;

public class GasContainer : Container, IHazardNotifier
{

    private double Pressure  { get; set; }

    public GasContainer(double loadWeight, double height, double curbWeight, double depth,
        double loadCapacity, double pressure)
    {
        LoadWeight = loadWeight;
        Height = height;
        CurbWeight = curbWeight;
        Depth = depth;
        SerialNumber = "KON-G-" + ContainerCounter;
        LoadCapacity = loadCapacity;
        Pressure = pressure;
        ContainerCounter++;
    }
    
    
    public override void Deload()
    {
        LoadWeight*=0.05;
    }

    public override void AddLoad(double loadToAdd)
    {
        try
        {
            if (LoadWeight + loadToAdd > LoadCapacity)
            {
                throw new OverfillException("Too much cargo for container"  + SerialNumber);
            }

            LoadWeight += loadToAdd;
        }
        catch (OverfillException overfillException)
        {
            Console.WriteLine(overfillException);
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
               "Pressure = " + Pressure + "atm";
    }

    public void Notify()
    {
        throw new NotImplementedException();
    }
}