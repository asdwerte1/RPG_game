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

    public PlayerCharacter()
    {
        bool validInput = false;
        string? playerNameInput = null;
        while(validInput != true)
        {
            try
            {
                Console.WriteLine("Enter the name of your charater: ");
                playerNameInput = Console.ReadLine();
                if (playerNameInput != null)
                {
                    Console.WriteLine($"Chosen name: {playerNameInput}");
                    this.Name = playerNameInput;
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
    }
}