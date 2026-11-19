public class TipCalculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the total bill amount: ");
        double bill = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the tip percentage: ");
        double tip = double.Parse(Console.ReadLine());
        double tipAmount = bill * tip / 100;
        Console.WriteLine("The tip amount is: " + tipAmount);
        Console.WriteLine("Total amount: " + (bill + tipAmount));
    }
}