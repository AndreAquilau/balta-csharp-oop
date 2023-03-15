using System;

namespace DelegateEvents;

public class Program
{
    public static void Main()
    {
        var componet = new Componet();

        componet.Created += Test;

        componet.Start();

    }

    public static void Test(object? sender, EventArgs e)
    {
        Console.WriteLine("Teste");
    }

}

public class Componet
{
    public Componet()
    {

    }

    public void Start()
    {
        this.OnCreated(this, EventArgs.Empty);
    }

    public event EventHandler? Created;

    protected virtual void OnCreated(object? sender, EventArgs e)
    {
        EventHandler? eventHandler = Created;

        eventHandler?.Invoke(sender, e);
    }
}