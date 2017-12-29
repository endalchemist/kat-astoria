using UnityEngine
using System.Collections;

public class BaseMSubclassBlueMage : BaseToonClasses{
	
	public BaseBlueMage(){
		ToonName = "Blue Mages";
		ToonDetails = "Studied powerful mages adept at casting with rare magics imbued through reciting ancient languages practiced by ancestors of the more modern Lighkin of Serendipity the most magical realm. Dont be fooled however as many Lighkin no longer practice magical arts after their race was dwindled to a mere few hundred or so after an unplanned magical explosion made there realms males sterile. The Lighkin live on as a species however due to 17 male members of them being in other realms at the the time. Some even half breeds. Blue mages are generally not liked in the realm of Serendipity for they are all blamed with sterilliaztion the elder Lighkin of the lands. Blue mages tend to excel in altering any playing field to their advantage. Many spells have been uncovered from the ancient Lighkin and taught by the Blue Mages of Thondar. Tensions between Astonia and Serendipity have never been higher but the Astonians High Consulate won't interfere with the practices of the residents in Thondar. Use your magic to voice your opinion in the realm or simply to make your life easier.";
		Health = 10;
		Stamina = 11;
		Endurance = 8;
		Strength = 2;
		Agility = 12;
		MagicPower = 17;
		Intellect = 15;
		Wisdom = 16;
		Sneak = 7;
		Luck = 16;
		Spirit = 14;
		
		HitP = Health + Strength + (Endurance + Stamina * .34);
		MagicEnergy = Intellect + Wisdom * Spirit + MagicPower;
		MagicSpeed = MagicPower * Intellect * Wisdom * (Luck/3);
		AttackSpeed = 1;
		CritChance = 1;
		CritMulitiplier = 1;
		SleightOfHand = 1;
		//room for more stats here
		
	}
}