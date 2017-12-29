using UnityEngine;
using System.Collections;

public class BasePotion :  BaseStatedLoot {

    public enum PotionTypes{
        HEALTH,
        ENERGY,
        STRENGTH,
        INTELLECT,
        VITALITY,
        ENDURANCE,
        SPEED
    }

    private PotionTypes potionTypes;
    private int spellEffectsID;

    public PotionTypes PotionType{
        get{return equipmentType;}
        set{equipmentType = value;}
    }
    public int SpellEffectID{
        get{return spellEffectID;}
        set{spellEffectID = value;}
    }
}
