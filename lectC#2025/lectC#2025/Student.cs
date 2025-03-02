namespace lecture2025;

public class Student(string id, string name, int age) : Person(name, age)
{
    public string Id { get; set; } = id;

    public Student() : this("", "", 0)
    {
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Id: {Id} Name: {Name} Age: {Age}");
    }
}