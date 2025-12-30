using System;

namespace boilerevent;

internal class Displayunit
{
public void Displaytemp(object sender, Tempraturechangedeventargs e)
{
    Console.WriteLine($"Current Temperature: {e.NowTemperature} °C at {e.When}");
}
}
