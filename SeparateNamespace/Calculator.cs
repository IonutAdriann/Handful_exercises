namespace SeparateNamespace;

public class Calculator
{
    public int Add(int x, int y)
    {
        int sum = 0;

        return sum = x + y;
    }

    public int Add(int[] integers)
    {
        var result = 0;

        foreach (var n in integers)
        {
            result += n;
        }

        return result;
    }
}