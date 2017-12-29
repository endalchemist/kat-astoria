using UnityEngine;
using System.Collections;

public class BaseLoot {

	private string lootName;
	private string lootDetails;
	private int lootID;
	public enum LootTypes{
		EQUIPMENT,
		WEAPON,
		POTION,
		CRYSTAL,
		CHEST
	}
	private LootTypes lootType;

	public string LootName{
		get{return lootName;}
		set{lootName = value;}
	}
	public string LootDetails{
		get{return lootDetails;}
		set{lootDetails = value;}
	}
	public int LootName{
		get{return lootName;}
		set{lootName = value;}
	}
	public LootTypes LootType{
		get{return lootType;}
		set{lootType = value;}
	}
}
