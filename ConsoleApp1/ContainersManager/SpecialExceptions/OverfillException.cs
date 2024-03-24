namespace ConsoleApp1.SpecialExceptions;

public class OverfillException : Exception
{
    public OverfillException(string message) : base(message) { }
    public OverfillException(){}
}