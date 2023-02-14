using System;

public class Warrior : Hero
{
	public Warrior(string heroName)
	{
		int[] startingAttributes = new int[3] {1,1,8};
		int[] levelUpAttributes = new int[3] { 1, 1, 5 };
		levelAttributes = new HeroAttribute(startingAttributes, levelUpAttributes);
		setName(heroName);
	}
}
