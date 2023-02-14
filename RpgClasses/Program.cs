namespace RpgClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mage character = new Mage("Steve");
            Armor gauntlets = new Armor("Fisters", 3, Armor.ArmorType.Plate, Item.Slots.Body);

            Console.WriteLine("Name: " + character.getName());
            Console.WriteLine("Intellect: " + character.levelAttributes.intellect);
            Console.WriteLine("Level Up!");
            character.LevelUp();
            Console.WriteLine("Intellect: " + character.levelAttributes.intellect);

            Console.WriteLine(gauntlets.getItemName() + " dropped!");
            Console.WriteLine("You need to be level " + gauntlets.getRequiredLevel() + " to use them");
            Console.WriteLine("It is made of solid " + gauntlets.getArmorType());
            Console.WriteLine("It can be worn in the slot " + gauntlets.getSlot());
            Console.WriteLine("Bonus stats include: ");
            Console.WriteLine("Intellect bonus: " + gauntlets.getBonusIntellect());
            Console.WriteLine("Dexerity bonus: " + gauntlets.getBonusDexerity());
            Console.WriteLine("Strength bonus: " + gauntlets.getBonusStrength());
        }
    }
}