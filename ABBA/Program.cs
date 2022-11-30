
using System.Diagnostics.Metrics;

string makeABBA(string a, string b)
{
    return $"{a}{b}{b}{a}";
}

Console.WriteLine(makeABBA("Hi", "Bye"));
Console.WriteLine(makeABBA("Yo", "Alice"));
Console.WriteLine(makeABBA("What", "Up"));