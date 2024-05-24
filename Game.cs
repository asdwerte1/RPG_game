using Characters;
using Items;
class Game
{
    static void Main(string[] args)
    {
        PlayerCharacter test = new PlayerCharacter();
        Console.Clear();
        Console.WriteLine($"Player Name: {test.Name}");
        Console.WriteLine($"Player Gender: {test.GetGender()}");
        Console.WriteLine($"Player Race: {Capitalise(test.Race)}");
        Console.ReadLine();
        Sword sword = new Sword(MeleeMaterials.ElvenSteel, MeleeConditons.Good);
        Console.WriteLine(sword.ToString());
    }

    static string Capitalise(string text)
    {
        if (string.IsNullOrEmpty(text))
            throw new ArgumentNullException("ERROR: Missing Text");
        else
            return char.ToUpper(text[0]) + text[1..];
    }
}