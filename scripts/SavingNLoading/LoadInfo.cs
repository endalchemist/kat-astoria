using UnityEngine;
using System.Collections;

public class LoadInfo{
    public static void LoadAll(){
      GameInformation.PlayerLevel = PlayerPrefs.GetString("PLAYERNAME");
      GameInformation.PlayerName = PlayerPrefs.GetInt("PLAYERLEVEL");
      GameInformation.Health = PlayerPrefs.GetInt("Health");
      GameInformation.Stamina = PlayerPrefs.GetInt("STAMINA");
      GameInformation.Endurance = PlayerPrefs.GetInt("ENDURANCE");
      GameInformation.Strength = PlayerPrefs.GetInt("STRENGTH");
      GameInformation.MagicPower = PlayerPrefs.GetInt("MAGICPOWER");
      GameInformation.Intellect = PlayerPrefs.GetInt("INTELLECT");
      GameInformation.Wisdom = PlayerPrefs.GetInt("WISDOM");
      GameInformation.Agility = PlayerPrefs.GetInt("AGILITY");
      GameInformation.Luck = PlayerPrefs.GetInt("LUCK");
      GameInformation.Spirit = PlayerPrefs.GetInt("SPIRIT");
}



}
