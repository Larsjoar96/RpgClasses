using System;
using System.Security.Cryptography;

public class Weapon : Item
{

	int weaponDamage = 1;
	string weaponType;
	public enum WeaponType 
	{
		Axe,
		Bow,
		Dagger,
		Hammer,
		Staff,
		Sword,
		Wand
	}
	public Weapon(string name, int reqLevel, WeaponType type, Slots itemSlot)
	{
		setItemName(name);
		setRequiredLevel(reqLevel);
		weaponType = type.ToString();
		setSlot(itemSlot.ToString());
		weaponDamage = calculateWeaponDamage();
	}

	private int calculateWeaponDamage() 
	{
		int modifierMax = 9;
		int randomModifier = RandomNumberGenerator.GetInt32(modifierMax) + 1;
		return weaponDamage * getRequiredLevel() + randomModifier;
	}
}
