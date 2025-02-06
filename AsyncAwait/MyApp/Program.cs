using System.Diagnostics;

class Program
{
      
   public static async Task DoHeavyWork()
{
    await Task.Run(() =>
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"İşlem {i} devam ediyor... {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(1000); // 1 saniye bekle
        }
    });
}

    static async Task Main()
    {
    
        await DoHeavyWork();

    }
}