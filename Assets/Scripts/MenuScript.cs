using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void NewGame()
    {
        SceneManager.LoadScene("1st Level");
    }

    public void Continue()
    {

    }

    public void LevelSelect()
    {
        SceneManager.LoadScene("Level Select");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
