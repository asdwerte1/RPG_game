using System.Security;
using Items;

namespace Characters;

public abstract class Character 
{
    public int Hp { get; set;}
    public int Stamina { get; protected set; }
    public int Strength { get; protected set; }
    public int Agility { get; protected set; }
    public int Endurance { get; protected set; }

    public Character()
    {
        this.Hp = 100;
        this.Stamina = 100;
        this.Strength = 15;
        this.Agility = 15;
        this.Endurance = 15;
    }
}

public abstract class Humanoid: Character
{
    public int Mana {get; protected set;} = 100;
    public int Intelligence  {get; protected set; } = 15;
    public int Charisma {get; protected set; } = 15;
    public int Luck {get; protected set; } = 15;
    public int Swordsmanship {get; protected set; } = 15;
    public int DaggerMastery {get; protected set; } = 15;
    public int OneHandedBlunt {get; protected set;} = 15;
    public int TwoHandedBlunt { get; protected set; } = 15;
    public int Bowmanship {get; protected set;} = 15;
    public int Crafting {get; protected set;} = 15;
    public int OffensiveMagic {get; protected set;} = 15;
    public int PassiveMagic {get; protected set;} = 15;
    public int IllusionMagic {get; protected set;} = 15;
    public int Necromancy {get; protected set;} = 15;
    public int Alchemy {get; protected set;} = 15;
    public int SummoningMagic {get; protected set;} = 15;
    public int ShadowMagic {get; protected set;} = 15;
    public int Level {get; protected set;}
}

public class PlayerCharacter: Humanoid
{
    public string? Name { get; private set; }
    public char? Gender { get; private set; }
    public string? Race { get; private set; }
    private Dictionary<string, int> startingStats = new Dictionary<string, int>();

    public PlayerCharacter()
    {
        Console.Clear();
        // Set player name
        this.Name = SetName();
        
        // Set gender
        this.Gender = SetGender();

        // Set race and alter starting stats
        this.SetRace();
    }
    private static string SetName()
    {
        bool validInput = false;
        string playerNameInput = string.Empty;

        // Player chooses name
        while(!validInput)
        {
            try
            {
                Console.WriteLine("Enter the name of your charater: ");
                playerNameInput = Console.ReadLine();
                if (!string.IsNullOrEmpty(playerNameInput))
                {
                    Console.WriteLine($"Chosen name: {playerNameInput}");
                    validInput = true;
                }
                else
                {
                    throw new Exception("No name entered");
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("No name entered, please try again.");
                validInput = false;
            }
        }
        return playerNameInput;
    }
    private static char SetGender()
    {
        bool validInput = false;
        char playerGenderInput = ' ';

        while (!validInput)
        {
            try
            {
                Console.WriteLine("Enter m or f for the gender you wish your character to be:\n\tMale(m)\n\tFemale(f)");
                playerGenderInput = Console.ReadLine()[0];

                if (playerGenderInput == 'm' || playerGenderInput == 'M')
                {
                    Console.WriteLine("You have chosen male");
                    validInput = true;
                }
                else if (playerGenderInput == 'f' || playerGenderInput == 'F')
                {
                    Console.WriteLine("You have chosen female");
                    validInput = true;
                }
                else
                {
                    throw new Exception("Invalid gender choice");
                }
            }
            catch (System.Exception)
            {
                
                Console.WriteLine("Invalid gender entered");
                validInput = false;
            }
        }
        return playerGenderInput;
    }
    public string GetGender()
    {
        if (this.Gender == 'm' || this.Gender == 'M') return "Male";
        else return "Female";
    }
    private void SetRace()
    {
        bool validInput = false;
        do
        {
            Console.WriteLine("Enter which race you wish to play as");
            string raceChoice = Console.ReadLine().ToLower();

            Races races = new Races();
            if (!String.IsNullOrEmpty(raceChoice))
            {
                startingStats = races.SetPlayerRace(raceChoice);
                Race = raceChoice;
                validInput = true;
            }
            else
                Console.WriteLine("Invalid race input, try again");
        }while(!validInput);

        this.Hp = startingStats["hp"];
        this.Stamina = startingStats["stamina"];
        this.Mana = startingStats["mana"];
        this.Strength = startingStats["strength"];
        this.Agility = startingStats["agility"];
        this.Endurance = startingStats["endurance"];
        this.Intelligence  = startingStats["intelligence"];
        this.Charisma = startingStats["charisma"];
        this.Luck = startingStats["luck"];
        this.Swordsmanship = startingStats["swordsmanship"];
        this.DaggerMastery = startingStats["daggerMastery"];
        this.OneHandedBlunt = startingStats["oneHandedBlunt"];
        this.TwoHandedBlunt = startingStats["twoHandedBlunt"];
        this.Bowmanship = startingStats["bowmanship"];
        this.Crafting = startingStats["crafting"];
        this.OffensiveMagic = startingStats["offensiveMagic"];
        this.PassiveMagic = startingStats["passiveMagic"];
        this.IllusionMagic = startingStats["illusionMagic"];
        this.Necromancy = startingStats["necromancy"];
        this.Alchemy = startingStats["alchemy"];
        this.SummoningMagic = startingStats["summoningMagic"];
        this.ShadowMagic = startingStats["shadowMagic"];
    }
}

