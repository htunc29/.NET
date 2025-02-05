### Delegate (Temsilciler)
Delegate, metodları veya fonksiyonları birer değişken gibi kullanmamızı sağlayan tip güvenli (type-safe) bir yapıdır. Bu yapı sayesinde kod işlevselliği artar ve aynı anda birden fazla metodu çalıştırmak mümkün hale gelir (multicast delegate). Böylece, esnek ve modüler yapıların oluşturulması kolaylaşır.
#### Örnek
```csharp
public delegate void Log(string message);
public class Program
{
    public static void ConsoleLog(string log)=>Console.WriteLine($"Console:{log}");
    public static void FileLog(string log)=>Console.WriteLine($"File:{log}");
    public static void Main()
    {
        Log log=ConsoleLog;
        log+=FileLog;
        log("Merhaba");
    }
}
```
C# ta hazır gelen 3 temel generic delegate vardır
### Func Delegate
Geriye değer döndüren metotlar için kullanılır.
* `Func<parametreler,dönüş_tipi>`
```csharp
//Örnek1
Func<int,int,int> multiply = (a, b) => a * b;
Console.WriteLine(multiply(3,4));

//Örnek-2
Func<string, string, string> full_name = (ad, soyad) => (ad + soyad);
Console.WriteLine(full_name("Hüseyin","Tunç"));
```
### Action Delegate
Geriye değer döndürmeye aksiyon işlem gerçekleştiren metotlar için kullanılır.
* `Action<parametreler>`

```csharp
//Örnek1

Action<string,string,string> sendMessage=(sender,receiver,message)=>Console.WriteLine($"{receiver} {sender} sana {message} gönderdi");
sendMessage("Ali","Ahmet","Selam");

//Örnek2
Action<string> ReadAllText=(path)=>Console.WriteLine(File.ReadAllText(path));
ReadAllText("action.txt");

//Örnek3
Action<string> ReadFileLines=(path)=>File.ReadAllLines(path).ToList().ForEach(x=>Console.WriteLine(x));
ReadFileLines("action.txt");
```
### Predicate Delegate
Geriye sadece bool(True or False) değer döndüren metotlar için kullanılır
* `Predicate<parametre>`
```csharp
Predicate<int> ageController=(age)=>age>=18;
Console.WriteLine(ageController(20)?"Yaşınız uygun":"Yaşın küçük");
```
