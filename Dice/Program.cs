using dice;

var dice = new Dice();
var player = new Player();
bool gameOver = false;
var numberFromDice = dice.PlayDice();

Game();

if (gameOver == false)
{
    Console.WriteLine("You lose!");
}

void Game()
{
    for (int i = 0; i < 3; i++)
    {
        var numberFromPlayer = player.SetNumberFromPlayer();
        if (numberFromPlayer == numberFromDice)
        {
            Console.WriteLine("You win!");
            gameOver = true;
            break;
        }
    }
}

Console.ReadKey();