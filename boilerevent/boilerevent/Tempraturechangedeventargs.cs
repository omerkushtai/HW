using System;

namespace boilerevent;

internal class Tempraturechangedeventargs:EventArgs
{
    public double NowTemperature { get;set; }
    public DateTime When { get;set; }
    public Tempraturechangedeventargs (double temprature)
    {
        this.NowTemperature=temprature;
        this.When=DateTime.Now;
    }
    

}
