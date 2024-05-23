using Characters;
class Game
{
    static void Main(string[] args)
    {
        PlayerCharacter test = new PlayerCharacter();
        Console.WriteLine($"Player Name: {test.Name}");
        Console.WriteLine($"Player Health: {test.Hp}");
        Console.WriteLine($"Player Strenght: {test.Strength}");
    }
}