namespace lecture2025;

public class Student(string id, string name, int age) : Person(name, age)
{
    public string Id { get; set; } = id;

    public Student() : this("", "", 0)
    {
    }

    public static Student operator +(Student student, Student student2)
    {
        return new Student(
            student.Id + student2.Id,
            student.Name + student2.Name,
            student.Age + student2.Age);
    }

    public static int Plus(int a, int b)
    {
        return a + b;
    }

    public static Func<int, int> plus(int a)
    {
        return b => Plus(a, b);
    }

    Group DeepCloneGroup(Group group)
    {
        return new Group(group.Name);
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Id: {Id} Name: {Name} Age: {Age}");
        
    }


    enum Day
    {
        MONDAY = 21,
         WEDNESDAY = 9
        //...
    }
}