
using System.Security;

public class Utils
{
    public static void Login(Player player)
    {
        Console.WriteLine("Write your username for your fighter:");
        
        while (player.username.Length < 3 || player.username.Length > 10)
        {
            player.username = Console.ReadLine();
            if (player.username.Length < 3)
            {
                Console.Clear();
                Console.WriteLine("Write your username for your fighter:");
                Console.WriteLine("Username cannot be less then 3 words. Please try again.");
            }
            else if (player.username.Length > 10)
            {
                Console.Clear();
                Console.WriteLine("Write your username for your fighter:");
                Console.WriteLine("Username cannot have more than 10 words. Please try again.");
            }

        }
    }
    
    public static string Menu(Player player)
    {
        // Huvudmenyn
        string choice = "";
        while (choice != "play" && choice != "shop")
        {
            Console.Clear();
            Console.WriteLine($"Welcome {player.username}!");
            Console.WriteLine("Would you like to 'play' a match or visit the 'shop'? Type 'play' or 'shop'.");
            Console.WriteLine($"You have {player.coins} coins.");
            Console.WriteLine("TYPE 'EXIT' TO CLOSE THE GAME");
            Console.WriteLine("Please type 'play' or 'shop'.");
            choice = Console.ReadLine().ToLower();

            if (choice == "exit")
            {
                return "";
            }
        }

        return choice;

    }
}