using UnityEngine;
using System.Collections;

public class BaseToonClass (

	private string toonName;
	private string toonDetails;
	//major stats
	private int health;
	private int stamina;
	private int endurance;
	private int magicPower;
	private int	strength;
	private int intellect;
	private int wisdom;
	private int	luck;
    private int spirit;
	//minor stats
	private int sneak;
	private int magicEnergy;
	private int magicSpeed;
	private float attackSpeed;
	private float critPercentChance;
	private int critMultiplier;
	private int sleightOfHand;
	private int thieving;

	public string ToonName{
		get{return toonName;}
		set{toonName = value;}
	}
	public string ToonDetails{
		get{return toonDetails;}
		set{toonDetails = value;}
	}
	public int Health{
		get{return health;}
		set{health = value;}
	}
	public int Stamina{
		get{return stamina;}
		set{stamina = value;}
	}
	public int Endurance{
		get{return endurance;}
		set{endurance = value;}
	}
	public int MagicPower{
		get{return magicPower;}
		set{magicPower = value;}
	}
	public int Strength{
		get{return strength;}
		set{strength = value;}
	}
	public int Intellect{
		get{return intellect;}
		set{intellect = value;}
	}
	public int Wisdom{
		get{return wisdom;}
		set{wisdom = value;}
	}
	public int Sneak{
		get{return sneak;}
		set{sneak = value;}
	}
	public int Luck{
		get{return luck;}
		set{luck = value;}
	}
	public int Spirit{
		get{return spirit;}
		set{spirit = value;}
	}
	public int MagicEnergy{
		get{return magicEnergy;}
		set{magicEnergy = value;}
	}
	public int MagicSpeed{
		get{return magicSpeed;}
		set{magicSpeed = value;}
	}
	public int AttackSpeed{
		get{return attackSpeed;}
		set{attackSpeed = value;}
	}
	public int CritPercentChance{
		get{return critPercentChance;}
		set{critPercentChance = value;}
	}
	public int CritMultiplier{
		get{return critMultiplier;}
		set{critMultiplier = value;}
	}
	public int SleightOfHand{
		get{return sleightOfHand;}
		set{sleightOfHand = value;}
	}
	public int Thieving{
		get{return thieving;}
		set{thieving = value;}
	}



)
