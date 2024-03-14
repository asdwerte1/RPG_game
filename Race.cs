using System;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;
using System.Collections.Generic;

namespace Race
{
    public class Race(string name, int hp, int stamina, int mana)
    {
        public int Hp { get; set; } = hp;
        public int Stamina { get; set; } = stamina;
        public int Mana { get; set; } = mana;
        public string Name { get; set; } = name;

        //A dictionary that store the stats of a given race - stats initialised at 15, standard value
        Dictionary<string, int> attributes = new Dictionary<string, int>()
        {
            { "Strength", 15 },
            { "Agility", 15 },
            { "Endurance", 15 },
            { "Intelligence", 15 },
            { "Charisma", 15 },
            { "Luck", 15 },
            { "Swordsmanship", 15 },
            { "Dagger Mastery", 15 },
            { "One-handed Blunt Weapons", 15 },
            { "Two-handed Blunt Weapons", 15 },
            { "Bowmanship", 15 },
            { "Crossbowmanship", 15 },
            { "Offensive Magic", 15 },
            { "Defensive Magic", 15 },
            { "Passive Magic", 15 },
            { "Illusion Magic", 15 },
            { "Necromancy", 15 },
            { "Alchemy", 15 },
            { "Summoning Magic", 15 },
            { "Shadow Magic", 15 }
        };

        public override string ToString()
        {
            return Name;
        }
    }

    public static class Races
    {
        public static Race Altrian { get; } = new Race("Altrian", hp: 100, stamina: 100, mana: 100);
        public static Race Sylvanari { get; } = new Race("Sylvanari", hp: 80, stamina: 100, mana: 120);
        public static Race Brugrak { get; } = new Race("Brugrak", hp: 120, stamina: 120, mana: 60);
        public static Race Dravok { get; } = new Race("Dravok", hp: 140, stamina: 80, mana: 80);
        public static Race Emberforge { get; } = new Race("Emberforge", hp:120, stamina: 100, mana: 80);
        public static Race Astrai { get; } = new Race("Astrai", hp: 80, mana: 140, stamina: 80);
    }
}
