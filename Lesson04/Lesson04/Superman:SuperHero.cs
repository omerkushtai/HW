using System;

namespace Lesson04;

public class Superman:SuperHero, Iflyable, Ilaserable
{
    public void Fly()
    {
        Console.WriteLine("its a bird? its a plane? no its superman!");
    }
    public void shootLaser()
    {
        Console.WriteLine("laser");
    }
}
