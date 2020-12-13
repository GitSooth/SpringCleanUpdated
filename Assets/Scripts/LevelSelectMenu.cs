using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectMenu : MonoBehaviour
{

	public void GoCharacterSelect()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

  public void GoBack()
  {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
	}
   
}
