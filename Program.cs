using System;

class Program
{
    static void Main()
    {
       Thermostat thermostat = new Thermostat(0);
        thermostat.OverHeat += DangerOverHeat;

        thermostat.Temperature = 20;
        thermostat.Temperature = 30;
        thermostat.Temperature = 40;
        thermostat.Temperature = 50;
       
    }

    public static void DangerOverHeat(int temperature)
    {
        Console.WriteLine($"!!! ПЕРЕГРЕВ {temperature}* !!!");
    }
}

public class Thermostat
{
    private int _temperature;

    public event Action<int>? OverHeat;

    public int Temperature
    {
        get => _temperature;
        set
        {
            _temperature = value;
            if(_temperature > 30)
            {
                OverHeat?.Invoke(_temperature);
            }
        }
    }

    public Thermostat(int temperature)
    {
        Temperature = temperature;
    }
}
