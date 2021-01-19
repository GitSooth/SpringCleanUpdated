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
            StartCoroutine(LoadScene2().ToString());
            StartCoroutine(LoadScene3().ToString());
        }
	}

	IEnumerable LoadScene()
	{
		animator.SetTrigger("LevelsTransEnd");
		yield return new WaitForSeconds(2.0f);
		SceneManager.LoadScene(SceneTransmission);
	}


    IEnumerable LoadScene2()
    {
        animator.SetTrigger("LevelsTransEnd");
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene(SceneTransmission);
    }


    IEnumerable LoadScene3()
    {
        animator.SetTrigger("LevelsTransEnd");
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene(SceneTransmission);
    }
}
