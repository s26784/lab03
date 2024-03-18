using ConsoleApp1.SpecialExceptions;

namespace ConsoleApp1.Models.Base;

public abstract class Container
{
    protected double LoadWeight { get; set; }
    protected double Height{ get; set; }
    protected double CurbWeight{ get; set; }
    protected double Depth{ get; set; }
    protected string SerialNumber{ get; set; }
    protected double LoadCapacity{ get; set; }


    protected Container(double loadWeight, double height, double curbWeight, double depth, string serialNumber,
        double loadCapacity)
    {
        this.LoadWeight = loadWeight;
        this.Height = height;
        this.CurbWeight = curbWeight;
        this.Depth = depth;
        this.SerialNumber = serialNumber;
        this.LoadCapacity = loadCapacity;
    }

    public void Deload()
    {
        this.LoadWeight = 0;
    }

    public void AddLoad(double loadToAdd)
    {
        if (loadToAdd + LoadWeight > LoadCapacity) throw new OverfillException("You have overloaded container");
        LoadWeight += loadToAdd;
    } 
    
    
}