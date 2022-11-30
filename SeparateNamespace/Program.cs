

using SeparateNamespace;

class Program
{
    static void Main(string[] args)
    {
        var calculator = new Calculator();
        Console.WriteLine(calculator.Add(3, 4));
        Console.WriteLine(calculator.Add(new int[] {1,2,3,4,5,6}));
    }

}