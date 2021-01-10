using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportWrap : MonoBehaviour
{
    public GameObject Player;
    public GameObject Teleport;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine("Warp");
        }

        IEnumerable Warp()
        {
            yield return new WaitForSeconds(1);
            Player.transform.position = new Vector2(Teleport.transform.position.x, Teleport.transform.position.y);
        }
    }
}