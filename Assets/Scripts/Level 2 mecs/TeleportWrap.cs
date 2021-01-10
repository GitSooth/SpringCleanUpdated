using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportWrap : MonoBehaviour
{
	public GameObject Player;
	public GameObject Teleport;

	public void OnTriggerEnter2D(Collider other)
	{
		if(other.gameObject.tag=="Player")
		{
			StartCoroutine(Wrap());
		}

		IEnumerable Wrap()
		{
			yield return new WaitForSeconds(1);
			Player.transform.position = new Vector2(Teleport.transform.position.x, Teleport.transform.position.y);
		}
	}
}
