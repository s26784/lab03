using ConsoleApp1.SpecialExceptions;

namespace ConsoleApp1.Models.Base;

public class ContainerShip
{
    private List<Container> ListOfContainers { get; set;}
    private double MaxSpeed { get; set;}
    private int HowManyConatainers;
    private int MaxContainersAmount { get; set;}
    private double CurrentLoad { get; set;}
    private double MaxPossibleLoad { get; set;}
    
    private string ShipName { get; set; }

    public ContainerShip(double maxSpeed, int maxContainersAmount, double maxPossibleLoad, string shipName)
    {
        ListOfContainers = new List<Container>();
        HowManyConatainers = 0;
        CurrentLoad = 0.0;
        MaxSpeed = maxSpeed;
        MaxContainersAmount = maxContainersAmount;
        MaxPossibleLoad = maxPossibleLoad;
        ShipName = shipName;
    }

    public void AddContainer(Container container)
    {
        try
        {
            if (CurrentLoad + container.GetLoadWeight() > MaxPossibleLoad)
            {
                throw new OverloadException("We will sink!!!");
            }

            if (HowManyConatainers >= 20)
            {
                throw new TooManyContainers("Too many containers");
            }
            HowManyConatainers++;
            CurrentLoad += container.GetLoadWeight();
            ListOfContainers.Add(container);
        }
        catch (OverloadException overloadException)
        {
            Console.WriteLine(overloadException);
        }
        

        
    }
    public void AddListOfContainers(List<Container> listOfContainers)
    {
        foreach (var container in listOfContainers)
        {

            if (CurrentLoad + container.GetLoadWeight() > MaxPossibleLoad)
            {
                throw new OverloadException("We will sink!!!");
            }
            
            if (HowManyConatainers >= 20)
            {
                throw new TooManyContainers("Too many containers");
            }

            HowManyConatainers++;
            CurrentLoad += container.GetLoadWeight();
            ListOfContainers.Add(container);
        }
    }
    
    public void RemoveContainer(string serialNumber)
    {
        for (int i = 0; i < ListOfContainers.Count; i++)
        {
            if (serialNumber == ListOfContainers[i].GetSerialNumber())
            {
                ListOfContainers.RemoveAt(i);
                Console.WriteLine("Container with serial number " + serialNumber + " has been removed.");
                i--;
            }
        }
    }

    public void DeloadContainer(string serialNumber)
    {
        foreach (var container in ListOfContainers)
        {
            if (serialNumber == container.GetSerialNumber())
            {
                container.Deload();
                CurrentLoad -= container.GetLoadWeight();
                Console.WriteLine("We have deloaded container " + container.GetSerialNumber());
            }
        }
    }
    
    
    public void ReplaceContainer(string serialNumber, Container container2)
    {
        foreach (var container in ListOfContainers)
        {
            if (serialNumber == container.GetSerialNumber())
            {
                RemoveContainer(serialNumber);
                CurrentLoad -= container.GetLoadWeight();
            }
        }
        
        ListOfContainers.Add(container2);
        CurrentLoad += container2.GetLoadWeight();

    }

    public void ReplaceContainersBetweenShips(ContainerShip secondShip, Container container)
    {
        RemoveContainer(container.GetSerialNumber());
        HowManyConatainers--;
        CurrentLoad -= container.GetLoadWeight();
        secondShip.AddContainer(container);
        secondShip.CurrentLoad += container.GetLoadWeight();
        secondShip.HowManyConatainers++;
    }

    public override string ToString()
    {
        string shipInfo = $"Ship Name: {ShipName}\n";
        shipInfo += $"Max Speed: {MaxSpeed}\n";
        shipInfo += $"Max Containers Amount: {MaxContainersAmount}\n";
        shipInfo += $"Max Possible Load: {MaxPossibleLoad}\n";
        shipInfo += $"Current Load: {CurrentLoad}\n";
        shipInfo += $"Number of Containers: {HowManyConatainers}\n\n";

        shipInfo += "Containers:\n\n";
        
        foreach (var container in ListOfContainers)
        {
            shipInfo += container.ToString() + "\n";
        }
        

        return shipInfo;
    }
}