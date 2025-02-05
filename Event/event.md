### Event
Event'ler, **delegateler** üzerine kuruludur ve belirli bir olayın gerçekleşmesi durumunda belirli metotları çağırmak için kullanılır.

#### Örnek
```csharp
//Delegate Tanımlama
public delegate void ButtonClickHandler();

class Button
{
    //event tanımlama
    //nullable olabileciği için '?' kullanılır
    public event ButtonClickHandler? Click;
    public void Press()
    {
        if(Click!=null)
        Click();
    }
}
class Program
{
    static void ButtonClicked()
    {
        Console.WriteLine("Butona tıklandı!");
    }    static void Main()
    {
        Button btn=new Button();
        btn.Click+=ButtonClicked;
        btn.Press();
    }
}

```