using ConsoleApp1.Interfaces;
using ConsoleApp1.Models.Base;
using ConsoleApp1.SpecialExceptions;

namespace ConsoleApp1.Models.Extended;

public class CoolingContainer : Container, IHazardNotifier
{
    private double ContainerTemperature { get; set; }
    
    private string ProductType { get; set; }

    public CoolingContainer(double loadWeight, double height, double curbWeight, double depth,
        double loadCapacity, double containerTemperature, string productType)
    {
        LoadWeight = loadWeight;
        Height = height;
        CurbWeight = curbWeight;
        Depth = depth;
        SerialNumber = "KON-C-" + ContainerCounter;
        LoadCapacity = loadCapacity;
        ContainerCounter++;
        ContainerTemperature = containerTemperature;
        ProductType = productType;
    }

    public override void Deload()
    {
        LoadWeight = 0;
    }

    public override void AddLoad(double loadToAdd)
    {
        throw new NotImplementedException();
    }
    
    public void AddCargoToContainer(double loadToAdd, string product, double requiredMinTemperature)
    {
        try
        {
            if (ContainerTemperature < requiredMinTemperature)
                throw new TooColdException("Too cold for that product... We cannot do that Sir.");
        }
        catch (TooColdException tooColdException)
        {
            Console.WriteLine(tooColdException);
        }
        
        
        try
        {
            if (LoadWeight + loadToAdd > LoadCapacity) throw new OverfillException("Too much cargo for container"  + SerialNumber);
        }
        catch (OverfillException overfillException)
        {
            Console.WriteLine(overfillException);
        }

        try
        {
            if (ProductType != product)
                throw new MixOfProductsException("We cannot mix products in the same container...");
        }
        catch (MixOfProductsException mixOfProductsException)
        {
            Console.WriteLine(mixOfProductsException);
        }
        
        LoadWeight += loadToAdd;
        
    }

    public void Notify()
    {
        throw new NotImplementedException();
    }
    
    public override double GetLoadWeight()
    {
        return LoadWeight;
    }
    
    
    public override string ToString()
    {
        return "Container " + SerialNumber + "\n" +
               "Load weight = " + LoadWeight + "kg\n" +
               "Load capacity = " + LoadCapacity + "kg\n" + 
               "Curb weight = " + CurbWeight + "kg\n" +
               "Height = " + Height + "m\n" +
               "Depth = " + Depth + "m\n" +
               "Product type = " + ProductType + "\n" +
               "Temperature " + ContainerTemperature +" Celsius degrees\n";
    }
    
    public override string GetSerialNumber()
    {
        return SerialNumber;
    }
    
    
}