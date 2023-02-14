using System;
using System.Security.Cryptography;

public class Armor : Item
{
	string armorType;
	int[] baseArmorAttribute = new int[3] { 1, 1, 1 };
	int[] armorLevelUp = new int[3] { 0, 0, 0 };
	HeroAttribute armorAttribute;
	armorAttribute = new HeroAttribute(baseArmorAttribute, armorLevelup);
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
		intellectBonus = calculateBonusIntellect();
		dexerityBonus = calculateBonusDexerity();
		strengthBonus = calculateBonusStrength();
	}

    //Gives a random intellect bonus at a max of 5 + requiredLevel
    private int calculateBonusIntellect() 
    {
		int modifierMax = 4;
		int randomModifier = RandomNumberGenerator.GetInt32(modifierMax) + 1;
		return  intellectBonus * getRequiredLevel() + randomModifier; 
	}

	public int getBonusIntellect() 
    {
		return intellectBonus;
	}
    //Gives a random dexerity bonus at a max of 5 + requiredLevel
    private int calculateBonusDexerity()
    {
        int modifierMax = 4;
        int randomModifier = RandomNumberGenerator.GetInt32(modifierMax) + 1;
        return dexerityBonus * getRequiredLevel() + randomModifier;
    }

    public int getBonusDexerity()
    {
        return dexerityBonus;
    }
    //Gives a random strength bonus at a max of 5 + requiredLevel
    private int calculateBonusStrength() 
    {
        int modifierMax = 4;
        int randomModifier = RandomNumberGenerator.GetInt32(modifierMax) + 1;
        return strengthBonus * getRequiredLevel() + randomModifier;
    }

    public int getBonusStrength()
    {
        return strengthBonus;
    }
    public string getArmorType() 
	{
		return armorType;
	}
}
