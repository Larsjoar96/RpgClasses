using System;
using System.Security.Cryptography;

public class Armor : Item
{
	public ArmorType armorType;
	int[] tempArmorAttributes;
	int[] armorLevelUp = new int[3] { 0, 0, 0 };
	HeroAttribute armorAttribute;

	public enum ArmorType 
	{
		Cloth = 1,
		Leather = 2,
		Mail = 3,
		Plate = 4
	}
	public Armor(string name, int reqLevel, ArmorType type, Hero.Slots itemSlot)
	{
		setItemName(name);
		setRequiredLevel(reqLevel);
		armorType = type;
		setSlot(itemSlot);
        tempArmorAttributes = new int[3] { calculateBonusStrength(), calculateBonusDexerity(), calculateBonusIntellect() };
        armorAttribute = new HeroAttribute(tempArmorAttributes, armorLevelUp);
    }

    //Gives a random intellect bonus at a max of 5 + requiredLevel
    private int calculateBonusIntellect() 
    {
		int modifierMax = 4;
		int randomModifier = RandomNumberGenerator.GetInt32(modifierMax) + 1;
		return  getRequiredLevel() + randomModifier; 
	}

    //Gives a random dexerity bonus at a max of 5 + requiredLevel
    private int calculateBonusDexerity()
    {
        int modifierMax = 4;
        int randomModifier = RandomNumberGenerator.GetInt32(modifierMax) + 1;
        return getRequiredLevel() + randomModifier;
    }

    //Gives a random strength bonus at a max of 5 + requiredLevel
    private int calculateBonusStrength() 
    {
        int modifierMax = 4;
        int randomModifier = RandomNumberGenerator.GetInt32(modifierMax) + 1;
        return getRequiredLevel() + randomModifier;
    }
	public override HeroAttribute getAttribute() 
	{ 
		return armorAttribute;
	}
}
