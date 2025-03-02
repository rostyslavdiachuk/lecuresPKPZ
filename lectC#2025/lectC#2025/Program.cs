// // See https://aka.ms/new-console-template for more information
//
// using System.Text;
// using System.Text.RegularExpressions;
// using lecture2025;
//
// internal class Program
// {
//     /*
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("Hello, World!");
//
//         var a = () => Console.WriteLine("Hello, World!");
//         var b = (int x) => Console.WriteLine(x);
//         var b1 = (int x, int y) => Console.WriteLine(x + y);
//         var c = (int a1, int b2) => a1 + b2;
//         var d = (bool q, bool w) => q && w;
//         DoSmth(b);
//         DoSmth(smth);
//         smth(a: 10);
//         var s = from number in Enumerable.Range(0, 10) select 2 * number;
//
//         string x = new string('0', 10);
//         var chars = new char[] { 'a', 'b', 'c' };
//         string s1 = new string(chars);
//         string interpolatedString = $"asdasddsa {s1}";
//         string f = "aasdasdasd";
//         string v = "a";
//
//         var conc = String.Concat(f, v);
//         var compareTo = f.Contains(v);
//         var joined = String.Join("qwe", new string[] { "a", "b", "c" });
//         string? va = null;
//         char[] destination = new char[100];
//
//         var startsWith = joined.IndexOf("qwe");
//         var insert = joined.Insert(3, "ROSTYK");
//         Console.WriteLine(insert);
//
//         var replace = insert.Replace("e", "");
//         Console.WriteLine(replace);
//         var strings = replace.Split("q");
//
//         foreach (var st in strings)
//         {
//             Console.WriteLine(st);
//         }
//
//         var substring = "hello wolrd".Substring(3, 6);
//         Console.WriteLine(substring.ToUpper());
//     }
//     */
//
//     // public static void Main(string[] args)
//     // {
//     //     var regex = new Regex("^[a-zA-Z123]{4,5}$");
//     //     var regex1 = new Regex(".*([0-9]{1}).*");
//     //
//     //
//     //     var match = regex1.Match("Hel1dasda3dasda2sdasd");
//     //     foreach (Group matchGroup in match.Groups)
//     //     {
//     //         Console.WriteLine("group: ");
//     //         Console.WriteLine(matchGroup.Value);
//     //     }
//     //     
//     // }
//
//     /*
//     public static void Main(string[] args)
//     {
//         using (var fileStream = File.Open("a.txt", FileMode.OpenOrCreate))
//         {
//             var student = new Student();
//             // fileStream.Write(Encoding.Unicode.GetBytes("dasdasdasda"));
//
//             var binaryWriter = new BinaryWriter(fileStream);
//             binaryWriter.Write("Hello binary text");
//
//
//             var binaryReader = new BinaryReader(fileStream);
//
//             var bytes = binaryReader.ReadString();
//             
//             Console.WriteLine(bytes);
//
//             binaryReader.Close();
//         }
//         */
//
//         // var readAllLines = File.ReadAllLines("a.txt");
//         //
//         // foreach (var v in readAllLines)
//         // {
//         //     Console.WriteLine(v);
//         // }
//     }
//
//     /*
//     public static void smth(int a = 10)
//     {
//         Console.WriteLine(a);
//     }
//
//     public static void DoSmth(Action<int> a)
//     {
//         a.Invoke(1);
//     }*/
// }