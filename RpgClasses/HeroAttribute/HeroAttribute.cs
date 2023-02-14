using System;

public class HeroAttribute
{
	public int strength;
	public int dexerity;
	public int intellect;
	public int[] levelAttributes;
	public HeroAttribute(int[] startingAttributes, int[] levelUpAttributes)
	{
		levelAttributes = levelUpAttributes;
		strength = startingAttributes[0];
		dexerity = startingAttributes[1];
		intellect = startingAttributes[2];
	}

	public void improveAttributes() 
	{
		strength = strength + levelAttributes[0];
		dexerity = dexerity + levelAttributes[1];
		intellect = intellect + levelAttributes[2];
	}
}
