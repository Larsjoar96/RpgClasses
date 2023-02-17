using System;

public class Rogue : Hero
{
    public enum ValidWeaponTypes
    {
        Dagger = 3,
        Sword = 6    }
    public enum ValidArmorTypes
    {
        Leather = 2,
        Mail = 3
    }
    //Starting gear


    public Rogue(string heroName)
    {
        int[] startingAttributes = new int[3] { 2, 6, 1 };
        int[] levelUpAttributes = new int[3] { 1, 4, 1 };
        levelAttributes = new HeroAttribute(startingAttributes, levelUpAttributes);
        setName(heroName);
        initializeEquipment();

    }
    //Checks if the Hero has the valid level and WeaponType to wield the weapon
    public override void equipWeapon(Weapon weapon)
    {
        if (weapon.getRequiredLevel() <= getLevel())
        {
            switch ((int)weapon.weaponType)
            {
                case (int)ValidWeaponTypes.Dagger:
                    equipment[weapon.getSlot()] = weapon;
                    Console.WriteLine("Equipped: " + weapon.getItemName());
                    break;
                case (int)ValidWeaponTypes.Sword:
                    equipment[weapon.getSlot()] = weapon;
                    Console.WriteLine("Equipped: " + weapon.getItemName());
                    break;
                default:
                    Console.WriteLine("Not the required weapon type");
                    //Throw error InvalidWeaponException
                    break;
            }
        }
    }
    public override void equipArmor(Armor armor)
    {
        if (armor.getRequiredLevel() <= getLevel())
        {
            switch ((int)armor.armorType)
            {
                case (int)ValidArmorTypes.Leather:
                    equipment[armor.getSlot()] = armor;
                    Console.WriteLine("Equipped: " + armor.getItemName());
                    break;
                case (int)ValidArmorTypes.Mail:
                    equipment[armor.getSlot()] = armor;
                    Console.WriteLine("Equipped: " + armor.getItemName());
                    break;
                default:
                    Console.WriteLine("Not the required weapon type");
                    //Throw error InvalidWeaponException
                    break;
            }
        }
        else
        {
            Console.WriteLine("Your hero is not the required level");
        }
    }
    public override int doDamage()
    {
        int weaponDamage = 1;
        damagingAttribute = getTotalAttributes().dexterity;
        if (equipment[Slots.Weapon] != null)
        {
            weaponDamage = ((Weapon)(equipment[Slots.Weapon])).weaponDamage;
        }
        return weaponDamage + damagingAttribute;
    }
}
