using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportWarp : MonoBehaviour
{
	public GameObject Player;
	public GameObject Teleport;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Teleport")
        {
            Debug.Log($"{collision.tag}");
            Debug.Log("inside");
            StartCoroutine(Warp());
        }
    }

    IEnumerator Warp()
	{
		yield return new WaitForSeconds(1);
		Player.transform.position = Teleport.transform.position;
	}
}
