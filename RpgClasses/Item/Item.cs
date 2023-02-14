using System;

public class Item
{
	string itemName;
	int requiredLevel;
    string slot;
    public enum Slots
    {
        Weapon,
        Head,
        Body,
        Legs
    }

    public Item()
	{
 
	}

    public void setSlot(string itemSlot) 
    {
        slot = itemSlot;
    }
    public string getSlot() 
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
