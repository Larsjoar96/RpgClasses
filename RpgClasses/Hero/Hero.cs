using System;

public class Hero
{
    string heroName;
    int level = 1;
    public HeroAttribute levelAttributes;
    Item[] equipment;

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
        
    }
    public void setName(string name) 
    {
        heroName = name;
    }
    public string getName()
    {
        return heroName;
    }

}
