# 📌LINQ (Language Integrated Query)
C# dilinde veri sorgulama işlemlerini daha okunabilir ve etkili hale getirmek için linq kullanılır.Linq sql benzeri sorgular yazmanıza olanak sağlar.Koleksiyonlar veritabanları,xml json gibi farklı veri kaynaklarıyla çalışabilir.Kısaca C#'ın farklı veri kaynakları ile etkileşim kurmasını sağlar

## LINQ Temel Söz Dizimi
1. Query Syntax
1. Method Syntax

**Örnek**
```csharp
List<int> numbers=new List<int>{1,2,3,4,5,6,7,8,9,10};
//Query Syntax
var evenNumbers1=from number in numbers
                 where number%2==0
                 select number;
                
// Method Syntax
var evenNumbers2=numbers.Where(number=>number%2==0).ToList();
```
## LINQ Operatörleri
### Filtreleme Operatörleri
Filtreleme verileri belirli kriterlere göre seçmek için kullanılır

**Where**
```csharp
List<int> numbers=new List<int>{1,2,3,4,5,6,7,8,9,10};
// ikiye tam bölünen sayılar
var evenNumbers2=numbers.Where(number=>number%2==0)
```
**Take**
> _Kullanım_:Take(2)
- `Parametre olarak int değer alır verilen parametre adedi kadar veri getirir`
```csharp
List<int> numbers=new List<int>{1,2,3,4,5,6,7,8,9,10};
//çift sayılardan ilk 2'si
var firstEvenNumbers=numbers.Where(number=>number%2==0).Take(2);
//çıktı [2,4] 
```
**Skip**
> Kullanım:Skip(2)
- `Verilen parametre adedi kadar veri atlamak için kullanılır`
```csharp
List<int> numbers=new List<int>{1,2,3,4,5,6,7,8,9,10};
//çift sayılardan ilk 2'sini atla 2 tanesini al
var skipFirstEvenNumbers=numbers.Where(number=>number%2==0).Skip(2).Take(2);
//çıktı [6,8]
```
**Distinct**
- `Tekrar eden verileri kaldırır`
```csharp
List<string> nameExamples=new List<string>{"ali","ahmet","veli","selim","ali"};

var names=nameExamples.Distinct();
//çıktı ["ali","veli","selim"]
```
### Sıralama Operatörleri
**OrderBy & OrderByDescending**
```csharp
List<int> ages=new List<int>{36,78,9,12,25,37};
//küçükten büyüğe a-z
var sortedAges=ages.OrderBy(x=>x);

//büyükten küçüğe z-a
var sortedAgesDesc=ages.OrderByDescending(x=>x);
```
**ThenBy**
- `İkinci bir sıralama için kullanılır`
```csharp
class Person
{
    public string? Name;
    public string? Surname;
    
    List<Person> persons=new List<Person>
    {
       new Person{Name="Ali",Surname="Veli"},
       new Person{Name="Hüseyin",Surname="Tunç"}
    };
    
    public List<Person> sırala(List<Person> persons)
    {
        var list=persons.OrderBy(x=>x.Name).ThenBy(x=>x.Surname).ToList();
        return list;
    }

}
```
### Seçim Operatörleri

**Select**
```csharp
List<int> sayilar=new List<int>{2,4,6,8,10};

var squaredNumbers=sayilar.Select(n=>n*n);
//Çıktı {4,16,36,64,100}
```
## PLINQ(PARALLEL LINQ) - PARALEL İŞLEM
```csharp
var evenNumbers=numbers.AsParallel().Where(n=>n%2==0).ToList()
```