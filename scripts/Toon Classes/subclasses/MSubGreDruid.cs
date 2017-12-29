using UnityEngine
using System.Collections;

public class BaseMsubclassGreDruid : BaseToonClasses{
	
	public BaseGreDruidMod(){
		ToonName = "Gre Druid";
		ToonDetails = "Druidy Details";
		Health = 25;
		Stamina = 15;
		Endurance = 13;
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