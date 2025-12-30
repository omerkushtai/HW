using System;

namespace boilerevent;

public class Alarmsystem
{
public void displayalert(object sender, EventArgs e)
{
    Console.WriteLine("Target Temperature Reached! Alarm Activated!");
    if (sender is Waterheater heater)
    {
        Console.WriteLine($"Final Temperature: {heater.tempinfarenheit} °F");
    }
}
}
