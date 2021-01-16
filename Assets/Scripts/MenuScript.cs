using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    SaveLoadGame svGame;

    private void Start()
    {
        svGame = new SaveLoadGame();  
    }

    public void NewGame()
    {
        SceneManager.LoadScene("1st Level");
    }

    public void Continue() => svGame.LoadGame();

    public void LevelSelect()
    {
        Debug.Log(Application.persistentDataPath);
        SceneManager.LoadScene("Level Select");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
