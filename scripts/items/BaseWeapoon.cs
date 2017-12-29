using UnityEngine;
using System.Collections;

public class BaseWeapon : BaseStatedLoot {
	
	public enum WeaponTypes{
		LONGSWORD,
		STAFF,
		WAND,
		DAGGER,
		GREATSWORD,
		BOW,
		SHIELD, 
		GUN,
		POLEARM,
		QUARTERSTAFF,
		MAUL,
		TOME,
		HALBERD,
		SHORTSWORD,
		CROSSBOW,
		FISTS,
		MACE,
		HOE,
		CRAFTERSMAUL,
		CRAFTERSHAMMER,
		WOODSMANSAXE,
		PICKAXE,
		TINKERTOOLS,
		SHOVEL,
		AXE,
		GREATAXE
	}
	private WeaponTypes weaponType;
	private int enchantmentID;
	
	public WeaponTypes WeaponType{
		get{return weaponType;}
		set{weaponType=value;}
	}
	public int EnchantmentID{
		get{return enchantmentID;}
		set{enchantmentID=value;}
	}		
}