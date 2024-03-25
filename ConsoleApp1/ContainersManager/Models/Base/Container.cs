using ConsoleApp1.SpecialExceptions;

namespace ConsoleApp1.Models.Base;

public abstract class Container
{
    
    protected static int ContainerCounter  { get; set; }
    protected double LoadWeight { get; set; }
    protected double Height{ get; set; }
    protected double CurbWeight{ get; set; }
    protected double Depth{ get; set; }
    protected string SerialNumber{ get; set; }
    protected double LoadCapacity { get; set; }
    
    /*public static int ContainerCounter  { get; set; }
    public double LoadWeight { get; set; }
    public double Height{ get; set; }
    public double CurbWeight{ get; set; }
    public double Depth{ get; set; }
    public string SerialNumber{ get; set; }
    public double LoadCapacity{ get; set; }*/
    


    public abstract void Deload();
    public  abstract void AddLoad(double loadToAdd);

    public abstract double GetLoadWeight();
    
    public abstract string GetSerialNumber();
    


}