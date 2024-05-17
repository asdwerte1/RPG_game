using Creatures;
namespace PlayerCharacter;
    public class PlayerCharacter : Creature
    {
        private (string, int, int, int) newStartStats;
        public PlayerCharacter(string race)
        {
            newStartStats = RaceStartStats.get_race(race);
        }
        public void getRaceStartStats()
        {
            return this.newStartStats;
        }

    }

class RaceStartStats
{
    private Dictionary<string, int[3]> StartingStats = new Dictionary<string, int[]>()
    {
        {"Altrian", [100, 100, 100]},
        {"Sylvanari", [80, 100, 120]},
        {"Brugrak", [120, 120, 60]},
        {"Dravok", [140, 80, 80]},
        {"Emberforge", [120, 100, 80]},
        {"Astrai", [80, 140, 80]}
    };

    public (string, int, int, int) get_race(string race)
    {
        (string, int, int, int) raceStats;
        if (this.StartingStats.ContainsKey(race))
        {
            raceStats[0] = this.StartingStats[race];
            raceStats[1] = this.StartingStats[race[0]];
            raceStats[2] = this.StartingStats[race[1]];
            raceStats[3] = this.StartingStats[race[2]];

            return raceStats;
        }
    }
}