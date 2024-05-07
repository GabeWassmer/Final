public class AgeCalculator
{
    public static int CalculateAgeInDays()
    {
        Console.WriteLine("What's your birthday?");
        DateTime birthday;
        while (!DateTime.TryParse(Console.ReadLine(), out birthday))
        {
            Console.WriteLine("Invalid date format.");
        }

        TimeSpan ageInDays = DateTime.Now - birthday;
        return ageInDays.Days;
    }

    public static void Main(string[] args)
    {
        int ageInDays = CalculateAgeInDays();
        Console.WriteLine($"You are: {ageInDays} days old.");
        Console.ReadLine();
    }
}