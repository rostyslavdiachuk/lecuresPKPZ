using System.Collections;

namespace lecture2025;

public class Program2
{
    public static void Main(string[] args)
    {
        // var student = new Student("id1", "Rostyslav", 26);
        // var studentName = student.Name;
        // student.Name = "Ne Rostyk";
        // var studentAge = student.Age;
        // student.Age = 10;
        //
        // var s = new Student
        // {
        //     Name = "Rostyk",
        //     Age = 26,
        //     Id = "id2"
        // };
        //
        // var stud = new Stud("id", "name");
        // var studId = stud.Id;
        //
        //
        // var groupStruct1 = new group("243");
        // var groupStruct2 = new group("243");
        //
        //
        // var groupStruct3 = groupStruct2;
        // groupStruct3.Name = "343";
        //
        // Console.WriteLine(groupStruct1);
        // Console.WriteLine(groupStruct2);
        // Console.WriteLine(groupStruct3);
        //
        // var groupClass1 = new Group("243");
        // var groupClass2 = new Group("243");
        //
        //
        // Console.WriteLine(groupStruct1.Equals(groupStruct2));
        // Console.WriteLine(groupClass1.Equals( groupClass2));


        // var valueTuple = getTuple("name", 19);

        var list = new List<string>();

        // var s1 = list[10];
        
        var linkedList = new LinkedList<string>();
        var hashSet = new HashSet<string>();

        var dictionary = new Dictionary<string, string>();
        // var s = dictionary["key"];
        
        List<string> students = ["Rostyslav", "Oleh", "Ivan", "Perto"];

        List<string> secondList = ["1", "2", "3","4", "5"];

        var valueTuples = students.Zip(secondList, (first,second)=> (first,second) ).ToList();
        // valueTuples.ForEach(el => Console.WriteLine(el));
        
    }

 


    public static bool HasStudent(List<string> students, string name)
    {
        foreach (var student in students)
        {
            if (student == name)
            {
                return true;
            }
        }

        return false;
    }
    
    public static bool HasStudentLinq(List<string> students, string name)
    {
        return students.Any(student => student == name);
    }

    public static List<string> addSign(List<string> students, string name)
    {
        return students.Select((stud) => stud + "!").ToList();
    }

    public static string getStudentWithMark(List<string> student, string name)
    {
        return student
            .Where(st => st == name)
            .Select(st => st + "!")
            .FirstOrDefault("!!!!!!");
    }

    public static string getStudentWithMarkI(List<string> students, string name)
    {
        var studentWithMark =
            from student in students
            where student == name
            select student + "!";

        return studentWithMark.FirstOrDefault("!!!!!");
    }

    public static (string name, int age) getTuple(string name, int age)
    {
        return (name, age);
    }
}

public record Stud(string Id, string Name);