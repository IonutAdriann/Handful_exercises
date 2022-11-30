
int countClumps(int[] elements)
{
    var clumps = 0;
    for (var i = 0; i < elements.Length - 1; i++)
    {
        var clump = false;
        while (i < elements.Length - 1 && elements[i] == elements[i + 1])
        {
            clump = true;
            i++;
        }

        if (clump)
        {
            clumps++;
        }
    }

    return clumps;
}

Console.WriteLine(countClumps(new int[] { 1, 2, 2, 3, 4, 4 }));
Console.WriteLine(countClumps(new int[] {1, 1, 2, 1, 1}));
Console.WriteLine(countClumps(new int[] {1, 1, 1, 1, 1}));