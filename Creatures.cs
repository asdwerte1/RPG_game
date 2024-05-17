namespace Creatures;
class Creature
// Base class for all beings within the game such as character, NPCs, enemies, creatures etc
{
    
    private int hp;
    private int mana;
    private int stamina;

    public Creature()
    {
        // Standard starter for all - multipliers will be used to alter for classes, races, creatures etc
        this.hp = 100;
        this.mana = 100;
        this.stamina = 100;
    }
}