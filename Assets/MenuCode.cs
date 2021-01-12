using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuCode : MonoBehaviour
{
	public void PlayFreeMode()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}


	public void PlayStoryMode()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
	}

	public void QuitGame()
	{
		Debug.Log("Quit");
		Application.Quit();
	}
		
}
