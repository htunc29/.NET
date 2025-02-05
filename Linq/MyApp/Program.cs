// List<int> numbers=new List<int>{1,2,3,4,5,6,7,8,9,10};
// //Query Syntax
// var evenNumbers1=from number in numbers
//                  where number%2==0
//                  select number;

// // Method Syntax
// var evenNumbers2=numbers.Where(number=>number%2==0).ToList();

// var firstEvenNumbers=numbers.Where(number=>number%2==0).Take(2);
// var skipFirstEvenNumbers=numbers.Where(number=>number%2==0).Skip(2).Take(2);

// List<string> nameExamples=new List<string>{"ali","ahmet","veli","selim","ali"};
// var names=nameExamples.Distinct();

// List<int> ages=new List<int>{36,78,9,12,25,37};
// var sortedAges=ages.OrderBy(x=>x);
// var sortedAgesDesc=ages.OrderByDescending(x=>x);
// sortedAges.ToList().ForEach(x=>Console.WriteLine(x));
// List<int> sayilar=new List<int>{2,4,6,8,10};
// var squaredNumbers=sayilar.Select(n=>n*n);
// class Person
// {
//     public string? Name;
//     public string? Surname;

//     List<Person> persons=new List<Person>
//     {
//        new Person{Name="Ali",Surname="Veli"},
//        new Person{Name="Hüseyin",Surname="Tunç"}
//     };

//     public List<Person> sırala(List<Person> persons)
//     {
//         var list=persons.OrderBy(x=>x.Name).ThenBy(x=>x.Surname).ToList();
//         return list;
//     }

// }


