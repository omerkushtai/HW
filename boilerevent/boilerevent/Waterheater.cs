using System;

namespace boilerevent;

internal class Waterheater:EventArgs
{
    private double CurrentTemperature;
    public String tempinfarenheit
    {
        get { return (CurrentTemperature * 9 / 5 + 32).ToString("F2"); }
    }
    public event EventHandler<Tempraturechangedeventargs> Tempraturechanged;
    public event EventHandler TargetReached;
    public void startboiler(double temprature)
    {
        while (CurrentTemperature < temprature)
        {
            Thread.Sleep(1500);
            CurrentTemperature+=0.5;
            Tempraturechanged?.Invoke(this,new Tempraturechangedeventargs(CurrentTemperature));
            /*if (Tempraturechanged != null)
            {
                Tempraturechanged(this,new Tempraturechangedeventargs(CurrentTemperature));
            }*/
        }
        if (TargetReached != null)
        {
            TargetReached(this,new EventArgs());
        }
    }

}
