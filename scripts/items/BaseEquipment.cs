using UnityEngine;
using System.Collections;

[System.Serializable]
public class BaseEquipment :  BaseStatedLoot {

    public enum EquipmentTypes{
        HEAD,
        CHEST,
        SHOULDERS,
        LEGS,
        FEET,
        NECK,
        RINGONE,
        RINGTWO,
        GLOVES,
        //Back for capes. later need options for toggle cape n helm visuals
        //done and done
        BACK
    }

    private EquipmentTypes equipmentType;
    private int spellEffectID;

    public EquiptmentTypes EquipmentType{
        get{return equipmentType;}
        set{equipmentType = value;}
    }
    public int SpellEffectID{
        get{return spellEffectID;}
        set{spellEffectID = value;}
    }

}
