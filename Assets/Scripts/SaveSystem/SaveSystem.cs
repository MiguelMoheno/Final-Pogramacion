
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Unity.VisualScripting;
using UnityEngine;

public class SaveSystem 
{
    public static void SaveGame()
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();

        string path = Application.dataPath + "/elJuguito.unity";

        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData();

        binaryFormatter.Serialize(stream, data);

        stream.Close();
    }
   public static PlayerData LoadGame()
    {
        string path = Application.dataPath + "/elJuguito.unity";

        if(File.Exists(path))
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            PlayerData data = binaryFormatter.Deserialize(stream) as PlayerData;
            stream.Close ();

            return data;
        }
       else
        {
            Debug.Log("No hay, no existe");
            return null;
        }


    }
}
