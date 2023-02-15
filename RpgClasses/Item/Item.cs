using System;

public class Item
{
	string itemName;
	int requiredLevel;
    int slot;
    public enum Slots
    {
        Weapon = 1,
        Head = 2,
        Body = 3,
        Legs = 4
    }

    public Item()
	{
 
	}

    public void setSlot(int itemSlot) 
    {
        slot = itemSlot;
    }
    public int getSlot() 
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
    public int getRequiredLevel() 
    {
        return requiredLevel;
    }



}
