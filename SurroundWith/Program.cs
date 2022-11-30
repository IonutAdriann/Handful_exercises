Console.WriteLine("Hello, World!");

string MakeOutWord(string outer, string word)
{
    return $"{outer[..2]}{word}{outer.Substring(2, 2)}";
}
Console.WriteLine(MakeOutWord("<<>>", "Yay"));
Console.WriteLine(MakeOutWord("<<>>", "WooHoo"));
Console.WriteLine(MakeOutWord("[[]]", "Word"));