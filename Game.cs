using Characters;
class Game
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 5; i++)
        {
            PlayerCharacter test = new PlayerCharacter();
            Console.Clear();
            Console.WriteLine($"Player Name: {test.Name}");
            Console.WriteLine($"Player Gender: {test.GetGender()}");
            Console.WriteLine($"Player Race: {Capitalise(test.Race)}");
            Console.WriteLine($"Player Health: {test.Hp}");
            Console.WriteLine($"Player Stamina: {test.Stamina}");
            Console.WriteLine($"Player Mana: {test.Mana}");
            Console.WriteLine($"Strength: {test.Strength}");
            Console.WriteLine($"Agility@ {test.Agility}");
            Console.WriteLine($"Endurance: {test.Endurance}");
            Console.WriteLine($"Intelligence: {test.Intelligence}");
            Console.WriteLine($"Charisma: {test.Charisma}");
            Console.WriteLine($"Luck: {test.Luck}");
            Console.WriteLine($"Swordsmanship: {test.Swordsmanship}");
            Console.WriteLine($"Dagger mastery: {test.DaggerMastery}");
            Console.WriteLine($"One handed blunt@ {test.OneHandedBlunt}");
            Console.WriteLine($"Two handed blunt: {test.TwoHandedBlunt}");
            Console.WriteLine($"Bowmanship: {test.Bowmanship}");
            Console.WriteLine($"Crafting: {test.Crafting}");
            Console.WriteLine($"Offensive magic: {test.OffensiveMagic}");
            Console.WriteLine($"Passive magic: {test.PassiveMagic}");
            Console.WriteLine($"Illusion magic: {test.IllusionMagic}");
            Console.WriteLine($"Necromancy: {test.Necromancy}");
            Console.WriteLine($"Summoning Magic: {test.SummoningMagic}");
            Console.WriteLine($"Shadow Magic: {test.ShadowMagic}");
            Console.ReadLine();
        }

    }

    static string Capitalise(string text)
    {
        if (string.IsNullOrEmpty(text))
            return "Empty text...";
        else
            return char.ToUpper(text[0]) + text[1..];
    }
}