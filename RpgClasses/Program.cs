namespace RpgClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mage character = new Mage("Steve");
            Weapon staff = new Weapon("Fire Cane", 3, Weapon.WeaponType.Staff, Item.Slots.Weapon);

            character.displayHero();

        }
    }
}