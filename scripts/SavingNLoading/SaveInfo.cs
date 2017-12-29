using UnityEngine;
using System.Collections;

public class SaveInfo{
  public static void SaveAllInfo(){
    PlayerPrefs.SetInt("PLAYERLEVEL",GameInformation.PlayerLevel);
    PlayerPrefs.SetString("PLAYERNAME",GameInformation.PlayerName);
    PlayerPrefs.SetInt("HEALTH",GameInformation.Health);
    PlayerPrefs.SetInt("STAMINA",GameInformation.Stamina);
    PlayerPrefs.SetInt("ENDURANCE",GameInformation.Endurance);
    PlayerPrefs.SetInt("STRENGTH",GameInformation.Strength);
    PlayerPrefs.SetInt("MAGICPOWER",GameInformation.MagicPower);
    PlayerPrefs.SetInt("INTELLECT",GameInformation.Intellect);
    PlayerPrefs.SetInt("WISDOM",GameInformation.Wisdom);
    PlayerPrefs.SetInt("AGILITY",GameInformation.Agility);
    PlayerPrefs.SetInt("LUCK",GameInformation.Luck);
    PlayerPrefs.SetInt("SPIRIT",GameInformation.Spirit);
    if(GameInformation.EquipmentOne != null){
      PPSerialztion.Save("EQUIPMENTONE", GameInformation.EquipmentOne);
    }
  }



}
