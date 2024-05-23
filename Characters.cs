namespace Characters;

public abstract class Character 
{
    public int Hp { get; set;}
    public int Stamina { get; protected set; }
    /*
    public int Strength { get; private set; }
    public int Agility { get; private set; }
    public int Endurance { get; private set; }*/

    public Character()
    {
        this.Hp = 100;
        this.Stamina = 100;
        //this.Strength = 15;
        //this.Agility = 15;
        //this.Endurance = 15;
    }
}

public abstract class Humanoid: Character
{
    public int Mana {get; protected set;}

    public Humanoid()
    {
        this.Mana = 100;
    }
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

    }
}

 public class Races
{
    // Create base case starting stats
    private Dictionary<string, int> playerRace = new Dictionary<string, int>
        {
            { "hp", 100 },
            { "stamina", 100 },
            { "mana", 100 },/*
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
            { "offensiveMagic", 15 },
            { "passiveMagic", 15 },
            { "illusionMagic", 15 },
            { "necromancy", 15 },
            { "alchemy", 15 },
            { "summoningMagic", 15 },
            { "shadowMagic", 15 }*/
        };
    public Dictionary<string, int> SetPlayerRace(string raceChoice)
    {
        bool validInput = false;

        do
        {  
            switch (raceChoice) // Alter starting stats based on chosen race
            {
                case "altrian":
                    break;

                case "sylvanari":
                    playerRace["hp"] = 80;
                    playerRace["mana"] = 120;
                    validInput = true;
                    break;
                
                case "brugrak":
                    playerRace["hp"] = 120;
                    playerRace["stamina"] = 120;
                    playerRace["mana"] = 60;
                    validInput = true;
                    break;

                case "dravok":
                    playerRace["hp"] = 140;
                    playerRace["stamina"] = 80;
                    playerRace["mana"] = 80;
                    validInput = true;
                    break;

                case "emberforge":
                    playerRace["hp"] = 120;
                    playerRace["mana"] = 80;
                    validInput = true;
                    break;

                case "astrai":
                    playerRace["hp"] = 80;
                    playerRace["stamina"] = 80;
                    playerRace["mana"] = 140;
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