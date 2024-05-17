using System;
namespace Creatures;
class Creature
// Base class for all beings within the game such as character, NPCs, enemies, creatures etc
{
    
    private int hp;
    private int stamina;
    private int mana;
    public Creature()
    {
        // Standard starter for all - multipliers will be used to alter for classes, races, creatures etc
        this.hp = 100;
        this.stamina = 100;
        this.mana = 100;
    }
}