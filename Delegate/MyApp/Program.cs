// public delegate void Log(string message);
// public class Program
// {
//     public static void ConsoleLog(string log)=>Console.WriteLine($"Console:{log}");
//     public static void FileLog(string log)=>Console.WriteLine($"File:{log}");
//     public static void Main()
//     {
//         Log log=ConsoleLog;
//         log+=FileLog;
//         log("Merhaba");
//     }
// }

Func<int,int,int> multiply = (a, b) => a * b;
Console.WriteLine(multiply(3,4));

Func<string, string, string> full_name = (ad, soyad) => (ad + soyad);
Console.WriteLine(full_name("Hüseyin","Tunç"));

Action<string,string,string> sendMessage=(sender,receiver,message)=>Console.WriteLine($"{receiver} {sender} sana {message} gönderdi");
sendMessage("Ali","Ahmet","Selam");

Action<string> ReadAllText=(path)=>Console.WriteLine(File.ReadAllText(path));
ReadAllText("action.txt");

Action<string> ReadFileLines=(path)=>File.ReadAllLines(path).ToList().ForEach(x=>Console.WriteLine(x));
ReadFileLines("action.txt");

Predicate<int> ageController=(age)=>age>=18;
Console.WriteLine(ageController(20)?"Yaşınız uygun":"Yaşın küçük");
