namespace RpgClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mage character = new Mage("Steve");
            Weapon staff = new Weapon("Fire Cane", 3, Weapon.WeaponType.Staff, Hero.Slots.Weapon);
            character.LevelUp();
            character.LevelUp();
            character.equipWeapon(staff);
            character.displayHero();
            Console.WriteLine(character.doDamage());

        }
    }
}