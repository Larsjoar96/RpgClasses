using System;
using System.Security.Cryptography;

public class Weapon : Item
{

	public int weaponDamage = 1;
	public int weaponType;
	public enum WeaponType 
	{
		Axe = 1,
		Bow = 2,
		Dagger = 3,
		Hammer = 4,
		Staff = 5,
		Sword = 6,
		Wand = 7
	}
	public Weapon(string name, int reqLevel, WeaponType type, Slots itemSlot)
	{
		setItemName(name);
		setRequiredLevel(reqLevel);
		weaponType =  (int)type;
		setSlot((int)itemSlot);
		weaponDamage = calculateWeaponDamage();
	}

	//Calculate the weapons damage based on its required level and a random modifier with an upper limit of 10
	private int calculateWeaponDamage() 
	{
		int modifierMax = 9;
		int randomModifier = RandomNumberGenerator.GetInt32(modifierMax) + 1;
		return weaponDamage * getRequiredLevel() + randomModifier;
	}
}
