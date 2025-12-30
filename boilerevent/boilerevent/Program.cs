namespace boilerevent;
internal class Program
{
    private static void Main(string[] args)
    {
        Waterheater heater=new Waterheater();
        Displayunit display=new Displayunit();
        heater.Tempraturechanged+=display.Displaytemp;
        heater.startboiler(45.0);
    }
}
