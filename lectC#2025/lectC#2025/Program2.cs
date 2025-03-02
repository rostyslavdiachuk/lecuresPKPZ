namespace lecture2025;

public class Program2
{
    public static void Main(string[] args)
    {
        var student = new Student("id1", "Rostyslav", 26);
        var studentName = student.Name;
        student.Name = "Ne Rostyk";
        var studentAge = student.Age;
        student.Age = 10;

       
    }
}