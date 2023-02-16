using System;

public class Item
{
	string itemName;
	int requiredLevel;
    Hero.Slots slot;

    public Item()
	{
 
	}

    public void setSlot(Hero.Slots itemSlot) 
    {
        slot = itemSlot;
    }
    public Hero.Slots getSlot() 
    {
        return slot;
    }

    public void setItemName(string newName) 
    {
        itemName = newName;
    }
    public string getItemName() 
    {
        return itemName;
    }

    public void setRequiredLevel(int reqLevel) 
    {
        requiredLevel = reqLevel;
    }
    public virtual HeroAttribute getAttribute() 
    {
        return null;
    }
    public int getRequiredLevel() 
    {
        return requiredLevel;
    }



}
