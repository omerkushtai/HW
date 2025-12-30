using lesson05;

public delegate bool Validate(int number);
public delegate void printmessage(string m);
public delegate int mathdel(int x, int y);
internal class Program
{
    public static int add(int x, int y)
    {
        return x + y;
    }
    public static int multiply(int x, int y)
    {
        return x * y;
    }
    public static List<int> onlyeven(List<int> list)
    {
        List<int> evenNumbers = new List<int>();
        foreach (int number in list)
        {
            if (number % 2 == 0)
            {
                evenNumbers.Add(number);
            }
        }
        return evenNumbers;
    }
    public static List<int> biggerthanfive(List<int> list)
    {
        List<int> biggerthanFive = new List<int>();
        foreach (int number in list)
        {
            if (number > 5)
            {
                biggerthanFive.Add(number);
            }
        }
        return biggerthanFive;
    }
    public static List<int> bycondition(List<int> list, Validate validate)
    {
        List<int> filteredList = new List<int>();
        foreach (int number in list)
        {
            if (validate(number))
            {
                filteredList.Add(number);
            }
        }
        return filteredList;
    }
    public static void Main(string[] args)
    {
        mathdel f = add;
        int sum = f(4, 2);
        Console.WriteLine("Sum: " + sum);
        f += multiply;
        Console.WriteLine(f(4, 2));
        Func<List<Student>, int, string, int> result = (students, classnum, classname) =>
        {
            int cunt = 0;
            foreach (var student in students)
            {
                if (student.classnum == classnum && student.classname == classname)
                {
                    cunt++;
                }
            }
            return cunt;
        };
        Func<List<Student>, string, string> result2 = (students, studentname) =>
        {
            string name = "";
            foreach (Student student in students)
            {
                if (studentname == student.name)
                {
                    name = studentname;
                }
            }
            return name;
        };
        Func<List<Student>, string,int,List<Student>> result3=(students, classname, classnum) =>
        {
            List<Student> temp = new List<Student>();
            foreach (Student student in students)
            {
                if (student.classname == classname && student.classnum == classnum)
                {
                    temp.Add(student);
                }
            }
            return temp;
        };

        List < Student > students1 = new List<Student>
        {
            new Student { name = "Alice", classname = "A", classnum = 1 },
            new Student { name = "Bob", classname = "B", classnum = 2 },
            new Student { name = "Charlie", classname = "A", classnum = 1 },
            new Student { name = "David", classname = "B", classnum = 2 },
            new Student { name = "Eve", classname = "A", classnum = 1 }
        };
        int countResult = result(students1, 2, "B");
        Console.WriteLine("Number of students in class A1: " + countResult);
    }
}