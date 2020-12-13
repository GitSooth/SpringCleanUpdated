using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toturial : MonoBehaviour
{
	public GameObject toturial;
	public Text dialogText;
	public string dialog;
	public bool dialongOn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Player"))
		{
			dialongOn = true;
			toturial.SetActive(true);
			dialogText.text = dialog;
			
		}
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		if(collision.CompareTag("Player"))
		{
			if (toturial.activeInHierarchy)
			{
				toturial.SetActive(false);
			}
			Debug.Log("Player left");
		}
	}
}
