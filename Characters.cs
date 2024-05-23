using System.Linq.Expressions;

namespace Characters;

public abstract class Character 
{
    public int Hp { get; set;}
    public int Stamina { get; private set; }
    public int Strength { get; private set; }
    public int Agility { get; private set; }
    public int Endurance { get; private set; }

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
    public int Mana {get; private set;}

    public Humanoid()
    {
        this.Mana = 100;
    }
}

public class PlayerCharacter: Humanoid
{
    public string? Name { get; private set; }
    public char? Gender { get; private set; }

    public PlayerCharacter()
    {
        // Set player name
        this.Name = SetName();
        
        // Set gender
        this.Gender = SetGender();
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
}