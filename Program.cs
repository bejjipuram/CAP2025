using System.Data;
/* class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your name: ");
        string? name = Console.ReadLine();
        Console.WriteLine("Hello, "+name+"!");
    }
}
class P1
{
    static void Main()
    {
        for(int i = 0; i < 10; i++)
        {
            if (i % 2 == 0){
                Console.WriteLine("Even: "+i);
            }
            else
            {
                Console.WriteLine("Odd: "+i);
            }

        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter age: ");
        string? input = Console.ReadLine();
        if(int.TryParse(input, out int age))
        {
            bool isAdult=age>=18;
            Console.WriteLine("Adult? "+isAdult);
        }
        else
        {
            Console.WriteLine("Invalid age. Please enter a whole number.");
        }
    }
}
*/

class Program
{
    static void Main()
    {
        Console.Write("Enter radius: ");
        string? input = Console.ReadLine();
        if (!double.TryParse(input, out double radius))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            return;
        }
        if (radius < 0)
        {
            Console.WriteLine("Radius cannot be negative.");
            return;
        }
        double area=Math.PI*radius*radius;
        Console.WriteLine($"Area of circle = {area:F2}");
    }
}