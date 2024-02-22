using System;
using Race;

class Game
{
    static void Main(string[] args)
    {
        Race.Race playerRace = PredefinedRaces.Altrian;

        Console.WriteLine($"The player character race is {playerRace}\nStarting HP is {playerRace.Hp}");

    }
}