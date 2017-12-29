using System.Collections;
using UnityEngine;

public class CreateLevelThirteenArmor : MonoBehaviour {

    private BaseArmor newArmor;
    private string[] weaponNames = new string[12] {"Light Metal","Cloth","Light Leather","Heavy Woven Cloth","Padded Leather","Chainmail","Metal","Plate","Heavy Padded Leather","Heavy Plate","Heavy Padded Cloth"};
	

    public void CreateArmor(){
		newArmor = new BaseArmor();
        newArmor.LootName = weaponNames(Random.Range(0, 11));
		if(newArmor.LootName = "Light Metal"){
			newArmor.LootDetails = "This is a Light Metal of fine craftsmanship.";
			newArmor.EquipmentTypes = BaseArmor.EquipmentTypes.LIGHTMETAL;
			newArmor.Strength = Random.Range(15,31);
			newArmor.Endurance = Random.Range(13,20);
			newArmor.Stamina = Random.Range(6,10);
			newArmor.Agility = Random.Range(15,24);
			newArmor.Health = 10 + newArmor.Stamina;
			newArmor.MagicPower = Random.Range(1,2);
			newArmor.Intellect = Random.Range(1,2);
			newArmor.Wisdom = Random.Range(1,2);
			newArmor.Luck = Random.Range(5,6);
			newArmor.Spirit = Random.Range(1,9);
			
		}
 		else if (newArmor.LootName = "Cloth"){
			newArmor.LootDetails = "This is a Cloth of fine craftsmanship.";
			newArmor.EquipmentTypes = BaseArmor.EquipmentTypes.CLOTH;
			newArmor.Strength = Random.Range(12,22);
			newArmor.Endurance = Random.Range(13,27);
			newArmor.Stamina = Random.Range(13,18);
			newArmor.Agility = Random.Range(15,24);
			newArmor.Health = 10 + newArmor.Stamina;
			newArmor.MagicPower = Random.Range(1,2);
			newArmor.Intellect = Random.Range(1,2);
			newArmor.Wisdom = Random.Range(1,2);
			newArmor.Luck = Random.Range(5,6);
			newArmor.Spirit = Random.Range(1,9);
			
		}
		else if (newArmor.LootName = "Light Leather"){
			newArmor.LootDetails = "This is a Light Leather of fine craftsmanship.";
			newArmor.EquipmentTypes = BaseArmor.EquipmentTypes.LIGHTMETAL;
			newArmor.Strength = Random.Range(12,20);
			newArmor.Endurance = Random.Range(13,27);
			newArmor.Stamina = Random.Range(15,125);
			newArmor.Agility = Random.Range(15,24);
			newArmor.Health = 10 + newArmor.Stamina;
			newArmor.MagicPower = Random.Range(1,2);
			newArmor.Intellect = Random.Range(1,2);
			newArmor.Wisdom = Random.Range(1,2);
			newArmor.Luck = Random.Range(5,6);
			newArmor.Spirit = Random.Range(1,9);
			
		}
		else if (newArmor.LootName = "Heavy Woven Cloth"){
			newArmor.LootDetails = "This is a Heavy Woven Cloth of fine craftsmanship.";
			newArmor.EquipmentTypes = BaseArmor.EquipmentTypes.HEAVYWOVENCLOTH;
			newArmor.Strength = Random.Range(12,20);
			newArmor.Endurance = Random.Range(13,25);
			newArmor.Stamina = Random.Range(10,27);
			newArmor.Agility = Random.Range(15,24);
			newArmor.Health = 10 + newArmor.Stamina;
			newArmor.MagicPower = Random.Range(1,2);
			newArmor.Intellect = Random.Range(1,2);
			newArmor.Wisdom = Random.Range(1,2);
			newArmor.Luck = Random.Range(5,6);
			newArmor.Spirit = Random.Range(1,9);
			
		}
		else if (newArmor.LootName = "Padded Leather"){
			newArmor.LootDetails = "This is a Padded Leather of fine craftsmanship.";
			newArmor.EquipmentTypes = BaseArmor.EquipmentTypes.PADDEDLEATHER;
			newArmor.Strength = Random.Range(15,22);
			newArmor.Endurance = Random.Range(17,27);
			newArmor.Stamina = Random.Range(13,18);
			newArmor.Agility = Random.Range(15,24);
			newArmor.Health = 10 + newArmor.Stamina;
			newArmor.MagicPower = Random.Range(1,2);
			newArmor.Intellect = Random.Range(1,2);
			newArmor.Wisdom = Random.Range(1,2);
			newArmor.Luck = Random.Range(5,6);
			newArmor.Spirit = Random.Range(1,9);
			
		}
		else if (newArmor.LootName = "Chainmail"){
			newArmor.LootDetails = "This is a Chainmail of fine craftsmanship.";
			newArmor.EquipmentTypes = BaseArmor.EquipmentTypes.CHAINMAIL;
			newArmor.Strength = Random.Range(15,22);
			newArmor.Endurance = Random.Range(17,27);
			newArmor.Stamina = Random.Range(14,16);
			newArmor.Agility = Random.Range(15,24);
			newArmor.Health = 10 + newArmor.Stamina;
			newArmor.MagicPower = Random.Range(1,2);
			newArmor.Intellect = Random.Range(1,2);
			newArmor.Wisdom = Random.Range(1,2);
			newArmor.Luck = Random.Range(5,6);
			newArmor.Spirit = Random.Range(1,9);
			
		}
		else if (newArmor.LootName = "Metal"){
			newArmor.LootDetails = "This is a Metal of fine craftsmanship.";
			newArmor.EquipmentTypes = BaseArmor.EquipmentTypes.METAL;
			newArmor.Strength = Random.Range(7,12);
			newArmor.Endurance = Random.Range(13,17);
			newArmor.Stamina = Random.Range(17,28);
			newArmor.Agility = Random.Range(15,24);
			newArmor.Health = 10 + newArmor.Stamina;
			newArmor.MagicPower = Random.Range(1,2);
			newArmor.Intellect = Random.Range(1,2);
			newArmor.Wisdom = Random.Range(1,2);
			newArmor.Luck = Random.Range(5,6);
			newArmor.Spirit = Random.Range(1,9);
			
		}
		else if (newArmor.LootName = "Plate"){
			newArmor.LootDetails = "This is a Plate of fine craftsmanship.";
			newArmor.EquipmentTypes = BaseArmor.EquipmentTypes.PLATE;
			newArmor.Strength = Random.Range(10,16);
			newArmor.Endurance = Random.Range(10,20);
			newArmor.Stamina = Random.Range(19,28);
			newArmor.Agility = Random.Range(15,24);
			newArmor.Health = 10 + newArmor.Stamina;
			newArmor.MagicPower = Random.Range(1,2);
			newArmor.Intellect = Random.Range(1,2);
			newArmor.Wisdom = Random.Range(1,2);
			newArmor.Luck = Random.Range(5,6);
			newArmor.Spirit = Random.Range(1,9);
			
		}
		else if (newArmor.LootName = "Heavy Padded Leather"){
			newArmor.LootDetails = "This is a Heavy Padded Leather of fine craftsmanship.";
			newArmor.EquipmentTypes = BaseArmor.EquipmentTypes.HEAVYPADDEDLEATHER;
			newArmor.Strength = Random.Range(12,22);
			newArmor.Endurance = Random.Range(13,27);
			newArmor.Stamina = Random.Range(20,30);
			newArmor.Agility = Random.Range(15,24);
			newArmor.Health = 10 + newArmor.Stamina;
			newArmor.MagicPower = Random.Range(1,2);
			newArmor.Intellect = Random.Range(1,2);
			newArmor.Wisdom = Random.Range(1,2);
			newArmor.Luck = Random.Range(5,6);
			newArmor.Spirit = Random.Range(1,9);
			
		}
		else if (newArmor.LootName = "Heavy Plate"){
			newArmor.LootDetails = "This is a Heavy Plate of fine craftsmanship.";
			newArmor.EquipmentTypes = BaseArmor.EquipmentTypes.HEAVYPLATE;
			newArmor.Strength = Random.Range(7,14);
			newArmor.Endurance = Random.Range(6,15);
			newArmor.Stamina = Random.Range(16,30);
			newArmor.Agility = Random.Range(15,24);
			newArmor.Health = 10 + newArmor.Stamina;
			newArmor.MagicPower = Random.Range(1,2);
			newArmor.Intellect = Random.Range(1,2);
			newArmor.Wisdom = Random.Range(1,2);
			newArmor.Luck = Random.Range(5,6);
			newArmor.Spirit = Random.Range(1,9);
			
		}
		else if (newArmor.LootName = "Heavy Padded Cloth"){
			newArmor.LootDetails = "This is a Heavy Padded Cloth of fine craftsmanship.";
			newArmor.EquipmentTypes = BaseArmor.EquipmentTypes.HEAVYPADDEDCLOTH;
			newArmor.Strength = Random.Range(6,15);
			newArmor.Endurance = Random.Range(6,15);
			newArmor.Stamina = Random.Range(16,30);
			newArmor.Agility = Random.Range(17,27);
			newArmor.MagicPower = Random.Range(1,2);
			newArmor.Intellect = Random.Range(1,2);
			newArmor.Wisdom = Random.Range(1,2);
			newArmor.Luck = Random.Range(5,6);
			newArmor.Spirit = Random.Range(1,9);
			
		}		
    }

}
