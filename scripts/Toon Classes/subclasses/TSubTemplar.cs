using UnityEngine
using system.Collections;

public class BaseTSubclassHolyTemplar : BaseToonClasses{
	
	public BaseTemplarClassMod(){
		ToonName = "The Templar";
		ToonDetails = "A holy fighter of the Knight of the first order of Dionya. Only the purest of all th strongest physically and willfully shall be anointed in her lady's holy grace to help those more unfortunate in Mares Universe";
		Health = 25;
		Stamina = 15;
		Endurance = 13;
		Strenghth = 16;
		Agility = 8;
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