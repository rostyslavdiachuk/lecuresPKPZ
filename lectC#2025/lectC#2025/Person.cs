namespace lecture2025;

public abstract class Person(string name, int age) : IPrintInfo
{
    public string Name { get; set; } = name;
    public int Age { get; set; } = age;

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Name: {Name} Age: {Age}");
    }
}