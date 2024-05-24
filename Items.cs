namespace Items;

abstract public class Item{
    public string name = string.Empty;
    protected int _weight = 0;
    protected int _value = 0;
}

abstract public class Weapon: Item
{
    protected int _damage = 0;
    protected MeleeConditons _condition;
    // TODO Enchanchtment to be added in future + method to add enchanchments
}

abstract public class Melee: Weapon
{
    protected MeleeMaterials _material;
    protected string _materialToString = string.Empty; // Used for splitting multi-word materials
    protected void ChangeCondition()
    {
        // TODO
    }
}

abstract public class Ranged: Weapon
{
    // TODO
}

public class Sword: Melee
{
    // One handed sword class
    public Sword(MeleeMaterials material, MeleeConditons condition)
    {
        this._damage = 10; // Base damage for a sword
        this._weight = 5; // Base weight for a sword - MAY CHANGE - NEED TO WORK OUT WEIGHT SYSTEM
        this._value = 20; // Base gold value for a sword
        this._material = material;
        this._condition = condition;

        switch(this._material)
        {
            case MeleeMaterials.Stone:
                this._weight *= 2;
                this._value = (int)(this._value * 0.8);
                this._materialToString = "Stone";
                break;
            case MeleeMaterials.Steel:
                this._damage = (int)(this._damage * 1.5);
                this._weight = (int)(this._weight * 1.5);
                this._value = (int)(this._value * 1.5);
                this._materialToString = "Steel";
                break;
            case MeleeMaterials.ElvenSteel:
                this._damage = (int)(this._damage * 1.5);
                this._value *= 2;
                this._materialToString = "Elven Steel";
                break;
            case MeleeMaterials.DwarvenSteel:
                this._damage = (int)(this._damage * 1.75);
                this._weight *= 2;
                this._value = (int)(this._damage * 2.5);
                this._materialToString = "Dwarven Steel";
                break;
            case MeleeMaterials.Obsidean:
                this._weight = (int)(this._weight * 1.5);
                this._value = (int)(this._value * 1.75);
                this._materialToString = "Obsidean";
                break;
            case MeleeMaterials.Silver:
                this._damage = (int)(this._damage * 1.5);
                this._weight = (int)(this._weight * 1.5);
                this._materialToString = "Silver";
                break;
        }
        switch(this._condition)
        {
            case MeleeConditons.Ruined:
                this._damage = 0;
                this._value = 0;
                break;
            case MeleeConditons.Blunt:
                this._damage /= 2;
                this._value /= 2;
                break;
            case MeleeConditons.Tarnished:
                this._damage = (int)(this._damage * 0.75);
                this._value = (int)(this._value * 0.75);
                break;
            case MeleeConditons.Excellent:
                this._damage = (int)(this._damage * 1.25);
                this._value = (int)(this._value * 1.25);
                break;
            case MeleeConditons.Perfect:
                this._damage = (int)(this._damage * 1.5);
                this._value = (int)(this._value * 1.5);
                break;
        }   

        name = $"{this._materialToString} Sword [{this._condition}]";
    }

    public override string ToString() // CHECK IF CAN BE MOVED UP A CLASS
    {                                     //Would make this a property - type
        name = $"{this._materialToString} sword [{this._condition}]\n\tDamage: {this._damage}\tWeight: {this._weight}\tValue: {this._value}"; // Update name for current condition
        return name;
    }
}

public enum MeleeConditons
{
    // Apply damage multipliers to weapons
    // Weapons will degrade with use
    Ruined, // Damage multiplier -> 0
    Blunt, // Damage multiplier -> 0.5
    Tarnished, // Damage multipler -> 0.75
    Good, // Damage multiplier -> 1 (standard)
    Excellent, // Damage multiplier -> 1.25
    Perfect // Damage multiplier -> 1.5
}

public enum MeleeMaterials
{
    Stone, // Damage multiplier -> 1 (standard), weight multiplier -> 2
    Iron, // Damage multipler -> 1 (standard), weight multiplier -> 1 (standard)
    Steel, // Damage multiplier -> 1.5, weight multiplier -> 1.5
    ElvenSteel, // Damage multiplier -> 1.5, weight multiplier -> 1 (standard)
    DwarvenSteel, // Damage multiplier -> 1.75, weight multiplier -> 2
    Obsidean, // Damage multiplier -> 1, weight multiplier -> 1.5, enhances damage enchanchments -> 1.5
    Silver // Damage multiplier -> 1.5, weight multiplier -> 1.5, additional damage to undead -> 1.5
}

abstract public class Aparel: Item
{
    // TODO Enchantment to be added in future + methot o add enchanchments
}