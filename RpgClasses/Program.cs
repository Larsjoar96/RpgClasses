namespace RpgClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mage character = new Mage("Steve");
            Weapon staff = new Weapon("Fire Cane", 3, Weapon.WeaponType.Staff, Item.Slots.Weapon);

            Console.WriteLine("Name: " + character.getName());
            Console.WriteLine("Intellect: " + character.levelAttributes.intellect);
            Console.WriteLine("Level Up!");
            character.LevelUp();
            Console.WriteLine("Intellect: " + character.levelAttributes.intellect);
            //Testing the Item/Armor Class
            Console.WriteLine(staff.getItemName() + " dropped!");
            Console.WriteLine("You need to be level " + staff.getRequiredLevel() + " to use them");
            Console.WriteLine("It is made of solid " + staff.weaponType);
            Console.WriteLine("It can be worn in the slot " + staff.getSlot());
            //Console.WriteLine("Bonus stats include: ");
            //Console.WriteLine("Intellect bonus: " + gauntlets.getArmorAttribute().intellect);
            //Console.WriteLine("Dexerity bonus: " + gauntlets.getArmorAttribute().dexerity);
            //Console.WriteLine("Strength bonus: " + gauntlets.getArmorAttribute().strength);
            character.equipWeapon(staff);
            character.LevelUp();
            Console.WriteLine("Level Up!");
            character.equipWeapon(staff);

        }
    }
}