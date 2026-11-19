public class LogicalOperators
{
    public static void Main(string[] args)
    {
        int a = 10;
        int b = 20;
        int c = 30;
        
        Console.WriteLine(a > b && a > c);
        Console.WriteLine(a > b || a > c);
        Console.WriteLine(!(a > b && a > c));
        Console.WriteLine(a > b && a > c || a > c);
        Console.WriteLine(a > b && a > c || a > c && a > b);
        Console.WriteLine(a > b && a > c || a > c && a > b);

        bool d = true;
        bool e = false;
        if (!e)
        {
            Console.WriteLine("d is not equal to e");
        }
    }
}
