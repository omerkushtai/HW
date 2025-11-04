using System;

namespace Lesson04;

internal abstract class Plane:Iflyable
{
     public void Fly()
    {
         Console.WriteLine("fly high");
    }
    public String Name { get; set; }
}
