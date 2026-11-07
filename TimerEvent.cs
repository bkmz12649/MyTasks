using System;

class Program
{
    static void Main()
    {
        Timer timer = new Timer();
        timer.Tick += OnTimerTick;

        timer.GetTick();
        
    }

    public static void OnTimerTick(object? sender, EventArgs e)
    {
        Console.WriteLine("Tick");
    }

}

public class Timer
{
    public event EventHandler? Tick;
    
    public void GetTick()
    {
        Console.WriteLine("Timer tick");
        Tick?.Invoke(this, EventArgs.Empty);
    }
}


