PrintEvenNumbers(20);
PrintUnevenNumbers(20);
PrintDivisibleNumbers(20, 4);

void PrintEvenNumbers(int x)
{
    Console.WriteLine($"Printing even numbers up to {x}:");
    for (var i = 0; i <= x; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine();
        }
    }
}

void PrintUnevenNumbers(int x)
{
    Console.WriteLine($"Printing uneven numbers up to {x}:");
    for (var i = 0; i <= x; i++)
    {
        if (i % 2 != 0)
        {
            Console.WriteLine();
        }
    }
}

void PrintDivisibleNumbers(int x, int y)
{
    Console.WriteLine($"Printing numbers divisible by {y} up to {x}:");
    var n = 0;
    while (n <= x)
    {
        if (n % y == 0)
        {
            Console.WriteLine(n);
        }
        n++;
    }
}