using System;
using System.Collections;

public class Hero
{
    string heroName;
    int level = 1;
    public HeroAttribute levelAttributes;
    public Dictionary <Slots,Item> equipment;
    public int damagingAttribute;
    public Exception TooLowLevelException;
    public Exception WrongWeaponTypeException;
    public Exception WrongArmorTypeException;
    public Weapon startingWeapon;
    public Armor startingArmorHead;
    public Armor startingArmorBody;
    public Armor startingArmorLegs;
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
    //Calculates the total attributes of a hero and their equipped armor
    public HeroAttribute getTotalAttributes() 
    {
        int[] startAttributes = new int[3] {0,0,0};
        HeroAttribute totalAttributes = new HeroAttribute(startAttributes, startAttributes);
        //Add level attributes
        totalAttributes.strength = levelAttributes.strength;
        totalAttributes.dexterity = levelAttributes.dexterity;
        totalAttributes.intellect = levelAttributes.intellect;
        //Add stats for helmet
        if (equipment[Slots.Head] != null) 
        {
            totalAttributes.strength = totalAttributes.strength + ((Armor)(equipment[Slots.Head])).getAttribute().strength;
            totalAttributes.dexterity = totalAttributes.dexterity + ((Armor)(equipment[Slots.Head])).getAttribute().dexterity;
            totalAttributes.intellect = totalAttributes.intellect + ((Armor)(equipment[Slots.Head])).getAttribute().intellect;
        }
        if (equipment[Slots.Body] != null)
        {
            totalAttributes.strength = totalAttributes.strength + ((Armor)(equipment[Slots.Body])).getAttribute().strength;
            totalAttributes.dexterity = totalAttributes.dexterity + ((Armor)(equipment[Slots.Body])).getAttribute().dexterity;
            totalAttributes.intellect = totalAttributes.intellect + ((Armor)(equipment[Slots.Body])).getAttribute().intellect;
        }
        if (equipment[Slots.Legs] != null)
        {
            totalAttributes.strength = totalAttributes.strength + ((Armor)(equipment[Slots.Legs])).getAttribute().strength;
            totalAttributes.dexterity = totalAttributes.dexterity + ((Armor)(equipment[Slots.Legs])).getAttribute().dexterity;
            totalAttributes.intellect = totalAttributes.intellect + ((Armor)(equipment[Slots.Legs])).getAttribute().intellect;
        }

        return totalAttributes;
    }
    public virtual int doDamage() 
    {
        return 0;
    }
    public void displayHero() 
    {
        Console.WriteLine("Name: " + heroName);
        Console.WriteLine("Class: " + this.GetType());
        Console.WriteLine("Level: " + level);
        Console.WriteLine("Attributes: ");
        Console.WriteLine("Strength: " + getTotalAttributes().strength);
        Console.WriteLine("Dexterity: " + getTotalAttributes().dexterity);
        Console.WriteLine("Intellect: " + getTotalAttributes().intellect);
        Console.WriteLine("Equipment: ");
        if (equipment[Slots.Weapon] != null) 
        { 
            Console.WriteLine("Weapon: " + (equipment[Slots.Weapon].getItemName())); 
        }
        else 
        {
            Console.WriteLine("Weapon: Unarmed");
        }
        if (equipment[Slots.Head] != null)
        {
            Console.WriteLine("Head: " + (equipment[Slots.Head].getItemName()));
        }
        else
        {
            Console.WriteLine("Head: Empty");
        }
        if (equipment[Slots.Body] != null)
        {
            Console.WriteLine("Body: " + (equipment[Slots.Body].getItemName()));
        }
        else
        {
            Console.WriteLine("Body: Empty");
        }
        if (equipment[Slots.Legs] != null)
        {
            Console.WriteLine("Legs: " + (equipment[Slots.Legs].getItemName()));
        }
        else
        {
            Console.WriteLine("Legs: Empty");
        }
    }

}
