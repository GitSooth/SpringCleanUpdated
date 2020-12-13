using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLeftSelect : MonoBehaviour
{
	public GameObject[] charactercube;
	public int selection = 0;


	public void PreviousCharacter()
	{
		charactercube[selection].SetActive(false);
		selection--;

		if(selection <0 )
		{
			selection = (selection - 1) % charactercube.Length;
		}
	

		charactercube[selection].SetActive(true);
	}

	
}
