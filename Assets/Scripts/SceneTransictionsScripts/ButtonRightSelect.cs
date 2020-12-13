using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRightSelect : MonoBehaviour
{
	public GameObject[] charactercube;
	public int selection = 0;

    public void NextCharacter()
	{
		charactercube[selection].SetActive(false);
		selection = (selection + 1) % charactercube.Length;
		charactercube[selection].SetActive(true);
	}
}
