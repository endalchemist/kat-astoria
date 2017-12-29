using UnityEngine
using system.Collections;

public class BasePlayer {

	private string playerName;
	private int playerLevel;
	private BaseToonClass playerClass;
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

	public string PlayerName{
		get{return playerName;}
		set{playerName = value;}
	}
	public int PlayerLevel{
		get{return playerLevel;}
		set{playerLevel = value;}
	}
	public BaseToonClass PlayerClass{
		get{return playerClass;}
		set{playerClass = value;}
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
	public int Strength{
		get{return strength;}
		set{strength = value;}
	}
	public int MagicPower{
		get{return magicPower;}
		set{magicPower = value;}
	}
	public int Intellect{
		get{return intellect;}
		set{intellect = value;}
	}
	public int Wisdom{
		get{return wisdom;}
		set{wisdom = value;}
	}
	public int Agility{
		get{return agility;}
		set{agility = value;}
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
