using UnityEngine;
using System.collections;

public class CreateNewToon : MonoBehaviour {
    private BaseToon newToon;
    private bool isArcher;
    private bool isBrawler;
    private bool isDivineMage;
    private bool isElementalMage;
    private bool isKnight;
    private bool isScoundrel;
    private bool isWorker;
    private String yourName;

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
        newToon.CritPerecentChance = newToon.PlayerClass.CritPerecentChance;
        newToon.CritMultiplier = newToon.PlayerClass.CritMultiplier;
        newToon.SlieghtOfHand = newToon.PlayerClass.SlieghtOfHand;
        newToon.Thieving = newToon.PlayerClass.Thieving;
        newtoon.PlayerName = yourName;
        StoreNewInfo();
        SaveInfo.SaveAllInfo();
        if(GUILayout.Button("Create")){
          Application.LoadLevel("Tset");
        }
      }
      private void StoreNewInfo(){
        GameInformation.PlayerName  = newtoon.PlayerName;
        GameInformation.Health  = newtoon.Health;
        GameInformation.Stamina  = newtoon.Stamina;
        GameInformation.Endurance  = newtoon.Endurance;
        GameInformation.MagicPower  = newtoon.MagicPower;
        GameInformation.Strength  = newtoon.Strength;
        GameInformation.Intellect  = newtoon.Intellect;
        GameInformation.Wisdom  = newtoon.Wisdom;
        GameInformation.Sneak  = newtoon.Sneak;
        GameInformation.Luck  = newtoon.Luck;
        GameInformation.Spirit  = newtoon.Spirit;
        GameInformation.MagicEnergy  = newtoon.MagicEnergy;
        GameInformation.MagicSpeed  = newtoon.MagicSpeed;
        GameInformation.AttackSpeed  = newtoon.AttackSpeed;
        GameInformation.CritPerecentChance  = newtoon.CritPerecentChance;
        GameInformation.CritMultiplier  = newtoon.CritMultiplier;
        GameInformation.SlieghtOfHand  = newtoon.SlieghtOfHand;
        GameInformation.Thieving  = newtoon.Thieving;

      }
    }
}
