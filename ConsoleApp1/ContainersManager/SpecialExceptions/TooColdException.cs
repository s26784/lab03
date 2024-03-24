namespace ConsoleApp1.SpecialExceptions;

public class TooColdException : Exception
{
   public TooColdException(string message) : base(message) { }
}