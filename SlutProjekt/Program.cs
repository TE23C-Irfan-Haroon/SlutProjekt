

Player player = new();

Utils.Login(player);


bool startGame = true;

while (startGame)
{
    ConsoleKey choice = Utils.Menu(player);

    if (choice == ConsoleKey.Spacebar)
    {
        player.coins += player.moneyPerClick;

    }
    if (choice == ConsoleKey.S) // Om spelaren väljer shop då körs shop metoden
    {
        Utils.Shop(player);
        continue; // Hoppar över resten av loopen och visar menyn igen
    }
}