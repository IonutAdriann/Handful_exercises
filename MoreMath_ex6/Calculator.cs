using static System.Int32;

namespace MoreMath_ex6;

public class Calculator
{
    public void Maximum()
    {
        Console.WriteLine("Input number: ");
        TryParse(Console.ReadLine(), out var x);
        
        Console.WriteLine("Input number: ");
        TryParse(Console.ReadLine(), out var y);
        
        Console.WriteLine($"The largest number is: {Math.Max(x, y)}");
    }
}