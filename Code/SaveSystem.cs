using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem 
{
    public static void savePlayer(playerData player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.sv";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerGetData data = new PlayerGetData(player);

        formatter.Serialize(stream, data);
        stream.Close();
    }


    public static PlayerGetData loadPlayer()
    {
        string path = Application.persistentDataPath + "/player.sv";
        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerGetData data =  formatter.Deserialize(stream) as PlayerGetData;
            stream.Close();
            return data;
        } 
        else
        {
            Debug.LogError("FILE NOT FOUND " + path);
            return null;
        }

    }
}
