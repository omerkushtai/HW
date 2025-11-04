using Lesson04;

internal class Program
{
    static void Main(string[] args)
    {
        Iflyable[] flyables = new Iflyable[2];
        flyables[0] = new Boeing747();
        flyables[1] = new Superman();
        for (int i = 0; i < flyables.Length; i++)
        {
            flyables[i].Fly();
            if (flyables[i] is Superman super)
            {
                super.shootLaser();
            }
        }
        Ilaserable[] lasershooters = new Ilaserable[2];
        lasershooters[0] = new Darthvader();
        lasershooters[1] = (Superman)flyables[1];
        for (int i = 0; i < lasershooters.Length; i++)
        {
            lasershooters[i].shootLaser();
            if (lasershooters[i] is Iflyable fly)
            {
                fly.Fly();
            }
        }
    }
}

