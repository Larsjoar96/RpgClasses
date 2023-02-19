using System;

public class Warrior : Hero
{
    public enum ValidWeaponTypes
    {
        Axe = 1,
        Hammer = 4,
        Sword = 6    }
    public enum ValidArmorTypes
    {
        Mail = 3,
        Plate = 4
    }
    //Starting gear


    public Warrior(string heroName)
    {
        int[] startingAttributes = new int[3] { 5, 2, 1 };
        int[] levelUpAttributes = new int[3] { 3, 2, 1 };
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
                case (int)ValidWeaponTypes.Axe:
                    equipment[weapon.getSlot()] = weapon;
                    Console.WriteLine("Equipped: " + weapon.getItemName());
                    break;
                case (int)ValidWeaponTypes.Hammer:
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
    //Checks if the Hero has the valid level and ArmorType to wear the armor
    public override void equipArmor(Armor armor)
    {
        if (armor.getRequiredLevel() <= getLevel())
        {
            switch ((int)armor.armorType)
            {
                case (int)ValidArmorTypes.Mail:
                    equipment[armor.getSlot()] = armor;
                    Console.WriteLine("Equipped: " + armor.getItemName());
                    break;
                case (int)ValidArmorTypes.Plate:
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
        damagingAttribute = getTotalAttributes().strength;
        if (equipment[Slots.Weapon] != null)
        {
            weaponDamage = ((Weapon)(equipment[Slots.Weapon])).weaponDamage;
        }
        return weaponDamage + damagingAttribute;
    }
}
