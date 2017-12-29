using UnityEngine
using System.Collections;

public class BaseTSubClassDuskKnight : BaseToonClasses{
	
	public BaseDuskKnightMod(){
		ToonName = "Dusk Knight";
		ToonDetails = "The ultimate knight of shadows and fear serving only the realm Abyseius All Knowing Lord Raasien. the most unholy of all criminals and villains fear even the mighty Dusk Knights";
		Health = 27;
		Stamina = 13;
		Endurance = 13;
		Strength = 15;
		Agility = 14;
		MagicPower = 2;
		Intellect = 12;
		Wisdom = 6;
		Sneak = 8;
		Luck = 12;
		Spirit = 17;
		
		MagicEnergy = Intellect + Wisdom * Spirit + MagicPower;
		MagicSpeed = MagicPower * Intellect * Wisdom * (Luck/3);
		AttackSpeed = 1;
		CritChance = 1;
		CritMulitiplier = 1;
		SleightOfHand = 1;
		
		//room for more stats here
		
	}
}