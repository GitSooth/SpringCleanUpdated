using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.SceneManagement;

public static class SaveSystem
{
    public static void SaveGame()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.spring";
        Debug.Log(Application.persistentDataPath);
        FileStream stream = new FileStream(path, FileMode.Create);

        string scene = SceneManager.GetActiveScene().name;

        formatter.Serialize(stream, scene);
        stream.Close();
    }

    public static string LoadGame()
    {
        string path = Application.persistentDataPath + "/player.spring";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

           string data = formatter.Deserialize(stream) as string;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}
