namespace shapes;
internal class Program
{
    static void Main(string[] args)
    {
        Shape[] shapes = new Shape[3];
        shapes[0] = new Circle("Red", 5);
        shapes[1] = new Rectangle("Blue", 4, 6);
        shapes[2] = new Square("Green", 3);
        Console.WriteLine(((Circle)shapes[0]).Area());
        Console.WriteLine(((Circle)shapes[0]).Perimeter());
        Console.WriteLine(((Rectangle)shapes[1]).Area());
        Console.WriteLine(((Rectangle)shapes[1]).Perimeter());
        Console.WriteLine(((Square)shapes[2]).Area());
        Console.WriteLine(((Square)shapes[]).Perimeter());
    }
}
