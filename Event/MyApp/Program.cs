//Delegate Tanımlama
public delegate void ButtonClickHandler();

class Button
{
    //event tanımlama
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
