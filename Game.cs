using System.ComponentModel.Design.Serialization;
using Characters;
class Game
{
    static void Main(string[] args)
    {
        PlayerCharacter test = new PlayerCharacter();
        Console.Clear();
        Console.WriteLine($"Player Name: {test.Name}");
        Console.WriteLine($"Player Gender: {test.GetGender()}");
        Console.WriteLine($"Player Race: {Capitalise(test.Race)}");
        Console.WriteLine($"Player Health: {test.Hp}");
        Console.WriteLine($"Player Stamina: {test.Stamina}");
        Console.WriteLine($"Player Mana: {test.Mana}");

    }

    static string Capitalise(string text)
    {
        if (string.IsNullOrEmpty(text))
            return "Empty text...";
        else
            return char.ToUpper(text[0]) + text[1..];
    }
}