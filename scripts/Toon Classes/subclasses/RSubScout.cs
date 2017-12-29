using UnityEngine
using System.Collections;

public class BaseRSubclassScout : BaseToonClasses{
	
	//mod=subclass
	public BaseScoutMod(){
		ToonName = "Scout";
		ToonDetails = "Deadly speed and precision hailing mostly from ranger camps in the woods of all realms";
		Health = 17;
		Stamina = 14;
		Endurance = 12;
		Strength = 16;
		Agility = 14;
		MagicPower = 3;
		Intellect = 10;
		Wisdom = 6;
		Sneak = 11;
		Luck = 9;
		Spirit = 13;
		
		MagicEnergy = Intellect + Wisdom * Spirit + MagicPower;
		MagicSpeed = MagicPower * Intellect * Wisdom * (Luck/3);
		AttackSpeed = 1;
		CritChance = 1;
		CritMulitiplier = 1;
		SleightOfHand = 1;
		//room for more stats here
		
	}
}