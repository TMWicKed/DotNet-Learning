public class DiceGame
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int dice1 = random.Next(1, 7);
        int dice2 = random.Next(1, 7);
        int dice3 = random.Next(1, 7);
        int sum = dice1 + dice2 + dice3;
        Console.WriteLine("The dice is: " + dice1 + " " + dice2 + " " + dice3);
        Console.WriteLine("The sum is: " + sum);
        if (sum > 10)
        {
            Console.WriteLine("Your sum is greater than 10, you get 10  extra points!");
        }
        else
        {
            Console.WriteLine("Your sum is less than 10, you get 0 points!");
        }
        if (dice1 == dice2)
        {
            if (dice1 == dice3)
            {
                Console.WriteLine("All three dice are the same, you get 10 extra points!");
            }
            else
            {
                Console.WriteLine("Two dice are the same, you get 5 extra points!");
            }
        }
        else if (dice1 == dice3)
        {
            Console.WriteLine("Two dice are the same, you get 5 extra points!");
        }
        else if (dice2 == dice3)
        {
            Console.WriteLine("Two dice are the same, you get 5 extra points!");
        }
        else
        {
            Console.WriteLine("No dice are the same, you get 0 extra points!");
        }
    }
}