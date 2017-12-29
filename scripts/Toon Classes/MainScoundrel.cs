using UnityEngine;
using System.Collections;

public class BaseMainScoundrel : BaseToonClass{

	//Main class is only class till subclasses at level 30
	public void BaseScoundrelMain(){
		ToonName = "Scoundrel";
		ToonDetails = "Sneak people often very hard to find. Often seem to know just where and when to plunge their daggers seemingly leaving any foe in wonder of what just happened";
		Health = 17;
		Stamina = 14;
		Endurance = 12;
		Strength = 16;
		Agility = 14;
		MagicPower = 3;
		Intellect = 10;
		Wisdom = 6;
		Luck = 9;
		Spirit = 13;

		HitPoint = (Health * Math.Round((Strength/4))) + Endurance + Stamina;
		MagicEnergy = Intellect + Wisdom * Spirit + MagicPower;
		MagicSpeed = MagicPower + Math.Round((Intellect/2)) + Math.Round((Wisdom/4)) + Math.Round((Luck/3));
		AttackSpeed = (Stamina + Endurance + Agility)/100;
		CritChance = Math.Round((Agility/3)) + Luck;
		CritMultiplier = Math.Round((Luck/2));
		SleightOfHand = (Agility + Luck)/100;
		Sneak = Agility + Luck;
		//room for more stats here

	}
}
