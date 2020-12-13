using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitions : MonoBehaviour
{
	public Animator animator;
	public string SceneTransmission;
	void Update()
	{

		if (Input.GetMouseButtonDown(0))
		{
			StartCoroutine(LoadScene().ToString());
		}
	}

	IEnumerable LoadScene()
	{
		animator.SetTrigger("2nd level Trash");
		yield return new WaitForSeconds(2.0f);
		SceneManager.LoadScene(SceneTransmission);
	}


}
