using UnityEngine
using System.Collections;

public class BaseWSubclassDingus : BaseToonClasses{
	
	public BaseDingusMod(){
		ToonName = "Dingus";
		ToonDetails = "Neat way of gathering. all around worst and most things possible. Perhaps their uniqueness originates from another realm. More often than not most will tell you their sheer for of will and luck power them through a life much more difficult than the rest";
		Health = 5;
		Stamina = 5;
		Endurance = 5;
		Strength = 5;
		Agility = 14;
		MagicPower = 5;
		Intellect = 5;
		Wisdom = 5;
		Luck = 20;
		Spirit = 20;
		
		MagicEnergy = Intellect + Wisdom * Spirit + MagicPower;
		MagicSpeed = MagicPower * Intellect * Wisdom * (Luck/3);
		AttackSpeed = .3 *;
		CritChance = 1;
		CritMulitiplier = 1;
		SleightOfHand = 1;
		Sneak = 5;
		//room for more stats here
		
	}
}