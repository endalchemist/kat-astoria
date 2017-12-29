using UnityEngine;
using System.Collections;

public class BaseStatedLoot : BaseLoot {
	
	private int health;
	private int stamina;
	private int endurance;
	private int	strength;
	private int magicPower;
	private int intellect;
	private int wisdom;
	private int agility;
	private int	luck;
    private int spirit;
	
	//minor stats
	
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
	
	

}