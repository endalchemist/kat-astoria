using System.Collections;
using UnityEngine;

public class CreateLevelOneItem : MonoBehaviour {

    private BaseWeapon newWeapon;
    private string[] weaponNames = new string[27] {"Greatsword","Greataxe","Maul","Axe","Halberd","Polearm","Short Sword","Long Sword","Bow","Crossbow","Gun","Dagger","Fists","Mace","Staff","Quarterstaff","Wand","Tome","Hoe","Crafters Maul","Crafters Hammer", "Woodsmans Axe", "Shovel","Pickaxe","Tinkers Tools", "Shield" };
	

    public void CreateWeapon(){
		newWeapon = new BaseWeapon();
        newWeapon.LootName = weaponNames( Random.Range(0, 26));
		if(newWeapon.LootName = "Greatsword"){
			newWeapon.LootDetails = "This is a Greatsword of fine craftsmanship.";
			newWeapon.WeaponTypes = BaseWeapon.WeaponTypes.GREATSWORD;
			newWeapon.Strength = Random.Range(15,31);
			newWeapon.Endurance = Random.Range(13,20);
			newWeapon.Stamina = Random.Range(6,10);
			newWeapon.Agility = Random.Random(15,24);
			newWeapon.Health = 10 + newWeapon.Stamina;
			newWeapon.MagicPower = Random.Random(1,2);
			newWeapon.Intellect = Random.Random(1,2);
			newWeapon.Wisdom = Random.Random(1,2);
			newWeapon.Luck = Random.Random(5,6);
			newWeapon.Spirit = Random.Random(1,9);
			
		}
 		else if (newWeapon.LootName = "Greataxe"){
			newWeapon.LootDetails = "This is a Greataxe of fine craftsmanship.";
			newWeapon.WeaponTypes = BaseWeapon.WeaponTypes.GREATAXE;
			newWeapon.Strength = Random.Range(12,22);
			newWeapon.Endurance = Random.Range(13,27);
			newWeapon.Stamina = Random.Range(13,18);
			newWeapon.Agility = Random.Random(15,24);
			newWeapon.Health = 10 + newWeapon.Stamina;
			newWeapon.MagicPower = Random.Random(1,2);
			newWeapon.Intellect = Random.Random(1,2);
			newWeapon.Wisdom = Random.Random(1,2);
			newWeapon.Luck = Random.Random(5,6);
			newWeapon.Spirit = Random.Random(1,9);
			
		}
		else if (newWeapon.LootName = "Maul"){
			newWeapon.LootDetails = "This is a Maul of fine craftsmanship.";
			newWeapon.WeaponTypes = BaseWeapon.WeaponTypes.MAUL;
			newWeapon.Strength = Random.Range(12,20);
			newWeapon.Endurance = Random.Range(13,27);
			newWeapon.Stamina = Random.Range(15,125);
			newWeapon.Agility = Random.Random(15,24);
			newWeapon.Health = 10 + newWeapon.Stamina;
			newWeapon.MagicPower = Random.Random(1,2);
			newWeapon.Intellect = Random.Random(1,2);
			newWeapon.Wisdom = Random.Random(1,2);
			newWeapon.Luck = Random.Random(5,6);
			newWeapon.Spirit = Random.Random(1,9);
			
		}
		else if (newWeapon.LootName = "Axe"){
			newWeapon.LootDetails = "This is a Axe of fine craftsmanship.";
			newWeapon.WeaponTypes = BaseWeapon.WeaponTypes.AXE;
			newWeapon.Strength = Random.Range(12,20);
			newWeapon.Endurance = Random.Range(13,25);
			newWeapon.Stamina = Random.Range(10,27);
			newWeapon.Agility = Random.Random(15,24);
			newWeapon.Health = 10 + newWeapon.Stamina;
			newWeapon.MagicPower = Random.Random(1,2);
			newWeapon.Intellect = Random.Random(1,2);
			newWeapon.Wisdom = Random.Random(1,2);
			newWeapon.Luck = Random.Random(5,6);
			newWeapon.Spirit = Random.Random(1,9);
			
		}
		else if (newWeapon.LootName = "Halberd"){
			newWeapon.LootDetails = "This is a Halberd of fine craftsmanship.";
			newWeapon.WeaponTypes = BaseWeapon.WeaponTypes.HALBERD;
			newWeapon.Strength = Random.Range(15,22);
			newWeapon.Endurance = Random.Range(17,27);
			newWeapon.Stamina = Random.Range(13,18);
			newWeapon.Agility = Random.Random(15,24);
			newWeapon.Health = 10 + newWeapon.Stamina;
			newWeapon.MagicPower = Random.Random(1,2);
			newWeapon.Intellect = Random.Random(1,2);
			newWeapon.Wisdom = Random.Random(1,2);
			newWeapon.Luck = Random.Random(5,6);
			newWeapon.Spirit = Random.Random(1,9);
			
		}
		else if (newWeapon.LootName = "Polearm"){
			newWeapon.LootDetails = "This is a Polearm of fine craftsmanship.";
			newWeapon.WeaponTypes = BaseWeapon.WeaponTypes.POLEARM;
			newWeapon.Strength = Random.Range(15,22);
			newWeapon.Endurance = Random.Range(17,27);
			newWeapon.Stamina = Random.Range(14,16);
			newWeapon.Agility = Random.Random(15,24);
			newWeapon.Health = 10 + newWeapon.Stamina;
			newWeapon.MagicPower = Random.Random(1,2);
			newWeapon.Intellect = Random.Random(1,2);
			newWeapon.Wisdom = Random.Random(1,2);
			newWeapon.Luck = Random.Random(5,6);
			newWeapon.Spirit = Random.Random(1,9);
			
		}
		else if (newWeapon.LootName = "Short Sword"){
			newWeapon.LootDetails = "This is a Short Sword of fine craftsmanship.";
			newWeapon.WeaponTypes = BaseWeapon.WeaponTypes.SHORTSWORD;
			newWeapon.Strength = Random.Range(7,12);
			newWeapon.Endurance = Random.Range(13,17);
			newWeapon.Stamina = Random.Range(17,28);
			newWeapon.Agility = Random.Random(15,24);
			newWeapon.Health = 10 + newWeapon.Stamina;
			newWeapon.MagicPower = Random.Random(1,2);
			newWeapon.Intellect = Random.Random(1,2);
			newWeapon.Wisdom = Random.Random(1,2);
			newWeapon.Luck = Random.Random(5,6);
			newWeapon.Spirit = Random.Random(1,9);
			
		}
		else if (newWeapon.LootName = "Long Sword"){
			newWeapon.LootDetails = "This is a Long Sword of fine craftsmanship.";
			newWeapon.WeaponTypes = BaseWeapon.WeaponTypes.LONGSWORD;
			newWeapon.Strength = Random.Range(10,16);
			newWeapon.Endurance = Random.Range(10,20);
			newWeapon.Stamina = Random.Range(19,28);
			newWeapon.Agility = Random.Random(15,24);
			newWeapon.Health = 10 + newWeapon.Stamina;
			newWeapon.MagicPower = Random.Random(1,2);
			newWeapon.Intellect = Random.Random(1,2);
			newWeapon.Wisdom = Random.Random(1,2);
			newWeapon.Luck = Random.Random(5,6);
			newWeapon.Spirit = Random.Random(1,9);
			
		}
		else if (newWeapon.LootName = "Bow"){
			newWeapon.LootDetails = "This is a Bow of fine craftsmanship.";
			newWeapon.WeaponTypes = BaseWeapon.WeaponTypes.BOW;
			newWeapon.Strength = Random.Range(12,22);
			newWeapon.Endurance = Random.Range(13,27);
			newWeapon.Stamina = Random.Range(20,30);
			newWeapon.Agility = Random.Random(15,24);
			newWeapon.Health = 10 + newWeapon.Stamina;
			newWeapon.MagicPower = Random.Random(1,2);
			newWeapon.Intellect = Random.Random(1,2);
			newWeapon.Wisdom = Random.Random(1,2);
			newWeapon.Luck = Random.Random(5,6);
			newWeapon.Spirit = Random.Random(1,9);
			
		}
		else if (newWeapon.LootName = "Crossbow"){
			newWeapon.LootDetails = "This is a Crossbow of fine craftsmanship.";
			newWeapon.WeaponTypes = BaseWeapon.WeaponTypes.CROSSBOW;
			newWeapon.Strength = Random.Range(7,14);
			newWeapon.Endurance = Random.Range(6,15);
			newWeapon.Stamina = Random.Range(16,30);
			newWeapon.Agility = Random.Random(15,24);
			newWeapon.Health = 10 + newWeapon.Stamina;
			newWeapon.MagicPower = Random.Random(1,2);
			newWeapon.Intellect = Random.Random(1,2);
			newWeapon.Wisdom = Random.Random(1,2);
			newWeapon.Luck = Random.Random(5,6);
			newWeapon.Spirit = Random.Random(1,9);
			
		}
		else if (newWeapon.LootName = "Gun"){
			newWeapon.LootDetails = "This is a Gun of fine craftsmanship.";
			newWeapon.WeaponTypes = BaseWeapon.WeaponTypes.GUN;
			newWeapon.Strength = Random.Range(6,15);
			newWeapon.Endurance = Random.Range(6,15);
			newWeapon.Stamina = Random.Range(16,30);
			newWeapon.Agility = Random.Random(17,27);
			newWeapon.MagicPower = Random.Random(1,2);
			newWeapon.Intellect = Random.Random(1,2);
			newWeapon.Wisdom = Random.Random(1,2);
			newWeapon.Luck = Random.Random(5,6);
			newWeapon.Spirit = Random.Random(1,9);
			
		}
		else if (newWeapon.LootName = "Fists"){
			newWeapon.LootDetails = "This is a Fists of fine craftsmanship.";
			newWeapon.WeaponTypes = BaseWeapon.WeaponTypes.FISTS;
			newWeapon.Strength = Random.Range(12,22);
			newWeapon.Endurance = Random.Range(13,27);
			newWeapon.Stamina = Random.Range(13,18);
			newWeapon.Agility = Random.Random(15,24);
			newWeapon.Health = 10 + newWeapon.Stamina;
			newWeapon.MagicPower = Random.Random(1,2);
			newWeapon.Intellect = Random.Random(1,2);
			newWeapon.Wisdom = Random.Random(1,2);
			newWeapon.Luck = Random.Random(5,6);
			newWeapon.Spirit = Random.Random(1,9);
			
		}
		else if (newWeapon.LootName = "Dagger"){
			newWeapon.LootDetails = "This is a Dagger of fine craftsmanship.";
			newWeapon.WeaponTypes = BaseWeapon.WeaponTypes.DAGGER;
			newWeapon.Strength = Random.Range(12,22);
			newWeapon.Endurance = Random.Range(13,27);
			newWeapon.Stamina = Random.Range(13,18);
			newWeapon.Agility = Random.Random(15,24);
			newWeapon.Health = 10 + newWeapon.Stamina;
			newWeapon.MagicPower = Random.Random(1,2);
			newWeapon.Intellect = Random.Random(1,2);
			newWeapon.Wisdom = Random.Random(1,2);
			newWeapon.Luck = Random.Random(5,6);
			newWeapon.Spirit = Random.Random(1,9);
			
			
		}
		else if (newWeapon.LootName = "Mace"){
			newWeapon.LootDetails = "This is a Mace of fine craftsmanship.";
			newWeapon.WeaponTypes = BaseWeapon.WeaponTypes.MACE;
			newWeapon.Strength = Random.Range(12,22);
			newWeapon.Endurance = Random.Range(13,27);
			newWeapon.Stamina = Random.Range(13,18);
			newWeapon.Agility = Random.Random(15,24);
			newWeapon.Health = 10 + newWeapon.Stamina;
			newWeapon.MagicPower = Random.Random(1,2);
			newWeapon.Intellect = Random.Random(1,2);
			newWeapon.Wisdom = Random.Random(1,2);
			newWeapon.Luck = Random.Random(5,6);
			newWeapon.Spirit = Random.Random(1,9);
			
		}
		else if (newWeapon.LootName = "Staff"){
			newWeapon.LootDetails = "This is a Staff of fine craftsmanship.";
			newWeapon.WeaponTypes = BaseWeapon.WeaponTypes.STAFF;
			newWeapon.Strength = Random.Range(12,22);
			newWeapon.Endurance = Random.Range(13,27);
			newWeapon.Stamina = Random.Range(13,18);
			newWeapon.Agility = Random.Random(15,24);
			newWeapon.Health = 10 + newWeapon.Stamina;
			newWeapon.MagicPower = Random.Random(1,2);
			newWeapon.Intellect = Random.Random(1,2);
			newWeapon.Wisdom = Random.Random(1,2);
			newWeapon.Luck = Random.Random(5,6);
			newWeapon.Spirit = Random.Random(1,9);
			
		}
		else if (newWeapon.LootName = "Quarterstaff"){
			newWeapon.LootDetails = "This is a Quarterstaff of fine craftsmanship.";
			newWeapon.WeaponTypes = BaseWeapon.WeaponTypes.QUARTERSTAFF;
			newWeapon.Strength = Random.Range(12,22);
			newWeapon.Endurance = Random.Range(13,27);
			newWeapon.Stamina = Random.Range(13,18);
			newWeapon.Agility = Random.Random(15,24);
			newWeapon.Health = 10 + newWeapon.Stamina;
			newWeapon.MagicPower = Random.Random(1,2);
			newWeapon.Intellect = Random.Random(1,2);
			newWeapon.Wisdom = Random.Random(1,2);
			newWeapon.Luck = Random.Random(5,6);
			newWeapon.Spirit = Random.Random(1,9);
			
		}
		else if (newWeapon.LootName = "Wand"){
			newWeapon.LootDetails = "This is a Wand of fine craftsmanship.";
			newWeapon.WeaponTypes = BaseWeapon.WeaponTypes.WAND;
			newWeapon.Strength = Random.Range(12,22);
			newWeapon.Endurance = Random.Range(13,27);
			newWeapon.Stamina = Random.Range(13,18);
			newWeapon.Agility = Random.Random(15,24);
			newWeapon.Health = 10 + newWeapon.Stamina;
			newWeapon.MagicPower = Random.Random(1,2);
			newWeapon.Intellect = Random.Random(1,2);
			newWeapon.Wisdom = Random.Random(1,2);
			newWeapon.Luck = Random.Random(5,6);
			newWeapon.Spirit = Random.Random(1,9);
			
		}
		else if (newWeapon.LootName = "Tome"){
			newWeapon.LootDetails = "This is a Tome of fine craftsmanship.";
			newWeapon.WeaponTypes = BaseWeapon.WeaponTypes.TOME;
			newWeapon.Strength = Random.Range(12,22);
			newWeapon.Endurance = Random.Range(13,27);
			newWeapon.Stamina = Random.Range(13,18);
			newWeapon.Agility = Random.Random(15,24);
			newWeapon.Health = 10 + newWeapon.Stamina;
			newWeapon.MagicPower = Random.Random(1,2);
			newWeapon.Intellect = Random.Random(1,2);
			newWeapon.Wisdom = Random.Random(1,2);
			newWeapon.Luck = Random.Random(5,6);
			newWeapon.Spirit = Random.Random(1,9);
			
		}
		else if (newWeapon.LootName = "Hoe"){
			newWeapon.LootDetails = "This is a Hoe of fine craftsmanship.";
			newWeapon.WeaponTypes = BaseWeapon.WeaponTypes.HOE;
			newWeapon.Strength = Random.Range(12,22);
			newWeapon.Endurance = Random.Range(13,27);
			newWeapon.Stamina = Random.Range(13,18);
			newWeapon.Agility = Random.Random(15,24);
			newWeapon.Health = 10 + newWeapon.Stamina;
			newWeapon.MagicPower = Random.Random(1,2);
			newWeapon.Intellect = Random.Random(1,2);
			newWeapon.Wisdom = Random.Random(1,2);
			newWeapon.Luck = Random.Random(5,6);
			newWeapon.Spirit = Random.Random(1,9);
			
		}
		else if (newWeapon.LootName = "Crafters Maul"){
			newWeapon.LootDetails = "This is a Crafters Maul of fine craftsmanship.";
			newWeapon.WeaponTypes = BaseWeapon.WeaponTypes.CRAFTERSMAUL;
			newWeapon.Strength = Random.Range(12,22);
			newWeapon.Endurance = Random.Range(13,27);
			newWeapon.Stamina = Random.Range(13,18);
			newWeapon.Agility = Random.Random(15,24);
			newWeapon.Health = 10 + newWeapon.Stamina;
			newWeapon.MagicPower = Random.Random(1,2);
			newWeapon.Intellect = Random.Random(1,2);
			newWeapon.Wisdom = Random.Random(1,2);
			newWeapon.Luck = Random.Random(5,6);
			newWeapon.Spirit = Random.Random(1,9);
			
		}
		else if (newWeapon.LootName = "Crafters Hammer"){
			newWeapon.LootDetails = "This is a Crafters Hammer of fine craftsmanship.";
			newWeapon.WeaponTypes = BaseWeapon.WeaponTypes.CRAFTERSHAMMER;
			newWeapon.Strength = Random.Range(12,22);
			newWeapon.Endurance = Random.Range(13,27);
			newWeapon.Stamina = Random.Range(13,18);
			newWeapon.Agility = Random.Random(15,24);
			newWeapon.Health = 10 + newWeapon.Stamina;
			newWeapon.MagicPower = Random.Random(1,2);
			newWeapon.Intellect = Random.Random(1,2);
			newWeapon.Wisdom = Random.Random(1,2);
			newWeapon.Luck = Random.Random(5,6);
			newWeapon.Spirit = Random.Random(1,9);
			
		}
		else if (newWeapon.LootName = "Woodsmans Axe"){
			newWeapon.LootDetails = "This is a Woodsmans Axe of fine craftsmanship.";
			newWeapon.WeaponTypes = BaseWeapon.WeaponTypes.WOODSMANSAXE;
			newWeapon.Strength = Random.Range(12,22);
			newWeapon.Endurance = Random.Range(13,27);
			newWeapon.Stamina = Random.Range(13,18);
			newWeapon.Agility = Random.Random(15,24);
			newWeapon.Health = 10 + newWeapon.Stamina;
			newWeapon.MagicPower = Random.Random(1,2);
			newWeapon.Intellect = Random.Random(1,2);
			newWeapon.Wisdom = Random.Random(1,2);
			newWeapon.Luck = Random.Random(5,6);
			newWeapon.Spirit = Random.Random(1,9);
			
		}
		else if (newWeapon.LootName = "Shovel"){
			newWeapon.LootDetails = "This is a Shovel of fine craftsmanship.";
			newWeapon.WeaponTypes = BaseWeapon.WeaponTypes.SHOVEL;
			newWeapon.Strength = Random.Range(12,22);
			newWeapon.Endurance = Random.Range(13,27);
			newWeapon.Stamina = Random.Range(13,18);
			newWeapon.Agility = Random.Random(15,24);
			newWeapon.Health = 10 + newWeapon.Stamina;
			newWeapon.MagicPower = Random.Random(1,2);
			newWeapon.Intellect = Random.Random(1,2);
			newWeapon.Wisdom = Random.Random(1,2);
			newWeapon.Luck = Random.Random(5,6);
			newWeapon.Spirit = Random.Random(1,9);
			
		}
		else if (newWeapon.LootName = "Pickaxe"){
			newWeapon.LootDetails = "This is a Pickaxe of fine craftsmanship.";
			newWeapon.WeaponTypes = BaseWeapon.WeaponTypes.PICKAXE;
			newWeapon.Strength = Random.Range(12,22);
			newWeapon.Endurance = Random.Range(13,27);
			newWeapon.Stamina = Random.Range(13,18);
			newWeapon.Agility = Random.Random(15,24);
			newWeapon.Health = 10 + newWeapon.Stamina;
			newWeapon.MagicPower = Random.Random(1,2);
			newWeapon.Intellect = Random.Random(1,2);
			newWeapon.Wisdom = Random.Random(1,2);
			newWeapon.Luck = Random.Random(5,6);
			newWeapon.Spirit = Random.Random(1,9);
			
		}
		else if (newWeapon.LootName = "Tinkers Tools"){
			newWeapon.LootDetails = "This is a Tinkers Tools of fine craftsmanship.";
			newWeapon.WeaponTypes = BaseWeapon.WeaponTypes.Tinkers Tools;
			newWeapon.Strength = Random.Range(12,22);
			newWeapon.Endurance = Random.Range(13,27);
			newWeapon.Stamina = Random.Range(13,18);
			newWeapon.Agility = Random.Random(15,24);
			newWeapon.Health = 10 + newWeapon.Stamina;
			newWeapon.MagicPower = Random.Random(1,2);
			newWeapon.Intellect = Random.Random(1,2);
			newWeapon.Wisdom = Random.Random(1,2);
			newWeapon.Luck = Random.Random(5,6);
			newWeapon.Spirit = Random.Random(1,9);
			
		}
		else if (newWeapon.LootName = "Shield"){
			newWeapon.LootDetails = "This is a Shield of fine craftsmanship.";
			newWeapon.WeaponTypes = BaseWeapon.WeaponTypes.SHIELD;
			newWeapon.Strength = Random.Range(12,22);
			newWeapon.Endurance = Random.Range(13,27);
			newWeapon.Stamina = Random.Range(13,18);
			newWeapon.Agility = Random.Random(15,24);
			newWeapon.Health = 10 + newWeapon.Stamina;
			newWeapon.MagicPower = Random.Random(1,2);
			newWeapon.Intellect = Random.Random(1,2);
			newWeapon.Wisdom = Random.Random(1,2);
			newWeapon.Luck = Random.Random(5,6);
			newWeapon.Spirit = Random.Random(1,9);
			
		}
		
    }

}
