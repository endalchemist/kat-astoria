using UnityEngine
using System.Collections;

public class BaseMSubClassRvSorc : BaseToonClasses{
	
	public BaseRvSorc(){
		ToonName = "Red Violet Wizard";
		ToonDetails = "Sneaky magic wielders extremely rare and well versed in using the raw elemental an magical properties that lie between these few know realms of the universes";
		Health = 14;
		Stamina = 13;
		Endurance = 5;
		Strength = 6;
		Agility = 14;
		MagicPower = 13;
		Intellect = 12;
		Wisdom = 12;
		Sneak = 19;
		Luck = 12;
		Spirit = 10;
		
		MagicEnergy = Intellect + Wisdom * Spirit + MagicPower;
		MagicSpeed = MagicPower * Intellect * Wisdom * (Luck/3);
		AttackSpeed = 1;
		CritChance = 1;
		CritMulitiplier = 1;
		SleightOfHand = 1;
		//room for more stats here
		
	}
}