using System;
using System.Collections.Generic;
using System.Linq;

class Program
{

    static async Task Main()
    {
        var cts = new CancellationTokenSource();
        cts.CancelAfter(2000);

        try
        {
            await CountToTenAsync(cts.Token);
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Операция была отменена");
        }
    }

    public static async Task CountToTenAsync(CancellationToken token)
    {
        for(int i = 1; i < 11; i++)
        {
            token.ThrowIfCancellationRequested();
            await Task.Delay(500, token);
            Console.WriteLine(i);
        }
    }
}
