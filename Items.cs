namespace Items;

abstract public class Item{
    public string name = String.Empty;
    private int weight = 0;
    private int value = 0;
}

abstract public class Weapon: Item
{
    private int damage = 0;
    private string condition = String.Empty;
    // TODO Enchanchtment to be added in future + method to add enchanchments
}

abstract public class Aparel: Item
{
    // TODO Enchantment to be added in future + methot o add enchanchments
}