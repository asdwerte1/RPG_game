using System;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;

namespace Race
{
    public class Race(string name, int hp, int stamina, int mana)
    {
        public int Hp { get; set; } = hp;
        public int Stamina { get; set; } = stamina;
        public int Mana { get; set; } = mana;
        public string Name { get; set; } = name;

        public override string ToString()
        {
            return Name;
        }
    }

    public static class PredefinedRaces
    {
        public static Race Altrian { get; } = new Race("Altrian", 100, 100, 100);
        public static Race Sylvanari { get; } = new Race("Sylvanari", 100, 100, 100);
        public static Race Brugrak { get; } = new Race("Brugrak", 100, 100, 100);
        public static Race Dravok { get; } = new Race("Dravok", 100, 100, 100);
        public static Race Emberforge { get; } = new Race("Emberforge", 100, 100, 100);
        public static Race Astrai { get; } = new Race("Astrai", 100, 100, 100);
    }
}
