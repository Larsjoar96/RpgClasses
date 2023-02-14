using System;

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

	public Mage(string heroName)
	{
		int[] startingAttributes = new int[3] {1,1,8};
		int[] levelUpAttributes = new int[3] { 1, 1, 5 };
		levelAttributes = new HeroAttribute(startingAttributes, levelUpAttributes);
		setName(heroName);
		initializeEquipment();
	}
}
