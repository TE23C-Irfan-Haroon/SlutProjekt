
using System.Security;

public class Utils
{
    public static void Login(Player player)
    {
        Console.WriteLine("Write your username:");

        while (player.username.Length < 3 || player.username.Length > 10)
        {
            player.username = Console.ReadLine();
            if (player.username.Length < 3)
            {
                Console.Clear();
                Console.WriteLine("Write your username:");
                Console.WriteLine("Username cannot be less then 3 words. Please try again.");
            }
            else if (player.username.Length > 10)
            {
                Console.Clear();
                Console.WriteLine("Write your username:");
                Console.WriteLine("Username cannot have more than 10 words. Please try again.");
            }

        }
    }

    public static ConsoleKey Menu(Player player)
    {
        // Huvudmenyn
        ConsoleKey choice = ConsoleKey.None;
        while (choice != ConsoleKey.Spacebar && choice != ConsoleKey.S)
        {
            Console.Clear();
            Console.WriteLine($"Welcome {player.username}!");
            Console.WriteLine("Press 'Spacebar' to make money or visit the 'shop' to buy upgrades? Press the key 'S' to go to the shop.");
            Console.WriteLine("Press 'ESC' to exist");
            Console.WriteLine($"You have {player.coins} coins.");
            Console.WriteLine("TYPE 'EXIT' TO CLOSE THE GAME");
            choice = Console.ReadKey().Key;

            if (choice == ConsoleKey.Escape)
            {
                
            }
        }

        return choice;

    }

    public static void Shop(Player player)
    {
        // shop där man kan köpa uppgraderingar
        while (true)
        {
            int shopChoice = Utils.ShopMenu(player);

            if (shopChoice == 1)
            {
                Utils.ShopHp(player);
            }
            else if (shopChoice == 2)
            {
                Utils.ShopMaxDamage(player);
            }
            else if (shopChoice == 3)
            {
                Utils.ShopMinDamage(player);
            }

            if (shopChoice == 4)
            {
                break;
            }

        }
    }
    public static int ShopMenu(Player player)
    {
        // Menyn för shopen
        Console.BackgroundColor = ConsoleColor.DarkYellow;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();
        Console.WriteLine("Welcome to the Shop!");
        Console.WriteLine($"You have {player.coins} coins.");
        Console.WriteLine("1. Upgrade Armor (Increase HP by 20)  Cost: 15 coins");
        Console.WriteLine("2. Upgrade Sword Damage (Increase MaxDamage by 10)  Cost: 20 coins");
        Console.WriteLine("3. Upgrade Sword Reliablity (Increase MinDamage by 2)  Cost: 5 coins");
        Console.WriteLine("4. Exit Shop");
        Console.WriteLine("Choose an option: 1, 2, 3, or 4");

        int shopChoice;
        while (!int.TryParse(Console.ReadLine(), out shopChoice) || shopChoice < 1 || shopChoice > 4)
        {
            Console.WriteLine("Invalid input. Please Choose a valid option");
        }

        return shopChoice;
    }

    public static void ShopHp(Player player)
    {
        // Metod för att uppgradera spelarens HP om de har tillräckligt med mynt
        if (player.coins >= 100)
        {
            player.MaxHP += 1;
            player.MaxHP = player.hp;
            player.coins -= 100;
            Console.WriteLine($"Your HP is now {player.hp}/{player.MaxHP}. You have {player.coins} coins left.");
        }
        else
        {
            Console.WriteLine("You don't have enough coins for this purchase.");
        }
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }
    public static void ShopMaxDamage(Player player)
    {
        // Metod för att uppgradera spelarens maxDamage om de har tillräckligt med mynt
        if (player.coins >= 20)
        {
            player.MaxDamage += 10;
            player.coins -= 20;
            Console.WriteLine($"Your maximum damage is now {player.MaxDamage}. You have {player.coins} coins left.");
        }
        else
        {
            Console.WriteLine("You don't have enough coins for this purchase.");
        }
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }

    public static void ShopMinDamage(Player player)
    {
        // Metod för att uppgradera spelarens minDamage om de har tillräckligt med mynt
        if (player.coins >= 5)
        {
            player.MinDamage += 2;
            player.coins -= 5;
            Console.WriteLine($"Your minimum damage is now {player.MinDamage}. You have {player.coins} coins left.");
        }
        else
        {
            Console.WriteLine("You don't have enough coins for this purchase.");
        }
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }
}
