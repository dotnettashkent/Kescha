using Kescha.Classes;
public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Animal kescha = new Bird("Kescha", 3);
            Animal kasee = new Pet("Kasee", 2);
            Console.WriteLine($"Kescha was created{kescha.CreatedTime}");
            Console.WriteLine($"Kasee was created{kasee.CreatedTime}");
            Console.Write("Enter your name ");
            string name = Console.ReadLine();
            Console.WriteLine("Kescha says !");
            kescha.Greet(name);
            Console.WriteLine("Kasee says !");
            kasee.Greet(name);
            Console.Write("Enter your age ");
            string ageString = Console.ReadLine();
            Console.WriteLine("Converting...");
            int age = Convert.ToInt32(ageString);
            Console.WriteLine($"Succesfully converted {age}");

            kescha.CalculateAgeDifference(userAge: age);
            kescha.PrintAgeDifference();
            kescha.CompareAge(userAge: age);
            kescha.TellAboutFriends(userName: name, userAge: age);
        }
        catch (FormatException formatException)
        {
            Console.WriteLine("Error was thrown... Message: {0}",formatException.Message);
        }
        Console.WriteLine("continue...");
    }
}