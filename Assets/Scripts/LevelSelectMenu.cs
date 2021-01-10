using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectMenu : MonoBehaviour
{

	public void GoCharacterSelect()
	{
		SceneManager.LoadScene("Level Select");
	}

    public void Level1()
    {
        SceneManager.LoadScene("1st Level");
    }

    public void Level2()
    {
        SceneManager.LoadScene("2nd Level");
    }

    public void Level3()
    {
        SceneManager.LoadScene("3rd Level");
    }

    public void Level4()
    {
        SceneManager.LoadScene("4th Level");
    }

    public void ButtonBack()
    {
        SceneManager.LoadScene("Menu");
    }
   
}
