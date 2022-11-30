namespace SimplePersonExample;

public class Person
{
    public string Name { get; set; }

    public void Introduce()
    {
        System.Console.WriteLine($"Hi, my name is {Name}");
    }
}