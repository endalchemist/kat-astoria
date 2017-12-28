using UnityEngine;
using System.Collections;

public class BaseMainArcher : BaseToonClass{

	//Main class is only class till subclasses at level 30
	public void BaseArcherMain(){
		ToonName = "Archer";
		ToonDetails = "Skilled with a bow. Stealthy in nature by nature.";
		Health = 15;
		Stamina = 12;
		Endurance = 10;
		Strength = 9;
		Agility = 20;
		MagicPower = 11;
		Intellect = 14;
		Wisdom = 16;
		Luck = 9;
		Spirit = 1;

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
