using System;
using System.Security.Cryptography;

public class Armor : Item
{
	string armorType;
	int[] armorAttributes;
	int[] armorLevelUp = new int[3] { 0, 0, 0 };
	HeroAttribute armorAttribute;

	public enum ArmorType 
	{
		Cloth,
		Leather,
		Mail,
		Plate
	}
	public Armor(string name, int reqLevel, ArmorType type, Slots itemSlot)
	{
		setItemName(name);
		setRequiredLevel(reqLevel);
		armorType = type.ToString();
		setSlot(itemSlot.ToString());
        armorAttributes = new int[3] { calculateBonusIntellect(), calculateBonusDexerity(), calculateBonusStrength() };
        armorAttribute = new HeroAttribute(armorAttributes, armorLevelUp);
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

    public string getArmorType() 
	{
		return armorType;
	}

	public HeroAttribute getArmorAttribute() 
	{ 
		return armorAttribute;
	}
}
