using UnityEngine;
using System.Collections;

public class BaseMainRealmcastingMage : BaseToonClass{

	//Main class is only class till subclasses at level 30
	public void BaseRealmcastingMageMain(){
		ToonName = "Realmcasting Mage";
		ToonDetails = "In astonia some magical casters are lucky enough to get there arcane magical energy drawn directly from the spaces between all realms in the known universe.";
		Health = 8;
		Stamina = 9;
		Endurance = 10;
		Strength = 6;
		Agility = 13;
		MagicPower = 22;
		Intellect = 17;
		Wisdom = 15;
		Luck = 15;
		Spirit = 10;

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
