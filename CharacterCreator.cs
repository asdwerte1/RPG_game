using Microsoft.VisualBasic;

class CharacterCreator
{

    public static Dictionary<int, string> races = new Dictionary<int, string>()
    {
        {1, "Altrian"},
        {2, "Sylvanari"},
        {3, "Brugrak"},
        {4, "Dravok"},
        {5, "Emberforge Clans"},
        {6, "Astrai"}
    };
    
    public static string ChooseRace()
    {
        Console.WriteLine("Choose one of the following races for your character:\n1.\tAltrian\n2.\tSylvanari\n3.\tBrugrak\n4.\tDravok\n5.\tEmberforge Clan\n6.\tAstrai");
        
        bool valid_input = false;
        do
        {
            Console.WriteLine("Please choose the race you wish to play as, by typing the corresponding number: ");
            string? player_choice = Console.ReadLine();

            if (int.TryParse(player_choice, out int player_choice_num))
            {
                if (player_choice_num >= 1 && player_choice_num <= 6)
                {
                    valid_input = true;
                    string player_race = races[player_choice_num];
                    Console.WriteLine($"You have chosen: {player_race}");
                    return player_race;
                }
                else
                {
                    Console.WriteLine("Please ensure you eneter a number between 1 and 6.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a number corresponding to one of the races listed,");
            }

        } while (valid_input != true);

        //Default return value - will lead to recalling the method
        return "";
        
    }
}