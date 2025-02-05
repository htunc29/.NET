// public delegate int MultiplyDelegate(int x, int y);

// class Program
// {
//     static void Main()
//     {
//         MultiplyDelegate multiply = (x, y) => x * y;
//         Console.WriteLine(multiply(5, 4));  // Çıktı: 20
//     }

// }


List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// Çift sayıları filtrele
var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

evenNumbers.ForEach(n => Console.WriteLine(n));