using UnityEngine;
using System.Collections;

public class GameInformation : MonoBehaviour {

    void Awake(){
        DontDestroyOnLoad(transform.gameObject);
    }

    public static string PlayerName{get;set;}
    public static int PlayerLevel{get;set;}
    public static BaseToonClass PlayerClass{get;set;}
    public static int Health{get;set;}
    public static int Stamina{get;set;}
    public static int Endurance{get;set;}
    public static int MagicPower{get;set;}
    public static int Wisdom{get;set;}
    public static int Sneak{get;set;}
    public static int Luck{get;set;}
    public static int Spirit{get;set;}
    public static int MagicEnergy{get;set;}
    public static int MagicSpeed{get;set;}
    public static int AttackSpeed{get;set;}
    public static int CritPercentChance{get;set;}
    public static int CritMultiplier{get;set;}
    public static int SleightOfHand{get;set;}
    public static int Thieving{get;set;}
        
}
