using UnityEngine;
using System.Collections;

public class BaseMainDivineMage : BaseToonClass{

	//Main class is only class till subclasses at level 30
	public void BaseDivineMageMain(){
		ToonName = "Divine Mage";
		ToonDetails = "Magic wielders blessed by the father of all creation to heal and aide those they see fit of his divine benevolent gifts to the realmspeople. Many are sought after by churches as aid with the many warring factions rising across the realms keeps many divine churches busy with healing needs.";
		Health = 10;
		Stamina = 8;
		Endurance = 9;
		Strength = 5;
		Agility = 10;
		MagicPower = 16;
		Intellect = 17;
		Wisdom = 13;
		Luck = 18;
		Spirit = 23;

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
