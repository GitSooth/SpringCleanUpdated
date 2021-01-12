using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveLoadGame : MonoBehaviour
{
    public void SaveGame()
    {
        SaveSystem.SaveGame();
    }

    public void LoadGame()
    {
        string scene = SaveSystem.LoadGame();

        SceneManager.LoadScene(scene);
    }
}
