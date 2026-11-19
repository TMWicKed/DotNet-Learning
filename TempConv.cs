public class TempConv
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the temperature: ");
        double temperature = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the unit: ");
        string unit = Console.ReadLine();
        if (unit == "C" || unit == "c") {
            double fahrenheit = (temperature * 9 / 5) + 32;
            Console.WriteLine("The temperature in Fahrenheit is: " + fahrenheit);
        } else if (unit == "F" || unit == "f") {
            double celsius = (temperature - 32) * 5 / 9;
            Console.WriteLine("The temperature in Celsius is: " + celsius);
        }
    }
}