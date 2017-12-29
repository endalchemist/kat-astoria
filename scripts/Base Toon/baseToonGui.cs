using UnityEngine;
using System.Collections;

public class CreateNewToon : MonoBehaviour {
    private BaseToon newToon;
    private bool isArcher;
    private bool isBrawler;
    private bool isDivineMage;
    private bool isElementalMage;
    private bool isKnight;
    private bool isScoundrel;
    private bool isWorker;
    private String toonName = "Enter Name Here";

    void Start(){
      newToon = new BaseToon();
    }
    void Update(){



    }
    void OnGUI{
      yourName = GUILayout.TextArea(toonName,15);
      isArcher = GUILayout.Toggle(isArcher,"Archer");
      isBrawler = GUILayout.Toggle(isBrawler,"Brawler");
      isDivineMage = GUILayout.Toggle(isDivineMage,"Divine Mage");
      isElementalMage = GUILayout.Toggle(isElementalMage,"Elemental Mage");
      isKnight = GUILayout.Toggle(isKnight,"Knight");
      isScoundrel = GUILayout.Toggle(isScoundrel,"Scoundrel");
      isWorker = GUILayout.Toggle(isWorker,"Worker");
      if(GUILayout.Button("Create")){
        if(isArcher){
          newPlayer.PlayerClass = new BaseMainArcher;
        }
        else if(isBrawler){
          newPlayer.PlayerClass = new BaseMainBrawler;
        }
        else if(isDivineMage){
          newPlayer.PlayerClass = new BaseMainDivineMage;
        }
        else if(isElementalMage){
          newPlayer.PlayerClass = new BaseMainElementalMage;
        }
        else if(isKnight){
          newPlayer.PlayerClass = new BaseMainKnight;
        }
        else if(isScoundrel){
          newPlayer.PlayerClass = new BaseMainScoundrel;
        }
        else if(isWorker){
          newPlayer.PlayerClass = new BaseMainWorker;
        }
        newToon.PlayerLevel=1;
        newToon.Health = newToon.PlayerClass.Health;
        newToon.Stamina = newToon.PlayerClass.Stamina;
        newToon.Endurance = newToon.PlayerClass.Endurance;
        newToon.MagicPower = newToon.PlayerClass.MagicPower;
        newToon.Strength = newToon.PlayerClass.Strength;
        newToon.Intellect = newToon.PlayerClass.Intellect;
        newToon.Wisdom = newToon.PlayerClass.Wisdom;
        newToon.Sneak = newToon.PlayerClass.Sneak;
        newToon.Luck = newToon.PlayerClass.Luck;
        newToon.Spirit = newToon.PlayerClass.Spirit;
        newToon.MagicEnergy = newToon.PlayerClass.MagicEnergy;
        newToon.MagicSpeed = newToon.PlayerClass.MagicSpeed;
        newToon.AttackSpeed = newToon.PlayerClass.AttackSpeed;
        newToon.CritPercentChance = newToon.PlayerClass.CritPercentChance;
        newToon.CritMultiplier = newToon.PlayerClass.CritMultiplier;
        newToon.SleightOfHand = newToon.PlayerClass.SleightOfHand;
        newToon.Thieving = newToon.PlayerClass.Thieving;
        newToon.PlayerName = toonName;
        StoreNewInfo();
        SaveInfo.SaveAllInfo();
        if(GUILayout.Button("Create")){
          Application.LoadLevel("Tset");
        }
      }
      private void StoreNewInfo(){
        GameInformation.PlayerName  = newToon.PlayerName;
        GameInformation.Health  = newToon.Health;
        GameInformation.Stamina  = newToon.Stamina;
        GameInformation.Endurance  = newToon.Endurance;
        GameInformation.MagicPower  = newToon.MagicPower;
        GameInformation.Strength  = newToon.Strength;
        GameInformation.Intellect  = newToon.Intellect;
        GameInformation.Wisdom  = newToon.Wisdom;
        GameInformation.Sneak  = newToon.Sneak;
        GameInformation.Luck  = newToon.Luck;
        GameInformation.Spirit  = newToon.Spirit;
        GameInformation.MagicEnergy  = newToon.MagicEnergy;
        GameInformation.MagicSpeed  = newToon.MagicSpeed;
        GameInformation.AttackSpeed  = newToon.AttackSpeed;
        GameInformation.CritPercentChance  = newToon.CritPercentChance;
        GameInformation.CritMultiplier  = newToon.CritMultiplier;
        GameInformation.SlieghtOfHand  = newToon.SlieghtOfHand;
        GameInformation.Thieving  = newToon.Thieving;

      }
    }
}