 public class Races
{
    // Create base case starting stats
    private Dictionary<string, int> playerRace = new Dictionary<string, int>
        {
            { "hp", 100 },
            { "stamina", 100 },
            { "mana", 100 },
            { "strength", 15 },
            { "agility", 15 },
            { "endurance", 15 },
            {"intelligence", 15 },
            { "charisma", 15 },
            { "luck", 15 },
            { "swordsmanship", 15 },
            { "daggerMastery", 15 },
            { "oneHandedBlunt", 15 },
            { "twoHandedBlunt" , 15 },
            { "bowmanship", 15 },
            { "crafting", 15 },
            { "offensiveMagic", 15 },
            { "passiveMagic", 15 },
            { "illusionMagic", 15 },
            { "necromancy", 15 },
            { "alchemy", 15 },
            { "summoningMagic", 15 },
            { "shadowMagic", 15 }
        };
    public Dictionary<string, int> SetPlayerRace(string raceChoice)
    {
        bool validInput = false;

        do
        {  
            switch (raceChoice) // Alter starting stats based on chosen race
            {
                case "altrian":
                    playerRace["intelligence"] = 20;
                    playerRace["charisma"] = 20;
                    playerRace["luck"] = 20;
                    playerRace["swordsmanship"] = 20;
                    playerRace["necromancy"] = 10;
                    playerRace["alchemy"] = 20;
                    playerRace["summoningMagic"] = 10;
                    playerRace["shadowMagic"] = 10;
                    validInput = true;
                    break;

                case "sylvanari":
                    playerRace["hp"] = 80;
                    playerRace["mana"] = 120;
                    playerRace["strength"] = 10;
                    playerRace["agility"] = 20;
                    playerRace["daggerMastery"] = 20;
                    playerRace["twoHandedBlunt"] = 10;
                    playerRace["bowmanship"] = 20;
                    playerRace["passiveMagic"] = 20;
                    playerRace["illusionMagic"] = 20;
                    playerRace["shadowMagic"] = 10;
                    validInput = true;
                    break;
                
                case "brugrak":
                    playerRace["hp"] = 120;
                    playerRace["stamina"] = 120;
                    playerRace["mana"] = 60;
                    playerRace["strength"] = 20;
                    playerRace["agility"] = 10;
                    playerRace["endurance"] = 20;
                    playerRace["oneHandedBlunt"] = 20;
                    playerRace["twoHandedBlunt"] = 20;
                    playerRace["offensiveMagic"] = 20;
                    playerRace["illusionMagic"] = 10;
                    playerRace["summoningMagic"] = 10;
                    validInput = true;
                    break;

                case "dravok":
                    playerRace["hp"] = 140;
                    playerRace["stamina"] = 80;
                    playerRace["mana"] = 80;
                    playerRace["endurance"] = 20;
                    playerRace["swordsmanship"] = 20;
                    playerRace["oneHandedBlunt"] = 20;
                    playerRace["crafting"] = 20;
                    playerRace["offensiveMagic"] = 10;
                    playerRace["passiveMagic"] = 20;
                    playerRace["necromancy"] = 10;
                    playerRace["summoningMagic"] = 10;
                    validInput = true;
                    break;

                case "emberforge":
                    playerRace["hp"] = 120;
                    playerRace["mana"] = 80;
                    playerRace["agility"] = 10;
                    playerRace["intelligence"] = 20;
                    playerRace["daggerMastery"] = 10;
                    playerRace["bowmanship"] = 10;
                    playerRace["crafting"] = 20;
                    playerRace["offensiveMagic"] = 20;
                    playerRace["passiveMagic"] = 20;
                    playerRace["alchemy"] = 20;
                    validInput = true;
                    break;

                case "astrai":
                    playerRace["hp"] = 80;
                    playerRace["stamina"] = 80;
                    playerRace["mana"] = 140;
                    playerRace["swordsmanship"] = 10;
                    playerRace["oneHandedBlunt"] = 10;
                    playerRace["twoHandedBlunt"] = 10;
                    playerRace["passiveMagic"] = 20;
                    playerRace["illusionMagic"] = 20;
                    playerRace["necromancy"] = 20;
                    playerRace["summoningMagic"] = 20;
                    playerRace["shadowMagic"] = 20;
                    validInput = true;
                    break;

                default:
                    Console.WriteLine("Invalid race choice. Please try again.");
                    break;
            }
        }while(!validInput);

        return playerRace;
    }
}

public class Inventory
{
    private List<Item> items = new List<Item>();

    public void addItem(Item newItem)
    {
        items.Add(newItem);
    }

    public Item dropItem(Item item)
    {
        int index = items.IndexOf(item);
        if (index != -1)
        {
            Item returnItem = items[index];
            items.RemoveAt(index);
            return returnItem;
        }
        else
        {
            throw new ArgumentException("Item not found in the inventory");
        }
    }

    public void showItems()
    {
        foreach(Item item in items)
        {

            // Will need to add branching for different child classes of Item

            Console.WriteLine($"{item}"); // This will need formatting in future
        }
    }
}