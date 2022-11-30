
string nTwice(string value, int n)
{
    return $"{value[..n]}{value.Substring(value.Length - n, n)}";
}

Console.WriteLine(nTwice("Hello", 2));
Console.WriteLine(nTwice("Chocolate", 3));
Console.WriteLine(nTwice("Chocolate", 1));