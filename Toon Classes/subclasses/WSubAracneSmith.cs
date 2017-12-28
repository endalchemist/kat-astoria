using UnityEngine
using System.Collections;

public class BaseWSubClassArcaneSmith : BaseToonClasses{
	
	public BaseArcaneSmithMod(){
		ToonName = "Arcane Smith";
		ToonDetails = "Craftspeoople trained directly by master magical smiths of the small yet seemingly large city known to many townspeople in the realm of Astonia as the infinite clock city. Its true name however, is only accessible to few rare to find formerly blue mages never to be taken lightly as they are exclusively they most powerful who have ascended to control the very flow of time becoming the crystalline gatekeepers. that drawing time magics from the little explored realm of serenity,the place most holy beings get their powers. You and your fellow crafters have been known to make the finest of wares buildings and shops. Seemingly your keenly trained eyes have much ease in finding the most valued resources of all realms combined.. undoubtedly the stingiest hearts of all the known races of the realms as well. Very poor fighting capabilities as well. Usually prefer quiet passive lives often not interfering with the monstrous beings scattered through the many realms. Few tactful tradespeople and tinkers about have had also had tales often of tricking many almighty beasts";
		Health = 5;
		Stamina = 10;
		Endurance = 12;
		Strength = 10;
		Agility = 10;
		MagicPower = 2;
		Intellect = 20;
		Wisdom = 6;
		Sneak = 11;
		Luck = 13;
		Spirit = 18;
		
		MagicEnergy = Intellect + Wisdom * Spirit + MagicPower;
		MagicSpeed = MagicPower * Intellect * Wisdom * (Luck/3);
		AttackSpeed = 1;
		CritChance = 1;
		CritMulitiplier = 1;
		SleightOfHand = 1;
		//room for more stats here
		
	}
}