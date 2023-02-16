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
        equipment.Add(Slots.Weapon, startingWeapon);
        equipment.Add(Slots.Head, startingArmorHead);
        equipment.Add(Slots.Body, startingArmorBody);
        equipment.Add(Slots.Legs, startingArmorLegs);
        
    }
    //Calculates the total attributes of a hero and their equipped armor
    public HeroAttribute getTotalAttributes() 
    {
        int[] startAttributes = new int[3] {0,0,0};
        HeroAttribute totalAttributes = new HeroAttribute(startAttributes, startAttributes);
        totalAttributes.strength = totalAttributes.strength + 
                                   levelAttributes.strength + 
                                   equipment[Slots.Head].getAttribute().strength +
                                   equipment[Slots.Body].getAttribute().strength +
                                   equipment[Slots.Legs].getAttribute().strength;
        totalAttributes.dexterity = totalAttributes.dexterity +
                                   levelAttributes.dexterity +
                                   equipment[Slots.Head].getAttribute().dexterity +
                                   equipment[Slots.Body].getAttribute().dexterity +
                                   equipment[Slots.Legs].getAttribute().dexterity;
        totalAttributes.intellect = totalAttributes.intellect +
                                   levelAttributes.intellect +
                                   equipment[Slots.Head].getAttribute().intellect +
                                   equipment[Slots.Body].getAttribute().intellect +
                                   equipment[Slots.Legs].getAttribute().intellect;
        return totalAttributes;
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
        Console.WriteLine("Weapon: " + equipment[Slots.Weapon].getItemName());
        Console.WriteLine("Head: " + equipment[Slots.Head].getItemName());
        Console.WriteLine("Body: " + equipment[Slots.Body].getItemName());
        Console.WriteLine("Legs: " + equipment[Slots.Legs].getItemName());

    }

}
