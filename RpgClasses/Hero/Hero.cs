using System;
using System.Collections;

public class Hero
{
    string heroName;
    int level = 1;
    public HeroAttribute levelAttributes;
    public Hashtable equipment;
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
    public void equipItem(Item item) 
    {
        if(item.GetType() == typeof(Weapon)) 
        { 
            equipWeapon(item);
        }
        else if(item.GetType() == typeof(Armor)) 
        {
            equipArmor(item);
        }
    }
    public virtual void equipWeapon(Item weapon) 
    {
        
    }
    public virtual void equipArmor(Item armor) 
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
        equipment = new Hashtable();
        equipment.Add(Slots.Weapon, null);
        equipment.Add(Slots.Head, null);
        equipment.Add(Slots.Body, null);
        equipment.Add(Slots.Legs, null);
        
    }

}
