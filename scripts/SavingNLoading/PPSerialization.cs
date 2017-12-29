using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serializtion.Formatters.Binary;
// binary Serializtion example script
public class PPSerialztion{
  public static BinaryFormatter binaryFormatter = new BinaryFormatter();

  public static void Save(string saveTag, object obj){
    MemoryStream memoryStream = new MemoryStream();
    binaryFormatter.Serialize(memoryStream, obj);
    string temp = System.Convert.ToBase64String(memoryStream.ToArray());
    PlayerPrefs.SetString(saveTag, temp);

  }

  public static object Load(string savetag){
    string temp = PlayerPrefs.GetString(saveTag);
    if(temp == string.Empty){
      return null;
    }
    MemoryStream memoryStream = new MemoryStream(System.Convert.FromBase64String(temp));
    return binaryFormatter.Deserialize(memoryStream);
  }
}
