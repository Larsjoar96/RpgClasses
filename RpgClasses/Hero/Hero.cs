using System;
using System.Collections;

public class Hero
{
    string heroName;
    int level = 1;
    public HeroAttribute levelAttributes;
    public Dictionary <Slots,Item> equipment;
    public enum Slots 
    {
        Weapon = 1,
        Head = 2,
        Body = 3,
        Legs = 4
    } 

    public Hero()
	{

	}

    public void LevelUp() 
    {
        level++;
        levelAttributes.improveAttributes();
    }
    public virtual void equipWeapon(Weapon weapon) 
    {
        
    }
    public virtual void equipArmor(Armor armor) 
    {

    }
    public void setName(string name) 
    {
        heroName = name;
    }
    public string getName()
    {
        return heroName;
    }

    public int getLevel() 
    {
        return level;
    }
    public void initializeEquipment() 
    {
        equipment = new Dictionary<Slots, Item>();
        equipment.Add(Slots.Weapon, null);
        equipment.Add(Slots.Head, null);
        equipment.Add(Slots.Body, null);
        equipment.Add(Slots.Legs, null);
        
    }

}
