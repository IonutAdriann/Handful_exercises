
int BigDiff(int[] values)
{
    return values.Max() - values.Min();
}

Console.WriteLine(BigDiff(new[] {10, 3, 5, 6}));
Console.WriteLine(BigDiff(new[] {7, 2, 10, 9}));
Console.WriteLine(BigDiff(new[] {2, 10, 7, 2}));