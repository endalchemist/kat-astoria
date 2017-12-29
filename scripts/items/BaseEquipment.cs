using UnityEngine;
using System.Collections;

public class BaseEquipment :  BaseStatedLoot {

    public enum EquipmentTypes{
        HEAD,
        CHEST,
        SHOULDERS,
        LEGS,
        FEET,
        NECK,
        EARRING,
        RING
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
