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
    protected double LoadCapacity{ get; set; }
    

    public abstract void Deload();
    public  abstract void AddLoad(double loadToAdd);
    
    
}