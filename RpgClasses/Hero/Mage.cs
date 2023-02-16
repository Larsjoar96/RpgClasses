using System;
using System.ComponentModel;

public class Mage : Hero
{
	public enum ValidWeaponTypes
	{
		Staff = 5,
		Wand = 7
	}
	public enum ValidArmorTypes
	{
		Cloth = 1
	}
	//Starting gear


    public Mage(string heroName)
	{
		int[] startingAttributes = new int[3] { 1, 1, 8 };
		int[] levelUpAttributes  = new int[3] { 1, 1, 5 };
		levelAttributes = new HeroAttribute(startingAttributes, levelUpAttributes);
		setName(heroName);
        startingWeapon = new Weapon("Wooden staff", 1, Weapon.WeaponType.Staff, Slots.Weapon);
        startingArmorHead = new Armor("Cloth hood", 1, Armor.ArmorType.Cloth, Slots.Head);
        startingArmorBody = new Armor("Cloth robe", 1, Armor.ArmorType.Cloth, Slots.Body);
        startingArmorLegs = new Armor("Cloth pants", 1, Armor.ArmorType.Cloth, Slots.Legs);
        initializeEquipment();
		
	}
	//Checks if the Hero has the valid level and WeaponType to wield the weapon
	public override void equipWeapon(Weapon weapon)
	{
		if (weapon.getRequiredLevel() <= getLevel())
		{
			switch ((int)weapon.weaponType)
			{
				case (int)ValidWeaponTypes.Staff:
					equipment[weapon.getSlot()] = weapon;
					Console.WriteLine("Equipped: " + weapon.getItemName());
					break;
				case (int)ValidWeaponTypes.Wand:
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
                case (int)ValidArmorTypes.Cloth:
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
}
