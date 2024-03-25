namespace ConsoleApp1.SpecialExceptions;

public class TooManyContainers : Exception
{
    public TooManyContainers(string message) : base(message) { }
}